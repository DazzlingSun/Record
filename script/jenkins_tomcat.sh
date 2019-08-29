#!/bin/bash
TIME=`date +%F-%H`
xmmc=$1
version="*"
xmqc=$1$version
tomcatpath=/data/gcxherp/tomcat/
/usr/bin/unzip -oq /data/jenkins/${xmqc}.war -d /data/jenkins/${xmmc}
rm -rf /data/jenkins/${xmqc}.war
if [ -e ${tomcatpath}webapps/${xmmc} ] 
then 
	cd ${tomcatpath}webapps/${xmmc}
	mv WEB-INF WEB-INF${TIME}
	/usr/bin/rsync -aI --delete /data/jenkins/${xmmc}/WEB-INF ${tomcatpath}webapps/${xmmc}/
	/bin/rm -rf /data/jenkins/${xmmc}
else
	/usr/bin/rsync -aI --delete /data/jenkins/${xmmc} ${tomcatpath}webapps/
	${tomcatpath}bin/shutdown.sh
	sleep 1
	${tomcatpath}bin/startup.sh

fi

