open System

// Definicja rekordu dla danych użytkownika
type User = { Weight: float; Height: float }

let calculateBMI weight height =
    weight / ((height / 100.0) ** 2.0)

let classifyBMI bmi =
    if bmi < 18.5 then "Niedowaga"
    elif bmi < 24.9 then "Prawidłowa waga"
    elif bmi < 29.9 then "Nadwaga"
    else "Otyłość"

[<EntryPoint>]
let main _ =
    printfn "Podaj swoją wagę (kg):"
    let weight = Console.ReadLine() |> float

    printfn "Podaj swój wzrost (cm):"
    let height = Console.ReadLine() |> float

    let user = { Weight = weight; Height = height }
    let bmi = calculateBMI user.Weight user.Height
    let category = classifyBMI bmi

    printfn "Twoje BMI: %.2f" bmi
    printfn "Kategoria BMI: %s" category

    0
