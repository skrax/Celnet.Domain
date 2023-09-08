# Celnet.Domain

Celnet.Domain is a toolkit for building client-server models and APIs in .NET.
This library simplifies the development of networking applications by providing a set of interfaces and implementations to streamline the process.

## Overview

Celnet.Domain is a .NET library that offers interfaces and implementations for creating client-server models and APIs.
Whether you're building a networked application or a web service, this library provides the tools you need to create robust and scalable solutions.

## Features

### Client-Server Model

Celnet.Domain offers a comprehensive set of interfaces for implementing a client-server model:

- **IPeer**:
  - Provides a foundation for sending and receiving messages.
  - Defines essential events such as PeerConnectedEvent, PeerDisconnectedEvent, PeerTimeoutEvent, and PeerReceiveEvent.

- **IClient**:
  - Extends the IPeer interface to cater to client-specific functionalities.
  
- **IServer**:
  - Extends the IPeer interface to cater to server-specific functionalities.

### API Building

Building APIs in your application is simplified with Celnet.Domain:

- **IApi**:
  - Offers an interface for executing various requests, including GET, POST, DELETE, PUT, and EVENT.
  
- **IApiBuilder**:
  - Provides an interface for defining APIs, allowing you to create, configure, and manage your API endpoints with ease.
 
### Building APIs with `Backend<TBody, TResponse>`

The Celnet.Domain library provides a powerful way to define and manage APIs using the `Backend<TBody, TResponse>` class.
This class is designed to simplify the process of mapping request methods (GET, POST, PUT, DELETE, EVENT) to specific routes in your application.

#### Creating a Backend

You can create a new `Backend<TBody, TResponse>` instance using either the standard `Make` method or a concurrent version using `MakeConcurrent`.
Here's how you can create a `Backend`:

```csharp
// Standard Backend
var backend = Backend<TBody, TResponse>.Make();

// Concurrent Backend (Thread-safe)
var concurrentBackend = Backend<TBody, TResponse>.MakeConcurrent();
```

#### Mapping Routes

Once you have a `Backend` instance, you can easily map routes to functions or actions using the provided methods:

- `MapGet(string route, Func<TBody?, TResponse> functor)`: Map a route to a GET request handler.
- `MapPost(string route, Func<TBody, TResponse> functor)`: Map a route to a POST request handler.
- `MapPut(string route, Func<TBody, TResponse> functor)`: Map a route to a PUT request handler.
- `MapDelete(string route, Func<TBody, TResponse> functor)`: Map a route to a DELETE request handler.
- `MapEvent(string route, Action<TBody> act)`: Map a route to an event handler.

Here's an example of how to map routes in your `Backend` instance:

```csharp
backend.MapGet("/get/resource", GetResourceFunction);
backend.MapPost("/post/resource", PostResourceFunction);
backend.MapPut("/put/resource", PutResourceFunction);
backend.MapDelete("/delete/resource", DeleteResourceFunction);
backend.MapEvent("/event/resource", EventResourceFunction);
```

#### Executing Requests and Events

Once routes are mapped, you can easily execute requests and events using the corresponding methods:

- `Get(string route, TBody? body)`: Execute a GET request with an optional body.
- `Post(string route, TBody body)`: Execute a POST request with a body.
- `Put(string route, TBody body)`: Execute a PUT request with a body.
- `Delete(string route, TBody body)`: Execute a DELETE request with a body.
- `Event(string route, TBody body)`: Execute an event with a body.

Here's an example of how to execute requests and events:

```csharp
var response = backend.Get("/get/resource", null);
var postResponse = backend.Post("/post/resource", requestBody);
var eventBody = new EventRequestBody(/*...*/);
backend.Event("/event/resource", eventBody);
```


## Getting Started

To get started with Celnet.Domain, follow these steps:

1. Install the Celnet.Domain library using NuGet Package Manager or add it to your project's references.

2. Import the necessary namespaces:
   
   ```csharp
   using Celnet.Domain;
   ```
3. Implement the required interfaces (IPeer, IClient, IServer, IApi, IApiBuilder) in your application based on your project's requirements.

4. Utilize the provided API implementation for your backend development, making use of IApi and IApiBuilder to define and execute requests.


## Contributing

We welcome contributions to the Celnet.Domain library. If you have ideas for improvements, bug fixes, or new features, please open an issue or create a pull request on our GitHub repository.

## License

This library is licensed under the MIT License. See the [LICENSE](https://github.com/skrax/Celnet.Domain/blob/main/LICENSE) file for details.
