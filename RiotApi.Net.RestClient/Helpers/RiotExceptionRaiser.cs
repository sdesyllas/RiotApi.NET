using System;
using System.Runtime.Serialization;
using NLog;

namespace RiotApi.Net.RestClient.Helpers
{
    public class RiotExceptionRaiser
    {
        static readonly Logger Logger = LogManager.GetLogger("RiotExceptionRaiser");

        #region RiotApiException
        public class RiotApiException : Exception
        {
            public RiotErrorCode RiotErrorCode { get; set; }
                
            public RiotApiException()
            {
            }

            public RiotApiException(string message) : base(message)
            {
            }

            public RiotApiException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected RiotApiException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        #endregion

        /// <summary>
        /// Raise a riot exception
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public static RiotApiException RaiseException(int errorCode)
        {
            var riotError = (RiotErrorCode)errorCode;
            var msg = GetMessage(riotError);
            var riotException = new RiotApiException(msg) {RiotErrorCode = riotError};
            Logger.Error(riotException, $"RiotErrorCode:{riotException.RiotErrorCode}");
            return riotException;
        }

        public enum RiotErrorCode
        {
            BAD_REQUEST = 400,
            FORBIDDEN = 403,
            DATA_NOT_FOUND = 404,
            UNAUTHORIZED = 401,
            RATE_LIMITED = 429,
            SERVER_ERROR = 500,
            UNAVAILABLE = 503,
            PARSE_FAILURE = 600
        }

        private static string GetMessage(RiotErrorCode errorCode)
        {
            switch (errorCode)
            {
                case RiotErrorCode.BAD_REQUEST:
                    return "Bad request";
                case RiotErrorCode.FORBIDDEN:
                    return "Forbidden";
                case RiotErrorCode.DATA_NOT_FOUND:
                    return "Requested data not found";
                case RiotErrorCode.PARSE_FAILURE:
                    return "Failed to parse Riot's JSON response";
                case RiotErrorCode.RATE_LIMITED:
                    return "Rate limit exceeded";
                case RiotErrorCode.SERVER_ERROR:
                    return "Internal server error";
                case RiotErrorCode.UNAUTHORIZED:
                    return "Unauthorized";
                case RiotErrorCode.UNAVAILABLE:
                    return "Service unavailable";
                default:
                    return "An unknown API error occured";
            }
        }
    }
}
