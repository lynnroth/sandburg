var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Sandburg_Server>("sandburg-server");

builder.Build().Run();
