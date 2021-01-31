module Parse

let parseUnits = function
    | 0 -> ""
    | 1 -> "one"
    | 2 -> "two"
    | 3 -> "three"
    | 4 -> "four"
    | 5 -> "five"
    | 6 -> "six"
    | 7 -> "seven"
    | 8 -> "eight"
    | 9 -> "nine"
    | _ -> failwith "I expected a single digit."

let tensName = function
    | 2 -> "twenty"
    | 3 -> "thirty"
    | 4 -> "forty"
    | 5 -> "fifty"
    | 6 -> "sixty"
    | 7 -> "seventy"
    | 8 -> "eighty"
    | 9 -> "ninety"
    | _ -> failwith "The tens cannot > 9 or < 1!"

let parseTens n = 
    let tens = (n % 100) / 10
    let units = n % 10
    match tens with
    | 0 -> parseUnits units
    | 1 -> 
        match units with 
        | 0 -> "ten"
        | 1 -> "eleven"
        | 2 -> "twenteen"
        | 3 -> "thirteen"
        | 4 -> "forteen"
        | 5 -> "fifteen"
        | 6 -> "sixteen"
        | 7 -> "seventeen"
        | 8 -> "eighteen"
        | 9 -> "nineteen"
        | _ -> failwith "Units cannot be > 9."
    | n -> sprintf "%s %s" (tensName n) (parseUnits units)

let parseHundreds n = 
    match (n % 1000) / 100 with
    | 0 -> parseTens n
    | h -> 
        let prefix = sprintf "%s hundred" (parseUnits h)
        match n % 100 with
        | 0 -> prefix
        | rest ->
            let units = parseTens rest
            sprintf "%s and %s" prefix units

let parseThousands n =
    match (n % 10000) / 1000 with
    | 0 -> parseHundreds n
    | h -> 
        let prefix = sprintf "%s thousand" (parseUnits h)
        match n % 1000 with
        | 0 -> prefix
        | rest ->
            let units = parseHundreds rest
            sprintf "%s and %s" prefix units
            //match (n % 1000) / 100 with
            //| 0 -> sprintf "%s and %s" prefix units
            //| _ -> sprintf "%s" units

let parse = function
    | 0 -> "zero"
    | n ->
        match n > 9999 || n < -9999 with
        | true -> failwith "Out of range!"
        | _ ->
            match n > 0 with
            | true -> parseThousands n
            | _ -> sprintf "minus %s" (parseThousands -n)
