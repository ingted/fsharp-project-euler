module Euler4
open System

let isPalindrome (num: int32) =
    let numStr = num.ToString()
    let reversedNum = String(numStr.ToCharArray() |> Array.rev)
    numStr = reversedNum


let solve() = 
    [0..1000]
        |> Seq.collect(fun x -> [0..1000] |> Seq.map(fun y -> x * y)) 
        |> Seq.filter(fun x -> isPalindrome(x))
        |> Seq.max

