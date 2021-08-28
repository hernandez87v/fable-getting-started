module App

open Browser.Dom

// get references for UI elements
let increase = document.getElementById "increase"
let decrease = document.getElementById "decrease"
let countViewer = document.getElementById "countViewer"

let mutable currentCount = 0

//attach even handlers
increase.onclick <-
    fun ev ->
        // update the state
        currentCount <- currentCount + 1
        // update the view
        countViewer.innerText <- sprintf "Count is at %d" currentCount

decrease.onclick <-
    fun ev ->
        // update the state
        currentCount <- currentCount - 1
        // update the view
        countViewer.innerText <- sprintf "Count is at %d" currentCount

// set the count viewer with the initial count
countViewer.innerText <- sprintf "Count is at %d" currentCount
