module terrainGenerator

open Raylib_cs
open types

let mutable size = float (Raylib.GetRandomValue(30, 600))
let mutable distance = float (Raylib.GetRandomValue(30, 700))
let mutable mountainheight = float (Raylib.GetRandomValue(1, 190))

let spawnTrees (currentScale: int) (currentIndex: int) =
    match currentScale with
    | xy when xy > 604 && xy < 880 ->
        if currentIndex % 70 = 0 && currentIndex > 0 then true 
        else false
    | _ ->
        false 



let chunkGen (gameData: gameData) (beginning: int) (ending: int) =
    let mutable xy = 0
    if Raylib.IsKeyPressed(KeyboardKey.R) = true then 
        size <- float (Raylib.GetRandomValue(30, 600))
        distance <- float (Raylib.GetRandomValue(30, 700))
        mountainheight <- float (Raylib.GetRandomValue(1, 300))
    for x in beginning .. ending do
        let y = int (mountainheight * sin(float x / (float)size) + distance)
        xy <- (int)gameData.window.size.y - y
        if spawnTrees xy x && xy < 664 then
             Raylib.DrawRectangle(x, xy - 100, 20, 100, Color.Brown)
             Raylib.DrawRectangle(x - 20 , (xy - 100) - 60, 60, 60, Color.Green)
        let color =
            match xy with
            | xy when xy < 612 && xy > 603 -> Color.Gray
            | xy when xy < 604 -> Color.White
            | xy when xy > 880 -> Color.DarkBlue
            | xy when xy > 860 -> Color.Yellow
            | _ -> Color.DarkGreen
        let groundColor =
            match xy with
            | xy when xy > 880 -> Color.DarkBlue
            | _ -> Color.Gray
        Raylib.DrawRectangle(x, xy, 10, xy + (int)gameData.window.size.y, groundColor);
        Raylib.DrawRectangle(x, xy, 20, 20, color);
        

    

let terrainGen (gameData: gameData) =
    chunkGen gameData 0 900
    chunkGen gameData 900 3000
    chunkGen gameData 3000 4000
    chunkGen gameData 4000 4060
   


    


