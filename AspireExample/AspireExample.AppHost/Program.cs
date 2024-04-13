var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.AspireExample_Api>("webapi");
builder.AddProject<Projects.AspireExample_App>("front")
    .WithReference(api);

builder.Build().Run();
