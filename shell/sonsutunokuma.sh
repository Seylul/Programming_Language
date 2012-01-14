#!/bin/bash
while IFS=: read user pass uid gid full home shell
do
	#$full :\n\
	#Pseudo : $user\n\
	#UID :\t $uid\n\
	#GID :\t $gid\n\
	#Home :\t $home\n\
	echo "Shell : $shell" 
done </etc/passwd
#IFS bu dosya için şu işlemi yapıyor. etc/passwd içindeki her satir  ":" bu
#işaretle 7'ye bölümüş, o yüzden IFS yazdığımız yere readkomutundan sonra 7 tane
#etiket atıyoruz göstermesini istediğimiz etiketi de echo komutuyla yazdırıyoruz. 
