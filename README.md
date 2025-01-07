# ipcalypse
dotnet web api sample for grab remote ip address

use:
```
curl -kv http://localhost:[port]/orbit
```

result:
```
{
  "remoteIp": "127.0.0.1",
  "xForwardedForIp": "Unable to determine Forwarded For IP"
}
```
remoteIp = client ip address\
xForwardedForIp = client ip address if forrwarded or pass a reverse proxy
