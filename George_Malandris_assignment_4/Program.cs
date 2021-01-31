using George_Malandris_assignment_4.CheckOut;
using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Intefaces;
using George_Malandris_assignment_4.Interfaces;
using George_Malandris_assignment_4.Products;
using George_Malandris_assignment_4.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            var unsortedList = new List<TShirt>(db.TShirts);

            Console.WriteLine("Unsorted List:\n");
            foreach (var shirt in unsortedList)
            {
                shirt.Output();
            }

            ITShirtSort bubbleSortAscBySize = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Size, false);
            ITShirtSort bubbleSortDescBySize = new BubbleSort(OrderMethod.Descending, OrderByProperty.Size, false);
            ITShirtSort bubbleSortAscByColor = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Color, false);
            ITShirtSort bubbleSortDescByColor = new BubbleSort(OrderMethod.Descending, OrderByProperty.Color, false);
            ITShirtSort bubbleSortAscByFabric = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Fabric, false);
            ITShirtSort bubbleSortDescByFabric = new BubbleSort(OrderMethod.Descending, OrderByProperty.Fabric, false);
            ITShirtSort bubbleSortAscAll = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Size, true);
            ITShirtSort bubbleSortDescAll = new BubbleSort(OrderMethod.Descending, OrderByProperty.Size, true);

            ITShirtSort quickSortAscBySize = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Size, false);
            ITShirtSort quickSortDescBySize = new BubbleSort(OrderMethod.Descending, OrderByProperty.Size, false);
            ITShirtSort quickSortAscByColor = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Color, false);
            ITShirtSort quickSortDescByColor = new BubbleSort(OrderMethod.Descending, OrderByProperty.Color, false);
            ITShirtSort quickSortAscByFabric = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Fabric, false);
            ITShirtSort quickSortDescByFabric = new BubbleSort(OrderMethod.Descending, OrderByProperty.Fabric, false);
            ITShirtSort quickSortAscAll = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Size, true);
            ITShirtSort quickSortDescAll = new BubbleSort(OrderMethod.Descending, OrderByProperty.Size, true);

            ITShirtSort bucketSortAscBySize = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Size, false);
            ITShirtSort bucketSortDescBySize = new BubbleSort(OrderMethod.Descending, OrderByProperty.Size, false);
            ITShirtSort bucketSortAscByColor = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Color, false);
            ITShirtSort bucketSortDescByColor = new BubbleSort(OrderMethod.Descending, OrderByProperty.Color, false);
            ITShirtSort bucketSortAscByFabric = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Fabric, false);
            ITShirtSort bucketSortDescByFabric = new BubbleSort(OrderMethod.Descending, OrderByProperty.Fabric, false);
            ITShirtSort bucketSortAscAll = new BubbleSort(OrderMethod.Ascending, OrderByProperty.Size, true);
            ITShirtSort bucketSortDescAll = new BubbleSort(OrderMethod.Descending, OrderByProperty.Size, true);

            SortHandler sorter0 = new SortHandler(bubbleSortAscBySize, unsortedList);
            SortHandler sorter1 = new SortHandler(bubbleSortDescBySize, unsortedList);
            SortHandler sorter2 = new SortHandler(bubbleSortAscByColor, unsortedList);
            SortHandler sorter3 = new SortHandler(bubbleSortDescByColor, unsortedList);
            SortHandler sorter4 = new SortHandler(bubbleSortAscByFabric, unsortedList);
            SortHandler sorter5 = new SortHandler(bubbleSortDescByFabric, unsortedList);
            SortHandler sorter6 = new SortHandler(bubbleSortAscAll, unsortedList);
            SortHandler sorter7 = new SortHandler(bubbleSortDescAll, unsortedList);

            SortHandler sorter8 = new SortHandler(quickSortAscBySize, unsortedList);
            SortHandler sorter9 = new SortHandler(quickSortDescBySize, unsortedList);
            SortHandler sorter10 = new SortHandler(quickSortAscByColor, unsortedList);
            SortHandler sorter11 = new SortHandler(quickSortDescByColor, unsortedList);
            SortHandler sorter12 = new SortHandler(quickSortAscByFabric, unsortedList);
            SortHandler sorter13 = new SortHandler(quickSortDescByFabric, unsortedList);
            SortHandler sorter14 = new SortHandler(quickSortAscAll, unsortedList);
            SortHandler sorter15 = new SortHandler(quickSortDescAll, unsortedList);

            SortHandler sorter16 = new SortHandler(bucketSortAscBySize, unsortedList);
            SortHandler sorter17 = new SortHandler(bucketSortDescBySize, unsortedList);
            SortHandler sorter18 = new SortHandler(bucketSortAscByColor, unsortedList);
            SortHandler sorter19 = new SortHandler(bucketSortDescByColor, unsortedList);
            SortHandler sorter20 = new SortHandler(bucketSortAscByFabric, unsortedList);
            SortHandler sorter21 = new SortHandler(bucketSortDescByFabric, unsortedList);
            SortHandler sorter22 = new SortHandler(bucketSortAscAll, unsortedList);
            SortHandler sorter23 = new SortHandler(bucketSortDescAll, unsortedList);

            // Use a sorter between 0 and 23 to view the sorted list
            sorter0.Sort();

            Console.WriteLine("\nSorted List:\n");
            foreach (var shirt in unsortedList)
            {
                shirt.Output();
            }
        }
    }
}