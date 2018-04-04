namespace EulerProject

module Euler6 =
    open Common

    let squareSumMinusSumSquare x =
        [[1..x];[1..x]] 
        |> cartesian 
        |> List.filter (fun l -> l.[0]<>l.[1])
        |> List.map (fun l -> l.[0]*l.[1])
        |> List.sum
