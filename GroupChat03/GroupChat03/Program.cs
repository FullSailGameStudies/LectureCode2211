using System.Collections.Generic;

namespace GroupChat03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dc = new() { "Joker", "Wonder Woman", "Batman", "Superman", "Aquaman", "Batwoman", "Flash", "Riddler", "Penguin", "Catwoman", "Poison Ivy", "Bizarro", "Bane", "Alfred", "James Gordon", "Green Lantern", "Cyborg",  "Batgirl", "Beast Boy" };

            List<string> sorted = BubbleSort(dc, out int numberOfLoops);
            for (int i = 0; i < dc.Count; i++)
            {
                Console.Write(dc[i]);
                Console.CursorLeft = 25;
                Console.WriteLine(sorted[i]);
            }
            Console.WriteLine($"number of DC characters: {dc.Count}. number of bubble sort loops: {numberOfLoops}");
        }

        static List<string> BubbleSort(List<string> unsorted, out int loops)
        {
            loops = 0;
            List<string> sorted = unsorted.ToList();
            int itemCountToSort = sorted.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= itemCountToSort-1; i++)
                {
                    if (sorted[i - 1].CompareTo(sorted[i]) > 0)
                    {
                        (sorted[i - 1], sorted[i]) = (sorted[i], sorted[i - 1]);
                        swapped = true;
                    }
                    loops++;
                }
                --itemCountToSort;
            } while (swapped);
            return sorted;
        }
    }
}


//procedure bubbleSort(A : list of sortable items)
// n:= length(A)
// repeat
//  swapped := false
//  for i := 1 to n - 1 inclusive do
//        if A[i - 1] > A[i] then
//          swap(A, i - 1, i)
//          swapped = true
//        end if
//  end for
//  n := n - 1
// while swapped
//end procedure