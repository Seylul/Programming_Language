def oku():
	sayi=[]
	ilkon=[]
	toplam=0
	okunan=open('euler13.txt','r')
	
	for digit in okunan:
		sayi.append(digit)
	
	for i in sayi:
		toplam+= int(i)
	
	for rakamlar in str(toplam):
		ilkon.append(rakamlar)
	sonuc=ilkon[0:10]
	
	print sonuc
		
	okunan.close()    
oku()
