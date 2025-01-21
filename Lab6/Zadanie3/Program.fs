open System

let liczSowaIZnaki (tekst: string) =
    let liczbaSlow = tekst.Split([|' '; '\t'; '\n'|], StringSplitOptions.RemoveEmptyEntries).Length
    let liczbaZnakow = tekst.Replace(" ", "").Length
    liczbaSlow, liczbaZnakow

let czyPalindrom (tekst: string) =
    let oczyszczony = tekst.Replace(" ", "").ToLower()
    oczyszczony = String(oczyszczony.ToCharArray() |> Array.rev)

let usunDuplikaty (lista: string list) =
    lista |> List.distinct

printf "Podaj tekst: "
let tekst = Console.ReadLine()

let liczbaSlow, liczbaZnakow = liczSowaIZnaki tekst

let wynikPalindrom = if czyPalindrom tekst then "jest palindromem" else "nie jest palindromem"

let slowa = tekst.Split([|' '|], StringSplitOptions.RemoveEmptyEntries) |> Array.toList
let unikalneSlowa = usunDuplikaty slowa

printfn "Liczba słów: %d" liczbaSlow
printfn "Liczba znaków (bez spacji): %d" liczbaZnakow
printfn "Podany tekst %s" wynikPalindrom
printfn "Unikalne słowa: %A" unikalneSlowa
