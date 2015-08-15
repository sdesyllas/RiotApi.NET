# RealmDto Class
RiotApi.NET Documentation 

This object contains realm data.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="22bc6593-2751-9b34-8b72-58f2176b2e98">RiotApi.Net.RestClient.Dto.RiotDto</a><br />&nbsp;&nbsp;&nbsp;&nbsp;RiotApi.Net.RestClient.Dto.LolStaticData.Realm.RealmDto<br />
**Namespace:**&nbsp;<a href="f67d9fe6-5ce7-842b-4d1f-b23ab418dc88">RiotApi.Net.RestClient.Dto.LolStaticData.Realm</a><br />**Assembly:**&nbsp;RiotApi.Net.RestClient (in RiotApi.Net.RestClient.dll) Version: 1.0.1.20531

## Syntax

**C#**<br />
``` C#
public class RealmDto : RiotDto
```

**VB**<br />
``` VB
Public Class RealmDto
	Inherits RiotDto
```

**C++**<br />
``` C++
public ref class RealmDto : public RiotDto
```

The RealmDto type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="d3784330-9032-7db3-3c01-ffb09ce172b1">RealmDto</a></td><td>
Initializes a new instance of the RealmDto class</td></tr></table>&nbsp;
<a href="#realmdto-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="f7410305-bc08-d2ed-5210-c30162bdf039">Cdn</a></td><td>
The base CDN url.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="0480c9b1-b7e7-b67b-4565-83e26b492cdf">Css</a></td><td>
Latest changed version of Dragon Magic's css file.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="99341b76-cd4e-1e64-d34a-259de3fc56a2">Dd</a></td><td>
Latest changed version of Dragon Magic.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="e82740db-128e-4b19-7b4f-498e53566b6d">L</a></td><td>
Default language for this realm.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="89198515-c215-9117-546c-f5adaa166d59">Lg</a></td><td>
Legacy script mode for IE6 or older.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="8ed584e7-0011-78da-e596-999758d03f26">N</a></td><td>
Latest changed version for each data type listed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="4cdf5054-8447-3ba8-695c-2e70c4f8621f">Profileiconmax</a></td><td>
Special behavior number identifying the largest profileicon id that can be used under 500. Any profileicon that is requested between this number and 500 should be mapped to 0.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="cc63183d-bf0f-3f39-427e-08d562fd22bb">Store</a></td><td>
Additional api data drawn from other sources that may be related to data dragon functionality.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="635d537c-d229-450c-fab7-7b841da5737b">V</a></td><td>
Current version of this file for this realm.</td></tr></table>&nbsp;
<a href="#realmdto-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="e5b2e748-9f2c-8c52-118b-c0e16562d719">ToString</a></td><td>
Serializes Dto to Json
 (Inherited from <a href="22bc6593-2751-9b34-8b72-58f2176b2e98">RiotDto</a>.)</td></tr></table>&nbsp;
<a href="#realmdto-class">Back to Top</a>

## See Also


#### Reference
<a href="f67d9fe6-5ce7-842b-4d1f-b23ab418dc88">RiotApi.Net.RestClient.Dto.LolStaticData.Realm Namespace</a><br />