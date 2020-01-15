using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EclyssiaSharp
{
    public interface IClient
    {
        #region Async
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#blur"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> BlurAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#grayscale"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> GreyscaleAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#invert"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> InvertAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#pixelate"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> PixelateAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#posterize"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> PosterizeAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#sepia"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> SepiaAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#beautiful"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> BeautifulAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#blood"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> BloodAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#bobross"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> BobrossAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#brazzers"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> BrazzersAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#captcha"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> CaptchaAsync(string imageUrl, string username);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#gay"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> GayAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#jackolantern"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> JackolanternAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#phvideo"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> PhvideoAsync(string imageUrl, string username);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#prison"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> PrisonAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#treasure"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> TreasureAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#triggered"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> TriggeredAsync(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#whatspokemon"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Task<Stream> WhatspokemonAsync(string imageUrl);
        #endregion
        #region Sync
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#blur"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Blur(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#grayscale"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Greyscale(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#invert"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Invert(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#pixelate"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Pixelate(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#posterize"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Posterize(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/filters#sepia"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Sepia(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#beautiful"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Beautiful(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#blood"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Blood(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#bobross"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Bobross(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#brazzers"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Brazzers(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#captcha"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        Stream Captcha(string imageUrl, string username);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#gay"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Gay(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#jackolantern"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Jackolantern(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#phvideo"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <param name="username">The username to be displayed with the image.</param>
        /// <returns>Image stream</returns>
        Stream Phvideo(string imageUrl, string username);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#prison"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Prison(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#treasure"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Treasure(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#triggered"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Triggered(string imageUrl);
        /// <summary>
        /// <see cref="https://docs.eclyssia-api.tk/endpoints/image#whatspokemon"/>
        /// </summary>
        /// <param name="imageUrl">The targeted image.</param>
        /// <returns>Image stream</returns>
        Stream Whatspokemon(string imageUrl);
        #endregion
    }
}
