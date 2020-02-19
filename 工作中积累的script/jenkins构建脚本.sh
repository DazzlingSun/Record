#tomcat应用中的名字
appName=kqgl
#打包后的war前缀
warName=gxsnERP-kq

baseDir=/usr/local/tomcat
#back-up
if [ ! -e $baseDir/bak/ ];then
        mkdir $baseDir/bak/
fi
cp -rf $baseDir/webapps/gxsnerp-all/$appName  $baseDir/bak/$appName

#redeploye
rm -rf $baseDir/webapps/gxsnerp-all/$appName
mv -f $warName*.war  $baseDir/webapps/gxsnerp-all/$appName.war

#copy static resources
if [ ! -e  $baseDir/bak/$appName/resources ];then
       mkdir $baseDir/bak/$appName/resources/
fi
cp -rf  $baseDir/bak/$appName/resources $baseDir/webapps/gxsnerp-all/$appName/