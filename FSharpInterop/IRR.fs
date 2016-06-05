module Calculations.IRR

let internal discount cash rate days = cash * (1.0 + rate) ** (days / 365.0)
let internal discountDX cash rate days = cash * days / 365.0 * (1.0 + rate) ** ((days - 365.0) / 365.0)

let internal pv (cashflows : List<float * float>) rate = 
    cashflows
        |> List.map(fun (days, cashflow) -> discount cashflow rate days)
        |> List.fold (+) 0.0

let internal pvDX (cashflows : List<float * float>) rate = 
    cashflows
        |> List.map(fun (days, cashflow) -> discountDX cashflow rate days)
        |> List.fold (+) 0.0

let internal convertList (dictionary : System.Collections.Generic.Dictionary<System.DateTime, float>) (today : System.DateTime) =
    dictionary |> Seq.map(fun (kvp) -> ((today - kvp.Key).TotalDays, kvp.Value))
    |> List.ofSeq
    
let solveIRR (cash : System.Collections.Generic.Dictionary<System.DateTime, float>) target tolerance maxIterations (today : System.DateTime) =
    let cashflows = convertList cash today

    let rec solve rate count =
        if count > maxIterations then raise (System.InvalidOperationException("The maximum number of iterations has been reached"))
        let presentVal = pv cashflows rate
        let presentValDX = pvDX cashflows rate
        if abs (target - presentVal) <= tolerance then
            rate
        else
            solve (rate - (presentVal - target) / presentValDX)  (count + 1)

    solve 0.0 0