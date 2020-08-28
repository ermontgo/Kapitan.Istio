using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1beta1
{
    public partial class HTTPRedirect
    {
        /** <summary>On a redirect, overwrite the Path portion of the URL with this value. Note that the entire path will be replaced, irrespective of the request URI being matched as an exact path or prefix.</summary> */
        public string uri { get; set; }
        /** <summary>On a redirect, overwrite the Authority/Host portion of the URL with this value.</summary> */
        public string authority { get; set; }
        /** <summary>On a redirect, Specifies the HTTP status code to use in the redirect response. The default response code is MOVED_PERMANENTLY (301).</summary> */
        public int redirectCode { get; set; }
    }
}