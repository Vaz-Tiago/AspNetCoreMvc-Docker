# AspNetCoreMvc-Docker
**How to prepare a project to run on docker.**

- Create Volumes
- Create Networks
- Create DataBase Image
- Create App Image


## Understanding the workflow

1. Creating a Container with a haproxy image to load balancer the application.
2. Creating a frontend network to communicate the load balancer container with the application containers.
3. Creating the application containers with the production code version.
4. Creating a backend network to communicate the app containers with the database.

