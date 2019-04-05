using RestSharp;

using System;
using System.Net;
using System.Reflection;
using System.Diagnostics;

namespace VisibleSCM
{
    public class Client
    {
        internal string version;

        internal RestClient client;
        internal VisibleConfig configuration;

        internal Client() : this(new VisibleConfig()) { }
        internal Client(VisibleConfig visibleConfiguration)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            if (visibleConfiguration == null) throw new ArgumentNullException("visibleConfiguration");
            configuration = visibleConfiguration;

            client = new RestClient(visibleConfiguration.ApiURL);

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
            version = info.FileVersion;
        }

        internal T Execute<T>(VisibleRequest request) where T : new()
        {
            RestResponse<T> response = (RestResponse<T>)client.Execute<T>((RestRequest)request);

            return response.Data;
        }
    }
}
