using EclyssiaSharp.Implementation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace EclyssiaSharp.Static
{
    public static class StaticClient
    {
        private static HttpClient HttpClient = InitHttpClient();
        private static SemaphoreSlim SemaphoreSlim = new SemaphoreSlim(1);
        private static string BaseApi = "https://eclyssia-api.tk/api/v1/";
        private static DateTime NextRequestAllow = DateTime.Now;
        private static HttpClient InitHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("Api-Client", "EclyssiaSharp");
            return client;
        }
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#blur"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> BlurAsync(string imageUrl) => Request("blur", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#grayscale"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> GreyscaleAsync(string imageUrl) => Request("greyscale", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#invert"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> InvertAsync(string imageUrl) => Request("invert", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#pixelate"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> PixelateAsync(string imageUrl) => Request("pixelate", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#posterize"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> PosterizeAsync(string imageUrl) => Request("posterize", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#sepia"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> SepiaAsync(string imageUrl) => Request("sepia", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#beautiful"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> BeautifulAsync(string imageUrl) => Request("beautiful", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#blood"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> BloodAsync(string imageUrl) => Request("blood", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#bobross"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> BobrossAsync(string imageUrl) => Request("bobross", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#brazzers"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> BrazzersAsync(string imageUrl) => Request("brazzers", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#captcha"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> CaptchaAsync(string imageUrl,string username) => Request("captcha", $"url={HttpUtility.UrlEncode(imageUrl)}&username={HttpUtility.UrlEncode(username)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#gay"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> GayAsync(string imageUrl) => Request("gay", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#jackolantern"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> JackolanternAsync(string imageUrl) => Request("jackolantern", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#phvideo"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> PhvideoAsync(string imageUrl,string username) => Request("jackolantern", $"url={HttpUtility.UrlEncode(imageUrl)}&username={HttpUtility.UrlEncode(username)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#prison"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> PrisonAsync(string imageUrl) => Request("prison", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#treasure"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> TreasureAsync(string imageUrl) => Request("treasure", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#triggered"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> TriggeredAsync(string imageUrl) => Request("triggered", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#whatspokemon"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Task<Stream> WhatspokemonAsync(string imageUrl) => Request("whatspokemon", $"url={HttpUtility.UrlEncode(imageUrl)}");


        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#blur"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Blur(string imageUrl) => RequestSync("blur", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#grayscale"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Greyscale(string imageUrl) => RequestSync("greyscale", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#invert"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Invert(string imageUrl) => RequestSync("invert", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#pixelate"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Pixelate(string imageUrl) => RequestSync("pixelate", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#posterize"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Posterize(string imageUrl) => RequestSync("posterize", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#sepia"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Sepia(string imageUrl) => RequestSync("sepia", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#beautiful"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Beautiful(string imageUrl) => RequestSync("beautiful", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#blood"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Blood(string imageUrl) => RequestSync("blood", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#bobross"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Bobross(string imageUrl) => RequestSync("bobross", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#brazzers"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Brazzers(string imageUrl) => RequestSync("brazzers", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#captcha"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        public static Stream Captcha(string imageUrl, string username) => RequestSync("captcha", $"url={HttpUtility.UrlEncode(imageUrl)}&username={HttpUtility.UrlEncode(username)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#gay"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Gay(string imageUrl) => RequestSync("gay", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#jackolantern"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Jackolantern(string imageUrl) => RequestSync("jackolantern", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#phvideo"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        public static Stream Phvideo(string imageUrl, string username) => RequestSync("jackolantern", $"url={HttpUtility.UrlEncode(imageUrl)}&username={HttpUtility.UrlEncode(username)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#prison"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Prison(string imageUrl) => RequestSync("prison", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#treasure"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Treasure(string imageUrl) => RequestSync("treasure", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#triggered"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Triggered(string imageUrl) => RequestSync("triggered", $"url={HttpUtility.UrlEncode(imageUrl)}");
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#whatspokemon"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        public static Stream Whatspokemon(string imageUrl) => RequestSync("whatspokemon", $"url={HttpUtility.UrlEncode(imageUrl)}");



        private static async Task<Stream> Request(string method, string parameters)
        {
            await SemaphoreSlim.WaitAsync();
            try
            {
                return await ProcessRequest(method, parameters);
            }
            finally
            {
                SemaphoreSlim.Release();
            }
        }

        private static Stream RequestSync(string method, string parameters)
        {
            Task<Stream> stream = Request(method, parameters);
            stream.Wait();
            return stream.Result;
        }

        private static async Task<Stream> ProcessRequest(string method, string parameters)
        {
            TimeSpan time = NextRequestAllow - DateTime.Now;
            if (time.TotalSeconds > 1)
            {
                await Task.Delay(time);
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HttpResponseMessage httpResponse = await HttpClient.GetAsync($"{BaseApi}{method}?{parameters}");
            stopwatch.Stop();
            if(httpResponse.IsSuccessStatusCode)
            {
                NextRequestAllow = DateTime.Now
                    .AddSeconds(1)
                    // This is supposed to fix a bug when having a high latency.
                    .AddMilliseconds(stopwatch.ElapsedMilliseconds);
                return await httpResponse.Content.ReadAsStreamAsync();
            } else
            {
                throw new InvalidDataException("Ecclysia failed to generate the requested image.");
            }
        }
        /// <summary>
        /// Get's a client
        /// </summary>
        /// <returns></returns>
        public static IClient GetImplementedClient() => new ImplementedClient();
    }
}
