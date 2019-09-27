
docker run --rm \
    --name sudoNetDb \
    -p 5432:5432 \
    -e POSTGRES_USER=sudoUser \
    -e POSTGRES_PASSWORD=sudoPassword \
    -e POSTGRES_DATABASE=sudonet \
    postgres

