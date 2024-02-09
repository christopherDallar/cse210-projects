using System;

class Rectangle : Shape
{
  double _length;
  double _width;

  public Rectangle(string color, double length, double width) : base(color)
  {
    _width = width;
    _length = length;
  }

  public override double GetArea()
  {
    return _width * _length;
  }
}