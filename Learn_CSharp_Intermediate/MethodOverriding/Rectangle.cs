namespace MethodOverriding
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            System.Console.WriteLine("Draw a rectangle");
        }
    }
}
