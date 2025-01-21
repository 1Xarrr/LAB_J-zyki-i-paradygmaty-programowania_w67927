type Tree<'T> =
    | Empty
    | Node of 'T * Tree<'T> * Tree<'T>

let rec searchTreeRecursive value tree =
    match tree with
    | Empty -> false
    | Node(v, left, right) ->
        if v = value then true
        else searchTreeRecursive value left || searchTreeRecursive value right

let searchTreeIterative value tree =
    let stack = System.Collections.Generic.Stack<Tree<'T>>()
    stack.Push(tree)
    let mutable found = false
    while stack.Count > 0 && not found do
        match stack.Pop() with
        | Empty -> ()
        | Node(v, left, right) ->
            if v = value then found <- true
            else (stack.Push(right); stack.Push(left))
    found

let tree = Node(5, Node(3, Node(1, Empty, Empty), Node(4, Empty, Empty)), Node(8, Node(7, Empty, Empty), Node(10, Empty, Empty)))
printfn "Wyszukiwanie wartości 4 w drzewie (rekurencyjnie): %b" (searchTreeRecursive 4 tree)
printfn "Wyszukiwanie wartości 6 w drzewie (iteracyjnie): %b" (searchTreeIterative 6 tree)
