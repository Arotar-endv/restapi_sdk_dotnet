﻿using Newtonsoft.Json;
using SecureNetRestApiSDK.Api.Models;

namespace SecureNetRestApiSDK.Api.Responses
{
    public class VerifyResponse : SecureNetResponse
    {
        #region Properties

        [JsonProperty("transaction")]
        public Transaction Transaction { get; set; }

        #endregion
    }
}
