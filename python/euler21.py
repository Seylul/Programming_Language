def bolen(sayi):
	dizi=[]
	toplam=0
	for i in range (1,sayi):
		if sayi%i==0:
			dizi.append(sayi/i)
			i+=1
	for j in dizi:
		toplam+=j
	sonuc=toplam+1-sayi
	if sonuc!=1 and sonuc!=sayi:
		return sonuc
def function():
	sayi=[]
	index=[]
	topla=0
	for i in range(10000):
		sayi.append(bolen(i))
		index.append(i)
	for k in index:
		temp=sayi[k]
		if temp != None:
			if temp < 10000:
				if k==sayi[temp]:
					topla+=k
					print k
	print "toplam:"+str(topla)
	
function()
	 

