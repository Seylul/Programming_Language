import math
def sum():
		bir=0
		iki=0
		#~ kosegenlerin formulize hali
		#~ kuzeydogu=pow(x,2)
		#~ kuzeybati=(pow(x,2))-x+1
		#~ guneydogu=(pow(x,2))-(3*x)+3
		#~ guneybati=(pow(x,2))-(2*x)+2
		#~ toplam= 4*pow(x,2) -(6*x) - 6
		
		
		
		for i in range(3,1002,2):
			j=i**2
			bir+=j
			iki+=i
		birinci=bir*4
		ikinci=6*iki
		ucuncu=6*500
		print birinci -ikinci+ ucuncu +1 
		
sum()
