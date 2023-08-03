namespace API
{
    /// <summary>
    /// This class is used to implement your own API functions, but 
    /// the StringFunction interface must be implemented as the endpoint of this class.
    /// </summary>
    public class Doll: StringFunction
    {
        private readonly Description _description = new("Echo", "Returns the input string.", "Hello, World!", "Hello, World!");
        public string MainDescription { get => _description.ToString(); }
        /// <summary>
        /// The Main function is the function that is called when the API is called.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Main(string input)
        {
            return input;
        }
    }
}