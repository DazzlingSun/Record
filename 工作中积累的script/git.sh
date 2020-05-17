#!/bin/
time=$(date "+%Y-%m-%d %H:%M:%S")
echo "##################${time} Begin Sync Code#######################" 
oldPort=$1
newPort=$2
# workdir=$(cd $(dirname $0); pwd)
# git checkout master
sed -i "s/qgzhdc/qgzhdc-px/g" package.json
sed -i "s/$oldPort/$newPort/g" package.json
sed -i "s/qgzhdc/qgzhdc-px/g" ./config/config.default.js





 

