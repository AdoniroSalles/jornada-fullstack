using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests
{
    public abstract class Request
    {
        //class abstract nao pode ser instanciada, apenas herdada
        public string UserId { get; set; } = string.Empty;
    }
}
