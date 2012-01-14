#!/bin/bash
typeset -i sonuc
#bu satir olmasaydı echo sonuc sayi1+sayi2 olarak donerdi
#bu satir sayesinde degiskenlere atadigimiz degerler uzerinde islem yapilir.
echo bir sayi giriniz:
read sayi1
echo toplanıcak diger sayiyi giriniz:
read sayi2
sonuc=sayi1+sayi2
echo sonuc $sonuc
