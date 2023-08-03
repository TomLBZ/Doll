namespace API
{
    /// <summary>
    /// This struct specifies the name, text, sample input, and sample output of the API.
    /// </summary>
    internal readonly struct Description
    {
        string Name { get; }
        string Text { get; }
        string SampleInput { get; }
        string SampleOutput { get; }
        public Description(string name, string text, string sampleInput, string sampleOutput)
        {
            Name = name;
            Text = text;
            SampleInput = sampleInput;
            SampleOutput = sampleOutput;
        }
        public override string ToString()
        {
            return $"name={Name}; text={Text}; sampleInput={SampleInput}; sampleOutput={SampleOutput};";
        }
    }
}