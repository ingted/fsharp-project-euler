module Tests

open Expecto

[<Tests>]
let tests =
  testList "EulerSolutions" [ 
    testCase "Euler1" <| fun _ ->
      let subject = Euler1.solve()
      Expect.equal subject 233168 "I compute, therefore I am."
  ]