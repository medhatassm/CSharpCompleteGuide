using System;

namespace OOPPrinciples.Classes;

#region Association

class Department
{
    public string? Name { get; set; }
}

class Employee
{
    public string? Name { get; set; }
    public Department? Department { get; set; } // Employee Use Department Class 
                                                //But Deleting Emplpyee Class will not effect Department


}

#endregion

#region Aggregation

class Company
{
    public string? Name { get; set; }
    public Department? Department { get; set; } // Company Has Lot of Department
                                                // But if Company Deleting, Department will not effected
                                                // it will be belong to other company
}

#endregion

#region Composition

class Vicale
{
    public string? Name { get; set; }
    public Engine? Engine { get; set; } // Vicale own an Engine, so when vicale is Distoryed,
                                        // the Engine will be distoryed eaither.
}

class Engine
{
    public string? Model { get; set; }
    public int CC { get; set; }
}

#endregion
