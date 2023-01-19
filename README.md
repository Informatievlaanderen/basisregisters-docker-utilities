# basisregisters-docker-utilities

Docker-compose utilities for C#. 

See the samples folder on how to use the library.

Example code:

    var dockerComposeFilePath = Path.Combine(Directory.GetCurrentDirectory(), "postgres_test.yml");
    var serviceName = "dockerutilities-postgres-sample";

    var compositeService = DockerComposer.Compose(dockerComposeFilePath, serviceName);