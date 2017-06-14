using System.Collections.Generic;
using System.Windows.Forms;

namespace DnDManager
{

	public class DialogItem
	{
		public DialogItem() { }
		public DialogItem(CheckBox selector, TextBox name, TextBox desc, NumericUpDown weight, NumericUpDown value)
		{
			m_selector = selector;
			m_nameBox = name;
			m_descBox = desc;
			m_weightBox = weight;
			m_valueBox = value;
		}
		~DialogItem()
		{
			// remove all the controlls from the form
			cleanup();
		}

		public void cleanup()
		{// remove all the controlls from the form
			if (m_selector != null)
			{
				if (m_selector.Parent != null)
				{
					m_selector.Parent.Controls.Remove(m_selector);
					m_selector.Dispose();
				}
			}
			if (m_nameBox != null)
			{
				if (m_nameBox.Parent != null)
				{
					m_nameBox.Parent.Controls.Remove(m_nameBox);
					m_nameBox.Dispose();
				}
			}
			if (m_descBox != null)
			{
				if (m_descBox.Parent != null)
				{
					m_descBox.Parent.Controls.Remove(m_descBox);
					m_descBox.Dispose();
				}
			}
			if (m_weightBox != null)
			{
				if (m_weightBox.Parent != null)
				{
					m_weightBox.Parent.Controls.Remove(m_weightBox);
					m_weightBox.Dispose();
				}
			}
			if (m_valueBox != null)
			{
				if (m_valueBox.Parent != null)
				{
					m_valueBox.Parent.Controls.Remove(m_valueBox);
					m_valueBox.Dispose();
				}
			}
		}

		public CheckBox m_selector = null;
		public TextBox m_nameBox = null;
		public TextBox m_descBox = null;
		public NumericUpDown m_weightBox = null;
		public NumericUpDown m_valueBox = null;
	}


	partial class InventoryWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.contextMenuStripListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonDeleteItem = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.contextMenuStripFlowLayout = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonAddItem = new System.Windows.Forms.Button();
			this.contextMenuStripListBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contextMenuStripFlowLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStripListBox
			// 
			this.contextMenuStripListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.contextMenuStripListBox.Name = "ListContextMenu";
			this.contextMenuStripListBox.Size = new System.Drawing.Size(121, 26);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
			this.toolStripMenuItem1.Text = "AddItem";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// listBox2
			// 
			this.listBox2.ContextMenuStrip = this.contextMenuStripListBox;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(546, 12);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(266, 563);
			this.listBox2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(465, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = ">>";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(465, 259);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "<<";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteItem
			// 
			this.buttonDeleteItem.Location = new System.Drawing.Point(465, 393);
			this.buttonDeleteItem.Name = "buttonDeleteItem";
			this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteItem.TabIndex = 6;
			this.buttonDeleteItem.Text = "-";
			this.buttonDeleteItem.UseVisualStyleBackColor = true;
			this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(441, 543);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(447, 562);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inventory";
			// 
			// contextMenuStripFlowLayout
			// 
			this.contextMenuStripFlowLayout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
			this.contextMenuStripFlowLayout.Name = "ListContextMenu";
			this.contextMenuStripFlowLayout.Size = new System.Drawing.Size(121, 26);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
			this.toolStripMenuItem2.Text = "AddItem";
			// 
			// buttonAddItem
			// 
			this.buttonAddItem.Location = new System.Drawing.Point(465, 364);
			this.buttonAddItem.Name = "buttonAddItem";
			this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
			this.buttonAddItem.TabIndex = 9;
			this.buttonAddItem.Text = "+";
			this.buttonAddItem.UseVisualStyleBackColor = true;
			this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
			// 
			// InventoryWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 586);
			this.Controls.Add(this.buttonAddItem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonDeleteItem);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox2);
			this.Name = "InventoryWindow";
			this.Text = "Inventory";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryWindow_Closing);
			this.Load += new System.EventHandler(this.InventoryWindow_Load);
			this.contextMenuStripListBox.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.contextMenuStripFlowLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		// custom variables
		public Character m_character = null;
		protected Form1 m_parent = null;
		protected List<DialogItem> m_items = null;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripListBox;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonDeleteItem;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private GroupBox groupBox1;
		private ContextMenuStrip contextMenuStripFlowLayout;
		private ToolStripMenuItem toolStripMenuItem2;
		private Button buttonAddItem;
	}
}