var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NativeWebApi>("nativewebapi");

builder.AddProject<Projects.BlazorApp>("blazorapp");

builder.Build().Run();
