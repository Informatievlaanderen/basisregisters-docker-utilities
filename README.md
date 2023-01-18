# basisregisters-docker-utilities

Docker-compose utilities for C#. 

    var dockerComposeFilePath = Path.Combine(Directory.GetCurrentDirectory(), "postgres_test.yml");
    var serviceName = "dockerutilities-postgres-sample";

    var compositeService = DockerComposer.Compose(dockerComposeFilePath, serviceName);