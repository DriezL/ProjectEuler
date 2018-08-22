open System
open Dries.ProjectEuler

[<EntryPoint>]
let main argv = 

    printfn("geef probleem # of 0 voor allemaal (zal een tijd duren)")

    //let rec readlines () = seq {
    //    let line = Console.ReadLine()
    //    if line <> null then
    //        yield line
    //        yield! readlines ()
    //    }

    //let SolveForMe (input:int) = 
    //    match input with
    //        | 1 -> Problem1.solve()
    //        | 2 -> Problem2.solve()
    //        | _ -> printfn "nothing"
        
    //    0

    //let mutable input = Console.Read()
    //while input <> 0
    //   do

    //   if input <> 0
    //   then
    //       SolveForMe input
    //       Console.Write "\nEnter input:"
    //       input <- Console.Read()


    //printfn readlines()

    Problem1.solve()
    Problem2.solve()
    //Problem3.solve()
    
//    Problem3.solve()
//    Problem5.solve()

    //SolveForMe

    //End projectEuler
    printfn "<Enter> to end"
    let key = System.Console.ReadKey()
    
    0 // return an integer exit code
