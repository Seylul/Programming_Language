def even_fib():
	artis,toplam,sayi=1,0,0
	while True:
		sayi=sayi+artis
		if sayi <= 4000000:
			if sayi%2==0:
				toplam+=sayi
		else:
			break
		artis=sayi-artis
	print toplam
