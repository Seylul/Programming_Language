#!/bin/bash

logs= echo Password | sudo -S cp /var/log/syslog /home/User/backup
## /var/log/syslog file is protected, it needs sudo password. For pass it i used  "echo MYPASSWORD | sudo -S COMMAND"
## syslog file is important, so i coppied file for work on it


while IFS=" " read month day time user pid action 
do
      #"Month : $month
       #  Day : $day
        #Time : $time
        #User : $user
     #Proces  : $pid 
      #Action : $action"
echo $month $day $time $user  
done </home/User/backup
## IFS - Internal field separator is used for seperate fields according to space in syslog's backup file. 
I need just timestamp and username for now
