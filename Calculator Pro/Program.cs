using System;
using System.Collections.Generic;
using System.Threading;

namespace CalculatorPro
{
    public class MyClass
    {
        public IList<string> List { get; set; }
        public IEnumerable<string> BasicList { get; set; }
    }

    public delegate void bankMessage(string message);
    public class Bank
    {
        int sum;
        bankMessage bankMessage;
        
        public void bankMessageMethod(bankMessage bankMessage1)
        {
            bankMessage = bankMessage1;
        }
        public Bank(int bankSum)
        {
            sum = bankSum;
        }

        public void put(int putSum)
        {
            sum += putSum;
            bankMessage($"На счет положено {sum}");
        }

        public void withdraw(int withdrawSum)
        {
            if(sum >= withdrawSum)
            {
                sum -= withdrawSum;
                bankMessage($"С счета снали {sum}");
            }
            else
            {
                bankMessage($"На счете не хватет средств");
            }
            
        }
    }
    
    class Program
    {
        delegate int DelegateSum(int x, int y);
        delegate int DelegateMult(int x, int y);
        delegate void DelegateMessage();
        static public void messageMethod()
        {
            Console.WriteLine("Message");
        }

        static public int methodSum(int x, int y)
        {
            return x + y;

        }

        static public int methodMult(int x, int y)
        {
            return x * y;
        }

        static void Main()
        {
            var aobj = new MyClass();

            aobj.List = new List<string>();

            aobj.List.Add("1asfsdfg");
            aobj.List.Add("sdfsdf2");
            aobj.List.Add("sdfsdfsdf");

            DelegateMessage delegateMessage;
            delegateMessage = messageMethod;
            delegateMessage.Invoke();

            DelegateSum delegateSum;
            delegateSum = methodSum;
            int result = delegateSum.Invoke(4, 5);
            Console.WriteLine($"Результат {result}");

            DelegateMult delegateMult;
            delegateMult = methodMult;
            result = delegateSum.Invoke(4, 5);
            Console.WriteLine($"Результат {result}");

            Bank bank = new Bank(1000);
            bank.bankMessageMethod(displayMessage);
            bank.put(300);
            bank.withdraw(1000);
            bank.withdraw(400);

            static void displayMessage(string message)
            {
                Console.WriteLine(message);
            }

        }
    }
}
