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

## Getting Started

To get started with Celnet.Domain, follow these steps:

1. Install the Celnet.Domain library using NuGet Package Manager or add it to your project's references.

2. Import the necessary namespaces:
   
   ```csharp
   using Celnet.Domain;
   ```
3. Implement the required interfaces (IPeer, IClient, IServer, IApi, IApiBuilder) in your application based on your project's requirements.

4. Utilize the provided API implementation for your backend development, making use of IApi and IApiBuilder to define and execute requests.


