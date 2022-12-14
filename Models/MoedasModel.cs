using System.Text.Json.Serialization;

namespace ConsumoAPI_Dolar.Models
{
    public class MoedasModel
    {
        [JsonPropertyName("USDBRL")]
        public USDBRL USDBRL { get; set; }
    }

    public class USDBRL
    {
        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("codein")]
        public string codein { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("high")]
        public string high { get; set; }

        [JsonPropertyName("low")]
        public string low { get; set; }

        [JsonPropertyName("varBid")]
        public string varBid { get; set; }

        [JsonPropertyName("pctChange")]
        public string pctChange { get; set; }

        [JsonPropertyName("bid")]
        public string bid { get; set; }

        [JsonPropertyName("ask")]
        public string ask { get; set; }

        [JsonPropertyName("timestamp")]
        public string timestamp { get; set; }

        [JsonPropertyName("create_date")]
        public string create_date { get; set; }
    }


    //public class MoedasModel
    //{
    //     [JsonPropertyName("code")]
    //    public string? Code { get; set; }

    //    [JsonPropertyName("codein")]
    //    public string? Codein { get; set; }

    //    [JsonPropertyName("name")]
    //    public string? Name { get; set; }

    //    [JsonPropertyName("high")]
    //    public string? High { get; set; }

    //    [JsonPropertyName("low")]
    //    public string? Low { get; set; }

    //    [JsonPropertyName("varBid")]
    //    public string? VarBid { get; set; }

    //    [JsonPropertyName("pctChange")]
    //    public string? PctChange { get; set; }

    //    [JsonPropertyName("bid")]
    //    public string? Bid { get; set; }

    //    [JsonPropertyName("ask")]
    //    public string? Ask { get; set; }

    //    [JsonPropertyName("timestamp")]
    //    public string? Timestamp { get; set; }

    //    [JsonPropertyName("create_date")]
    //    public string? CreateDate { get; set; }
    //}
}