﻿namespace ChessSharp
{
    [System.Flags]
    enum Direction
    {
        None,
        North = 1,
        Northeast = 2,
        East = 4,
        Southeast = 8,
        South = 16,
        Southwest = 32,
        West = 64,
        Northwest = 128
    }
}
