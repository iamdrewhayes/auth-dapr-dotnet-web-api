# auth-dapr-dotnet-web-api
Authentication and Authorization of Dapr Requests for .NET Web API

This reference project gives an example on how to setup a .NET Web API with authentication and authorization for requests coming from a Dapr sidecar. [Check out the article](https://www.drewhayes.dev/blog/authentication-and-authorization-dapr-requests-net-web-api/) that goes with this repo.

Executing the SampleBff's InitiateBackgroundProcessingController action will publish 10 messages using Dapr. The SampleProcessingService subscribes to these messages and prints the message contents. The SampleProcessingService is configured to authenticate and authorize requests from Dapr.
