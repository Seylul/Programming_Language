import collections
def is_palindrome(number):
	compare = lambda x, y: collections.Counter(x) == collections.Counter(y)
	first,last=[],[]
	for i in str(number):
		last.append(i)
	length=len(last)/2
	first=last[0:length]
	last=(last[length:len(last)])
	if compare(first,last) == True:
		return True
	else:
		return False
		
def find():
	sequence=[]
	for i in range(900,1000):
		for j in range(900,1000):
			if is_palindrome(i*j) == True:
				#~ print i ,"x", j,"=",i*j
				sequence.append(i*j)
	print sequence[-1]
				
find()	
