using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BattleBards.Helpers
{
    public class SystemMessage
    {
        public string Message { get; set; }
        public string MessageClass { get; set; }
        public bool isSuccessful { get; set; }
        public object Value { get; set; }
    }
}