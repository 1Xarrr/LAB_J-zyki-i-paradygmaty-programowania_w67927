let rec quickSort = function
    | [] -> []
    | pivot::rest ->
        let smaller, greater = List.partition ((>=) pivot) rest
        quickSort smaller @ [pivot] @ quickSort greater

let quickSortIterative list =
    let stack = System.Collections.Generic.Stack<List<int>>()
    let mutable sorted = []
    stack.Push(list)
    while stack.Count > 0 do
        match stack.Pop() with
        | [] -> ()
        | pivot::rest ->
            let smaller, greater = List.partition ((>=) pivot) rest
            stack.Push(greater)
            sorted <- pivot :: sorted
            stack.Push(smaller)
    List.rev sorted

printfn "Sortowanie QuickSort rekurencyjne:"
printfn "%A" (quickSort [3;1;4;1;5;9;2;6;5;3;5])

printfn "Sortowanie QuickSort iteracyjne:"
printfn "%A" (quickSortIterative [3;1;4;1;5;9;2;6;5;3;5])