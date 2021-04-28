using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviePro.Services
{
    public class BasicImageService : IImageService
    {
        public string DecodePoster(byte[] poster, string contentType)
        {
            if (poster == null)
            {
                return null;
            }
            var posterImage = Convert.ToBase64String(poster);
            return $"data:{contentType};base64,{posterImage}";
        }

        public string DecodeProfile(byte[] profile, string contentType)
        {
            throw new NotImplementedException();
        }

        public async Task<byte[]> EncodeImageURLAsync(string imageURL)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(imageURL);

            Stream stream = await response.Content.ReadAsStreamAsync();
            var ms = new MemoryStream();
            await stream.CopyToAsync(ms);

            return ms.ToArray();
        }

        public async Task<byte[]> EncodePosterAsync(IFormFile poster)
        {
            if (poster == null)
            {
                return null;
            }
            using var ms = new MemoryStream();
            await poster.CopyToAsync(ms);
            return ms.ToArray();

        }

        public Task<byte[]> EncodeProfileAsync(IFormFile profile)
        {
            throw new NotImplementedException();
        }

        public string RecordContentType(IFormFile poster)
        {
            if (poster == null)
            {
                return null;
            }
            return poster.ContentType;
        }
        //new profile
    }
}
