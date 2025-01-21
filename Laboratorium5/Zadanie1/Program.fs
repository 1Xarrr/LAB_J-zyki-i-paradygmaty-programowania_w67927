let rec fibonacci n =
    if n <= 1 then n
    else fibonacci (n - 1) + fibonacci (n - 2)

let fibonacciTail n =
    let rec aux n a b =
        if n = 0 then a
        else aux (n - 1) b (a + b)
    aux n 0 1

printfn "Fibonacci (rekurencyjnie) dla n=10: %d" (fibonacci 10)
printfn "Fibonacci (ogonowo) dla n=10: %d" (fibonacciTail 10)