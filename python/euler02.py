def even_fib():
	increase,total,number=1,0,0
	while True:
		number=number+increase
		if number <= 4000000:
			if number%2==0:
				total+=number
		else:
			break
		increase=number-increase
	print total
