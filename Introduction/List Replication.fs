open System
let rec readItemsFromInput () = seq {
    let line = Console.ReadLine ()
    match line with
    | null -> ()
    | _ -> yield line |> int
           yield! readItemsFromInput ()         
}
let replicate n s =
    seq { for v in s do yield! seq { for _ in 1 .. n do yield v } }
[<EntryPoint>]
let main argv = 
    let s = Console.ReadLine () |> int
    let items = readItemsFromInput ()
    items
    |> replicate s
    |> Seq.iter (fun v -> printfn "%A" v)
    0 // return an integer exit code