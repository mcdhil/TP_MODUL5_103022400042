using System;

public class HaloGeneric
{
    // Method dengan generic parameter T
    public void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}");
    }
}
