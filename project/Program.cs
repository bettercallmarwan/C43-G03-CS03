namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //bool flag;
            //int x;
            //do
            //{
            //    Console.WriteLine("Enter a number");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //} while (!flag);

            //Console.WriteLine(x);
            #endregion

            #region Q2
            //string s = Console.ReadLine();
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(n);
            //// It will result to a run-time error, because the entered string is not in the same format (numbers)
            //// So we must enter a string number in order to convert it to int
            #endregion

            #region Q3
            //double f1 = 0.5, f2 = 1.1;
            //f1 += f2; // Added the value of f2 to f1 which replaces the value of old f1 in stack
            //Console.WriteLine(f1); 
            //// I am not sure if this what the question mean
            #endregion

            #region Q4
            //string s1 = "Hello, world";
            //string s2 = s1.Substring(3, 5); // Starting from idx 3 (second 'l'), to length 5 from that idx (lo, w)
            //Console.WriteLine(s2);
            #endregion

            #region Q5
            //int a = 1; // Assigning var a = 1
            //int b = a; // Assigning var b = a

            //a++;  // Incrementing the value of a will increase the value of a by one (2)
            //      // Although var b = var a, but it's value wont be affected
            //      // Bec when making b equals a, this means taking a copy of value from a and assigning it to b, so they dont share the same object

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region Q6
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

            #region Q7
            //Console.WriteLine("enter 1st string");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("enter 2nd string");
            //string str2 = Console.ReadLine();

            //string str3 = str1 + str2;

            //Console.WriteLine(str3);
            #endregion

            #region Q8
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

            #region Q9

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

            #region Q10
            bool flag5;
            int temp;
            do
            {
                Console.WriteLine("Enter temp : ");
                flag5 = int.TryParse(Console.ReadLine(), out temp);

            } while (!flag5);

            string msg = temp < 10 ? "Just cold" : "just good or hot"; //The question indicates 3 cases but ternary only takes 2 conditions
            Console.WriteLine(msg);
            #endregion
        }
    }
}
