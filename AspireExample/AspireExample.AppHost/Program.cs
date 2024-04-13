var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("rediscache");

var api = builder.AddProject<Projects.AspireExample_Api>("webapi");
builder.AddProject<Projects.AspireExample_App>("front")
    .WithReference(api)
    .WithReference(cache);

builder.Build().Run();
