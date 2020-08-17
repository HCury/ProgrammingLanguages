n1 = int(input("Enter number 1 please "))
n2 = int(input("Enter number 2 please "))
n3 = input("Enter number 3 please ")

def multTwo(x,y):
  return x*y;

def multThree(x,y,z):
  return x*y*z

def first_a(n):
  lis =[x for x in range(1, n+1) if x%6==0 or x%11==0]
  print(lis)


def isMult6Or11(n):
  if(n%6 == 0 or n%11 == 0):
    return True;

def first_b(n):
  lis = [x for x in range(1, n+1) if isMult6Or11(x) == True]
  print(lis)
  
def second_a(n):
  lis = [x for x in range(1, int(n)+1) if str(x).startswith("3") == True and str(x).endswith("3")]
  print(lis)

def isPalindromeThatStartsWithDigit3(n):
  z = len(n)
  if(int(n[:1]) == 3 and int(n[z-1:]) == 3):
    return True;

def second_b(n):
  lis = [x for x in range(1, int(n)+1) if isPalindromeThatStartsWithDigit3(str(x)) == True]
  print(lis)

print(multTwo(n1,n2))
print(multThree(n1,n2,n3))
first_a(n3)
first_b(n3)
second_a(n3)
second_b(n3)
