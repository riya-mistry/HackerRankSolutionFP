//Enter your code here. Read input from STDIN. Print output to STDOUT
open System 
let count arr = 
    let mutable cnt = 0 
    for i in arr do
        cnt <- cnt + 1
    cnt
let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff):: arr
            buff <- Console.ReadLine()
    arr
    
let main = 
    let arr = read_and_parse()
    let result = count arr
    printfn "%d" result
    