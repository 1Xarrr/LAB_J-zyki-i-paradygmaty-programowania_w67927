open System

type Account = { ID: int; Balance: float }

let mutable accounts = Map.empty<int, Account>
let mutable nextID = 1

let createAccount () =
    let account = { ID = nextID; Balance = 0.0 }
    accounts <- accounts.Add(nextID, account)
    nextID <- nextID + 1
    printfn "Utworzono konto o numerze: %d" account.ID

let deposit id amount =
    match accounts.TryFind id with
    | Some acc ->
        let updatedAcc = { acc with Balance = acc.Balance + amount }
        accounts <- accounts.Add(id, updatedAcc)
        printfn "Wpłacono %.2f. Nowe saldo: %.2f" amount updatedAcc.Balance
    | None -> printfn "Nie znaleziono konta."

let withdraw id amount =
    match accounts.TryFind id with
    | Some acc when acc.Balance >= amount ->
        let updatedAcc = { acc with Balance = acc.Balance - amount }
        accounts <- accounts.Add(id, updatedAcc)
        printfn "Wypłacono %.2f. Nowe saldo: %.2f" amount updatedAcc.Balance
    | Some _ -> printfn "Niewystarczające środki."
    | None -> printfn "Nie znaleziono konta."

let showBalance id =
    match accounts.TryFind id with
    | Some acc -> printfn "Saldo konta %d: %.2f" id acc.Balance
    | None -> printfn "Nie znaleziono konta."

[<EntryPoint>]
let main _ =
    let mutable running = true

    while running do
        printfn "\n1. Stwórz konto\n2. Depozyt\n3. Wypłata\n4. Pokaż saldo\n5. Wyjdź"
        let choice = Console.ReadLine()

        match choice with
        | "1" -> createAccount()
        | "2" ->
            printfn "Podaj numer konta:"
            let id = Console.ReadLine() |> int
            printfn "Podaj kwotę:"
            let amount = Console.ReadLine() |> float
            deposit id amount
        | "3" ->
            printfn "Podaj numer konta:"
            let id = Console.ReadLine() |> int
            printfn "Podaj kwotę:"
            let amount = Console.ReadLine() |> float
            withdraw id amount
        | "4" ->
            printfn "Podaj numer konta:"
            let id = Console.ReadLine() |> int
            showBalance id
        | "5" ->
            running <- false
        | _ -> printfn "Nieprawidłowy wybór."

    0
