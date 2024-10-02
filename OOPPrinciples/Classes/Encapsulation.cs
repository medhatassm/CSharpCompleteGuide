using System;

namespace OOPPrinciples.Classes;

class Person
{
    private string? _name;
    public string? Name
    {
        get
        {
            // Logic
            if (_name != "No Name")
            {
                return _name;
            }
            else
            {
                return "No Name Entered Please ReEnter your name";
            }
        }
        set
        {
            // Logic
            _name = !string.IsNullOrEmpty(value) ? value : "No Name";
        }
    }

    // Smart Properties
    public int Age { get; /* set; */} = 25;
}

