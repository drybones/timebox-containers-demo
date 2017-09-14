# escape=`
ARG base_version=latest
FROM microsoft/mssql-server-windows:$base_version

ENV sa_password D0cker!a8s

COPY start.ps1 /
COPY post-start.ps1 /

ARG database_name
ENV attach_dbs "[{'dbName':'$database_name','dbFiles':['C:\\\\database\\\\Data\\\\${database_name}.mdf','C:\\\\database\\\\Data\\\\${database_name}_log.ldf']}]"
ENV database_name $database_name

COPY bin/**/*_DeployPackage.ps1 /
COPY bin/**/*_Package.sql /