﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System.Text.Json.Serialization;

namespace Microsoft.StoreServices.DisplayCatalog.Product
{
    public class Conditions
    {
        [JsonPropertyName("ClientConditions")]
        public ClientConditions ClientConditions;

        [JsonPropertyName("EndDate")]
        public string EndDate;

        [JsonPropertyName("ResourceSetIds")]
        public string[] ResourceSetIds;

        [JsonPropertyName("StartDate")]
        public string StartDate;
    }
}