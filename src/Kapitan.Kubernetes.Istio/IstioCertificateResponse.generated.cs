using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class IstioCertificateResponse
    {
        /** <summary>PEM-encoded certificate chain. The leaf cert is the first element, and the root cert is the last element.</summary> */
        public IEnumerable<string> certChain { get; set; }
    }
}