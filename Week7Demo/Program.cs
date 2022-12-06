using System;
using System.Collections.Generic;
using Week7Demo;

void InitShapeList(List<Shape> sList)
{

    Circle circle1 = new Circle("Red", 20.0);
    Square square1 = new Square();
    Circle circle2 = new Circle("Green", 10.0);
    Circle circle3 = new Circle("Blue", 30.0);
    sList.Add(circle1);
    sList.Add(square1);
    sList.Add(circle2);
    sList.Add(circle3);
}
void InitCircleList(List<Circle> cList)
{
    Circle circle1 = new Circle("Red", 20.0);
    Circle circle2 = new Circle("Green", 10.0);
    Circle circle3 = new Circle("Blue", 30.0);
    cList.Add(circle1);
    cList.Add(circle2);
    cList.Add(circle3);
}

void DisplayShapeList(List<Shape> shapeList)
{
    int count = 1;
    foreach (var obj in shapeList)
    {
        Console.WriteLine("[{0}] Type: {1,-8} Color: {2,-8} ", count, obj.Type, obj.Color);
        count += 1;
    }
}
void DisplayList(List<Circle> circleList)
{
    int count = 1;
    foreach (var obj in circleList)
    {
        Console.WriteLine("[{0}] Type: {1,-8} Color: {2,-8} Radius: {3}", count, "Circle", obj.Color, obj.Radius);
        count += 1;
    }
}
//List<Circle> circleList = new List<Circle>();
//InitCircleList(circleList);
//circleList.Sort();
List<Shape> shapeList = new List<Shape>();
InitShapeList(shapeList);
DisplayShapeList(shapeList);
if (shapeList.Count > 0)
{
    bool deleted = false;
    for (int i = shapeList.Count - 1; i >= 0; i--)
    //foreach(var c in circleList)
    {
        Shape s = shapeList[i];

        if (s is Circle)
        {
            Console.WriteLine("Deleting last circle");
            Console.WriteLine("{0, -10} {1, -10}", s.Type, s.Color);
            shapeList.Remove(s);
            deleted = true;
            break;
        }
    }
    if (deleted)
    {
        DisplayShapeList(shapeList);
    }
    else
    {
        Console.WriteLine("There is no circle to delete");
    }
    
}
else
{
    Console.WriteLine("The list is empty");
}
//DisplayList(circleList);
/*
Delete the last Circle object in shapeList. 
Display an error message if the list is empty or the list does not contain any Circle object.
*/
