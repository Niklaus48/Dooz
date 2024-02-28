using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dooz
{
    [System.Serializable]
    public class MessageBase
    {
        public string action {  get; set; }
        public string data { get; set; }
    }

}
