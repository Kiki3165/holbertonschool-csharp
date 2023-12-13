using System.Collections;
    class List
    {
        public static int Sum(List<int> myList)
        {
            var set = new HashSet<int>{myList};
            Console.WriteLine(string.Join(",", set));
            return set;
        }
    }
