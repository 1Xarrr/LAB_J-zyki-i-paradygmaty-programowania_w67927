open System

let znajdzNajdluzszeSlowo (tekst: string) =
    let slowa = tekst.Split([|' '; '\t'; '\n'; '\r'; '.'; ','; ';'; ':'; '!'; '?'|], StringSplitOptions.RemoveEmptyEntries)
    if slowa.Length > 0 then
        let najdluzsze = slowa |> Array.maxBy (fun s -> s.Length)
        let dlugosc = najdluzsze.Length
        najdluzsze, dlugosc
    else
        "", 0

[<EntryPoint>]
let main argv =
    printfn "Wprowadź tekst:"
    let tekst = Console.ReadLine()
    let najdluzszeSlowo, dlugosc = znajdzNajdluzszeSlowo tekst
    if dlugosc > 0 then
        printfn "Najdłuższe słowo: \"%s\" (długość: %d)" najdluzszeSlowo dlugosc
    else
        printfn "Nie znaleziono żadnych słów w podanym tekście."
    0
