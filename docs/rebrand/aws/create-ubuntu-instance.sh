#!/bin/bash
#This script will create a Graviton Processor Instance from the Ubuntu Linux Distribution AMI
#You must input your public IP address
#./create-ubuntu-instance.sh "TYPE HERE YOUR PUBLIC IP"
echo -e "\n~~ CREATE GRAVITON+UBUNTU INSTANCE ~~\n"
if [[ $1 -gt 0 ]]
then 
: 
I=$1
  echo $I
else
  echo Include your public IP address as the first argument. 
fi
