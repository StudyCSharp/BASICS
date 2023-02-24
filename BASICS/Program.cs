/*
 * C# BASICS https://www.youtube.com/watch?v=IFayQioG71A
 * 
 * Variables
 * Functions
 * Conditions
 * Collections
 * Loops
 * Comments
 * Enums
 * Classes
 * Acessors
 * Scope
*/

namespace BASICS
{
    class Program
    {
        // Enums
        enum PlayerState
        {
            Attacking,
            Idle
        }
        static PlayerState playerState = PlayerState.Idle;

        static int scopeIndex;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Variables
            int intVar = 1;
            Console.WriteLine("This is int variable: " + intVar);

            // Functions ( class function )
            FirstFunction();
            SecondFunction();

            // Conditions
            int what = 5;
            if (what > 1)
            {
                Console.WriteLine("true!");
            } else
            {
                Console.WriteLine("false!");
            }

            // Collections
            int[] intArray = new int[] { 1, 2, 3, 4, 5};
            List<int> intList = new List<int>() { 1, 2, 3 };
            intList.Add(4);

            // Loops
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            int index = 0;
            while (index < intList.Count)
            {
                Console.WriteLine(intList[index]);
                index++;
            }

            int idx = 0;
            do
            {
                idx++;
            } while (idx < intList.Count);

            // Comments
            // Enums
            switch (playerState)
            {
                case PlayerState.Attacking:
                    Console.WriteLine("Attacking!");
                    break;
                case PlayerState.Idle:
                    Console.WriteLine("Idle.");
                    break;
                default:
                    break;
            }

            MyClass myClass = new MyClass();
            myClass.TestFunction();
            // Accessors
            // myClass.PrivateFunction();

            TestScopeFunction();

            Console.ReadKey();
        }

        class MyClass
        {
            float myFloat;
            int myInt;

            public MyClass()
            {
                // Custom constructor
            }

            public void TestFunction()
            {
                // Do something
            }
            
            private void PrivateFunction()
            {
                // Private
            }
        }

        // Scope
        static void TestScopeFunction()
        {
            scopeIndex++;
        }

        static void FirstFunction()
        {
            Console.WriteLine("This is first class function!");
        }

        static void SecondFunction()
        {
            Console.WriteLine("This is second class function!");
        }
    }
}
