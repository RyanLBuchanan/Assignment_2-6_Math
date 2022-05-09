using System;

namespace Assignment_2_6_Math
{
    class Math
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of given circle: ");
            int radius = int.Parse(Console.ReadLine());

            int diameter = 2 * radius;
            double circumference = 2 * 3.14159 * radius;
            double area = 3.14159 * (radius * radius); 
            
            Console.WriteLine($"\ndiameter = {diameter}\ncircumference = {circumference}\narea = {area}");
        }
    }
}
