module time

open Raylib_cs
open types



let makeNight (gameData: gameData) =
    match gameData.backgroundColor.B with
    | b when b = (byte)0 -> gameData.isDay <- false
    | _ -> gameData.backgroundColor.B <- gameData.backgroundColor.B - (byte)1
    match gameData.backgroundColor.G with
    | g when g = (byte)0 -> gameData.isDay <- false
    | _ -> gameData.backgroundColor.G <- gameData.backgroundColor.G - (byte)1

let makeDay (gameData: gameData) =
    match gameData.backgroundColor.B with
    | b when b = (byte)220 -> gameData.isDay <- true
    | _ -> gameData.backgroundColor.B <- gameData.backgroundColor.B + (byte)1
    match gameData.backgroundColor.G with
    | g when g = (byte)220 -> gameData.isDay <- true
    | _ -> gameData.backgroundColor.G <- gameData.backgroundColor.G + (byte)1



let changeTime (gameData: gameData) =
    gameData.time <- gameData.time + 1
    if gameData.time % gameData.speed = 0 then
        match gameData.isDay with
        | true -> makeNight gameData
        | _ -> makeDay gameData
    Raylib.DrawRectangle((int)gameData.backgroundColor.B - 100, (int)gameData.backgroundColor.B - 100, 60, 60, Color.Yellow);
    
    