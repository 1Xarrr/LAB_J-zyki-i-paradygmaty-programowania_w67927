open System

let exchangeRates = 
    Map [
        ("USD", Map [("EUR", 0.85); ("GBP", 0.75)])
        ("EUR", Map [("USD", 1.18); ("GBP", 0.88)])
        ("GBP", Map [("USD", 1.33); ("EUR", 1.14)])
    ]

[<EntryPoint>]
let main _ =
    printfn "Podaj kwotę do przeliczenia:"
    let amount = Console.ReadLine() |> float

    printfn "Podaj walutę źródłową (USD, EUR, GBP):"
    let sourceCurrency = Console.ReadLine()

    printfn "Podaj walutę docelową (USD, EUR, GBP):"
    let targetCurrency = Console.ReadLine()

    match exchangeRates.TryFind sourceCurrency with
    | Some rates when rates.ContainsKey targetCurrency ->
        let rate = rates.[targetCurrency]
        let convertedAmount = amount * rate
        printfn "Przeliczona kwota: %.2f %s" convertedAmount targetCurrency
    | _ ->
        printfn "Nieobsługiwana kombinacja walut."

    0
