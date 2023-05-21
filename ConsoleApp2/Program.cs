class Program {
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        Task1 t = new Task1(numbers);
        t.show();

        string sentence = "Hello World ! I am Software Engineer";
        Task2 t2 = new Task2(sentence);
        t2.show();
    }
}
