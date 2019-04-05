using RestSharp;

namespace VisibleSCM
{
    public class VisibleRequest
    {
        internal RestRequest restRequest;
        internal Client visibleClient;

        public static explicit operator RestRequest(VisibleRequest visibleRequest)
        {
            return visibleRequest.restRequest;
        }

        public VisibleRequest(object request, string resource, Method method = Method.POST)
        {
            visibleClient = new Client();

            restRequest = new RestRequest(resource, method);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("content_type", "application/json");
            restRequest.AddJsonBody(request);
        }

        public VisibleRequest(object request, string resource, VisibleConfig visibleConfiguration, Method method = Method.POST)
        {
            visibleClient = new Client(visibleConfiguration);

            restRequest = new RestRequest(resource, method);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("content_type", "application/json");
            restRequest.AddJsonBody(request);
        }

        public T Execute<T>() where T : new()
        {
            return visibleClient.Execute<T>(this);
        }
    }
}
