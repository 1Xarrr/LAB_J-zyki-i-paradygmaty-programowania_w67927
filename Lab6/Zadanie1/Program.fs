open System

let liczSowaIZnaki (tekst: string) =
    let liczbaSlow = tekst.Split([|' '; '\t'; '\n'|], StringSplitOptions.RemoveEmptyEntries).Length
    let liczbaZnakow = tekst.Replace(" ", "").Length
    liczbaSlow, liczbaZnakow

printf "Podaj tekst: "
let tekst = Console.ReadLine()

let liczbaSlow, liczbaZnakow = liczSowaIZnaki tekst

printfn "Liczba słów: %d" liczbaSlow
printfn "Liczba znaków (bez spacji): %d" liczbaZnakow
