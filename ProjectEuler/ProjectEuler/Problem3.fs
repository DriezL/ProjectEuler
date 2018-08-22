module Dries.ProjectEuler.Problem3

    let make letter = "dyhsfsdfhisduhf"

    let isPrime n =
        match n with
        | _ when n > 3 && (n % 2 = 0 || n % 3 = 0) -> false
        | _ ->
            let maxDiv = int(System.Math.Sqrt(float n)) + 1
            let rec f d i = 
                if d > maxDiv then 
                    true
                else
                    if n % d = 0 then 
                        false
                    else
                        f (d + i) (6 - i)     
            f 5 2

    let primeFactors x = 
        let rec fact x div list = 
            if x % div = 0 then
                fact (x/div) div (div::list)
            elif div > int(sqrt (float x)) then
                if x > 1 then x::list
                else list
            else
                fact x (div+1) list
        fact x 2 []


    let solve () =

        //Problem3
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?



        let rec sieve = function
            | (p::xs) -> p :: sieve [ for x in xs do if isPrime x then yield x ]
            | []      -> []

        //sieve [600851475143 .. -1 .. 1]

        let ThatSumClosestTo x =
            (0, 0)
            |> Seq.unfold(function 
                (total, num)-> if (total + num > x) 
                                then None 
                                else Some(num,(total + num, num + 1)))

        let ThatSumsTo x =
            let closest = 
                ThatSumClosestTo x
                |> Seq.toList
            if closest |> List.sum = x 
            then Some(closest)
            else None

        
        printfn "PROBLEM #2, the sum of even-valued terms: %d" 1

