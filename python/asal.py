def asal(sayi):
	for i in range(2,sayi+1):
		for j in range(2,i+1):
			if i%j==0 and i==j:
				print i
			elif i%j==0 and i!=j:
				break
				
			
asal(10)

