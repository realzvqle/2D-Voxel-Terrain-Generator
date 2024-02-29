module scenemanager


open Raylib_cs
open types
open mainScene


let sceneManager (gameData: gameData) = 
    match gameData.currentScene with
    | 0 -> scene gameData
    | 1 -> playingScene gameData
    | _ -> gameData.currentScene <- 0