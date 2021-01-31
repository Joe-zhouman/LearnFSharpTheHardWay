module Ex4

type AExpr = 
    | CstI of int
    | Var of string
    | Add of AExpr * AExpr
    | Sub of AExpr * AExpr
    | Mul of AExpr * AExpr


let fmt (expr:AExpr) = 
    let rec fmtI (expr:AExpr,pre:bool):string = 
        match (expr,pre) with
        | CstI i, _ -> i.ToString()
        | Var x, _ -> x
        | Add(e1,e2), true -> (fmtI(e1, true) + "+" + fmtI(e2, false))
        | Add(e1,e2), false -> "(" + fmtI(e1,false) + "+" + fmtI(e2,false) + ")"
        | Sub(e1,e2), _ -> (fmtI(e1, false) + "*" + fmtI(e2, false))
        | Mul(e1,e2), true-> (fmtI(e1, true) + "-" + fmtI(e2, false))
        | Mul(e1,e2), false -> "(" + fmtI(e1, true) + "-" + fmtI(e2, false) + ")" 
    fmtI (expr,true)