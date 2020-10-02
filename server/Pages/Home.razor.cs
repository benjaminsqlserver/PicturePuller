using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Newtonsoft.Json;
using PicturePuller.Models;

namespace PicturePuller.Pages
{
    public partial class HomeComponent
    {

        private async Task FetchImages()
        {
            try
            {
                //get api connection string from appsettings.json
                var pixabayKey = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("PixabaySettings")["PixabayKey"];
                var pixabayAPIURL = string.Format("https://pixabay.com/api/?key={0}&q={1}&image_type={2}", pixabayKey, searchTerm, imageType);

                var client = new RestClient(pixabayAPIURL);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                //deserialize json response to C# objects

                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response.Content);

                //if deserialized object is not null get hits retrived from pixabay
                if (myDeserializedClass != null)
                {
                    getImageResult = myDeserializedClass.hits;
                }
            }
            catch
            {
                NotificationService.Notify(NotificationSeverity.Error, "Image Fetch Error", "An Error Occurred While Fetching Images From Pixabay", 7000);
            }
            
        }

        private async Task Reset()
        {
            getImageResult = new List<Models.Hit>();
        }

    }
}
