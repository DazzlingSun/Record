#!/bin/bash
export JAVA_HOME=/usr/local/jdk1.8.0_171
export JRE_HOME=/usr/local/jdk1.8.0_171/jre
#tomcat_pid=`/usr/sbin/lsof -n -P -t -i:8089`
#stop tomcat
#if [ -n "$tomcat_pid" ];then
#/bin/kill -9 $tomcat_pid
#sleep 1
#fi
/usr/bin/unzip -oq /mnt/jenkins/*${1}*.war -d /mnt/jenkins/$1
/usr/bin/rsync -aI --delete /mnt/jenkins/$1/WEB-INF /usr/local/tomcat9/webapps/$1/
/bin/rm -rf /mnt/jenkins/$1
#chown -R gxsnerp-all:gxsnerp-all  /data/www/gxsnerp-all/gxsnerp
#/etc/init.d/tomcat9 start
