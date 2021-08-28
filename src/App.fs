module App

open Browser.Dom

let printMsgButton = document.getElementById "printMsg"

printMsgButton.onclick <- fun eventArgs -> printfn "Button clicked"

printfn "Fable is up and running..."
