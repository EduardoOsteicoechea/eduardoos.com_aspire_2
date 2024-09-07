var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.eduardoos_com_aspire_2_ApiService>("apiservice");

builder.AddProject<Projects.eduardoos_com_aspire_2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
