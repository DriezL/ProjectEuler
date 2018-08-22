module Dries.ProjectEuler.Problem7 

    let solve() =
        3
        //Problem 7: 
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10001st prime number?

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


            


        //printfn "PROBLEM #7, the 10001st prime number is: %d" prime
