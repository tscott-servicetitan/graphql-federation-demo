# Apollo Federation + HotChocolate Demo

This project uses the following tools in order to create a federated
graph across 2 services.

* [Apollo Federation](https://www.apollographql.com/docs/federation/)
* [Apollo Router](https://www.apollographql.com/docs/router/)
* [Apollo Rover](https://www.apollographql.com/docs/rover/)
* [HotChocolate](https://chillicream.com/docs/hotchocolate/v13)

The project defines two types exposed by different graphs.

* `SubgraphA` defines a type titled [Service](./SubgraphA/Types/Service.cs)
* `SubgraphB` defines a type titled [Material](./SubgraphB/Types/Material.cs)

## Building

```bash
docker compose build
```

This will build all required services as well as spit out a `schema.graphql` for each
subgraph.

## Running

```bash
docker compose up
```

This will do the following services in order:
* Run `subgraph-a` and `subgraph-b`. These are our subgraphs.
* Run `rover`. This will take the outputted subgraph schemas 
and compose them into a supergraph (see [supergraph.yaml](./supergraph.yaml)
for onfiguration)
* Run our `router`. This is the apollo router which acts as our gateway
to our subgraphs and requires a supergraph.graphql file that `rover`
has built for us. (see [ApolloRouter/config.yml](./ApolloRouter/config.yml) for configuration)

Router: http://localhost:3000

SubgraphA: http://localhost:3001

SubgraphB: http://localhost:3002

## Developing

When making changes it is important to rebuild the DotNet projects.

```bash
docker compose build subgraph-a subgraph-b
```

Then again

```bash
docker compose up
```
