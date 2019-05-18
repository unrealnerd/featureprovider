# Feature Provider

Feature Provider helps fetching feature toggle or feature evaluators from mutiple sources.
This library aims to abstract the consumption of caching libraries. Right now you can access features using Redis and Basic configuration file.

## Usage

Add this package using `dotnet add package -s <path to package>` 

Once added to your application you need to register the IOC using the below method in Startup.cs

`services.AddFeatureProvider();`

Add the below section to appsettings.json

```json
  "FeatureProvider":{
    "RedisServer":"localhost",
    "DefaultFeatureSource":"redis"
  }
```

## TODO

- Provide ways to exclusively select caching libraries
- Add more caching libraries
- Publish to Nuget and git packages
- ci-cd using cicircle