module App

open Browser.Dom

// get references for UI elements
let increase = document.getElementById "increase"
let decrease = document.getElementById "decrease"
let countViewer = document.getElementById "countViewer"

let mutable currentCount = 0

let rnd = System.Random()

//attach even handlers
increase.onclick <-
    fun ev ->
        // update the state
        currentCount <- currentCount + rnd.Next(5, 10)
        // update the view
        countViewer.innerText <- sprintf "Count is at %d" currentCount

decrease.onclick <-
    fun ev ->
        // update the state
        currentCount <- currentCount - rnd.Next(5, 10)
        // update the view
        countViewer.innerText <- sprintf "Count is at %d" currentCount

// set the count viewer with the initial count
countViewer.innerText <- sprintf "Count is at %d" currentCount

// Runs the callback after a delay *HOW DOES THIS WORK*
let runAfter (ms: int) callback =
    async {
        do! Async.Sleep ms
        do callback()
    }
    |> Async.StartImmediate

let increaseDelayed = document.getElementById "increaseDelayed"

increaseDelayed.onclick <- fun _ ->
    runAfter 1000 (fun () ->
        currentCount <- currentCount + rnd.Next(5, 10)
        countViewer.innerText <- sprintf "Count is at %d" currentCount
    )
