namespace MethodOverriding
{
    class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            System.Console.WriteLine("Draw a circle");
        }
    }
}
