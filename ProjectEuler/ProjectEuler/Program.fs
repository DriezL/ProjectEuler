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

    let appendedList = threes |> List.append fives

    let distinctList = appendedList |> Seq.distinct |> List.ofSeq

    let totalSum = 
        distinctList
            |> List.sumBy ( fun b -> b)


    printfn "the sum of all the multiples of 3 or 5 below 1000: %d" totalSum

    //End projectEuler
    let key = System.Console.ReadKey();

    0 // return an integer exit code
