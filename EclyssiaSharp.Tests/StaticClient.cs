
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace EclyssiaSharp.Tests
{
    public class StaticClient
    {
        private string UserAvatar { get
            {
                return "https://cdn.discordapp.com/avatars/295483659274944512/62d0c7439962aa40f7316c91396cfbbd.png?size=128";
            }
        }

        [Test]
        public async Task BlurAsync()
        {
            await Static.StaticClient.BlurAsync(UserAvatar);
        }
        [Test]
        public async Task GrayscaleAsync()
        {
            await Static.StaticClient.GreyscaleAsync(UserAvatar);
        }
        [Test]
        public async Task InvertAsync()
        {
            await Static.StaticClient.InvertAsync(UserAvatar);
        }
        [Test]
        public async Task PixelateAsync()
        {
            await Static.StaticClient.PixelateAsync(UserAvatar);
        }
        [Test]
        public async Task PosterizeAsync()
        {
            await Static.StaticClient.PosterizeAsync(UserAvatar);
        }
        [Test]
        public async Task SepiaAsync()
        {
            await Static.StaticClient.SepiaAsync(UserAvatar);
        }
        [Test]
        public async Task BloodAsync()
        {
            await Static.StaticClient.BloodAsync(UserAvatar);
        }
        [Test]
        public async Task BobrossAsync()
        {
            await Static.StaticClient.BobrossAsync(UserAvatar);
        }
        [Test]
        public async Task BeautifulAsync()
        {
            await Static.StaticClient.BeautifulAsync(UserAvatar);
        }
        [Test]
        public async Task BrazzersAsync()
        {
            await Static.StaticClient.BrazzersAsync(UserAvatar);
        }
        [Test]
        public async Task CaptchaAsync()
        {
            await Static.StaticClient.CaptchaAsync(UserAvatar,"MAtthieu");
        }
        [Test]
        public async Task GayAsync()
        {
            await Static.StaticClient.GayAsync(UserAvatar);
        }
        [Test]
        public async Task JackolanternAsync()
        {
            await Static.StaticClient.JackolanternAsync(UserAvatar);
        }
        [Test]
        public async Task PhVideoAsync()
        {
            await Static.StaticClient.PhvideoAsync(UserAvatar,"MAtthieu");
        }
        [Test]
        public async Task PrisonAsync()
        {
            await Static.StaticClient.PrisonAsync(UserAvatar);
        }
        [Test]
        public async Task TreasureAsync()
        {
            await Static.StaticClient.TreasureAsync(UserAvatar);
        }
        [Test]
        public async Task TriggeredAsync()
        {
            await Static.StaticClient.TriggeredAsync(UserAvatar);
        }
        [Test]
        public async Task PokemonAsync()
        {
            await Static.StaticClient.WhatspokemonAsync(UserAvatar);
        }

        [Test]
        public void Blur()
        {
            Static.StaticClient.Blur(UserAvatar);
        }
        [Test]
        public void Grayscale()
        {
            Static.StaticClient.Greyscale(UserAvatar);
        }
        [Test]
        public void Invert()
        {
            Static.StaticClient.Invert(UserAvatar);
        }
        [Test]
        public void Pixelate()
        {
            Static.StaticClient.Pixelate(UserAvatar);
        }
        [Test]
        public void Posterize()
        {
            Static.StaticClient.Posterize(UserAvatar);
        }
        [Test]
        public void Sepia()
        {
            Static.StaticClient.Sepia(UserAvatar);
        }
        [Test]
        public void Blood()
        {
            Static.StaticClient.Blood(UserAvatar);
        }
        [Test]
        public void Bobross()
        {
            Static.StaticClient.Bobross(UserAvatar);
        }
        [Test]
        public void Beautiful()
        {
            Static.StaticClient.Beautiful(UserAvatar);
        }
        [Test]
        public void Brazzers()
        {
            Static.StaticClient.Brazzers(UserAvatar);
        }
        [Test]
        public void Captcha()
        {
            Static.StaticClient.Captcha(UserAvatar, "MAtthieu");
        }
        [Test]
        public void Gay()
        {
            Static.StaticClient.Gay(UserAvatar);
        }
        [Test]
        public void Jackolantern()
        {
            Static.StaticClient.Jackolantern(UserAvatar);
        }
        [Test]
        public void PhVideo()
        {
            Static.StaticClient.Phvideo(UserAvatar, "MAtthieu");
        }
        [Test]
        public void Prison()
        {
            Static.StaticClient.Prison(UserAvatar);
        }
        [Test]
        public void Treasure()
        {
            Static.StaticClient.Treasure(UserAvatar);
        }
        [Test]
        public void Triggered()
        {
            Static.StaticClient.Triggered(UserAvatar);
        }
        [Test]
        public void Pokemon()
        {
            Static.StaticClient.Whatspokemon(UserAvatar);
        }
        [Test]
        public Task TestMulti()
        {
            var t1 = new List<Task<Stream>>();
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));
            t1.Add(Static.StaticClient.BlurAsync(UserAvatar));

            Task.WaitAll(t1.ToArray());
            return Task.CompletedTask;
        }
    }
}