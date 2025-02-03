using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class coordinates
{
    [JsonProperty("lat")]
    public int lat { get; set; }

    [JsonProperty("lng")]
    public int lng { get; set; }

}

public class data
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("cca2")]
    public string cca2 { get; set; }

    [JsonProperty("landlocked")]
    public bool landlocked { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

    [JsonProperty("subregion")]
    public string subregion { get; set; }

    [JsonProperty("coordinates")]
    public coordinates coordinates { get; set; }

    [JsonProperty("borders")]
    public string[] borders { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
