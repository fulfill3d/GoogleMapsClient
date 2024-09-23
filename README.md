
# GoogleMapsClient

This provides an interface for interacting with the Google Maps Geocoding API, allowing for the retrieval of latitude and longitude based on a provided address. It is built with .NET 8 and leverages RestSharp for HTTP communication, following clean architecture principles with dependency injection.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
5. [Usage](#usage)
6. [Configuration](#configuration)

## Introduction

The Google Maps Client Microservice allows easy integration with the Google Maps Geocoding API, providing a streamlined way to convert addresses into geographic coordinates. This microservice is designed to be modular and easily extensible, following best practices for clean architecture.

## Features

- **Address Geocoding:** Convert physical addresses into geographic coordinates (latitude and longitude).
- **Error Handling & Retry Logic:** Built-in error handling and retry logic for robust API communication.

## Tech Stack

- **Backend:** .NET 8
- **API Client:** RestSharp
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the GoogleMapsClient:** Use the `RegisterGoogleMapsClient` method in `DepInj` to register the client in the dependency injection container.
2. **Fetch Coordinates:** Use the `GetCoordinatesAsync` method from the `IGoogleMapsClient` to retrieve latitude and longitude for a given address.

## Configuration

### GoogleMapsOptions

- **ApiKey:** The API key for accessing the Google Maps Geocoding API.

```csharp
public class GoogleMapsOptions
{
    public string ApiKey { get; set; }
}
```
