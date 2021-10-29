# Contenedor ubuntu kevin v.0.1
FROM ubuntu:18.04
RUN apt-get update -y
RUN apt-get install apache2 -y && apt-get install nginx -y && apt-get install Terminator -y
ENTRYPOINT echo "Todo Posi..."
