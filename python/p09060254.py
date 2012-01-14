import csv
import math
import time
from sequential import *

def hash(tc,tablesize):
	tc = int(tc)
	k = int(math.sqrt(tc)**3+math.sqrt(tc)*2)
	return k%tablesize

HASH=[[None]] * 75
oku=open("ogrenci10.csv", "r")
kisiler=oku.readlines()
top={}
ind = []
for i in range(75):
	top[i] = 0

for kisi in kisiler:
	tc=kisi.split(';')[3]
	
	t=hash(tc,75)
	ind.append(t)
	if t in ind:
		top[t] += 1
print top

aranan=[46864757568, 62116253084, 44383843816]

ilk = time.time()
for i in aranan:
	sequentialSearch(ind, i)
son = time.time()
print son-ilk


ilk = time.time()
for i in aranan:
	orderedSequentialSearch(ind, i)
son = time.time()
print son-ilk


ilk = time.time()
for i in aranan:
	binarySearch(ind, i)
son = time.time()
print son-ilk
 

