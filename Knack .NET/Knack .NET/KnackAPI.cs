using Knack.NET.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knack.NET
{
    public class KnackAPI : IApiSettings
    {
        private readonly string _apiKey;
        private readonly string _appId;
        private readonly string _baseUrl;
        private readonly RestClient _restClient;
        public KnackAPI(string apiKey, string appId, string baseurl = null)
        {
            _apiKey = apiKey;
            _appId = appId;
            _baseUrl = baseurl ?? "https://api.knack.com";
            _restClient = new RestClient(_baseUrl);
        }

        public string AppId
        {
            get { return _appId; }
        }

        public string ApiKey
        {
        
            get { return _apiKey; }
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
        }

        public string SendPostRequest(string path, object postObj)
        {
            var request = new RestRequest(_baseUrl + path, Method.POST, DataFormat.Json);

            request.AddHeader("X-Knack-Application-Id", AppId);
            request.AddHeader("X-Knack-REST-API-KEY", ApiKey);
            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(postObj));
       

            var response = _restClient.Execute(request);
            var responseData = response.Content;

            if (!response.IsSuccessful)
            {
                throw new Exception("Error from Knack: " + responseData);               
            }
            return responseData;
        }
        public RecordBase SendGetRequest(string path)
        {
            var request = new RestRequest(_baseUrl + path, Method.GET, DataFormat.Json);

            request.AddHeader("X-Knack-Application-Id", AppId);
            request.AddHeader("X-Knack-REST-API-KEY", ApiKey);
            

            var response = _restClient.Execute(request);
            var responseData = JsonConvert.DeserializeObject<RecordBase>(response.Content);

            if (!response.IsSuccessful)
            {
                throw new Exception("Error from Knack: " + responseData);
            }
            return responseData;
        }
    }
}
