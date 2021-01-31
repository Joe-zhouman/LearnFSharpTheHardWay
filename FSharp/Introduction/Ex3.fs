module Ex3

type AExpr = 
    | CstI of int
    | Var of string
    | Add of AExpr * AExpr
    | Sub of AExpr * AExpr
    | Mul of AExpr * AExpr

let rec fmt (expr:AExpr) = 
    match expr with
    |CstI i -> i.ToString()
    |Var x -> x
    |Add(e1,e2)-> "(" + (fmt e1) + "+" + (fmt e2) + ")"
    |Sub(e1,e2)-> "(" + (fmt e1) + "-" + (fmt e2) + ")"
    |Mul(e1,e2)-> "(" + (fmt e1) + "*" + (fmt e2) + ")"

let rec simplify (expr:AExpr) = 
    match expr with
    | CstI i -> CstI i
    | Var x -> Var x
    | Add(e1,e2)->
        if e1 = e2 then simplify (Mul(CstI 2,simplify  e1))
        else
        match (e1,e2) with
        |(CstI 0,_)->(simplify e2)
        |(_,CstI 0)->(simplify e1) 
        |(CstI _,Var _)|(CstI _,CstI _)|(Var _,Var _)|(Var _,CstI _)-> Add(e1,e2)
        |_-> simplify (Add((simplify e1),(simplify e2)))
    | Mul(e1,e2)->
        match (e1,e2) with
        |(CstI 1,_)->(simplify e2)
        |(_,CstI 1)->(simplify e1) 
        |(CstI 0,_)|(_,CstI 0)->CstI 0
        |(CstI _,Var _)|(CstI _,CstI _)|(Var _,Var _)|(Var _,CstI _)-> Mul(e1,e2)
        |_-> simplify (Mul((simplify e1),(simplify e2)))
    |Sub(e1,e2)->
        if e1 = e2 then CstI 0
        else
        match (e1,e2) with
        |(_,CstI 0)->(simplify e1)
        |(CstI _,Var _)|(CstI _,CstI _)|(Var _,Var _)|(Var _,CstI _)-> Sub(e1,e2)
        |_-> simplify (Sub(simplify e1,simplify e2))
        

    