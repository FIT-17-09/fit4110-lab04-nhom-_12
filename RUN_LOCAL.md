# RUN LOCAL

## Build image

docker build -t corebusiness:lab04 .

## Run container

docker run -d \
-p 8080:8080 \
--name corebusiness \
corebusiness:lab04

## Verify

curl http://localhost:8080/api/Health

## Stop

docker stop corebusiness
docker rm corebusiness