# BrawlSharp
A powerful C# library for interacting with the [Brawl Stars](https://developer.brawlstars.com) API.

## Installation
Install using the Package Manager Console in Visual Studio.
```ps
Install-Package BrawlMatic.API.BrawlSharp
```

## Dependencies
- [RestSharp](https://github.com/restsharp/RestSharp)

## Usage
```cs
var client = new BrawlSharpClient("<token>");
    
var player = await client.GetPlayerAsync("2L8Q9GRC");
Console.WriteLine(player.Name); //Tweenky
Console.WriteLine(player.HighestTrophies); //25620

var club = await client.GetClubAsync("8L8Q0VLR");
Console.WriteLine(club.RequiredTrophies); //10000
Console.WriteLine(club.Members.Length); //24

var leaderboard = await client.GetPlayerLeaderboardAsync();
Console.WriteLine(leaderboard.Players[0].Trophies); //65122
Console.WriteLine(leaderboard.Players[50].Club.Name); //Humble Grinders

var brawler = await client.GetBrawlerAsync(16000005);
Console.WriteLine(brawler.Name); //SPIKE
Console.WriteLine(brawler.StarPowers[1].Name); //CURVEBALL
```

### Support
Join our [Discord](https://discord.gg/AcE7W8h59D) server if you need any assistance.

### License
MIT