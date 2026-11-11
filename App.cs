#!/usr/bin/env dotnet
#:sdk Microsoft.NET.Sdk.Web

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

var app = builder.Build();

app.MapRazorComponents<App>();
app.Run();
