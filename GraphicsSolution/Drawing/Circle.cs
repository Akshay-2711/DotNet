namespace Drawing;

public class Circle:Shape, IPrintable{

    public Point Center{get;set;}
    public int Radius{get;set;}

    public Circle(Point c,int r)
    {
        this.Center=c;
        this.Radius=r;
    }

     public override void Draw()
    {
        Console.WriteLine("Center and Radius are {0},{1}",this.Center,this.Radius);
    }

     public void Print()
    {
        Console.WriteLine("A Circle is drawn using interface's Print method ");
    }

}