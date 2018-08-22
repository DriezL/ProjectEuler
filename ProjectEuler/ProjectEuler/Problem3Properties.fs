module Dries.ProjectEuler.Problem3Properties

open System
open FsCheck
open FsCheck.Xunit

    type Numbers = 
        static member Nums() = 
            Arb.Default.Int32()
            |> Arb.filter (fun c -> 0 <= c && c <= 999)

    [<Property>]
    let ``Diamond is non-empty`` (letter : char) = 
        let actual = Dries.ProjectEuler.Problem3.make letter
        not (String.IsNullOrWhiteSpace actual)

    
    [<Property(Arbitrary = [| typeof<Numbers> |])>]
    let ``Priemfactor altijd groter nul`` (cijfer : int) = 
        let actual = Dries.ProjectEuler.Problem3.primeFactors cijfer
        actual

    [<Xunit.Fact>]
    let ``sidhf sdfh sduifh sdf`` () =
        let getId _ = Guid.NewGuid()
        ()