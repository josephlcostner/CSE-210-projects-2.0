using System;
using System.Drawing;

public abstract class Shape
    {
        public string _color;

        public Shape(string color)
    {
        _color = color;
    }
        public abstract double GetArea();
    }
    