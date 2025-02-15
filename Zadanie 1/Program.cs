﻿using System;

class Rectangle
{
    private double a;
    private double b;
    private double surface_area;

    public void read_data()
    {
        Console.WriteLine("Podaj długość boku a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość boku b:");
        b = Convert.ToDouble(Console.ReadLine());
    }

    public void process_data()
    {
        surface_area = a * b;
    }

    public void show_results()
    {
        Console.WriteLine("Długość boku a: {0}", a);
        Console.WriteLine("Długość boku b: {0}", b);
        Console.WriteLine("Pole prostokąta: {0}", surface_area);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();

        rectangle.read_data();
        rectangle.process_data();
        rectangle.show_results();
    }
}