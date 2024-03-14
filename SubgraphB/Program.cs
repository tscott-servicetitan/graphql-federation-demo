using SubgraphB.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddApolloFederation()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();
app.RunWithGraphQLCommandsAsync(args);

app.Run();
