using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Coordinates data
    /// </summary>
    public class Coordinates
    {
        [JsonProperty("lat")]
        public int Lat { get; set; }

        [JsonProperty("lng")]
        public int Lng { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("cca2")]
        public string Cca2 { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("borders")]
        public string[] Borders { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
