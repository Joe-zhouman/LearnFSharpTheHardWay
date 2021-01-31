// Learn more about F# at http://fsharp.org

open System
open ConvertToRec
[<EntryPoint>]
let main argv =
    let s1 = sumBetween 1 4
    let s2 = sumBetween 4 1
    printfn "%d %d" s1 s2
    let s3 = sumBetweenTail 1 4
    let s4 = sumBetweenTail 4 1
    printfn "%d %d" s3 s4
    let n1 = NumOdd 1 4
    let n2 = NumOdd 2 1
    printfn "%d %d" n1 n2
    let m1 = NextMul 16 7
    printfn "%d" m1
    let p1 = IsPrime 7
    let p2 = IsPrime 9
    printfn "%b %b" p1 p2
    let sqrt2 = sqrt 2.0
    printfn "%f" sqrt2
    0 // return an integer exit code
