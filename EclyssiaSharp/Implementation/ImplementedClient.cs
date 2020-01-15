using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EclyssiaSharp.Implementation
{
    internal class ImplementedClient : IClient
    {
        public Stream Beautiful(string imageUrl) => Static.StaticClient.Beautiful(imageUrl);

        public Task<Stream> BeautifulAsync(string imageUrl) => Static.StaticClient.BeautifulAsync(imageUrl);

        public Stream Blood(string imageUrl) => Static.StaticClient.Blood(imageUrl);

        public Task<Stream> BloodAsync(string imageUrl) => Static.StaticClient.BloodAsync(imageUrl);

        public Stream Blur(string imageUrl) => Static.StaticClient.Blur(imageUrl);

        public Task<Stream> BlurAsync(string imageUrl) => Static.StaticClient.BlurAsync(imageUrl);

        public Stream Bobross(string imageUrl) => Static.StaticClient.Bobross(imageUrl);

        public Task<Stream> BobrossAsync(string imageUrl) => Static.StaticClient.BobrossAsync(imageUrl);

        public Stream Brazzers(string imageUrl) => Static.StaticClient.Brazzers(imageUrl);

        public Task<Stream> BrazzersAsync(string imageUrl) => Static.StaticClient.BrazzersAsync(imageUrl);

        public Stream Captcha(string imageUrl, string username) => Static.StaticClient.Captcha(imageUrl, username);

        public Task<Stream> CaptchaAsync(string imageUrl, string username) => Static.StaticClient.CaptchaAsync(imageUrl, username);

        public Stream Gay(string imageUrl) => Static.StaticClient.Gay(imageUrl);

        public Task<Stream> GayAsync(string imageUrl) => Static.StaticClient.GayAsync(imageUrl);

        public Stream Greyscale(string imageUrl) => Static.StaticClient.Greyscale(imageUrl);

        public Task<Stream> GreyscaleAsync(string imageUrl) => Static.StaticClient.GreyscaleAsync(imageUrl);

        public Stream Invert(string imageUrl) => Static.StaticClient.Invert(imageUrl);

        public Task<Stream> InvertAsync(string imageUrl) => Static.StaticClient.InvertAsync(imageUrl);
        public Stream Jackolantern(string imageUrl) => Static.StaticClient.Jackolantern(imageUrl);

        public Task<Stream> JackolanternAsync(string imageUrl) => Static.StaticClient.JackolanternAsync(imageUrl);

        public Stream Phvideo(string imageUrl, string username) => Static.StaticClient.Phvideo(imageUrl, username);

        public Task<Stream> PhvideoAsync(string imageUrl, string username) => Static.StaticClient.PhvideoAsync(imageUrl, username);

        public Stream Pixelate(string imageUrl) => Static.StaticClient.Pixelate(imageUrl);

        public Task<Stream> PixelateAsync(string imageUrl) => Static.StaticClient.PixelateAsync(imageUrl);

        public Stream Posterize(string imageUrl) => Static.StaticClient.Posterize(imageUrl);

        public Task<Stream> PosterizeAsync(string imageUrl) => Static.StaticClient.PosterizeAsync(imageUrl);

        public Stream Prison(string imageUrl) => Static.StaticClient.Prison(imageUrl);

        public Task<Stream> PrisonAsync(string imageUrl) => Static.StaticClient.PrisonAsync(imageUrl);

        public Stream Sepia(string imageUrl) => Static.StaticClient.Sepia(imageUrl);

        public Task<Stream> SepiaAsync(string imageUrl) => Static.StaticClient.SepiaAsync(imageUrl);

        public Stream Treasure(string imageUrl) => Static.StaticClient.Treasure(imageUrl);

        public Task<Stream> TreasureAsync(string imageUrl) => Static.StaticClient.TreasureAsync(imageUrl);

        public Stream Triggered(string imageUrl) => Static.StaticClient.Triggered(imageUrl);

        public Task<Stream> TriggeredAsync(string imageUrl) => Static.StaticClient.TriggeredAsync(imageUrl);

        public Stream Whatspokemon(string imageUrl) => Static.StaticClient.Whatspokemon(imageUrl);

        public Task<Stream> WhatspokemonAsync(string imageUrl) => Static.StaticClient.WhatspokemonAsync(imageUrl);
    }
}
