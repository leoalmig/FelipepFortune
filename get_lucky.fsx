#!/usr/bin/env -S dotnet fsi

open System

/// Never-ending stream of good luck!
let fortunes =
    [ "Vendi pra eles um time de alta performance..."
      "Esse é o Coringa!"
      "Vou mover esse card pra ToDo" ]

let rand = Random()
let maxNumberForIndex = fortunes.Length

let i = rand.Next(maxNumberForIndex)

printfn "%s - Felipep" fortunes.[i]
