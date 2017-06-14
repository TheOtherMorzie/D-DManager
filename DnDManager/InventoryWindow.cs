using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDManager
{
	public partial class InventoryWindow : Form
	{
		public InventoryWindow()
		{
			InitializeComponent();
		}

		public InventoryWindow(Form1 parent)
		{
			InitializeComponent();
			m_parent = parent;
		}

		public void updateForm()
		{

			if (m_items.Count > 0)
			{
				foreach (var item in m_items)
				{
					item.m_selector.Parent = flowLayoutPanel1;
					item.m_selector.Width = (flowLayoutPanel1.Width / 16) - 7;
					item.m_nameBox.Parent = flowLayoutPanel1;
					item.m_nameBox.Width = (flowLayoutPanel1.Width / 16) * 5 - 7;
					item.m_descBox.Parent = flowLayoutPanel1;
					item.m_descBox.Width = (flowLayoutPanel1.Width / 16) * 6 - 7;
					item.m_weightBox.Parent = flowLayoutPanel1;
					item.m_weightBox.Width = (flowLayoutPanel1.Width / 16) * 2 - 7;
					item.m_valueBox.Parent = flowLayoutPanel1;
					item.m_valueBox.Width = (flowLayoutPanel1.Width / 16) * 2 - 7;
					flowLayoutPanel1.SetFlowBreak(item.m_valueBox, true);
				}
			}

			// show details of selected item
		}

		// this will copy the inventory from this form into the character
		public void saveInventory()
		{

			if (m_items.Count > 0)
			{
				m_character.m_inventory.Clear(); // clear the out old
				foreach (var item in m_items) // bring in the new
				{
					m_character.m_inventory.Add(new Item(item.m_nameBox.Text, item.m_descBox.Text, (float)item.m_weightBox.Value, (float)item.m_valueBox.Value));
				}
			}
		}

		private void InventoryWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			saveInventory();
		}


		private void InventoryWindow_Load(object sender, EventArgs e)
		{
			if (m_parent == null)
			{
				this.Close();
			}
			m_character = m_parent.m_character;
			if (m_character == null)
			{
				this.Close();
			}
			if (m_character.m_inventory == null)
			{
				m_character.m_inventory = new List<Item>();
			}

			//m_character.m_inventory.Add(new Item("Battleaxe", "It's big", 10, 25));
			//m_character.m_inventory.Add(new Item("Greateaxe", "It's biger", 15, 50));

			if (m_items == null)
			{
				m_items = new List<DialogItem>();
				// populate list with character's items
				if (m_character.m_inventory.Count > 0)
				{
					foreach (var item in m_character.m_inventory)
					{
						CheckBox selector = new CheckBox();
						selector.CheckedChanged += new System.EventHandler(this.selector_CheckedChanged); // add handler
						TextBox name = new TextBox();
						name.Text = item.m_name;
						TextBox desc = new TextBox();
						desc.Text = item.m_desc;
						NumericUpDown weight = new NumericUpDown();
						weight.Value = (decimal)item.m_weight;
						NumericUpDown price = new NumericUpDown();
						price.Value = (decimal)item.m_value;

						DialogItem di = new DialogItem(selector, name, desc, weight, price);
						m_items.Add(di);
					}
				}
			}
			updateForm();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Item i = new Item();
			i.m_name = "Test name";
			m_character.m_inventory.Add(i);
			updateForm();
		}

		// this is called when ANY of the radio buttons from the inventory list are changed
		private void selector_CheckedChanged(object sender, EventArgs e)
		{
			if (m_items.Count > 0)
			{
				foreach (var item in m_items)
				{
					if (item.m_selector.Checked)
					{
						item.m_descBox.Text = "stop it!";
					}
				}
				updateForm();
			}
		}

		private void buttonAddItem_Click(object sender, EventArgs e)
		{
			CheckBox cb = new CheckBox();
			TextBox n = new TextBox();
			n.Text = "Item Name";
			TextBox d = new TextBox();
			d.Text = "Item Description";
			NumericUpDown w = new NumericUpDown();
			w.Maximum = 1000000000;
			NumericUpDown v = new NumericUpDown();
			v.Maximum = 1000000000;
			m_items.Add(new DialogItem(cb, n, d, w, v));
			updateForm();
		}

		private void buttonDeleteItem_Click(object sender, EventArgs e)
		{
			if (m_items.Count > 0)
			{
				List<DialogItem> tempList = new List<DialogItem>();
				foreach (var item in m_items)
				{
					if (item.m_selector.Checked)
					{
						tempList.Add(item);
					}
				}
				if (tempList.Count > 0)
				{
					foreach (var item in tempList)
					{
						m_items.Remove(item);
						item.cleanup();
					}
				}
				updateForm();
			}
		}
	}
}
