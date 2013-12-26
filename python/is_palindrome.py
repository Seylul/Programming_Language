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
		print True
	else:
		print False
