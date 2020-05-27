//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
let f arr delimiter =
    let mutable arr2 = []
    for i in arr do
        arr2 <- i::arr2
    for i in arr2 do
        if i < delimiter then 
            printfn "%d" i
    
let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff):: arr
            buff <- Console.ReadLine()
    arr

let main =  
    let delimiter = Int32.Parse(Console.ReadLine())
    let arr = read_and_parse()
    f arr delimiter
    