namespace Framework.Settings
{
    public static class SettingsConfiguration
    {
        public static TestSettings GetSettings(string settingsFileName)
        {
            var configRoot = BuildConfig(settingsFileName);

            return new TestSettings
            {
                WaitSeconds = configRoot.GetAppSetting("WaitSeconds"),
                BrowserName = configRoot.GetAppSetting("BrowserName"),
                BrowserType  = configRoot.GetAppSetting("BrowserType")
            };  
        }

        private static IConfigurationRoot BuildConfig(string settingsFileName)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFileName)
                .AddEnvironmentVariables()
                .Build();
        }

        private static string GetAppSetting(this IConfigurationRoot config, string settingName)
        {
            string content = config[settingName];

            if (!string.IsNullOrEmpty(content))
            {
                return content;
            }
            throw new InvalidOperationException($"Could not read app setting for {settingName}");
        }        
    }
}