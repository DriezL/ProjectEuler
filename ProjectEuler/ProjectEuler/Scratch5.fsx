//For problem #5...

let canBeDividedBy num div = num % div = 0
let canBeDividedByAll num numbers = numbers |> Seq.forall(fun c-> canBeDividedBy num c)

let numbers = [|1..20|]

let smallestNumber =
    Seq.unfold(function x -> Some(x, x+1)) 20
                |> Seq.filter(fun f -> canBeDividedByAll f numbers)
                |> Seq.head


