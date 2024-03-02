module createWindow


open Raylib_cs
open System.Numerics
open types
open scenemanager

let setupWindow : window =
    let window: window = {size = {x = 1600f; y = 900f}; name = "2D Voxel Terrain Generator"};
    window




let setupCamera : Camera2D =
    let target = Vector2(-50.0f, 0.0f)
    let offset = Vector2(0.0f, 0.0f)

    let camera: Camera2D = Camera2D(target, offset, 0.0f, 0.5f)

    camera




let createWindow =
    let mutable gameData: gameData = {window = setupWindow; camera = setupCamera; currentScene = 9; backgroundColor = Color(0, 220, 220, 255); isDay = true; speed = 30; time = 0}

    printfn "X: %f, Y: %f, Name: %s" gameData.window.size.x gameData.window.size.y gameData.window.name
    printfn "\nMove Camera -> WASD\nZoom In -> O\nZoom Out -> P\nGenerate New Terrain -> R\nIncrease Speed Of Time -> N\nDecrease Speed Of Time -> M"
    Raylib.SetTraceLogLevel(TraceLogLevel.Fatal)

    Raylib.InitWindow((int)gameData.window.size.x, (int)gameData.window.size.y, gameData.window.name);
    
    while not (Raylib.WindowShouldClose()) do
        Raylib.BeginDrawing()
        Raylib.BeginMode2D(gameData.camera)
        
        sceneManager gameData
            
        Raylib.ClearBackground(gameData.backgroundColor)
        Raylib.EndDrawing()

    Raylib.CloseWindow()