//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
let reverse arr = 
    for i in arr do
        printfn "%d" i
let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff):: arr
            buff <- Console.ReadLine()
    arr

let main =  
    let arr = read_and_parse()
    reverse arr
    