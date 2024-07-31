#!/bin/bash
#
#This script will create a Graviton Processor Instance from the Ubuntu Linux Distribution AMI
#
#You must input your public IP address to have your network traffic allowed to the new Instance
#https://checkip.amazonaws.com
#
#It's also important to use a Key Pair to prove your identity when connecting to an EC2 instance
#https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html
#
#run script passing your Public IP address and your Key Pair name
#./create-ubuntu-instance.sh “YOUR PUBLIC IP x.x.x.x” “YOUR KEY PAIR NAME”
#
#This script will create a Security Group named DevelopmentUbuntuSecurityGroup
#
#This new Instance will have the 22 SSH and 3389 RDP ports opened for your Machine.
#
#author: Samuel
#contact: https://sabsfilho.github.io/dev/
#
echo -e "\n~~ CREATE GRAVITON+UBUNTU INSTANCE ~~\n"
if [ -z $1 ]
then 
  echo Include your public IP address as the first argument. 
  exit 1
fi
if [ -z $2 ]
then 
  echo Include your Key Pair name as the second argument. 
  exit 1
fi

PUBLIC_IP=$1/32
KEY_PAIR=$2

# Instance Specification  
SecurityGroupName="DevelopmentUbuntuSecurityGroup"
SecurityGroupDescription="DevelopmentUbuntuSecurityGroup"
InstanceName="DevelopmentUbuntu01"
ImageId="ami-02832c25e621867d1"
InstanceType="r7g.medium"
DeviceMappings="DeviceName=/dev/sda1,Ebs={Iops=3000,VolumeSize=20,VolumeType=gp3,Throughput=125,DeleteOnTermination=true}"
TagSpecifications="ResourceType=instance,Tags=[{Key=Name,Value=$InstanceName}]"
NetworkInterfaces="AssociatePublicIpAddress=true,DeviceIndex=0"

echo create security group $SecurityGroupName

PrevGroupName=$(aws ec2 describe-security-groups --filters Name=group-name,Values=$SecurityGroupName --query 'SecurityGroups[*].GroupName' --output text)
if [[ $PrevGroupName == $SecurityGroupName ]]
then
  aws ec2 delete-security-group --group-name $SecurityGroupName
fi

SecurityGroupId=$(aws ec2 create-security-group --group-name $SecurityGroupName --description $SecurityGroupDescription --query 'GroupId' --output text)
aws ec2 wait security-group-exists --group-names $SecurityGroupName

echo open port SSH
aws ec2 authorize-security-group-ingress --group-id $SecurityGroupId --protocol tcp --port 22 --cidr $PUBLIC_IP

echo open port RDP
aws ec2 authorize-security-group-ingress --group-id $SecurityGroupId --protocol tcp --port 3389 --cidr $PUBLIC_IP

echo create new Instance using $SecurityGroupId
InstanceId=$(aws ec2 run-instances \
--image-id $ImageId \
--instance-type $InstanceType \
--key-name $KEY_PAIR \
--security-group-ids $SecurityGroupId \
--block-device-mappings $DeviceMappings \
--tag-specifications $TagSpecifications \
--network-interfaces $NetworkInterfaces \
--count 1 \
--query "Instances[*].[InstanceId]" \
--output text) || {
aws_cli_error_log ${?}
errecho "ERROR: $InstanceId"
exit 1
}
I=20
InstanceState="undefined"
while [[ $I -ge 0 && $InstanceState != "running" ]]
do
  InstanceState=$(aws ec2 describe-instance-status --instance-ids $InstanceId --include-all-instances --query 'InstanceStatuses[*].InstanceState.Name' --output text)
  echo $InstanceId: $InstanceState ...
  sleep 5
  echo $I
  (( I-- ))
done

echo $InstanceId: running

echo "This script was executed successfully. The instance $InstanceName[$InstanceId] was created and it's ready to be used."

echo -e "\n~~ END ~~\n"
