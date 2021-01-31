// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let inchToMillimeter v = v * 25.4
    let footToInch x = x * 12.0
    let yardToFoot v = v * 3.0
    let mileToYard mile = mile * 1760.0
    let t = footToInch 6.0 |> inchToMillimeter
    printfn " 6.0 foot is %f millimeter" t
    let divBy1000 = (*) 0.001
    let millimeterToMeter n = divBy1000 n
    let meterToKilometer = millimeterToMeter
    let millimeterToKilometer = divBy1000 >> divBy1000
    let t2 = 1024.0 |> mileToYard |> yardToFoot |> footToInch |> inchToMillimeter |> millimeterToKilometer
    printfn "1024.0 mile is %f kilometer" t2
    0 // return an integer exit code
