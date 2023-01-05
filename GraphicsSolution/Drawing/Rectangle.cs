namespace Drawing;

public class Rectangle:Shape,IPrintable{

    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

   public Rectangle()
   {
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
   }

    public Rectangle(Point p1,Point p2){
        this.StartPoint=p1;
        this.EndPoint=p2;
    }

    public override void Draw()
    {
        Console.WriteLine("Start and End points are {0},{1}",this.StartPoint,this.EndPoint);
    }

    public void Print()
    {
        Console.WriteLine("A Rectangle is drawn using interface's Print method ");
    }
}