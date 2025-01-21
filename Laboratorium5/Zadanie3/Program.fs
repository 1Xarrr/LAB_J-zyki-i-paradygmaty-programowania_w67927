let rec permutations list =
    match list with
    | [] -> [[]]
    | _ ->
        list |> List.collect (fun x ->
            permutations (List.filter ((<>) x) list)
            |> List.map (fun perm -> x :: perm))

printfn "Permutacje listy [1;2;3]:"
permutations [1;2;3] |> List.iter (printfn "%A")