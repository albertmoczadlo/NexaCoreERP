using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NexaCoreERP.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddClient();

await builder.Build().RunAsync();
