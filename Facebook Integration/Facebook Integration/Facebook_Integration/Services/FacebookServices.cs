using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook_Integration.Model;
using Newtonsoft.Json;
using ModernHttpClient;
using System.Net.Http;

namespace Facebook_Integration.Services
{
    class FacebookServices
    {
        public async Task<FacebookProfile> GetFacebookProfileAsync(string accessToken)
        {
            var requestUrl =
                "https://graph.facebook.com/v2.8/me/?fields=name,languages&access_token="
                + accessToken;

            var httpClient = new HttpClient(new NativeMessageHandler());

            var userJson = await httpClient.GetStringAsync(requestUrl);

            var facebookProfile = JsonConvert.DeserializeObject<FacebookProfile>(userJson);

            return facebookProfile;
        }

    }
}
