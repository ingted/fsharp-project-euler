module Euler9

let list = 
    seq {
        for a = 1 to 1000 do
            for b = 1 to 1000 do
                for c = 1 to 1000 do
                     if (a + b + c) = 1000 then yield [a;b;c]    
    }

let isPythagoreantriplet (data: int list) =
    match data |> List.sort with
    | [a;b;c] -> a*a + b*b = c*c
    | _ -> false

let solve() =
    list |> Seq.filter isPythagoreantriplet |> Seq.head |> Seq.fold((*)) 1