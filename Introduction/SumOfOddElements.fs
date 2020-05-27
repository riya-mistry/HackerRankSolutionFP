open System

(*USER CODE BEGIN*)
let f arr =
    let arr2 = arr |> List.filter (fun x -> x % 2 <> 0)
    let mutable s = 0
    for i in arr2 do
        s <- s + i
    s
    
(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    let result = f arr
    printf "%d"  result