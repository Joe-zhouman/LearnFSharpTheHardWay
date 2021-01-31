// Learn more about F# at http://fsharp.org

open System
open Ex1
open Ex2
open Ex3

[<EntryPoint>]
let main argv =
    printfn "%s" (fmt (CstI 1))
    printfn "%s" (fmt (Var "x"))
    printfn "%s" (fmt (Add( CstI 1,Var "x")))
    printfn "%s" (simplify(Mul(Add(CstI 1,CstI 0),Add(Var "x",Var "x")))|>fmt)
    0 // return an integer exit code
