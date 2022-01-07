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

        private string _message = null;
        private string _msg = null;

        /// <summary>
        /// error message for error response.
        /// </summary>
        public string Message { 
            get {

                return _message;
            
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                  _msg=  _message = value;
                }
                
            }
        }

        public string Msg {
            get
            {

                return _msg;

            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _msg = _message = value;
                }

            }
        }
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
