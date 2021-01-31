// Learn more about F# at http://fsharp.org

open System
open Ex1
open Ex2

open Ex4

[<EntryPoint>]
let main argv =
    printfn "%s" (fmt (CstI 1))
    printfn "%s" (fmt (Var "x"))
    printfn "%s" (fmt (Add( CstI 1,Var "x")))
    printfn "%s" (fmt (Add(CstI 2,Add(CstI 1,Var "x"))))
    0 // return an integer exit code
