using System;
using System.Collections.Generic;
using Week7Demo;

void InitCircleList(List<Circle> cList)
{
    Circle circle1 = new Circle("Red", 20.0);
    Circle circle2 = new Circle("Green", 10.0);
    Circle circle3 = new Circle("Blue", 30.0);
    cList.Add(circle1);
    cList.Add(circle2);
    cList.Add(circle3);
}

List<Circle> circleList = new List<Circle>();
InitCircleList(circleList);
circleList.Sort();
for (int i = 0; i < circleList.Count; i++)
//foreach(var c in circleList)
{
    Circle c = circleList[i];
    Console.WriteLine("{0, -4} {1, -10} {2, -10} {3}", (i + 1), c.Type, c.Color, c.Radius);
}
