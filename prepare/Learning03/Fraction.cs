using System;

public class Fraction 
{
private int _top;
private int _bottom;

public Fraction()

{
  _top = 1;
  _bottom = 1 ;
}

public Fraction(int _wholeNumber)
{
    _top = _wholeNumber;
    _bottom = 1;
}
public Fraction(int top, int bottom)
{
    _top = top;
    _bottom = bottom;
}

//Create methods to return the representations
public string GetFractionString()
{
    string text = $"{_top}/{_bottom}";
    return text;
}
public double GetDecimalValue()
{
    return (double)_top/(double)_bottom;
}
}

