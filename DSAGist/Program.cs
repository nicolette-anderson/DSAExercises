//Exercises Chapter 9
//1. Queue - First in line is the first call to get answered.
//2. 1, 2, 3, 4
//3. 3, 4, 5, 6

//4. Write a function that reverses the string "abcde"
    string word = "Awesomesauce";
    char[] letters = word.ToCharArray();
    string backwardsLetters = string.Empty;
    for (int i = letters.Length-1; i > -1; i--)
    {
        backwardsLetters += letters[i];
    }
    Console.WriteLine(backwardsLetters);

//Exercises Chapter 10
//Example: base case: if number == 1
//         next-to-last-case: else
//                              return number * factorial(number-1)
//                            end
//1. return if low > high

//2.
    var number = factorial(10);
    int factorial(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        return n * factorial(n - 1);
    };

    Console.WriteLine(number);

//A stack overflow happens because it never reaches the base case.
//Top-Down Recursion Staircase Example

    var result = numberOfPaths(11);
    int numberOfPaths(int n)
    {
        if (n < 0)
            return 0;
        if (n == 1 || n == 0)
            return 1;

        return numberOfPaths(n - 1) + numberOfPaths(n - 2) + numberOfPaths(n - 3);
    }

    Console.WriteLine("Total stair paths: " + result.ToString());
Console.ReadLine();