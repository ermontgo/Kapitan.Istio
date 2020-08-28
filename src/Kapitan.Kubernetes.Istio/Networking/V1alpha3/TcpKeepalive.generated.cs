using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kapitan.Kubernetes;

namespace Kapitan.Kubernetes.Networking.V1alpha3
{
    public partial class TcpKeepalive
    {
        /** <summary>The time duration a connection needs to be idle before keep-alive probes start being sent. Default is to use the OS level configuration (unless overridden, Linux defaults to 7200s (ie 2 hours.)</summary> */
        public string time { get; set; }
        /** <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead. Default is to use the OS level configuration (unless overridden, Linux defaults to 9.)</summary> */
        public int probes { get; set; }
        /** <summary>The time duration between keep-alive probes. Default is to use the OS level configuration (unless overridden, Linux defaults to 75s.)</summary> */
        public string interval { get; set; }
    }
}