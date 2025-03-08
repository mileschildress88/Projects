using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public int ItemNo;
        public string Description;
        public decimal Price;


        public InvItem()
        {

        }

        public InvItem(int intItemNo, string strDescription, decimal decPrice)
        {
            this.ItemNo = intItemNo;
            this.Description = strDescription;
            this.Price = decPrice;
        }

        public string GetDisplayText()
        {
            return ItemNo + "    " + Description + " " + "(" + Price.ToString("C") + ")";

        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
