module Ex1

let max2 (x:int,y:int) = 
    match x > y with
    | true -> x
    | false -> y


let max3 (x:int,y:int,z:int) =
    max2(max2(x,y),z)

let isPositive (l : int list) = 
    let rec checkHeader list = 
        match list with 
        | [] -> true
        | x::t ->
            match x > 0 with
            |false -> false
            |_-> checkHeader t
    checkHeader l

let isSort (l : int list) = 
    let rec checkSort x list = 
        match list with
        |[]->true
        |y::r->
            match x > y with
            |true->false
            |_-> checkSort y r
    match l with
    | [] -> true
    | x::t->      
        checkSort x t

type IntTree =
| Lf
| Br of int * IntTree * IntTree

let count (tree:IntTree) = 
    let rec isBr node = 
        match node with
        |Lf-> 0
        |Br(_,lc,rc)-> 1 + (isBr lc) + (isBr rc)
    isBr tree
let depth (tree:IntTree) = 
    let rec isBr node = 
        match node with
        |Lf-> 0
        |Br(_,lc,rc)-> 1 + max2((isBr lc) , (isBr rc))
    isBr tree