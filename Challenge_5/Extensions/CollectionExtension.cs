using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Extensions
{
    public static class CollectionExtension
    {



        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> collection)
        {
            return new ObservableCollection<T>(collection);
        }





        public static ObservableCollection<T> CloneObservableCollection<T>(this ObservableCollection<T> collection)
        {
            ObservableCollection<T> items = new ObservableCollection<T>();

            foreach (var item in collection)
            {
                if (item is ICloneable newItemClonable)
                {
                    items.Add((T)newItemClonable.Clone());
                }
            }
            return items;
        }



    }
    
}
