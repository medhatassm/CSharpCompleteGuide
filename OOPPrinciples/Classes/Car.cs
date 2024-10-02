using System;

namespace OOPPrinciples.Classes;

public class Car
{
    #region Class And Object
    public string _type = "Nissan";
    public string _color = "Red";
    public double _kmh = 50000;

    public string MoverForword()
    {
        return "Car Moved forword.";
    }
    #endregion

    #region Constructor

    public string model;

    // Constructor Chaining.
    public Car() : this("Volvo")
    {
        model = "Nissan";
    }

    public Car(string Model)
    {
        model = Model;
    }

    #endregion



}
