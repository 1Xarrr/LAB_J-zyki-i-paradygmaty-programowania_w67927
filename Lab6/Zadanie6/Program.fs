open System

let zamienSlowo (tekst: string) (slowoDoZamiany: string) (noweSlowo: string) =
    tekst.Replace(slowoDoZamiany, noweSlowo)

[<EntryPoint>]
let main argv =
    printfn "Wprowadź tekst:"
    let tekst = Console.ReadLine()
    
    printfn "Wprowadź słowo, które chcesz zamienić:"
    let slowoDoZamiany = Console.ReadLine()
    
    printfn "Wprowadź nowe słowo:"
    let noweSlowo = Console.ReadLine()
    
    let zmodyfikowanyTekst = zamienSlowo tekst slowoDoZamiany noweSlowo
    
    printfn "\nZmodyfikowany tekst:"
    printfn "%s" zmodyfikowanyTekst
    0
