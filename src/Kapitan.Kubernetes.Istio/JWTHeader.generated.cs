using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes
{
    public partial class JWTHeader
    {
        /** <summary>The HTTP header name.</summary> */
        public string name { get; set; }
        /** <summary>The prefix that should be stripped before decoding the token. For example, for "Authorization: Bearer <token>", prefix="Bearer " with a space at the end. If the header doesn't have this exact prefix, it is considerred invalid.</summary> */
        public string prefix { get; set; }
    }
}