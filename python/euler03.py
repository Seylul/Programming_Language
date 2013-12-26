def prime_factor(number):
	for i in range(2,number+1):
		for j in range(2,i+1):
			if i%j==0 and i==j:
				if number%i==0:
					print (i)
			elif i%j==0 and i!=j:
				break
#~ works with python3.3				
prime_factor(600851475143)		
