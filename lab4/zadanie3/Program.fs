open System

let countWords (text: string) =
    text.Split([|' '; '\n'; '\t'|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.length

let countCharacters (text: string) =
    text.Replace(" ", "").Length

let mostFrequentWord (text: string) =
    text.Split([|' '; '\n'; '\t'|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.countBy id
    |> Array.maxBy snd
    |> fst

[<EntryPoint>]
let main _ =
    printfn "Wprowadź tekst:"
    let inputText = Console.ReadLine()

    let wordCount = countWords inputText
    let charCount = countCharacters inputText
    let frequentWord = mostFrequentWord inputText

    printfn "Liczba słów: %d" wordCount
    printfn "Liczba znaków (bez spacji): %d" charCount
    printfn "Najczęściej występujące słowo: %s" frequentWord

    0
