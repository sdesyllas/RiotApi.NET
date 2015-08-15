# ILeague Methods
RiotApi.NET Documentation 

The <a href="f4feab45-6453-d761-cffb-cc231a5a7b28">ILeague</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="3b94ad37-2cf8-2a95-c4ba-2bd32968d27d">GetChallengerTierLeagues</a></td><td>
Get challenger tier leagues.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="8e37dbe9-9656-6a05-ae49-e4f79de14720">GetMasterTierLeagues</a></td><td>
Get master tier leagues.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="93e4105d-0c33-1baf-c7d5-523c1b512e47">GetSummonerLeagueEntriesByIds</a></td><td>
Get league entries mapped by summoner ID for a given list of summoner IDs. Implementation Notes : Returns all league entries for specified summoners and summoners' teams.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="53e5ca7f-8b22-22c6-0605-ca9c9d5fdc81">GetSummonerLeaguesByIds</a></td><td>
Get leagues mapped by summoner ID for a given list of summoner IDs. Implementation Notes : Returns all leagues for specified summoners and summoners' teams. Entries for each requested participant (i.e., each summoner and related teams) will be included in the returned leagues data, whether or not the participant is inactive. However, no entries for other inactive summoners or teams in the leagues will be included.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="f701e295-2b3c-577a-4776-b64cb8b6d8b4">GetTeamLeagueEntriesbyIds</a></td><td>
Get league entries mapped by team ID for a given list of team IDs. Implementation Notes Returns all league entries for specified teams.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="af7399ff-1bb8-e896-4aa4-371ef6b05266">GetTeamLeaguesbyIds</a></td><td>
Get leagues mapped by team ID for a given list of team IDs. Implementation Notes : Returns all leagues for specified teams.Entries for each requested team will be included in the returned leagues data, whether or not the team is inactive.However, no entries for other inactive teams in the leagues will be included.</td></tr></table>&nbsp;
<a href="#ileague-methods">Back to Top</a>

## See Also


#### Reference
<a href="f4feab45-6453-d761-cffb-cc231a5a7b28">ILeague Interface</a><br /><a href="48cda41f-0d73-abf8-ab33-13ac48004c66">RiotApi.Net.RestClient.Interfaces Namespace</a><br />