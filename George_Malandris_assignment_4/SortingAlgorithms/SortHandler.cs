using George_Malandris_assignment_4.Intefaces;
using George_Malandris_assignment_4.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4.SortingAlgorithms
{
    public class SortHandler
    {
        private ITShirtSort _sorter;
        private List<TShirt> _unsortedList;

        public SortHandler(ITShirtSort sorter, List<TShirt> unsortedList)
        {
            _sorter = sorter;
            _unsortedList = unsortedList;
        }

        public void Sort()
        {
            _sorter.SortShirts(_unsortedList);
        }

    }
}
