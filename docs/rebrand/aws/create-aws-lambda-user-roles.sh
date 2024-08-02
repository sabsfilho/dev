#!/bin/bash
#
#This script will create the AWS User credentials needed to access AWS Lambda resources
#
#run script 
#./create-aws-lambda-user-roles.sh
#
#This script will:
# - Create Security Group named LambdaSecurityGroup
# - Create User named LambdaUser
# - Apply FullAccessLambda role to LambdaSecurityGroup
# - Create Role DockerHeroRole
# - Apply AWSLambdaBasicExecutionRole role to DockerHeroRole

echo Create LambdaSecurityGroup
aws ec2 create-security-group --group-name LambdaSecurityGroup --description "Lambda security group"

echo Create LambdaUser
aws iam create-user --user-name LambdaUser

echo Add LambdaUser to LambdaSecurityGroup
aws iam add-user-to-group --user-name LambdaUser --group-name LambdaSecurityGroup

echo Apply FullAccessLambda to LambdaSecurityGroup
aws iam attach-role-policy --role-name DockerHeroRole --policy-arn arn:aws:iam::aws:policy/AWSLambda_FullAccess
echo Apply ECR_AllowAuthorization to LambdaSecurityGroup
aws iam attach-role-policy --role-name DockerHeroRole --policy-arn arn:aws:iam::091201685298:policy/ECR_AllowAuthorization

echo Create DockerHeroRole
aws iam create-role --role-name DockerHeroRole --assume-role-policy-document '{"Version": "2012-10-17","Statement": [{ "Effect": "Allow", "Principal": {"Service": "lambda.amazonaws.com"}, "Action": "sts:AssumeRole"}]}'

echo Apply AWSLambdaBasicExecutionRole to DockerHeroRole
aws iam attach-role-policy --role-name DockerHeroRole --policy-arn arn:aws:iam::aws:policy/service-role/AWSLambdaBasicExecutionRole

aws iam create-access-key --user-name LambdaUser

echo "This script was executed successfully."
echo "You can use the LambdaUser credentials AccessKeyId and SecretAccessKey to consume AWS Lambda Function resources."

echo -e "\n~~ END ~~\n"
