#Henrique Cury
#3517770 or he200230
import re
def checkVowels(string):
  vowels = ['A','E','I','O','U','a','e','i','o','u']
  li = list(string.split())
  for x in range(0, len(vowels) - 1):
    if(li[0] == vowels[x]):
      return True;

def checkShit(string, stringy):
  inLis = string
  inLis = re.sub(r'[^\w\s]','',inLis)
  checkLis = list(stringy)
  for x in range(0, len(inLis)):
    l = list(inLis[x])
    for y in range(0, len(l)):
      for z in range(0, len(checkLis)):
        if(l[y] == checkLis[z]):
          return True

def word_smith(string,stringy):
 inLis = list(string.split())
 finalList = [x for x in inLis if len(x) > 3 and (checkShit(x, stringy) == True or checkVowels(x) == True)]
 return(len(finalList))


def convert(n3):
  if n3 == 0:
    return 0
  else:
    return (n3 % 4 + 10 * convert(n3//4))

def base_builder(n3):
  qv=convert(n3)
  Sum=0
  qval= qv
  while qval > 0:
    Sum=Sum + qval % 10
    qval=qval//10
  return (Sum,qv)
