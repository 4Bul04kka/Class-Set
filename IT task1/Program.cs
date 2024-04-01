using System;
using System.Collections.Generic;

public class Set
{
    private HashSet<int> _elements = new HashSet<int>();

    public int Count { get { return _elements.Count; } }

    public bool IsEmpty { get { return _elements.Count == 0; } }

    public void AddElement(int element)
    {
        _elements.Add(element);
    }

    public void RemoveElement(int element)
    {
        _elements.Remove(element);
    }

    public void Clear()
    {
        _elements.Clear();
    }

    public int[] GetAllElements()
    {
        int[] result = new int[_elements.Count];
        _elements.CopyTo(result);
        return result;
    }

    public bool ContainsElement(int element)
    {
        return _elements.Contains(element);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Set mySet = new Set();

        mySet.AddElement(1);
        mySet.AddElement(2);
        mySet.AddElement(3);
        mySet.AddElement(3);
        mySet.AddElement(4);


        Console.WriteLine("Count: " + mySet.Count); // Count: 3
        Console.WriteLine("IsEmpty: " + mySet.IsEmpty); // IsEmpty: False

        mySet.RemoveElement(2);

        int[] allElements = mySet.GetAllElements();
        Console.WriteLine("All elements: " + string.Join(", ", allElements)); // All elements: 1, 3

        Console.WriteLine("Contains 2: " + mySet.ContainsElement(2)); // Contains 2: False
        Console.WriteLine("Contains 3: " + mySet.ContainsElement(3)); // Contains 3: True

        mySet.Clear();

        Console.WriteLine("Count: " + mySet.Count); // Count: 0
        Console.WriteLine("IsEmpty: " + mySet.IsEmpty); // IsEmpty: True
    }
}
