def circular_prime(number):
	temp=[]
	onesteps=[]
	other=[]
	
	for i in range(2,number+1):
		for j in range(2,i+1):
			if i%j==0 and i==j:
				temp.append(i)
	
			elif i%j==0 and i!=j:
				break
		
	for j in temp:
		if j/10==0:
			onesteps.append(j)
			
		elif "8" not in str(j):
			if "6" not in str(j):
				if "5" not in str(j):
					if "4" not in str(j):
						if "2" not in str(j):
							if "0" not in str(j):
								other.append(j)
	
	print  len(onesteps) + len(other)
circular_prime(1000000)

	


