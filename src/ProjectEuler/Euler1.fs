module Euler1 

let solve () =
    [0..999] |> Seq.filter(fun x -> x % 5 = 0 || x % 3 = 0) |> Seq.sum