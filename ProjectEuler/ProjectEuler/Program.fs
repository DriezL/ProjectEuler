open System

[<EntryPoint>]
let main argv = 

    printfn("geef probleem # [1,2,3 of 5]")

    let key = System.Console.ReadLine()

    match key with
        | "1" -> Problem1.solve()
        | "2" -> Problem2.solve()
        | "3" -> Problem3.solve()
        | "5" -> Problem5.solve()
        | _ -> printfn "nothing"


    //End projectEuler
    printfn "<Enter> to end"
    let key = System.Console.ReadKey()
    
    0 // return an integer exit code
