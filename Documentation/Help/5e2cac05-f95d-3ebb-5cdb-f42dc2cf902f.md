# League.GetTeamLeaguesbyIds Method 
RiotApi.NET Documentation 

\[Missing <summary> documentation for "M:RiotApi.Net.RestClient.ApiCalls.League.GetTeamLeaguesbyIds(RiotApi.Net.RestClient.Configuration.RiotApiConfig.Regions,System.String[])"\]

**Namespace:**&nbsp;<a href="ce503962-9d76-4097-585e-86aa8997f5c3">RiotApi.Net.RestClient.ApiCalls</a><br />**Assembly:**&nbsp;RiotApi.Net.RestClient (in RiotApi.Net.RestClient.dll) Version: 1.0.1.20531

## Syntax

**C#**<br />
``` C#
public Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeaguesbyIds(
	RiotApiConfig.Regions region,
	params string[] teamIds
)
```

**VB**<br />
``` VB
Public Function GetTeamLeaguesbyIds ( 
	region As RiotApiConfig.Regions,
	ParamArray teamIds As String()
) As Dictionary(Of String, IEnumerable(Of LeagueDto))
```

**C++**<br />
``` C++
public:
virtual Dictionary<String^, IEnumerable<LeagueDto^>^>^ GetTeamLeaguesbyIds(
	RiotApiConfig.Regions region, 
	... array<String^>^ teamIds
) sealed
```


#### Parameters
&nbsp;<dl><dt>region</dt><dd>Type: <a href="4d977124-7072-aed6-d4c3-44de17e37ee2">RiotApi.Net.RestClient.Configuration.RiotApiConfig.Regions</a><br />\[Missing <param name="region"/> documentation for "M:RiotApi.Net.RestClient.ApiCalls.League.GetTeamLeaguesbyIds(RiotApi.Net.RestClient.Configuration.RiotApiConfig.Regions,System.String[])"\]</dd><dt>teamIds</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a>[]<br />\[Missing <param name="teamIds"/> documentation for "M:RiotApi.Net.RestClient.ApiCalls.League.GetTeamLeaguesbyIds(RiotApi.Net.RestClient.Configuration.RiotApiConfig.Regions,System.String[])"\]</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/xfhwa508" target="_blank">Dictionary</a>(<a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>, <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="80ad95ef-2195-5efa-0497-14d42aa093ee">LeagueDto</a>))<br />\[Missing <returns> documentation for "M:RiotApi.Net.RestClient.ApiCalls.League.GetTeamLeaguesbyIds(RiotApi.Net.RestClient.Configuration.RiotApiConfig.Regions,System.String[])"\]

#### Implements
<a href="af7399ff-1bb8-e896-4aa4-371ef6b05266">ILeague.GetTeamLeaguesbyIds(RiotApiConfig.Regions, String[])</a><br />

## See Also


#### Reference
<a href="1791eaf8-1966-7c68-d613-842281663af6">League Class</a><br /><a href="ce503962-9d76-4097-585e-86aa8997f5c3">RiotApi.Net.RestClient.ApiCalls Namespace</a><br />