open System
open Exam1_2021
open Checker

//The results of the following functions are placeholders. Replace with your implementation
let triangleFlipped (height : int) : string = ""
  
let compress (list : List<'a>) : List<'a> = []

let last (node : Node<'a>) : 'a = 0

let map2 (f : 'a -> 'b -> 'c) (list1 : List<'a>) (list2 : List<'b>) : Option<List<'c>> = None

let treeMap (f : 'a -> 'b) (tree : Tree<'a>) : Tree<'b> = Empty


[<EntryPoint>]
let main argv =
  try
    let testedExercises =
      {
        Exercise1 = triangleFlipped
        Exercise2 = compress
        Exercise3 = last
        Exercise4 = map2
        Exercise5 = treeMap
      }
    printfn "%s" (validate testedExercises)
    0
  with
  | CheckerException msg -> 
      printfn "%s" msg
      1
  | :? Exception as e ->
      printfn "EXCEPTION: %s \nSTACK TRACE: %s" e.Message e.StackTrace
      1
  