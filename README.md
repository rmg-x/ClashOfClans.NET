[![Nuget](https://img.shields.io/nuget/v/ClashOfClans.NET)](https://www.nuget.org/packages/ClashOfClans.NET/)
[![Nuget downloads](https://img.shields.io/nuget/dt/ClashOfClans.NET)](https://www.nuget.org/packages/ClashOfClans.NET/)

## ClashOfClans.NET
A simple wrapper for the official clash of clans API.


## Installation
NuGet package manager console:
`Install-Package ClashOfClans.NET`

Or using the .NET core CLI:
`dotnet add package ClashOfClans.NET`

## Usage (basic)
```cs
using ClashOfClans;

var clashOfClansClient = new ClashOfClansClient("your_api_token");
```

## Usage with `IHttpClientFactory` (Dependency Injection)
```cs
using ClashOfClans;
using ClashOfClans.Core.Interfaces;

// Typically from a web application builder
IServiceCollection services;

services.AddHttpClient();

services.AddSingleton<IClashOfClansClient>(provider => new ClashOfClansClient("your_api_token", provider.GetService<IHttpClientFactory>()));
```