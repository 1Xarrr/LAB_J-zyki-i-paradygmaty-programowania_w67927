open System

let przeksztalcWpis (tekst: string) =
    let dane = tekst.Split(';')
    if dane.Length = 3 then
        let imie = dane.[0].Trim()
        let nazwisko = dane.[1].Trim()
        let wiek = dane.[2].Trim()
        sprintf "%s, %s (%s lat)" nazwisko imie wiek
    else
        "Niepoprawny format danych"

let przetworzWpisy () =
    printfn "Wprowadź wpisy w formacie 'imię; nazwisko; wiek'. Wpisz 'stop', aby zakończyć."
    let rec wczytajWpisy acc =
        let wpis = Console.ReadLine()
        if wpis.ToLower() = "stop" then
            acc
        else
            let przeksztalcony = przeksztalcWpis wpis
            if przeksztalcony <> "Niepoprawny format danych" then
                printfn "Przekształcony wpis: %s" przeksztalcony
            else
                printfn "Błąd: %s" przeksztalcony
            wczytajWpisy (przeksztalcony :: acc)
    
    wczytajWpisy []

[<EntryPoint>]
let main argv =
    let wynik = przetworzWpisy ()
    printfn "\nWszystkie przetworzone wpisy:"
    wynik
    |> List.rev
    |> List.iter (printfn "%s")
    0
