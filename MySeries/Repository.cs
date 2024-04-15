using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MySeries.Classes
{
    public class Repository<T>
    {
        private List<T> list;

        public Repository() 
        {
            list = new List<T>();
        }

        public Repository(List<T> list)
        {
            this.list = list;
        }

        public void add(T element)
        {
            list.Add(element);
        }

        public void eliminate(T element)
        {
            if (list.Contains(element))
            {
                list.Remove(element);
            }
        }

        public ReadOnlyCollection<T> getList()
        {
            return list.AsReadOnly();            
        }

        //todo: update(T element)
    }
}
