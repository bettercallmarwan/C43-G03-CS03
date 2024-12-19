namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program that allows the user to enter a number then print it.
            //bool flag;
            //int x;
            //do
            //{
            //    Console.WriteLine("Enter a number");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //} while (!flag);

            //Console.WriteLine(x);
            #endregion

            #region Q2.Write C# program that converts a string to an integer
            //string s = Console.ReadLine();
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(n);
            //// It will result to a run-time error, because the entered string is not in the same format (numbers)
            //// So we must enter a string number in order to convert it to int
            #endregion

            #region Q3.Write C# program that Perform a simple arithmetic operation with floating-point numbers 
            //double f1 = 0.5, f2 = 1.1;
            //f1 += f2; // Added the value of f2 to f1 which replaces the value of old f1 in stack
            //Console.WriteLine(f1); 
            //// I am not sure if this what the question mean
            #endregion

            #region Q4.Write C# program that Extract a substring from a given string
            //string s1 = "Hello, world";
            //string s2 = s1.Substring(3, 5); // Starting from idx 3 (second 'l'), to length 5 from that idx (lo, w)
            //Console.WriteLine(s2);
            #endregion

            #region Q5.Write C# program that Assigning one value type variable to another 
            //int a = 1; // Assigning var a = 1
            //int b = a; // Assigning var b = a

            //a++;  // Incrementing the value of a will increase the value of a by one (2)
            //      // Although var b = var a, but it's value wont be affected
            //      // Bec when making b equals a, this means taking a copy of value from a and assigning it to b, so they dont share the same object

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region Q6..Write C# program that Assigning one reference type variable to another 
            //int[] arr1 = { 1, 2 }; // Assigning arr1 with values 1, 2
            //int[] arr2 = arr1; // Assiging arr2 = arr1
            //// Since array is reference type, when assigning arr2 = arr1, this means that they share the same object in the heap
            //// So if any change is done to anyone of themm it will affect the other

            //// Displaying their values before any changes
            //Console.WriteLine($"arr1 : {arr1[0]} {arr1[1]}");
            //Console.WriteLine($"arr2 : {arr2[0]} {arr2[1]}");

            //arr1[0] += 10; ; // Incremneting each 1st idx in arr1 by 10, so this will affect both arr1 and arr2

            //// Displaying that both arrays are incremented
            //Console.WriteLine($"arr1 : {arr1[0]} {arr1[1]}");
            //Console.WriteLine($"arr2 : {arr2[0]} {arr2[1]}");
            #endregion

            #region Q7.Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("enter 1st string");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("enter 2nd string");
            //string str2 = Console.ReadLine();

            //string str3 = str1 + str2;

            //Console.WriteLine(str3);
            #endregion

            #region Q8.Write a program that calculates the simple interest given the principal amount
            //bool flag;
            //double p, r, t, i;
            //do {
            //    Console.WriteLine("Enter principle amount :");
            //    flag = double.TryParse(Console.ReadLine(), out p);
            //}while (!flag);
            //flag = false;

            //do
            //{
            //    Console.WriteLine("Enter rate of interset amount :");
            //    flag = double.TryParse(Console.ReadLine(), out r);
            //} while (!flag);
            //flag = false;

            //do
            //{
            //    Console.WriteLine("Enter time amount :");
            //    flag = double.TryParse(Console.ReadLine(), out t);
            //} while (!flag);
            //flag = false;

            //i = (p * r * t) / 100;
            //Console.WriteLine($"Interset : {i}");


            #endregion

            #region Q9.Write a program that calculates the Body Mass Index 

            //bool flag1;
            //double w, h, BMI;
            //do
            //{
            //    Console.WriteLine("Enter weight amount :");
            //    flag1 = double.TryParse(Console.ReadLine(), out w);
            //} while (!flag1);
            //flag1 = false;

            //do
            //{
            //    Console.WriteLine("Enter height amount :");
            //    flag1 = double.TryParse(Console.ReadLine(), out h);
            //} while (!flag1);
            //flag1 = false;

            //BMI = (w) / (h * h);
            //Console.WriteLine($"BMI : {BMI}");

            #endregion

            #region Q10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good
            //bool flag5;
            //int temp;
            //do
            //{
            //    Console.WriteLine("Enter temp : ");
            //    flag5 = int.TryParse(Console.ReadLine(), out temp);

            //} while (!flag5);

            //string msg = temp < 10 ? "Just cold" : "just good or hot"; //The question indicates 3 cases but ternary only takes 2 conditions
            //Console.WriteLine(msg);
            #endregion

            #region Q11.Write a program that takes the date from the user and displays it in various formats using string interpolation

            //bool dayFlag;
            //int day;
            //do {
            //    Console.WriteLine("Enter day");
            //    dayFlag = int.TryParse(Console.ReadLine(), out day);
            //}while (!dayFlag || (day > 31 || day < 1));

            //bool monthFlag;
            //int month;
            //do
            //{
            //    Console.WriteLine("Enter month");
            //    monthFlag = int.TryParse(Console.ReadLine(), out month);
            //} while (!monthFlag || (month > 12 || month < 1));

            //bool yearFlag;
            //int year;
            //do
            //{
            //    Console.WriteLine("Enter year");
            //    yearFlag = int.TryParse(Console.ReadLine(), out year);
            //} while (!yearFlag || (year < 1));

            //string date1 = $"Today's date : {day}, {month}, {year}";
            //string date2 = $"Today's date : {day} / {month} / {year}";
            //string date3 = $"Today's date : {day}-{month}-{year}";

            //Console.WriteLine(date1);
            //Console.WriteLine(date2);
            //Console.WriteLine(date3);

            #endregion

            #region Q12.Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            //bool flagg;
            //int numm;
            //do
            //{
            //    Console.WriteLine("Enter number");
            //    flagg = int.TryParse(Console.ReadLine(), out numm);

            //} while (!flagg);
            //if (numm % 3 == 0 && numm % 4 == 0)
            //    Console.WriteLine("YES");
            //else
            // Console.WriteLine("NO");

            #endregion

            #region Q13.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive
            //bool negFlag;
            //int negNum;

            //do
            //{
            //    Console.WriteLine("Enter number");
            //    negFlag = int.TryParse(Console.ReadLine(), out negNum);
            //} while (!negFlag);

            //if (negNum > 0)
            //    Console.WriteLine("Positive");
            //else if (negNum < 0)
            //    Console.WriteLine("negative");
            //else
            //    Console.WriteLine("zero");
            #endregion

            #region Q14.Write a program that takes 3 integers from the user then prints the max element and the min element
            //int[] arr2 = new int[3];

            //for(int i = 0; i < 3; i++)
            //{
            //    bool arrayFlag;
            //    do {
            //        Console.WriteLine($"enter number #{i+1}");
            //        arrayFlag = int.TryParse(Console.ReadLine(), out arr2[i]);
            //    } while (!arrayFlag);
            //}

            //int maxx = arr2[0], minn = arr2[1];

            //for(int i = 0; i < 3; i++)
            //{
            //    if(arr2[i] < minn)
            //        minn = arr2[i];
            //    if(arr2[i] > maxx)
            //        maxx = arr2[i];
            //}

            //Console.WriteLine($"Max Element = {maxx}");
            //Console.WriteLine($"Min Element = {minn}");

            #endregion

            #region Q14(2).Write a program that allows the user to insert an integer number then check If a number is even or odd
            //int num101;
            //bool numFlag101;

            //do
            //{
            //    Console.WriteLine("Enter number");
            //    numFlag101 = int.TryParse(Console.ReadLine(), out num101);
            //} while (!numFlag101);

            //if (num101 % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            #endregion

            #region Q15.Write a program that takes character from the user then if it is a vowel chars 

            //char c100;
            //bool c100Flag;
            //do
            //{
            //    Console.WriteLine("enter a char to check if vowel");
            //    c100Flag = char.TryParse(Console.ReadLine(), out c100);
            //} while (!((c100 >= 'a' && c100 <= 'z') || (c100 >= 'A' && c100 <= 'Z')));
            //c100 = char.ToLower(c100);

            //if (c100 == 'a' || c100 == 'e' || c100 == 'i' || c100 == 'o' || c100 == 'u')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonent");
            #endregion

            #region Q16.Write a program to input the month number and print the number of days in that month
            //bool flag200;
            //int mo;

            //do
            //{
            //    Console.WriteLine("enter month number");
            //    flag200 = int.TryParse(Console.ReadLine(), out mo);
            //} while (!flag200 || !(mo >= 1 && mo <= 12));

            //switch (mo)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31 Days");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30 Days");
            //        break;

            //    case 2:
            //        Console.WriteLine("28 Days");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}
            #endregion

            #region Q17.Write a program to create a Simple Calculator
            //double l, r;
            //char op;
            //bool lflag, rflag, opflag;

            //do
            //{
            //    Console.WriteLine("Enter 1st number");
            //    lflag = double.TryParse(Console.ReadLine(), out l);
            //} while (!lflag);

            //do
            //{
            //    Console.WriteLine("Enter opertion");
            //    opflag = char.TryParse(Console.ReadLine(), out op);
            //} while (!opflag || !(op == '+' || op == '-' || op == '*' || op == '/'));


            //do
            //{
            //    Console.WriteLine("Enter 2nd number");
            //    rflag = double.TryParse(Console.ReadLine(), out r);
            //} while (!rflag);

            //if (op == '+')
            //    Console.WriteLine($"{l} + {r} = {l + r}");
            //else if (op == '-')
            //    Console.WriteLine($"{l} - {r} = {l - r}");
            //else if (op == '*')
            //    Console.WriteLine($"{l} x {r} = {l * r}");
            //else if (op == '/')

            //    if(r == 0)
            //    {
            //        Console.WriteLine("Cant divide by zero ");
            //    }else
            //        Console.WriteLine($"{l} / {r} = {l/r}");
            #endregion

            #region Q18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int n700;
            //bool n700flag;

            //do
            //{
            //    Console.WriteLine("Enter number");
            //    n700flag = int.TryParse(Console.ReadLine(), out n700);
            //} while (!n700flag);

            //for (int i = 1; i <= n700; i++)
            //    Console.WriteLine(i);
            #endregion

            #region Q19.Write a program that allows the user to insert an integer then print a multiplication table up to 12

            //int num800;
            //bool num800flag;
            //do
            //{
            //    Console.WriteLine("Enter a number to get multiplication table up to 12");
            //    num800flag = int.TryParse(Console.ReadLine(), out num800);
            //} while (!num800flag);

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(i * num800);
            //    Console.Write(" ");
            //}

            #endregion

            #region Q20.Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int n900;
            //bool n000flag;

            //do
            //{
            //    Console.WriteLine("Enter number");
            //    n000flag = int.TryParse(Console.ReadLine(), out n900);
            //} while (!n000flag);

            //for (int i = 1; i <= n900; i++)
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            #endregion

            #region Q21.Write a program that takes two integers then prints the power

            //int num102, num202;
            //bool flag102, flag202;

            //do
            //{
            //    Console.WriteLine("enter 1st number");
            //    flag102 = int.TryParse(Console.ReadLine(), out num102);
            //} while (!flag102);

            //do
            //{
            //    Console.WriteLine("enter 2nd number");
            //    flag202 = int.TryParse(Console.ReadLine(), out num202);
            //} while (!flag202);

            //int ans = 1;

            //for (int i = 0; i < num202; i++)
            //{
            //    ans *= num102;
            //}

            //Console.WriteLine(ans);
            #endregion

            #region Q22.Write a program to allow the user to enter int and print the REVERSED of it

            //int revNum;
            //bool f4;

            //do {
            //    Console.WriteLine("Enter a number");
            //    f4 = int.TryParse(Console.ReadLine(), out revNum);
            //} while (!f4);

            //string s4 = Convert.ToString(revNum);

            //if(revNum >= 0)
            //{
            //    for(int i = s4.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(s4[i]);
            //    }
            //}
            //else
            //{
            //    Console.Write('-');
            //    for (int i = s4.Length - 1 ; i > 0 ; i--)
            //    {
            //        Console.Write(s4[i]);
            //    }
            //}
            #endregion

            #region Q23.Write a program in C# Sharp to find prime numbers within a range of numbers
            //int start, end;
            //bool startFlag, endFlag;

            //do {
            //    Console.WriteLine("Enter positive starting number");
            //    startFlag = int.TryParse(Console.ReadLine(), out start);
            //} while (!startFlag || !(start > 0));

            //do
            //{
            //    Console.WriteLine("Enter negative starting number");
            //    endFlag = int.TryParse(Console.ReadLine(), out end);
            //} while (!endFlag || !(end > 0));

            //for(int i = start; i <= end; i++)
            //{
            //    int cnt = 0;
            //    for(int j = i; j >= 1; j--)
            //    {
            //        if (i % j == 0)
            //            cnt++;
            //    }
            //    if (cnt == 2)
            //    {
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //}
            #endregion

            #region Q24.Write a program in C# Sharp to convert a decimal number into binary without using an array

            //int decimalNum;
            //bool decimalNumFlag;

            //string binary = "";

            //do
            //{
            //    Console.WriteLine("Enter number");
            //    decimalNumFlag = int.TryParse(Console.ReadLine(), out decimalNum);

            //} while (!decimalNumFlag || !(decimalNum >= 0));

            //if (decimalNum == 0)
            //    Console.WriteLine(0);
            //else
            //{
            //    while (decimalNum > 0)
            //    {
            //        binary = (decimalNum % 2) + binary;
            //        decimalNum /= 2;
            //    }

            //    Console.WriteLine(binary);
            //}

            #endregion

            #region Q25.Write a program in C# Sharp to find the sum of all elements of the array
            //int sz, sum = 0;
            //bool szFlag;
            //do {
            //    Console.WriteLine("Enter size of array");
            //    szFlag = int.TryParse(Console.ReadLine(), out sz);
            //} while (!szFlag);

            //int[] arr13 = new int[sz];

            //for(int i = 0; i < sz; i++)
            //{
            //    bool arrayFlag;

            //    do {
            //        Console.WriteLine($"Enter Element #{i + 1} :");

            //        arrayFlag = int.TryParse(Console.ReadLine(), out arr13[i]);
            //    } while (!arrayFlag);

            //    sum += arr13[i];
            //}

            //Console.WriteLine($"Sum of array is : {sum} ");
            #endregion

        }
    }
}
