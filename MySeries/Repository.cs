using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQL;

namespace MySeries.Classes
{
    public class Repository
    {
        private string table;
        private List<Artwork> list;

        public Repository(string table)
        {
            this.table = table;
            list = new List<Artwork>();
        }

        public Repository(List<Artwork> list)
        {
            this.list = list;
        }

        public void add(Artwork element)
        {
            if (!list.Contains(element))
            {
                list.Add(element);
                InsertToDatabaseTable(element);
            }
        }

        public void eliminate(Artwork element)
        {
            if (list.Contains(element))
            {
                list.Remove(element);
                RebuildDatabaseTable();
            }
        }

        public ReadOnlyCollection<Artwork> getList()
        {
            return list.AsReadOnly();            
        }

        public void overwrite(Artwork oldElement, Artwork newElement)
        {
            int index = list.IndexOf(oldElement);
            if (index != -1)
            {
                list[index] = newElement;
                RebuildDatabaseTable();
            }
        }

        private void InsertToDatabaseTable(Artwork element)
        {
            SQLConnection.ExecuteNonQuery($"INSERT INTO {table} VALUES {element.ToString()}");
        }

        private void ClearDatabaseTable()
        {
            SQLConnection.ExecuteNonQuery($"TRUNCATE TABLE {table}");
        }

        private void FillDatabaseTable()
        {
            foreach (Artwork element in list)
            {
                InsertToDatabaseTable(element);
            }
        }

        private void RebuildDatabaseTable()
        {
            ClearDatabaseTable();
            FillDatabaseTable();
        }
    }
}
