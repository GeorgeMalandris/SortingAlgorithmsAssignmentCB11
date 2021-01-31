using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Intefaces;
using George_Malandris_assignment_4.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCB11.SortingAlgorithms
{
    public class QuickSort : ITShirtSort
    {
        private Func<int, int, bool> _firstOrder;
        private Func<int, int, bool> _secondOrder;

        private Func<TShirt, TShirt, bool> _firstMulti;
        private Func<TShirt, TShirt, bool> _secondMulti;

        private OrderByProperty _orderBy;
        private bool _enableMulti;

        public QuickSort(OrderMethod order, OrderByProperty orderBy, bool multi = false)
        {
            if (order == OrderMethod.Descending)
            {
                _firstMulti = moreMulti;
                _secondMulti = lessMulti;
                _firstOrder = more;
                _secondOrder = less;
            }
            else
            {
                _firstMulti = lessMulti;
                _secondMulti = moreMulti;
                _firstOrder = less;
                _secondOrder = more;
            }
            _orderBy = orderBy;
            _enableMulti = multi;
        }

        public void SortShirts(List<TShirt> shirts)
        {
            if (_enableMulti)
                QuicksortMulti(shirts, 0, shirts.Count - 1);
            else
                Quicksort(shirts, 0, shirts.Count - 1);
        }
        private bool less(int value1, int value2)
        {
            return value1 < value2;
        }
        private bool more(int value1, int value2)
        {
            return value1 > value2;
        }
        private int OrderBy(TShirt shirt)
        {
            switch (_orderBy)
            {
                case (OrderByProperty.Color):
                    return (int)shirt.Color;
                case (OrderByProperty.Fabric):
                    return (int)shirt.Fabric;
                default:
                    return (int)shirt.Size;
            }
        }
        private void Quicksort(List<TShirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2];

            while(i <= j)
            {
                while (_firstOrder(OrderBy(shirts[i]),OrderBy(pivot)))
                    i++;
                while (_secondOrder(OrderBy(shirts[j]), OrderBy(pivot)))
                    j--;

                if (i <= j)
                {
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort(shirts, left, j);
            if (i < right)
                Quicksort(shirts, i, right);
        }
        private void QuicksortMulti(List<TShirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2];

            while (i <= j)
            {
                while (_firstMulti(shirts[i],pivot))
                    i++;
                   
                while (_secondMulti(shirts[j],pivot))
                    j--;

                if (i <= j)
                {
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortMulti(shirts, left, j);
            if (i < right)
                QuicksortMulti(shirts, i, right);
        }
        private bool lessMulti(TShirt a, TShirt b)
        {
            if ((int)a.Size < (int)b.Size)
                return true;
            if ((int)a.Size > (int)b.Size)
                return false;
            if ((int)a.Color < (int)b.Color)
                return true;
            if ((int)a.Color > (int)b.Color)
                return false;
            if ((int)a.Fabric < (int)b.Fabric)
                return true;
            else
                return false;
        }
        private bool moreMulti(TShirt a, TShirt b)
        {
            if ((int)a.Size > (int)b.Size)
                return true;
            if ((int)a.Size < (int)b.Size)
                return false;
            if ((int)a.Color > (int)b.Color)
                return true;
            if ((int)a.Color < (int)b.Color)
                return false;
            if ((int)a.Fabric > (int)b.Fabric)
                return true;
            else
                return false;
        }
    }
}
