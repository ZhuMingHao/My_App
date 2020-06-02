using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_App.Models
{
    public class ListItem
    {
        public string BookTitle { get; set; }
    }

    public class ItemManager
    {
        public static List<ListItem> GetListItems()
        {
            var items = new List<ListItem>
            {
                new ListItem { BookTitle = "The Wizard of Oz" }
            };

            return items;
        }
    }
}
