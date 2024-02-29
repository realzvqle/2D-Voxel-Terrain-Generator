module mainScene


open Raylib_cs
open types
open controls
open terrainGenerator


let scene (gameData: gameData) =
    controls gameData
    terrainGen gameData

let playingScene (gameData: gameData) =
    controls gameData
    
