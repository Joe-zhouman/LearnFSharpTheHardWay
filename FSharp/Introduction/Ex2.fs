module Ex2

type Expr = 
    | CstI of int
    | Var of string
    | Prim of string * Expr * Expr
    | If of Expr * Expr * Expr

let env = [("a", 3); ("c", 78); ("baf", 666); ("b", 111)]

let rec lookup env x = 
    match env with
    | [] -> failwith(x + "not found")
    | (y,v)::r -> if y = x then v else lookup r x


    
let rec eval (e:Expr) (env : (string * int) list) : int =
    match e with
    | CstI i -> i
    | Var x -> lookup env x
    | Prim(opt,e1,e2) ->
        match opt with
        |"+"->(eval e1 env) + (eval e2 env)
        |"-"->(eval e1 env) - (eval e2 env)
        |"*"->(eval e1 env) * (eval e2 env)
        |_->
            let r1 = eval e1 env
            let r2 = eval e2 env
            match opt with
            |"max"-> if r1 > r2 then r1 else r2
            |"min"-> if r1 < r2 then r1 else r2
            |"=="-> if r1 = r2 then 1 else 0
            |_-> failwith(opt + "not implement") 
            
    | If(e1,e2,e3)->if (eval e1 env) > 0 then (eval e2 env) else (eval e3 env)