using Godot;
using System;


[GlobalClass]
public partial class helpers: Node {
    private static readonly Random random = new Random();
    
    public static T enumvalue_helper<T>() where T : Enum
    {
        var values = Enum.GetValues(typeof(T));
        return (T)values.GetValue(random.Next(values.Length));
    }
}