using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public abstract class Response<TData>
    {
        public Response() => _code = Configuration.DefaultStatusCode;
        [JsonConstructor] // informa que esse construtor é o padrão
        public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }

        private int _code = 200;
        //Padronização - Http Status Code
        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;   // se o status code estiver dentro do range 200

    }
}
