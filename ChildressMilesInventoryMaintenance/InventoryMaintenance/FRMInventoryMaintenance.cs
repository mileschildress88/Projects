using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class FRMInventoryMaintenance : Form
	{
		public FRMInventoryMaintenance()
		{
			InitializeComponent();
		}

		// Add a statement here that declares the list of items.
		public List<InvItem> invItems = null;

		private void FRMInvMaint_Load(object sender, System.EventArgs e)
		{
			// Add a statement here that gets the list of items.
			invItems = InvItemDB.GetItems();
			FillItemListBox();
		}

		private void FillItemListBox()
		{
			LBXItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
			foreach(InvItem item in invItems)
			{
				LBXItems.Items.Add(item.GetDisplayText());
			}
		}

		private void BTNAdd_Click(object sender, System.EventArgs e)
		{
            // Add code here that creates an instance of the New Item form
			FRMNewItem frmNewItem = new FRMNewItem();
			// and then gets a new item from that form.
			InvItem invItem = frmNewItem.GetNewItem();

			if(invItem != null)
			{
				invItems.Add(invItem);
				InvItemDB.SaveItems(invItems);

				FillItemListBox();
			}
		}

		private void BTNDelete_Click(object sender, System.EventArgs e)
		{
			int i = LBXItems.SelectedIndex;
			if (i != -1)
			{
                // Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.

				if(MessageBox.Show("Are you sure you would like to delete " + LBXItems.Items[i].ToString() + "?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					invItems.RemoveAt(LBXItems.SelectedIndex);
					InvItemDB.SaveItems(invItems);
					FillItemListBox();
				}
			}
		}

		private void BTNExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}