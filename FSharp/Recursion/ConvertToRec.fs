module ConvertToRec

let sumBetween m n = 
    let rec sumTo v = 
        match n = v with
        |true -> v
        |_ -> v + sumTo (v+1)
    match m > n with
    |true -> 0
    |_ -> sumTo m

let sumBetweenTail m n = 
    let rec sumTo v acc = 
        match n = v with
        |true -> v + acc
        |_ -> sumTo (v+1) (acc + v)
    match m > n with
    |true -> 0
    |_ -> sumTo m 0

(* C# Code
int NumOdd(int start, int end) {
    int total = 0;
    for (int i = start; i < end; i++)
        if (i%2 == 1) {
            total++;
        }
    }
    return total;
}*)
let NumOdd m n =
    let rec sumTo v acc =
        match n = v with
        |true -> v % 2 + acc
        |_ -> sumTo (v + 1) (v % 2 + acc)
    match m > n with
    |true ->0
    |_ -> sumTo m 0

(* C# Code
int NextMul(int start, int n) {
    while (start % n != 0) {
        start++;
    }
    return start;
}*)
let NextMul start n = 
    let rec mul v = 
        match v % n with 
        |0 -> v
        |_ -> mul (v + 1)
    mul start

(*
bool IsPrime(int n) {
    int test = n-1;
    while (test > 1)
        if (n % test == 0) {
            return false;
        }
         test = test-1;
    }
    return true;
}*)

let IsPrime n = 
    let rec test v = 
        match n % v with
        | 0 -> false
        | _ -> 
            match v > 2  with
            |false -> true
            |_ -> test (v - 1)
    test (n - 1)

let sqrt n = 
    let rec calculate guess i =
        match i with
        | 10 ->guess
        | _ -> 
            let g = (guess + n / guess) / 2.0
            calculate g (i+1)
        
    match n <= 0.0 with
    | true -> failwith "Impossibru!"
    | _ ->
            calculate (n/2.0) 0
    
