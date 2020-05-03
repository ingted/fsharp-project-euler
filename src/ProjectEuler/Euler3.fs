module Euler3

let isPrime(number:int64) =
    let upperBound = number |> double |> sqrt |> int64
    [2L..upperBound] |> Seq.exists(fun x -> number % x = 0L) |> not

let solve (number:int64) =
        let upperBound = int64(sqrt (double number))
        [2L..upperBound] 
            |> Seq.filter(fun x -> number % x = 0L) 
            |> Seq.filter(fun x -> isPrime(x)) 
            |> Seq.max