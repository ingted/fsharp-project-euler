module Euler7 
open System

let solve number = 
    Seq.unfold(fun x -> Some(x,x + 1L)) 2L |> Seq.filter(Euler3.isPrime) |> Seq.skip(number - 1) |> Seq.head