using Be.Vlaanderen.Basisregisters.DockerUtilities;

var dockerComposeFilePath = Path.Combine(Directory.GetCurrentDirectory(), "postgres_test.yml");
var serviceName = "dockerutilities-postgres-sample";

Console.WriteLine("Performing docker-compose up for postgres_test.yml");

var compositeService = DockerComposer.Compose(dockerComposeFilePath, serviceName);

Console.WriteLine("Container is running");

Console.WriteLine("Hit any key to perform docker-compose down");
Console.ReadKey();

compositeService.Stop();

