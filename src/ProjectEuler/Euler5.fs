module Euler5 

let private isDivisableByAllNumbers n numbers =
    numbers |> Seq.exists(fun x -> n % x <> 0) |> not

let rec solve() =
    let numbers = seq[2..20]
    Seq.unfold(fun(x)-> Some(x, (x + 1)))(2520) 
        |> Seq.skipWhile(fun x -> isDivisableByAllNumbers x numbers |> not)
        |> Seq.head