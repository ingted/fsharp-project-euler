module Tests

open Expecto

[<Tests>]
let tests =
  testList "EulerSolutions" [ 
    testCase "Euler1" <| fun _ ->
      let subject = Euler1.solve()
      Expect.equal subject 233168 "I compute, therefore I am."
    testCase "Euler2" <| fun _ ->
      let subject = Euler2.solve()
      Expect.equal subject 4613732 "I compute, therefore I am."
    testCase "Euler3" <| fun _ ->
      let subject = Euler3.solve(600851475143L)
      Expect.equal subject 6857L "I compute, therefore I am."
    testCase "Euler4" <| fun _ ->
      let subject = Euler4.solve()
      Expect.equal subject 906609 "I compute, therefore I am."
  ]