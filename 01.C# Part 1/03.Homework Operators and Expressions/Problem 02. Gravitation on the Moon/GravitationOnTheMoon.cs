using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        // The gravitational field of the Moon is approximately 17% of that on the Earth.
        // Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

        Console.WriteLine("Please enter weight on the Earth");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = (17.0 / 100) * weightOnEarth;
        Console.WriteLine("Weight on moon is {0} ", weightOnMoon);
    }
}

