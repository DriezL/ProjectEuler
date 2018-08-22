module Problem6

open System

let mySum (number: int): int = 
    let naturalNumbers = [ 1 .. number ]
    naturalNumbers
        |> Seq.sum


let squareOfSum (number: int): int = 
    mySum number * mySum number
         

let sumOfSquares (number: int): int = 
    [| 1 .. number |]
        |> Seq.map (fun c -> c * c)
        |> Seq.sum

let differenceOfSquares number = 
    squareOfSum number - sumOfSquares number