// Learn more about F# at http://fsharp.org

open System

//  split a string into words at spaces 
let splitAtSpaces (text: string ) =
    text.Split ' '
    |> Array.toList 

//  Analyse a string for duplicate words
let wordCount text = 
    let words = splitAtSpaces text 
    let wordSet = Set.ofList words |> Set.toList 
//    let numWords = words.Length 
    let numWords = List.length words 
//  nub 
    let distinctWords = List.distinct words 
    let distinctWords2 = List.length wordSet    
//  diff   
    let numDups = numWords - distinctWords.Length 
    (numWords, numDups) 

//  Analyse a string for duplicate words and diplay the results
let showWordCount text =
    let numWords, numDups = wordCount text 
    printfn "--> %d words in the text" numWords 
    printfn "--> %d duplicate words" numDups 

//  dotnet run "The quick brown dog jumped over the lazy dog" "aa aa bb" 
[<EntryPoint>]
let main argv =
    for name in argv do
        showWordCount name  

    printfn "All finished from ExpertF#Ch02A"
    0 // return an integer exit code
