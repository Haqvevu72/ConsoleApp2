class Task2 {

    public string sentence { get; set; }

    public Task2(string sentence)
    {
        this.sentence = sentence;
    }

    // UpperCase
    private Func<string, string> upper = (sentence) =>
    {
        string newsentence;
        newsentence = sentence.ToUpper();
        return newsentence;

    };

    // Reverse
    private Func<string, string> reverse = (sentence) =>
    {
        string newsentence = new string(sentence.Reverse().ToArray());
        return newsentence;
    };

    // Cut space
    private Func<string,string> space = (sentence) =>
    {
        string newsentence = sentence.Replace(" " , "");
        return newsentence;
    };


    public void show() {
        Console.WriteLine("Normal Text: ");
        Console.WriteLine(sentence);

        Console.WriteLine("UpperCase Text: ");
        Console.WriteLine(upper(sentence));

        Console.WriteLine("Reverse Text: ");
        Console.WriteLine(reverse(sentence));

        Console.WriteLine("Space filtered Text: ");
        Console.WriteLine(space(sentence));
    }
}
