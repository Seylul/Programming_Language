#!/usr/bin/python

import MySQLdb
#connecting Mysql

import datetime  

#def get_values():
#
#
#here will be populated
#
#
#

def insertinto():
	now = datetime.datetime(2013,10,23)

	sql = "INSERT INTO EMPLOYEE(timestamp, \
       		user, publicip, privateip, destinationip) \
       		VALUES ('%s', '%s', '%s', '%s', '%s' )" % \
       		(now, 'eylul', '1.1.1.1' , '89.23.45.67', '12.34.56.78')
	#Here is sql query. Populate the data's in Employee table.
	return sql

def connectdb():

	db = MySQLdb.connect("localhost","root","passwd","TESTDB" )
	# Open database connection
	#Mysql user ->root , Mysql pw ->passwd, database name -> Testdb

	cursor = db.cursor()
	# prepare a cursor object using cursor() method

	try:
   
  		cursor.execute(insertinto())
  	 	# Execute the SQL command
   
  	 	db.commit()
   		# Commit your changes in the database
	except:
   
   		db.rollback()
   		# Rollback in case there is any error

	db.close()
	# disconnect from server

connectdb()
