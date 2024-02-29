module controls


open Raylib_cs
open types





let controls (gameData: gameData) =
    if Raylib.IsKeyDown(KeyboardKey.A) = true then
        gameData.camera.Target.X <- gameData.camera.Target.X - 600f * Raylib.GetFrameTime();
    if Raylib.IsKeyDown(KeyboardKey.D) = true then
        gameData.camera.Target.X <- gameData.camera.Target.X + 600f * Raylib.GetFrameTime();
    if Raylib.IsKeyDown(KeyboardKey.W) = true then
        gameData.camera.Target.Y <- gameData.camera.Target.Y - 600f * Raylib.GetFrameTime();
    if Raylib.IsKeyDown(KeyboardKey.S) = true then
        gameData.camera.Target.Y <- gameData.camera.Target.Y + 600f * Raylib.GetFrameTime();
    if Raylib.IsKeyDown(KeyboardKey.O) = true then
        gameData.camera.Zoom <- gameData.camera.Zoom + 0.001f
    if Raylib.IsKeyDown(KeyboardKey.P) = true then
        gameData.camera.Zoom <- gameData.camera.Zoom - 0.001f