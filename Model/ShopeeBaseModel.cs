using Newtonsoft.Json;
using System;

namespace WeTools.ShopeeSDK.Model
{
    [Serializable]
    public class ShopeeBaseModel
    {
        /// <summary>
        /// error code for error response, zero means successful response.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// error message for error response.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// request id for api request.
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; }


        [JsonProperty("warning")]
        public string Warning { get; set; }

        public bool IsError()
        {
            return !string.IsNullOrWhiteSpace(Error);
        }
    }
}
