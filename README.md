# Serilog Demo

A simple app that uses Serilog hosted on a Docker container.

## Serilog
- Enrichers.Environment
- Enrichers.Environment
- Enrichers.Thread
- Sinks

## Docker Command

docker run -d --restart unless-stopped --name seq -e ACCEPT_EULA=Y -v D:\Logs:/data -p 8081:80 datalust/seq:latest
