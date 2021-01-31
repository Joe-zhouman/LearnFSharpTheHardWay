// Learn more about F# at http://fsharp.org

open System
open Parse
[<EntryPoint>]
let main _argv =
    
    printfn "%s" (parse 2000)
    printfn "%s" (parse 2009)
    printfn "%s" (parse 2099)
    printfn "%s" (parse 2999)
    printfn "%s" (parse 299)
    printfn "%s" (parse 209)
    printfn "%s" (parse 200)
    printfn "%s" (parse 29)
    printfn "%s" (parse 20)
    printfn "%s" (parse 9)
    printfn "%s" (parse 0)
    printfn "%s" (parse -2000)
    0 // return an integer exit code
