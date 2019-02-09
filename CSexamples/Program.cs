using System;
using System.Collections.Generic;

namespace CSexamples
{
    class Program
    {
        static void Main(string[] args)
        {
          //  GetBinarySearchRecursive();

           BinarySearch();

            // Console.Write("List exclusion: ");
            // ItemsNotInBothLists();

            // Console.WriteLine();
            // BubbleSort2();

            //  InBothLists();

            ///   Distinct();

            // WeirdSort();
        }


        static void GetBinarySearchRecursive()
        {
            var list = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 11, 23, 44, 66, 77, 88, 99, 101, 102, 104, 170, 344, 445, 565, 673, 733, 874, 912, 1001, 1120 };
            int searchTerm = 102;
            int start = 0;
            int end = list.Length;

            var RecordNo = BinarySearchRecursive(ref list, start, end, searchTerm);

            if (RecordNo == -1)
            {
                Console.WriteLine("Record not found");
                return;
            }

            Console.WriteLine($"Seatch Term: {searchTerm}   Record Position: {RecordNo},  Value: {list[RecordNo]}");
        }

        static int BinarySearchRecursive(ref int[] terms, int start, int end,  int searchterm)
        {
            int mid = ((end - start) / 2) + start;
            int result = terms[mid];

            if (result == searchterm)
                return mid;

           start = (searchterm < result) ? start : start + ((end - start) / 2);
           end = (searchterm < result) ? end - ((end - start) / 2) : end;           

            if (Math.Abs(start - end) == 1 &&  mid != 1)
                return -1;

           return BinarySearchRecursive(ref terms,  start,  end,  searchterm);
        }


        static void BinarySearch()
        {
            // sort array
            var list = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 23, 44, 66, 77, 88, 99, 101, 102, 104, 170, 344, 445, 565, 673, 733, 874, 912, 1001, 1120 };
            var searchTerm = 9999;
            int result = -1; //assume is all postive numbers
            var start = 0;
            var end = list.Length;
            int RecordPosition = -1;

            while (searchTerm != result)
            {
                int mid = ((end - start) / 2) + start;
                result = list[mid];

                RecordPosition = mid; // will be last one tested;

                start = (searchTerm < result) ? start : start + ((end - start) / 2);
                end = (searchTerm < result) ? end - ((end - start) / 2) : end;

                if (searchTerm != result && Math.Abs(start - end) == 1 && mid != 1)
                {
                    result = -1;
                    Console.WriteLine($"Seatch Term: {searchTerm} NOT Found!");
                    return;
                }

            }

            Console.WriteLine($"Seatch Term: {searchTerm}   Record Position: {RecordPosition},  Value: {list[RecordPosition]}");
        }

        static void WeirdSort()
        {
            int[] allList = new[] { 1, 2, 3, 4, 6, 7, 7, 8, 8, 75, 4, 4, 3, 3, 3, 3, 4, 56, 6, 7, 7, 6, 4, 3, 2, 35, 56, 56, 56, 5, 77 };

            int[] presort = new int[allList.Length];

            for(var i=0; i< allList.Length; i++ )
            {

            }

            foreach (var b in allList)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine();

        }

        static void Distinct()
        {
            int[] allList = new[] { 1, 2, 3, 4, 6, 7, 7, 8, 8, 75, 4, 4, 3, 3, 3, 3, 4, 56, 6, 7, 7, 6, 4, 3, 2, 35, 56, 56, 56, 5, 77 };

            List<int> distinct = new List<int>();

            foreach(var i in allList)
            {
                bool canAdd = true;

                foreach (var v in distinct)
                {
                    if (v == i)
                    {
                        canAdd = false;
                    }

                    if (!canAdd)
                        break;
                }

                if (canAdd)
                    distinct.Add(i);
            }

            foreach (var b in distinct)
            {
                Console.Write(b + " ");
            }

            Console.WriteLine();

        }

        static void BubbleSort2()
        {
            // int[] arr = { 6, 77, 1, 555, 56, -1, 7, 800, 11, 50, 771, 649, 770, 240, 9 };
            int[] arr = { 10, 6, 8, 4, 5 };
            int temp;

            int count = 0;
            bool haschanges = true;
            for (var i = 0; i < arr.Length; i++)
            {
               // count++;
                haschanges = false;
                for (var sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;

                        haschanges = true;
                       
                    }
                    count++;
                }
                Console.Write($"Has Changres : {haschanges} Count : {count}  Current List: ");
                for (int p = 0; p < arr.Length; p++)
                    Console.Write(arr[p] + " ");

                Console.WriteLine();

                if (!haschanges)
                    break;

            }


            for (int p = 0; p < arr.Length; p++)
                Console.Write(arr[p] + " ");

        }


        static void BubbleSort()
        {
            int[] arr = { 6, 77,1,555,56,-1,7, 800, 11, 50, 771, 649, 770, 240, 9 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();

        }


      

        static void ItemsNotInBothLists()
        {

            int[] first = new[] { 1, 2, 3, 4, 6, 7, 7, 8, 8, 75, 4, 4, 3, 3, 3, 3, 4, 56, 6, 7, 7, 6, 4, 3, 2, 35, 56, 56, 56, 5, 77 };

            int[] second = new[] { 1, 3, 5 };


            List<int> SecNotInFirst = new List<int>();

            foreach (var i in first)
            {
                var ok = true;

                foreach (var v in second)
                {
                    if (i == v)
                        ok = false;             
                }

                if (ok)
                    SecNotInFirst.Add(i);

            }
            
            for (int i = 0; i < SecNotInFirst.Count; i++)
                Console.Write(SecNotInFirst[i] + " ");

        }

    }
}
