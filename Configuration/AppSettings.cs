using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClientWebAssembly.Configuration
{
    public class AppSettings
    {
         public string BaseAPIUrl { get; set; }
         public BaseBookEndpoint BaseBookEndpoint { get; set; }
    }
}