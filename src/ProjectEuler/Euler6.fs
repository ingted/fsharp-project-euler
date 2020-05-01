module Euler6

let solve() =
    let list = seq [(1.)..(100.)]
    let sumOfSquare = list |> Seq.sumBy(fun x -> x ** 2.)
    let squareOfSum = (list |> Seq.sum) ** 2.
    squareOfSum - sumOfSquare