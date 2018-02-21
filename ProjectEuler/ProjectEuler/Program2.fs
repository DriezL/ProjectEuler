module Problem2

    let solve() =

        //Problem2
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        let fibs = 
            let rec f a b = 
                seq { yield a
                      yield! f b (a+b) }
            f 1 1
            |> Seq.cache

    
        let evennumbers = 
            fibs
                |> Seq.takeWhile (fun a -> a < 4000000)
                |> Seq.filter ( fun a -> a % 2 = 0 )
                |> Seq.sum
            
        printfn "PROBLEM #2, the sum of even-valued terms: %d" evennumbers
