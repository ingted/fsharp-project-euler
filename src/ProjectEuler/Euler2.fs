module Euler2

let private fibSeq () =
    Seq.unfold(fun(x,y)-> Some(x,(y,x + y)))(0,1)

let solve () = 
    fibSeq() |> Seq.takeWhile(fun x -> x < 4000000) |> Seq.filter(fun x -> x % 2 = 0) |> Seq.sum 
