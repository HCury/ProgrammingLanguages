multTwo :: Int -> Int -> Int
multTwo x y = x * y

multThree :: Int -> Int -> Int -> Int
multThree x y z = x * y * z

first_a :: Int -> [Int]
first_a n = [x | x<-[1..n], x `mod` 6 == 0 || x `mod` 11 == 0]

first_b :: Int ->[Int]
first_b n = [x | x<-[1..n], isMult6Or11 x == True]

isMult6Or11 ::Int -> Bool
isMult6Or11 x = x `mod` 6 == 0|| x `mod` 11 == 0
