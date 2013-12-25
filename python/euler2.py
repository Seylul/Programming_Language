def fib():
	artis=1
	toplam=0
	sayi=0
	while True:
		sayi=sayi+artis
		if sayi <= 4000000:
			if sayi%2==0:
				toplam+=sayi
			
		else:
			break
		artis=sayi-artis
	print toplam
