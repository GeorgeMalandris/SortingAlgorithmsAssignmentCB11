using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Intefaces;
using George_Malandris_assignment_4.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4.SortingAlgorithms
{
    public class BubbleSort : ITShirtSort
    {
        private Func<int, int, bool> _ordering;

        private Func<TShirt, TShirt, bool> _multiOrder;

        private OrderByProperty _orderBy;
        private bool _enableMulti;

        public BubbleSort(OrderMethod order, OrderByProperty orderBy, bool multi = false)
        {
            if (order == OrderMethod.Descending)
            {
                _ordering = less;
                _multiOrder = multiLess;
            }
            else
            {
                _ordering = more;
                _multiOrder = multiMore;
            }
            _orderBy = orderBy;
            _enableMulti = multi;
        }

        public void SortShirts(List<TShirt> shirts)
        {
            if (_enableMulti)
                MultipleSortShirts(shirts);
            else
                SortShirtsByProperty(shirts);
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
        private void SortShirtsByProperty(List<TShirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            TShirt temp;
            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (_ordering(OrderBy(shirts[j]), OrderBy(shirts[j + 1])))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp; 
                    }
                }
            }
        }
        private void MultipleSortShirts(List<TShirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            TShirt temp;

            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (_multiOrder(shirts[j], shirts[j + 1]))
                    {
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }
        private bool multiMore(TShirt s1, TShirt s2)
        {
            if ((int)s1.Size > (int)s2.Size)
                return true;
            if ((int)s1.Size < (int)s2.Size)
                return false;
            if ((int)s1.Color > (int)s2.Color)
                return true;
            if ((int)s1.Color < (int)s2.Color)
                return false;
            if ((int)s1.Fabric > (int)s2.Fabric)
                return true;
            else
                return false;
        }
        private bool multiLess(TShirt s1, TShirt s2)
        {
            if ((int)s1.Size < (int)s2.Size)
                return true;
            if ((int)s1.Size > (int)s2.Size)
                return false;
            if ((int)s1.Color < (int)s2.Color)
                return true;
            if ((int)s1.Color > (int)s2.Color)
                return false;
            if ((int)s1.Fabric < (int)s2.Fabric)
                return true;
            else
                return false;
        }
    }
}
