using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class subject
{
    [JsonProperty("C")]
    public string c { get; set; }

    [JsonProperty("ST")]
    public string sT { get; set; }

    [JsonProperty("O")]
    public string o { get; set; }

    [JsonProperty("CN")]
    public string cN { get; set; }

}

public class issuer
{
    [JsonProperty("C")]
    public string c { get; set; }

    [JsonProperty("ST")]
    public string sT { get; set; }

    [JsonProperty("L")]
    public string l { get; set; }

    [JsonProperty("O")]
    public string o { get; set; }

    [JsonProperty("CN")]
    public string cN { get; set; }

}

public class infoAccess
{
    [JsonProperty("CA Issuers - URI")]
    public string[] cAIssuersURI { get; set; }

    [JsonProperty("OCSP - URI")]
    public string[] oCSPURI { get; set; }

}

public class data
{
    [JsonProperty("subject")]
    public subject subject { get; set; }

    [JsonProperty("issuer")]
    public issuer issuer { get; set; }

    [JsonProperty("subjectaltname")]
    public string subjectaltname { get; set; }

    [JsonProperty("infoAccess")]
    public infoAccess infoAccess { get; set; }

    [JsonProperty("ca")]
    public bool ca { get; set; }

    [JsonProperty("bits")]
    public int bits { get; set; }

    [JsonProperty("valid_from")]
    public string validfrom { get; set; }

    [JsonProperty("valid_to")]
    public string validto { get; set; }

    [JsonProperty("serialNumber")]
    public string serialNumber { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
