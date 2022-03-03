(**
## This is a test page
*)

#load "YahooFinance.fsx"

open YahooFinance

let twnk = YahooFinance.PriceHistory("TWNK")

twnk.[..3]

#r "nuget: Plotly.Net,2.0.0-preview.17"

open Plotly.NET

twnk
|> List.map (fun day -> day.Date, day.AdjustedClose)
|> Chart.Line
|> GenericChart.toChartHTML

(***include-it-raw***)


let list = [ 1; 2; 3; 4] // list<int>

list

