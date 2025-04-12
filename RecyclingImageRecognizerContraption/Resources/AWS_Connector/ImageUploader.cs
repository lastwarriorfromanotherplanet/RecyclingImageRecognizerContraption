using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;

namespace RecyclingImageRecognizerContraption.Resources.AWS_Connector;

public class ImageUploader
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public async Task<string> SendImageAsync(string imagePath)
    {
        var url = "http://54.196.169.74:8000/predict-image"; 

        using var multipartContent = new MultipartFormDataContent();
        using var fileStream = File.OpenRead(imagePath);
        using var streamContent = new StreamContent(fileStream);


        string mimeType;
        if (imagePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
            mimeType = "image/png";
        else
            mimeType = "image/jpeg";

        streamContent.Headers.ContentType = new MediaTypeHeaderValue(mimeType); 
        multipartContent.Add(streamContent, "file", Path.GetFileName(imagePath));

        var response = await _httpClient.PostAsync(url, multipartContent);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(); 
    }
}
