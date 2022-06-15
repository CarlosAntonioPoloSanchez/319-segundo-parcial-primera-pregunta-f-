// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
let rec fibonacci b =
    if b<=1 then b else (fibonacci(b-1)+fibonacci(b-2)) 
[<EntryPoint>]
let main argv = 
    Console.WriteLine("ingrese un numero")
    let a = Convert.ToInt32(Console.ReadLine())
    let b = ""
    for i=1 to a do
        let c= fibonacci(i)
        Console.WriteLine(c)
    let y = Console.ReadLine()
    printfn "%A" argv
    0 // devolver un código de salida entero
    