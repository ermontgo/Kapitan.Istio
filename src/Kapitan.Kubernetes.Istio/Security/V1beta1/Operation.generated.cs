using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Security.V1beta1
{
    public partial class Operation
    {
        /** <summary>Optional. A list of hosts, which matches to the "request.host" attribute.</summary> */
        public IEnumerable<string> hosts { get; set; }
        /** <summary>Optional. A list of negative match of hosts.</summary> */
        public IEnumerable<string> notHosts { get; set; }
        /** <summary>Optional. A list of ports, which matches to the "destination.port" attribute.</summary> */
        public IEnumerable<string> ports { get; set; }
        /** <summary>Optional. A list of negative match of ports.</summary> */
        public IEnumerable<string> notPorts { get; set; }
        /** <summary>Optional. A list of methods, which matches to the "request.method" attribute. For gRPC service, this will always be "POST".</summary> */
        public IEnumerable<string> methods { get; set; }
        /** <summary>Optional. A list of negative match of methods.</summary> */
        public IEnumerable<string> notMethods { get; set; }
        /** <summary>Optional. A list of paths, which matches to the "request.url_path" attribute. For gRPC service, this will be the fully-qualified name in the form of "/package.service/method".</summary> */
        public IEnumerable<string> paths { get; set; }
        /** <summary>Optional. A list of negative match of paths.</summary> */
        public IEnumerable<string> notPaths { get; set; }
    }
}