#when u import something always go to the top of the code.
import random

#because it is from the library random and i want to access randit from random i put random.randint
number = random.randint(1,100)
#IMPROVMENT the loop will continue for 10 attempts
attempts=10
print("gissa talet")
print("du ska nu gissa ett tal mellan 1 till 100")
#1. Ask for the user to input a number
##IMPROVMENT   uppdrag 3 while loop:
attempt=1
while attempts >= attempt:
  user_number=int(input("skriv in ett tal"))
#2. Check if the number is bigger than 100 or smaller than 1 -> If so print a error message
  if user_number > 100:
    print(f"Ditt tal är för stort! Gissa på ett mindre tal, du måste skriva ett tal mellan 1 och 100 \n Du har gissat {attempt} gånger")
  if user_number < 1:
    print(f"du måste skriva in ett tal mellan 1 och 100 \n Du har gissat {attempt} gånger")
  # define the close range 
  close_digit=3
  #now adding the less than or equal to symbol <=
  #if the input number is equal to random number plus 3 then it is too high but close 
  
  if user_number <= number + close_digit and user_number > number:
    print(f"Ditt tal är för stort. Gissa på ett mindre tal men du är nära! \n Du har gissat {attempt} gånger")
  #if the input number is equal to random number - 3 then it is close but too low
  if user_number >= abs(number - close_digit) and user_number < number:
      print(f"Ditt tal är för litet! gissa på ett större tal men du är nära! \n Du har gissat {attempt} gånger")
  #5.if the number is wrong and bigger or smaller than 3 margin
  if user_number > number:
    print(f"Ditt tal är för stort! gissa på ett mindre tal \n Du har gissat {attempt} gånger")
  #IMPROVMENT. I have put the amount of times the user guesses
  if user_number < number:
    print(f"Ditt tal är för litet! Gissa på ett större tal \n Du har gissat {attempt} gånger")
  
  #6. If the number is the same as generated then print correct message
  if user_number == number:
    print("Du har gissat rätt! YIPPIEE \n Programmet är slut")
  #IMPROVMENT to keep track of how many attempts are made and this enables us to print that the user is out of guesses when it has reached 6
  attempt += 1
  
  if attempts < attempt:
    print("du har inga fler gissningar kvar \n Programmet är slut")
  
