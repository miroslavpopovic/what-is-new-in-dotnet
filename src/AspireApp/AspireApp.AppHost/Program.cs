var builder = DistributedApplication.CreateBuilder(args);

var sql = builder
    .AddSqlServerContainer("sql")
    .AddDatabase("sqldata");

builder.AddProject<Projects.NativeWebApi>("nativewebapi")
    .WithReference(sql);

builder.AddProject<Projects.BlazorApp>("blazorapp");

builder.Build().Run();
