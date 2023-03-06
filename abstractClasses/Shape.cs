namespace abstractClasses
{
    abstract class Shape
    {


        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"\n This is a {Name}");
        }

        public abstract double Volume();
    }
}