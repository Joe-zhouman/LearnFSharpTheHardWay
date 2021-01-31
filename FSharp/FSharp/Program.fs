// Learn more about F# at http://fsharp.org

open System
let averageOf numbers = 
    let rec ave count sum numbers = 
        match numbers with
        |n::rest -> ave (count + 1) (n + sum) rest
        |[] -> sum / float count 
    ave 0 0.0 numbers


[<EntryPoint>]
let main argv =  
    let f x = x 3.0
    let g k = k + f (fun q -> q - 1.5)
    let t = f (fun p -> p + g p)
    printfn "%A" t
    0 // return an integer exit code
