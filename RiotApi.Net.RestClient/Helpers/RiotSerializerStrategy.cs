using System;

namespace RiotApi.Net.RestClient.Helpers
{
    /// <summary>
    /// Riot Api serializer strategy
    /// </summary>
    public class RiotSerializerStrategy : DataContractJsonSerializerStrategy
    {
        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public override object DeserializeObject(object value, Type type)
        {
            object obj;
            if (type.IsEnum && value is string)
                obj = Enum.Parse(type, (string)value, true);
            else
                obj = base.DeserializeObject(value, type);
            return obj;
        }

        /// <summary>
        /// Serializes the enum.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        protected override object SerializeEnum(Enum p)
        {
            return p.ToString();
        }
    }
}
