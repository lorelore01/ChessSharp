﻿using ChessSharp.Board;

namespace ChessSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Position pos = new Position(3, 4);
            Console.WriteLine(pos.Row);
        }
    }
}