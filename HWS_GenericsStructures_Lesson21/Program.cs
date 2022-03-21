using System;
using System.Collections.Generic;

namespace HWS_GenericsStructures_Lesson21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            int x = myDict[3];
            myDict.TryGetValue(4, out x);
            myDict.TryAdd(5, 13);
            MyClass myClass = new MyClass();
            MyClass myClass1 = new MyClass();
            Console.WriteLine(myClass.GetHashCode()); //1
            Console.WriteLine(myClass1.GetHashCode());//1
            Dictionary<MyClass, int> keyValuePairs = new Dictionary<MyClass, int>();
            keyValuePairs.Add(myClass, 3);
            keyValuePairs.Add(myClass1, 13);
            #endregion

            #region Library

            MyLibrary myLibrary = new MyLibrary();
            myLibrary.Add("123", null);

            #endregion
        }
    }

    class MyClass
    {
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
