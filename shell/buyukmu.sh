#!/bin/bash
bir=1
iki=2
#değişkenlere atıyoruz.
if [$bir -lt $iki ]; then #-lt küçüktür anlamında kullanılır.
	echo 'bir > iki'  #ekrana yazdır.
fi			  #if komutunu açtığımızda direkt kendisi fi'yi yazar.
