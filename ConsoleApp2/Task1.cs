class Task1 {
    public int[] numbers { get; set; }


    static private Predicate<int> IsEven = number => { if (number % 2 == 0) { return true; }
        else { return false; }
    };
    // Square all numbers
    private Func<int[], int[]> square = (int[] numbers) =>
    {
        int[] squared = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            squared[i] = numbers[i] * numbers[i];
        }
        return squared;
    };

    // Even numbers
    private Func<int[], List<int>> even = (int[] numbers) =>
    {
        List<int> evens = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsEven(numbers[i]))
            {
                evens.Add(numbers[i]);
            }
        }
        return evens;
    };

    // Sum of elements
    private Func<int[], int> sum = (int[] numbers) => {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    };

    public Task1(int[] numbers)
    {
        this.numbers = numbers;
    }

    // Show
    public void show() {
        Console.WriteLine("Normal Numbers: ");
        foreach (var item in numbers)
        {
            Console.Write(item+" ");
        }
        Console.Write("\n");

        Console.WriteLine("Squared Numbers: ");
        foreach (var item in square(numbers))
        {
            Console.Write(item + " ");
        }
        Console.Write("\n");

        Console.WriteLine("Even Numbers: ");
        foreach (var item in even(numbers))
        {
            Console.Write(item + " ");
        }
        Console.Write("\n");

        Console.Write("Sum of Numbers: ");
        Console.WriteLine(sum(numbers));
    }
}
