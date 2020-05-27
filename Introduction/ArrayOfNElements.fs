open System

let f n = //Complete this function
    [0..n-1]


let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%A" (f n)

main()