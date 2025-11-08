using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Subject data
    /// </summary>
    public class Subject
    {
        [JsonProperty("C")]
        public string C { get; set; }

        [JsonProperty("ST")]
        public string ST { get; set; }

        [JsonProperty("O")]
        public string O { get; set; }

        [JsonProperty("CN")]
        public string CN { get; set; }

    }
    /// <summary>
    /// Issuer data
    /// </summary>
    public class Issuer
    {
        [JsonProperty("C")]
        public string C { get; set; }

        [JsonProperty("ST")]
        public string ST { get; set; }

        [JsonProperty("L")]
        public string L { get; set; }

        [JsonProperty("O")]
        public string O { get; set; }

        [JsonProperty("CN")]
        public string CN { get; set; }

    }
    /// <summary>
    /// InfoAccess data
    /// </summary>
    public class InfoAccess
    {
        [JsonProperty("CA Issuers - URI")]
        public string[] CAIssuersURI { get; set; }

        [JsonProperty("OCSP - URI")]
        public string[] OCSPURI { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("subject")]
        public Subject Subject { get; set; }

        [JsonProperty("issuer")]
        public Issuer Issuer { get; set; }

        [JsonProperty("subjectaltname")]
        public string Subjectaltname { get; set; }

        [JsonProperty("infoAccess")]
        public InfoAccess InfoAccess { get; set; }

        [JsonProperty("ca")]
        public bool Ca { get; set; }

        [JsonProperty("bits")]
        public int Bits { get; set; }

        [JsonProperty("valid_from")]
        public string Validfrom { get; set; }

        [JsonProperty("valid_to")]
        public string Validto { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

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
