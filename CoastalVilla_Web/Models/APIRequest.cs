using System.Reflection.Metadata.Ecma335;
using static CoastalVilla_Utility.SD;

namespace CoastalVilla_Web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}
