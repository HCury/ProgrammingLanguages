--Henrique Cury
--3517770 or he200230
--problem 2
problem1 :: Int -> [Int]
problem1 n = second(take(n * 2)([x | x<-[2..], isPrime x]))
second(x:y:xs) = x : second xs
second [] = []
isPrime n = ip n [2..(n `div` 2)]    
  where    
    ip _ [] = True    
    ip n (x:xs)        
      | n `mod` x == 0 = False        
      | otherwise = ip n xs


--problem 2
problem2 n = if n < 3 then [] else fibHelper(generateFib n [1,1,2])
  where
    fibHelper [] = []
    fibHelper (x:xs)
      | last(show(x)) == '3' = [x] ++ fibHelper xs 
      | otherwise = fibHelper xs
    generateFib n list
      | last list > n = init list
      | otherwise = generateFib n (list ++ [((list !! (length list - 1)) + (list !! (length list - 2)))])
