namespace Be.Vlaanderen.Basisregisters.DockerUtilities
{
    using Ductus.FluentDocker.Builders;
    using Ductus.FluentDocker.Services;

    public static class DockerComposer
    {
        public static ICompositeService Compose(string dockerComposeFilePath, string serviceName)
        {
            return new Builder()
                .UseContainer()
                .UseCompose()
                .ServiceName(serviceName)
                .FromFile(dockerComposeFilePath)
                .RemoveOrphans()
                .Build()
                .Start();
        }
    }
}
