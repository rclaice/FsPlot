Highcharts Stacked Area
=======================

Code
----

```fsharp
#load "FsPlotInit.fsx"

open FsPlot.Data
open FsPlot.Highcharts.Charting

let asia = Series.StackedArea("Asia", [502; 635; 809; 947; 1402; 3634; 5268])
let africa = Series.StackedArea("Africa", [106; 107; 111; 133; 221; 767; 1766])
let europe = Series.StackedArea("Europe", [163; 203; 276; 408; 547; 729; 628])
let america = Series.StackedArea("America", [18; 31; 54; 156; 339; 818; 1201])
let oceania = Series.StackedArea("Oceania", [2; 2; 2; 6; 13; 30; 46])

let stackedArea =
    Chart.plot [asia; africa; europe; america; oceania]
    |> Chart.categories ["1750"; "1800"; "1850"; "1900"; "1950"; "1999"; "2050"]
    |> Chart.showLegend
    |> Chart.title "Historic and Estimated Worldwide Population Growth"
    |> Chart.tooltip "{series.name} <b>{point.y}</b> millions"
```
Chart
-----

![Highcharts Stacked Area](https://raw.github.com/TahaHachana/FsPlot/master/screenshots/HighchartsStackedArea.PNG)