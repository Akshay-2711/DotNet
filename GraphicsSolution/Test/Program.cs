using Drawing;
using System.Collections.Generic;
Point p1=new Point(10,20);
Point p2=new Point(15,25);
Point p3=new Point(20,30);
Point p4=new Point(25,35);

Shape shape1=new Line(p1,p2);
Shape shape2=new Rectangle(p3,p4);
Shape shape3=new Circle(p2,10);

List<Shape> shapes=new List<Shape>();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

Console.WriteLine( "Drawing all Shapes");

foreach ( Shape sh in shapes){
    sh.Draw();
    IPrintable obj= (IPrintable)sh;
    obj.Print();

}