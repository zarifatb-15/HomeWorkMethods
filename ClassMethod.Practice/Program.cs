using System.Reflection.Metadata.Ecma335;

namespace ClassMethod.Practice;

class Program
{
    static void Main(string[] args)
    {
        // // Console.WriteLine("Hello, World!");
        // int[] arr = {  2, 3, 4, 5, };
        // Console.WriteLine(  SumOfArrayElements(arr));
        // var result =AddElementToArray(new int[] { 33, 44 },66);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine(Factorial(3));
        // int[] numbers = {2,3,4 };
        // int [] result=FactorialArray(numbers);
        // foreach (int num in result)
        // {
        //     Console.WriteLine(num);
        // }
        // int[] arr = { 4, 7, 21 };
        // int[] result = RemoveSmall(arr);
        // Console.WriteLine(string.Join(", ", result));
        // Console.WriteLine(FirstSingleChar("eynek"));
        // Console.Write("Eded daxil edin:");
        // int number=int.Parse(Console.ReadLine());
        // IsPrimeOrComposite(number);
        



    }

    static int SumOfArrayElements(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
                     sum += num;
                     return sum;
    }

    static string RemoveStringFromString(string word)
    {
        string newWord=string.Empty;
        foreach (char letter in word)
        {
            if(letter!=' ')
                newWord += letter;
                
        }

        return newWord;
    }

    static int[] AddElementToArray(int[] array, int num)
    {
        int[] newArray = new int[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
              newArray[i] = array[i];
        newArray[newArray.Length-1] = num;
        return newArray;
    }
    //BINARY SEARCH
    //TASK1 FAKTIRAL METHOD
    static int Factorial(int num)
    {
        int result = 1;
        for (int i=1; i<=num; i++)
            result *= i;
            return result;
    }

    public static int[] FactorialArray(int[] array)
    {
        for (int i=0; i<array.Length; i++)
              array[i]=Factorial(array[i]);
        return array;
    }
    //TASK 2 
    public static int[] RemoveSmall(int[] numbers)
    {
        int min=numbers[0];
        for (int i=1; i<numbers.Length;i++)
              if (numbers[i]<min)
                 min=numbers[i];
        int[] result = new int [numbers.Length - 1];
        int index = 0;
        bool removed = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == min && !removed)
            {
                removed = true;
                continue;
            }
            result[index] = numbers[i];
            index++;
        }
        return result;
    }
    //TASK 3
    public static char FirstSingleChar(string text)
    {
        Dictionary<char, int>charCount = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (char c in text)
        {
            if(charCount[c]==1)
                return c;
        }

        return '\0';
    }
    //TASK 4
    public static void IsPrimeOrComposite(int num)
    {
        if (num <= 1)
        {
            Console.WriteLine($"{num} sade eded deyil");
            return;
        }

        if (num == 2 || num == 3)
        {
            Console.WriteLine($"{num} sade ededdir");
            return;
        }

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} murekkeb ededdir");
            return;
        }
            
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                Console.WriteLine($"{num} murekkeb ededdir");
                return;
            }  
        }
        Console.WriteLine($"{num} sade ededdir");
    }
    // TASK 5
    
    
    
    
}