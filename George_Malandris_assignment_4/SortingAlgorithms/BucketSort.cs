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
    public class BucketSort : ITShirtSort
    {
        private Func<int, int, bool> _ordering;

        private Func<TShirt, TShirt, bool> _multiOrder;

        private OrderMethod _orderMethod;
        private OrderByProperty _orderBy;
        private bool _enableMulti;

        public BucketSort(OrderMethod order, OrderByProperty orderBy, bool multi = false)
        {
            if (order == OrderMethod.Descending)
            {
                _ordering = more;
                _multiOrder = multiMore;
            }
            else
            {
                _ordering = less;
                _multiOrder = multiLess;
            }
            _orderMethod = order;
            // Always use Size as the first property to order when multiple properties are enabled 
            // It defines the initialization of the buckets
            if (multi)
                _orderBy = OrderByProperty.Size;
            else
                _orderBy = orderBy;
            _enableMulti = multi;
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
        public void SortShirts(List<TShirt> shirts)
        {
            SortShirtsWithBuckets(shirts);
        }
        private void SortShirtsWithBuckets(List<TShirt> shirts)
        {
            List<TShirt> sortedList = new List<TShirt>();
            int numOfBuckets = 4;

            List<TShirt>[] buckets = new List<TShirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<TShirt>();
            }
            for (int i = 0; i < shirts.Count; i++)
            {
                int bucket = OrderBy(shirts[i]);
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(shirts[i]);
            }

            shirts.Clear();

            if(_orderMethod == OrderMethod.Ascending)
            {
                for (int i = 0; i < numOfBuckets; i++)
                {
                    List<TShirt> temp = new List<TShirt>();
                    if (_enableMulti)
                        temp = InsertionSortBucketMulti(buckets[i]);
                    else
                        temp = InsertionSortBucket(buckets[i]);
                    shirts.AddRange(temp);
                }
            }
            else
            {
                for (int i = numOfBuckets-1; i >= 0; i--)
                {
                    List<TShirt> temp = new List<TShirt>();
                    if (_enableMulti)
                        temp = InsertionSortBucketMulti(buckets[i]);
                    else
                        temp = InsertionSortBucket(buckets[i]);
                    shirts.AddRange(temp);
                }
            }
        }
        public bool more(int value1, int value2)
        {
            return value1 > value2;
        }
        private bool less(int value1, int value2)
        {
            return value1 < value2;
        }
        private List<TShirt> InsertionSortBucket(List<TShirt> shirts)
        {
            TShirt temp;
            for (int i = 1; i < shirts.Count; i++)
            {
                int currentValue = OrderBy(shirts[i]);
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (_ordering(currentValue, OrderBy(shirts[pointer])))
                    {
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }

            return shirts;
        }
        private List<TShirt> InsertionSortBucketMulti(List<TShirt> shirts)
        {
            TShirt temp;
            for (int i = 1; i < shirts.Count; i++)
            {
                TShirt currentShirt = shirts[i];
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (_multiOrder(currentShirt,shirts[pointer]))
                    {
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return shirts;
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
