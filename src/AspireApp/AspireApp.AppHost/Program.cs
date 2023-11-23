var builder = DistributedApplication.CreateBuilder(args);

var sql = builder
    .AddSqlServerContainer("sql")
    .AddDatabase("sqldata");

var apiProject = builder.AddProject<Projects.NativeWebApi>("nativewebapi");

builder.AddProject<Projects.BlazorApp>("blazorapp")
    .WithReference(apiProject);

builder.Build().Run();
