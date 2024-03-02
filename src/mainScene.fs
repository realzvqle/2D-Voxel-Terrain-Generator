module mainScene


open Raylib_cs
open types
open controls
open terrainGenerator
open time

let scene (gameData: gameData) =
    controls gameData
    terrainGen gameData
    changeTime gameData


let playingScene (gameData: gameData) =
    controls gameData
    
