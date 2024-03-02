module types


open Raylib_cs

type vec2 = {
    mutable x: float32
    mutable y: float32
};

type window = {
    size: vec2
    name: string
};

type chunkData = {
    mutable height: float option
    mutable distance: float option
};

type gameData = {
    mutable window: window
    mutable camera: Camera2D
    mutable currentScene: int
    mutable backgroundColor: Color
    mutable isDay: bool
    mutable speed: int
    mutable time: int
};