using Google.Cloud.Vision.V1;   
using System;

namespace CloudVisionWithCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var client = ImageAnnotatorClient.Create();
            
            var image = Image.FromFile("images/003.jpg");
            
            var response = client.DetectLabels(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine($"Score: {annotation.Score} Description: {annotation.Description}");
            }
        }
    }
}
