#~ 1**2+2**2+3**2...N**2 = (N * (N + 1) * (2N + 1)) / 6
def squaresum(number):
	return (number*(number+1)*((2*number)+1))/6

#~ (1+2+3....+N) = (N*(N+1))/2
def sumsquare(number):
	return ((number*(number+1))/2)**2
	
def difference():
	print sumsquare(100)-squaresum(100)
	
difference() 
