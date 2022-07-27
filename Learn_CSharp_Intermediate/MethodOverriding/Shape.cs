namespace MethodOverriding
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            System.Console.WriteLine("Draw a generic shape");
        }
    }
}
