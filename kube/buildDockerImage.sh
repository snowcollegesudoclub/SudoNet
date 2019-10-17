#!/bin/bash

docker build -t alexmickelson/sudonet:latest -f ../Sudo/Dockerfile ..

docker push alexmickelson/sudonet:latest
