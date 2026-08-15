//  تمرین_1

//class student
//{
//    private string name;
//    private int age;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//   public int Age
//    {
//        get { return age; }
//        set {  age = value; }
//    }
//    public void Introduce()
//    {
//        Console.WriteLine($"Hello , my name is {name} and I am {age} years old");
//    }
//    public student(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//}

//  تمرین_2

//class BankAccount
//{
//    private int balance;

//    public void Deposit(double amount)
//    {
//        balance += (int)amount;
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount > balance)
//        {
//            Console.WriteLine("Not enough money");
//        }
//        else
//        {
//            balance -= (int)amount;
//        }
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine($"Your balance is {balance}");
//    }
//}


//  تمرین 3

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter third number: ");
//int c = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Initial Values");
//Console.WriteLine("Number 1 (Normal) = " + a);
//Console.WriteLine("Number 2 (Ref) = " + b);
//Console.WriteLine("Number 3 (Out) = " + c);

//Statistics stats = new Statistics();
//stats.AnalyzeNumbers(a, ref b, out c);

//Console.WriteLine("Modified Values");
//Console.WriteLine("Number 1 (Normal) = " + a);
//Console.WriteLine("Number 2 (Ref) = " + b);
//Console.WriteLine("Number 3 (Out) = " + c);
//class Statistics
//{
//    public void AnalyzeNumbers(int num1, ref int num2, out int num3)
//    {
//        Console.WriteLine("Inside Method: The first number is: " + num1);
//        num3 = num1 + num2;
//        num2 = num2 * num2;
//    }
//}


// تمرین_4
//Console.Write("Enter array size: ");
//int size = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[size];

//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//int max = 0;
//double average = 0.0;

//ArrayAnalyzer analyzer = new ArrayAnalyzer();
//analyzer.AnalyzeArray(arr, ref max, out average);

//Console.WriteLine(max);
//Console.WriteLine(average);

//class ArrayAnalyzer
//{
//    public void AnalyzeArray(int[] arr, ref int max, out double average)
//    {
//        if (arr.Length == 0)
//        {
//            max = 0;
//            average = 0.0;
//            return;
//        }

//        int sum = 0;
//        max = arr[0];

//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];

//            if (arr[i] > max)
//            {
//                max = arr[i];
//            }
//        }

//        average = (double)sum / arr.Length;
//    }
//}

//  تمرین_5 
//  amirreza-hsh

























