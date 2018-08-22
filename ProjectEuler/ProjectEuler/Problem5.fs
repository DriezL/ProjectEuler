module Dries.ProjectEuler.Problem5

    let solve() =

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
