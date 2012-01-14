#!/bin/bash
clear
echo "1.Topla"
echo "2.Cikar"
echo "3.Carp"
echo "4.Bol"
echo "5.Temizle"
echo "6.cikis"

while true;
do
read secenek
case $secenek in
	1)typeset -i sonuc
	echo "birinci sayi"
	read sayi1
	echo "ikinci sayi"
	read sayi2
	sonuc=sayi1+sayi2
	echo sonuc=$sonuc ;;
	2)typeset -i sonuc
	echo "birinci sayi"
	read sayi1
	echo "ikinci sayi"
	read sayi2
	sonuc=sayi1-sayi2
	echo sonuc=$sonuc ;;
	3)typeset -i sonuc
	echo "birinci sayi"
	read sayi1					 
	echo "ikinci sayi"
	read sayi2	
	sonuc=sayi1*sayi2
	echo sonuc=$sonuc ;;
	4)typeset -i sonuc
	echo "bölünen"
	read sayi1
	echo "bölen"
	read sayi2
	sonuc=sayi1/sayi2
	echo sonuc=$sonuc  ;;
	5)clear;;
	6)exit ;;
esac
done
