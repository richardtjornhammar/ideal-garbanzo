open System

let printGreeting name =
    printfn "F#! Hello %s!" name

let from whom =
    sprintf "from %s" whom

let rec factorial n = 
    if n = 0 then 1 else n * factorial (n-1)

// https://gist.github.com/richardtjornhammar/ef1719ab0dc683c69d5a864cb05c5a90
let rec Fibonacci n =
    if n<0 then 0
      else if n-2 > 0 then Fibonacci(n-1) + Fibonacci(n-2)
        else if n-1 > 0 then Fibonacci(n-1) 
          else if n > 0 then n else -1

let rec ipow n m =
    if m<1 then 1 else n * ipow n (m-1)

let Fibonacci_truth i =
    let Fi_0 = ipow (Fibonacci(i)) (2) 
    let Fi_1 = ipow (Fibonacci(i+1)) (2)
    if Fi_0+Fi_1 = Fibonacci(2*i+1) then 1 else 0


let rec isItPrime_rec N M p (lM05:float) : bool =
    if (M%p)=0 && (p>=2) then N=2 else
      let lp = System.Math.Log ( System.Convert.ToDouble(p) )
      if lp > lM05 then true else isItPrime_rec (N-1) (M) (p+1) lM05

let isItPrime (N:int) : bool =
    if N <= 2 then true else
        let p = 1
        let M = N
        let lM05 = System.Math.Log(  System.Convert.ToDouble(M) )*0.5
        isItPrime_rec N M p lM05

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    //
    printfn $"Factorial of 4 is %d{factorial 4}"
    printfn "The first Fiboancci numbers are"
    printfn $"  %d{Fibonacci 1},   %d{Fibonacci 2},   %d{Fibonacci 3},   %d{Fibonacci 4},   %d{Fibonacci 5}"
    printfn $"  %d{Fibonacci 6},  %d{Fibonacci 7},  %d{Fibonacci 8},  %d{Fibonacci 9},  %d{Fibonacci 10}"
    printfn $" %d{Fibonacci 11}, %d{Fibonacci 12}, %d{Fibonacci 13}, %d{Fibonacci 14}, %d{Fibonacci 15}"
    //
    let gnum = 1 + ipow 2 (ipow 2 4)
    printfn $"%d{ ipow 2 4 }"
    printfn "%d" gnum

    let i_ = 7
    printfn $"\nThese are equal %d{Fibonacci i_}^2 + %d{Fibonacci i_+1}^2 = %d{Fibonacci (2*i_+1)}"
    printfn $"is %b{ (Fibonacci_truth i_) = 1}\n"
    printfn "The first six Fermat numbers are:"
    let N = 1
    let FerN = 1 + ipow 2 (ipow 2 N) 
    printfn $"F%d{N} = %A{ FerN } and is it Prime? %b{isItPrime FerN }" 
    let N = 2
    let FerN = 1 + ipow 2 (ipow 2 N)
    printfn $"F%d{N} = %A{ FerN } and is it Prime? %b{isItPrime FerN }"
    let N = 3
    let FerN = 1 + ipow 2 (ipow 2 N)
    printfn $"F%d{N} = %A{ FerN } and is it Prime? %b{isItPrime FerN }"
    let N = 4
    let FerN = 1 + ipow 2 (ipow 2 N)
    printfn $"F%d{N} = %A{ FerN } and is it Prime? %b{isItPrime FerN }"

    // outside the range
    //let N = 5
    //let FerN = 4294967297
    //printfn $"F%d{N} = %A{ FerN } and is it Prime? %b{isItPrime FerN }"

    //
    // Call your new function!
    printGreeting "Saiga"
    0 // return an integer exit code

