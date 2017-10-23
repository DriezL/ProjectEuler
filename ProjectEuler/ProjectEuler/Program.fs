[<EntryPoint>]
let main argv = 

    //Problem 1: 
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.

    let naturalNumbers = [ 1 .. 999 ]  /// list of integers from 1 to 999 [including 999]

    let threes = 
        naturalNumbers
            |> List.filter (fun a -> a % 3 = 0)

    let fives = 
        naturalNumbers
            |> List.filter (fun a -> a % 5 = 0)

    let appendedList = threes @ fives

    let totalSum = appendedList |> Seq.distinct |> Seq.sum

    printfn "PROBLEM #1, the sum of all the multiples of 3 or 5 below 1000: %d" totalSum


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


    //Problem5
    //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

    let canBeDividedBy num div = num % div = 0
    let canBeDividedByAll num numbers = numbers |> Seq.forall(fun c-> canBeDividedBy num c)

    let numbers = [|1..20|]

    let smallestNumber =
        Seq.unfold(function x -> Some(x, x+1)) 20
                    |> Seq.filter(fun f -> canBeDividedByAll f numbers)
                    |> Seq.head

    printfn "PROBLEM #5, Smallest multiple: %d" smallestNumber


    //End projectEuler
    let key = System.Console.ReadKey();

    0 // return an integer exit code
