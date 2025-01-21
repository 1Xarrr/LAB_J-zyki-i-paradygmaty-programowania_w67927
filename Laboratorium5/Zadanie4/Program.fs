let rec hanoi n source auxiliary target =
    if n > 0 then
        hanoi (n - 1) source target auxiliary
        printfn "Przenieś dysk %d z %s do %s" n source target
        hanoi (n - 1) auxiliary source target

let hanoiIterative n =
    let moves = System.Collections.Generic.Stack<(int * string * string * string)>()
    moves.Push(n, "A", "B", "C")
    while moves.Count > 0 do
        let (disks, src, aux, dst) = moves.Pop()
        if disks > 0 then
            moves.Push(disks - 1, aux, src, dst)
            printfn "Przenieś dysk %d z %s do %s" disks src dst
            moves.Push(disks - 1, src, dst, aux)

printfn "Wieże Hanoi dla 3 dysków:"
hanoi 3 "A" "B" "C"