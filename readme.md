# Orleans Internet of Thing Example

Am extremely basic sample application to demonstrate how Project Orleans could be used in an 'Internet of Things' scenario.

## How to Run

1. Build the solution
1. Run the local silo `$(OrleansSDK)\StartLocalSilo.cmd`
1. Start the Web application

You can then do a POST to set the temperature of a device, or a GET to retrieve the temperature:

```
POST /api/Temperature/{deviceId}
{temperature as the message body}

GET /api/Temperature/{deviceId}
```

Using cURL:
```
$ curl http://localhost:24648/api/Temperature/1 --data =99
$ curl http://localhost:24648/api/Temperature/1
```

## License

MIT
