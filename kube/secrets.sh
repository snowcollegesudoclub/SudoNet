#!/bin/bash

kubectl create secret generic secret-appsettings \
    --from-file=$HOME/.microsoft/usersecrets/aspnet-WebApplication1-BFE5B400-A838-4B80-8681-AB46A45E14CC/secrets.json
