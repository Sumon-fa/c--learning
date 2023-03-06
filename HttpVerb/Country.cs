public class Country
{
    public string? Region { get; set; }
    public double Population { get; set; }
    public double Area { get; set; }
    public ComposedName? Name { get; set; }
    public class ComposedName
    {
        public string? Common { get; set; }
        public string? Official { get; set; }
    }

}