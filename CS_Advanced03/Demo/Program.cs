namespace Demo
{
    public delegate int StringFuncDelegate(string word);
    // new delegate(class): Reference(Pointer) Can Refere To Function or More (Ppointers Of Functions)
    // These Funcrio Must Be Have The Same Signature Of The Delegate int(string)
    // Regardless Function Name, Parameter Name Or Access Modifier
    //delegate bool ConditionFuncDelegate(int x);
    delegate bool ConditionFuncDelegate<T>(T x);

    internal class Program
    {
        //static List<T> FindElements<T>(List<T> list, ConditionFuncDelegate<T> reference)
        //{
        //    List<T> result = new List<T>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //                result.Add(list[i]);
        //        }
        //    }
        //    return result;
        //}

        static List<T> FindElements<T>(List<T> list, Func<T, bool> reference)
        {
            List<T> result = new List<T>();
            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                        result.Add(list[i]);
                }
            }
            return result;
        }

        //static List<int> FindNumbers(List<int> list, ConditionFuncDelegate reference)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //                result.Add(list[i]);
        //        }
        //    }
        //    return result;
        //}
        #region Methods
        //static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 != 0)
        //                result.Add(list[i]);
        //        }
        //    }
        //    return result;
        //}
        //static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //                result.Add(list[i]);
        //        }
        //    }
        //    return result;
        //}
        //static List<int> FindDivisableBy4Numbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0)
        //                result.Add(list[i]);
        //        }
        //    }
        //    return result;
        //} 
        #endregion
        static void DisplayList<T>(ICollection<T> values)
        {
            if (values is not null)
            {
                foreach (var item in values)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            #region Delegate Ex01
            ////StringFuncDelegate func = new StringFuncDelegate( StringFunction.GetCountOfUpperChar );
            //StringFuncDelegate func = StringFunction.GetCountOfUpperChar; //Syntax Sugar
            //func = StringFunction.GetCountOfLowerChar;
            //string word = "Hello World";
            ////int result = func.Invoke(word);
            //int result = func(word);
            //Console.WriteLine(result); 
            #endregion

            #region Delegate Ex02 Without Generic
            //int[] numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4, 10 };
            //SortingAlgorithm.BubbleSort(numbers, SortingCondition.IsGreater);
            //DisplayList(numbers);
            //SortingAlgorithm.BubbleSort(numbers, SortingCondition.IsLess);
            //DisplayList(numbers); 
            #endregion

            #region Delegate Ex02 With Generic
            //string[] names = { "Omar", "Abdelrahman", "Ali", "Toqa", "Aya" };
            //SortingAlgorithm.BubbleSort(names,SortingCondition.IsLengthGrt);
            //DisplayList(names);
            //SortingAlgorithm.BubbleSort(names,SortingCondition.IsLengthLess);
            //DisplayList(names);
            //Array.Sort(names);
            //DisplayList(names); 
            #endregion

            #region Delegate Ex03
            //List<int> numbers = new List<int>(Enumerable.Range(1,100));
            //List<int> numbers = Enumerable.Range(1,100).ToList();
            //List<int> oddNumbers = FindOddNumbers(numbers);
            //DisplayList(oddNumbers);
            //List<int> evenNumbers = FindEvenNumbers(numbers);
            //DisplayList(evenNumbers);
            //List<int> result = FindDivisableBy4Numbers(numbers);
            //DisplayList(result);

            //List<int> numbers = Enumerable.Range(1,100).ToList();
            //List<int> oddNumbers = FindNumbers(numbers, ConditionFunctions.IsOdd);
            //DisplayList(oddNumbers);
            //List<int> evenNumbers = FindNumbers(numbers, ConditionFunctions.IsEven);
            //DisplayList(evenNumbers);
            //List<int> result = FindNumbers(numbers, ConditionFunctions.DivisableBy4);
            //DisplayList(result);
            //result = FindNumbers(numbers, ConditionFunctions.DivisableBy8);
            //DisplayList(result); 
            #endregion

            #region Delegate Ex03 With Generic
            //List<string> names = new List<string>() { "Omar", "Abdelrahman", "Ali", "Toqa", "Aya" };
            //List<string> result = FindElements(names, SortingCondition.CheckLengthGrt4);
            //DisplayList(result);
            //result = FindElements(names, SortingCondition.CheckLengthEqual4);
            //DisplayList(result);
            #endregion

            #region Built-in Delegates
            //// Built-in Delegates
            ////  predicate - Func - Action

            //// predicate
            ////ConditionFuncDelegate<int> x = ConditionFunctions.IsEven;  
            //Predicate<int> x = ConditionFunctions.IsEven;

            //// Func
            ////Func<int> func = Fun01;
            //Func<int,bool> func = ConditionFunctions.IsOdd;

            //// Action
            //Action action = Fun02;
            //action(); 
            #endregion

            #region Lamda Expression
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////Func<int, bool> func = ConditionFunctions.IsEven;
            ////Func<int, bool> func = delegate (int x) { return x % 2 == 0; };

            ////List<int> result = FindElements(list, delegate (int x) { return x % 2 == 0; });

            ////DisplayList(result);

            //// Lamda Expression

            ////Func<int, bool> func = (int x) => { return x % 2 == 0; };
            //Func<int, bool> func = x => x % 2 == 0; 

            //List<int> result = FindElements(list, x => x % 2 == 0);

            //DisplayList(result); 
            #endregion


         

        }

        static int Fun01()
        {
            return 0;
        }
        static void Fun02()
        {
            Console.WriteLine("Hello World");
        }
    }
}
