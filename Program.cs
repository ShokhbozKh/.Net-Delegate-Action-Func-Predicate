namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //action-- qiymay qaytarmasa
            Action action = ActionDelegate;
            action();// 1 usul
            action.Invoke();// 2 usul

            //function-- qiymat qaytarsa
            // parametrlar va oxirgi verguldan keyin qaytuchi qiymat type i
            Func<int,int,float> func = FuncDelegate;
            Console.WriteLine(func(2, 4));

            //predicate-- faqat bool qaytarsa
            Predicate<int> predicate =(IsOdd);
            Console.WriteLine(predicate(5));
        }
        static void ActionDelegate()
        {
            Console.WriteLine("Bu delegat qiymat qaytarmaydi..");
        }
        static float FuncDelegate(int n, int m)
        {
            return (n+m);
        }
        static bool IsOdd(int n)
        {
            return (n%2==1);
        }
    }
}