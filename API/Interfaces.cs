namespace API
{
    /// <summary>
    /// This interface is used to define a function that takes a string and returns a string.
    /// </summary>
    public interface StringFunction
    {
        public string Main(string input);
        public string MainDescription { get; }
    }
}