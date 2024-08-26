namespace Be.Vlaanderen.Basisregisters.DockerUtilities
{
    using Ductus.FluentDocker.Builders;
    using Ductus.FluentDocker.Model.Compose;
    using Ductus.FluentDocker.Services;

    public static class DockerComposer
    {
        public static ICompositeService Compose(
            string dockerComposeFilePath,
            string serviceName,
            ComposeVersion dockerComposeVersion = ComposeVersion.V2)
        {
            return new Builder()
                .UseContainer()
                .UseCompose()
                .AssumeComposeVersion(dockerComposeVersion)
                .ServiceName(serviceName)
                .FromFile(dockerComposeFilePath)
                .RemoveOrphans()
                .Build()
                .Start();
        }
    }
}
