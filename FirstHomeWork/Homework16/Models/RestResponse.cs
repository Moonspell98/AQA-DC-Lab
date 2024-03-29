﻿using Newtonsoft.Json;

namespace Homework16.Models
{
    public class RestResponse : HttpResponseMessage
    {
        public string ResponseData { get; }

        public RestResponse(HttpResponseMessage responseMessage)
        {
            ResponseData = responseMessage.Content.ReadAsStringAsync().Result;
            StatusCode = responseMessage.StatusCode;
;       }

        public override string ToString()
        {
            return $"StatusCode: {StatusCode}\nResponse Data: {ResponseData}";
        }
    }

    public class RestResponse<T> : RestResponse where T : class
    {
        public T ResponseModel { get; }

        public RestResponse(HttpResponseMessage responseMessage) : base(responseMessage)
        {
            ResponseModel = JsonConvert.DeserializeObject<T>(ResponseData);
        }
    }
}
