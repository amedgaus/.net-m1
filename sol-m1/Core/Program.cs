﻿using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) Console.WriteLine($"Hello, {args[0]}!");
        }
    }
}