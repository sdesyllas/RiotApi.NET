<img src="http://i66.tinypic.com/2j4dqv6.jpg" border="0" alt="Image and video hosting by TinyPic">
#RiotApi.NET 

This is a .net wrapper Api for Riot Games League of Legends written in C#. The goal of this project is to provide a higher 
level of interaction with the Riot's API Rest service, json responses are deserialized into typed objects and all Http calls
are handled by this wrapper as documented by Riot. You can save time and focus on your actual application needs
and let this api do all the communication and deserialization work for you.

#Install
The easiest way to install this api to your project is using [NuGet](https://www.nuget.org/packages/RiotApi.NET/)

To install RiotApi.NET, run the following command in the Package Manager Console
```
PM> Install-Package RiotApi.NET
```

Ofcourse you can always download the source code and use it in your project as you like.

#How to use
The usage of the RiotApi.Net is a piece of cake! In less than three lines of code you can retrieve any kind of data
from Riot's services. 
For instance you can fetch all free to play champions and print them to screen as you can see in the following example.

## Examples

### Example 1
Get free to play champions

First import the appropriate libraries
```cs
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
```

Then create an http Riot client and make a call to champions API
```cs
IRiotClient riotClient = new RiotClient("your api key here");
//retrieve all current free to play champions
var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
//print the number of free to play champions
Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
```

```
response => There are 17 free to play champions to play with!
```

### Example 2
Get two summoners and compare their levels
```cs
IRiotClient riotClient = new RiotClient("your api key here");
//retrieve xeyanord and fnatictop summoners with one call
var summoners = riotClient.Summoner.GetSummonersByName(RiotApiConfig.Regions.EUNE, "xeyanord", "fnatictop");
var xeyanord = summoners["xeyanord"];
var fnatictop = summoners["fnatictop"];
//print the following statement about the two summoners
Console.WriteLine($"{fnatictop.Name} is level {fnatictop.SummonerLevel} and {xeyanord.Name} is {xeyanord.SummonerLevel}, its because {xeyanord.Name} is a slacker!");
```

```
response => Fnatic Top is level 30 and Xeyanord is 15, its because Xeyanord is a slacker!
```

### Example 3
Get top 5 Challenger Tier EUNE leaderboard for Ranked Solo 5x5
```cs
IRiotClient riotClient = new RiotClient("your api key here");
//get challeger tier league for ranked solo 5x5
var challengers = riotClient.League.GetChallengerTierLeagues(RiotApiConfig.Regions.EUNE, Enums.GameQueueType.RANKED_SOLO_5x5);
//get top 5 leaderboard using LINQ
var top5 = challengers.Entries.OrderByDescending(x => x.LeaguePoints).Take(5).ToList();
//Print top 5 leaderboard
top5.ForEach(
topEntry =>
Console.WriteLine(
$"{topEntry.PlayerOrTeamName} - wins:{topEntry.Wins}  loss:{topEntry.Losses} points:{topEntry.LeaguePoints}"));
```

```
response =>
Fnatic Top - wins:303  loss:239 points:1269
T5 yELLOW - wins:245  loss:157 points:1261
Konektiv - wins:185  loss:114 points:1204
Delitto123 - wins:193  loss:125 points:1185
ALBAN1AN god - wins:224  loss:158 points:1125
```

Download the full api documentation reference [here (chm format)] (https://github.com/sdesyllas/RiotApi.NET/blob/master/Documentation/Help/Documentation.chm?raw=true)

# Need help?
You can post a question on StackOverflow using the tags [riot-games-api](http://stackoverflow.com/questions/tagged/riot-games-api)
[riotapi.net](http://stackoverflow.com/questions/tagged/riotapi.net)

# End point versions supported
* champion-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* current-game-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR]
* featured-games-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR]
* game-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* league-v2.5 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* lol-static-data-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR]
* lol-status-v1.0 [BR, EUNE, EUW, LAN, LAS, NA, OCE, PBE, RU, TR]
* match-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* matchlist-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* stats-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* summoner-v1.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
* team-v2.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]

# Web UI
[LoLUniverse](https://github.com/sdesyllas/LoLUniverse) is a separated project that utilize this API and provides a user interface and a prototype League of Legends web application. The project is build in ASP.NET MVC framework and you can find it [here](https://github.com/sdesyllas/LoLUniverse).

# Third party libraries used
* [SimpleJson by Prabir Shrestha](https://github.com/facebook-csharp-sdk/simple-json)
* [LibLog by Damian Hickey](https://github.com/damianh/LibLog)
* [Ninject](http://www.ninject.org/index.html)
* [NUnit](http://www.nunit.org/)
* [moq](https://github.com/Moq/moq4)

## Also using
* [Appveyor](http://www.appveyor.com/) for continuous integration and build server.
* [waffle](https://waffle.io) for project management

## License
This wrapper is under the [MIT license](https://raw.githubusercontent.com/sdesyllas/RiotApi.NET/master/LICENSE).

## Disclaimer
This product is not endorsed, certified or otherwise approved in any way by Riot Games, Inc. or any of its affiliates.
