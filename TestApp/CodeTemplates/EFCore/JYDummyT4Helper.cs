using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System.Runtime.Remoting.Messaging
{
    /// <summary>
    /// This class is only used to prevent compile time error when mark t4 as TextTemplatingFilePreProcessor
    /// </summary>
    public class CallContext
    {
        public static object LogicalGetData(string varname ) { return "hello"; }
    }
}

