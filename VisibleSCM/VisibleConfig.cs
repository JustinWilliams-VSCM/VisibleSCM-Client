namespace VisibleSCM
{
    public class VisibleConfig
    {
        private const string DefaultVersion = "V1";
        private const string SandboxURL = "https://sandbox.packagehub.com/api/";
        private const string ProductionURL = "https://api.packagehub.com/api/";

        internal string ApiURL { get; set; }
        internal VisibleVersion ApiVersion { get; set; }
        internal VisibleEnvironment Environment { get; set; }
        
        public VisibleConfig(VisibleVersion version, VisibleEnvironment environment)
        {
            ApiVersion = version;
            Environment = environment;

            SetEnvironment();
            SetVersion();
        }
        internal VisibleConfig() : this(VisibleVersion.V1, VisibleEnvironment.Sandbox) { }
        internal VisibleConfig(VisibleVersion version) : this(version, VisibleEnvironment.Sandbox) { }
        internal VisibleConfig(VisibleEnvironment environment) : this(VisibleVersion.V1, environment) { }

        private void SetEnvironment()
        {
            switch (Environment)
            {
                case VisibleEnvironment.Sandbox:
                    ApiURL = SandboxURL;
                    break;
                case VisibleEnvironment.Production:
                    ApiURL = ProductionURL;
                    break;
            }
        }

        private void SetVersion()
        {
            if (ApiURL.Substring(ApiURL.Length - 1).Equals("/"))
                ApiURL += ApiVersion;
            else
                ApiURL += $"/{ApiVersion}";
        }
    }
}
