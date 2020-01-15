# **`EclyssiaSharp a C# Eclyssia API Wrapper 🚀`**
 
A C# Client wrapper for the Eclyssia image generation api.

## Installation

This package targets netstandard2.0 so it can be used everywhere.
You can install it using the nuget package manager \
**[[Nuget package 📦]](https://www.nuget.org/packages/MatthieuCoder.EclyssiaSharp)**

```
dotnet add package MatthieuCoder.EclyssiaSharp
```
of using the Install-Pckage command
```
Install-Package MatthieuCoder.EclyssiaSharp
```

## Ratelimit note. ⚡

Byt default the api is restricted at 1 request per second. This library handles the ratelimit automaticly, so you don't have to worry about it but the method calls can take up to 1 second.

## There is two ways of using the library.

### The static way.

You can use all the public methods on the `StaticClient.cs` class.
All the sync methods returns a `Stream` ( Wich contains the requestested image bytes )
All the async methods returns a `Task<Stream>` ( Wich contains the requestested image bytes )

### The implemented client.

**The implemented client only calls the static methods ⚠**

You can get an implemented client from the static client with the `GetImplementedClient()` method.