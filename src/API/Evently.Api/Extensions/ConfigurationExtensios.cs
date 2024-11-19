namespace Evently.Api.Extensions;

internal static class ConfigurationExtensios
{
    internal static void AddModuleConfiguration(
        this IConfigurationBuilder configurationBuilder,
        string[] modules)
    {
        foreach (string module in modules)
        {
            configurationBuilder.AddJsonFile($"modules.{module}.json", false, true);
            configurationBuilder.AddJsonFile($"modules.{module}.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true);
        }
}
