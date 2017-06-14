using System;
using System.Collections.Generic;

namespace DnDManager
{

	public class Item
	{
		public Item() { }
		public Item(string name, string desc, float weight, float value)
		{
			m_name = name;
			m_desc = desc;
			m_weight = weight;
			m_value = value;
		}
		public string m_name = "";
		public string m_desc = "";
		public float m_weight = 0; // in lb (It's stupid I know, but that's what D&D uses)
		public float m_value = 0; // in gp
	}

	public class Character
	{
		public Character()
		{
			m_inventory = new List<Item>();
		}
		// core stats
		public int m_str = 10;
		public int m_dex = 10;
		public int m_con = 10;
		public int m_int = 10;
		public int m_wis = 10;
		public int m_cha = 10;

		public int m_AC = 10;

		public float m_speed = 30;

		public int m_proficencyBonus = 2;

		public float m_maxHealth = 10; // maximum natural health
		public float m_currentHealth = 10; // current natural health (does not include temp health)
		public float m_tempHealth = 0; // temp health add on top of current health

		// skill proficiencies
		// str
		public bool m_sAthletics = false;
		// dex
		public bool m_sAcrobatics = false;
		public bool m_sSlightOfHand = false;
		public bool m_sStealth = false;
		// int
		public bool m_sArcana = false;
		public bool m_sHistory = false;
		public bool m_sInvestigation = false;
		public bool m_sNature = false;
		public bool m_sReligion = false;
		// wis
		public bool m_sAnimalHandling = false;
		public bool m_sInsight = false;
		public bool m_sMedicine = false;
		public bool m_sPerception = false;
		public bool m_sSurvival = false;
		// cha
		public bool m_sDeception = false;
		public bool m_sIntimidation = false;
		public bool m_sPerformance = false;
		public bool m_sPersuasion = false;

		// saving throws
		public bool m_stStr = false;
		public bool m_stDex = false;
		public bool m_stCon = false;
		public bool m_stInt = false;
		public bool m_stWis = false;
		public bool m_stCha = false;

		// inventory
		public List<Item> m_inventory = null;

	}

	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entry1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entry11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entry111ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxCoreStats = new System.Windows.Forms.GroupBox();
			this.labelChaMod = new System.Windows.Forms.Label();
			this.labelWisMod = new System.Windows.Forms.Label();
			this.labelIntMod = new System.Windows.Forms.Label();
			this.labelConMod = new System.Windows.Forms.Label();
			this.labelDexMod = new System.Windows.Forms.Label();
			this.labelStrMod = new System.Windows.Forms.Label();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.labelCha = new System.Windows.Forms.Label();
			this.numericUpDownCha = new System.Windows.Forms.NumericUpDown();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.labelWis = new System.Windows.Forms.Label();
			this.numericUpDownWis = new System.Windows.Forms.NumericUpDown();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.labelInt = new System.Windows.Forms.Label();
			this.numericUpDownInt = new System.Windows.Forms.NumericUpDown();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.labelCon = new System.Windows.Forms.Label();
			this.numericUpDownCon = new System.Windows.Forms.NumericUpDown();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.labelDex = new System.Windows.Forms.Label();
			this.numericUpDownDex = new System.Windows.Forms.NumericUpDown();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.labelStr = new System.Windows.Forms.Label();
			this.numericUpDownStr = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.splitContainer17 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.labelPasPer = new System.Windows.Forms.Label();
			this.splitContainer14 = new System.Windows.Forms.SplitContainer();
			this.labelInspiration = new System.Windows.Forms.Label();
			this.numericUpDownInspiration = new System.Windows.Forms.NumericUpDown();
			this.splitContainer13 = new System.Windows.Forms.SplitContainer();
			this.labelProficiencyBonus = new System.Windows.Forms.Label();
			this.numericUpDownProficiencyBonus = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.splitContainer53 = new System.Windows.Forms.SplitContainer();
			this.checkBoxChaSave = new System.Windows.Forms.CheckBox();
			this.splitContainer54 = new System.Windows.Forms.SplitContainer();
			this.labelChaSave = new System.Windows.Forms.Label();
			this.labelChaSaveMod = new System.Windows.Forms.Label();
			this.splitContainer55 = new System.Windows.Forms.SplitContainer();
			this.checkBoxWisSave = new System.Windows.Forms.CheckBox();
			this.splitContainer56 = new System.Windows.Forms.SplitContainer();
			this.labelWisSave = new System.Windows.Forms.Label();
			this.labelWisSaveMod = new System.Windows.Forms.Label();
			this.splitContainer57 = new System.Windows.Forms.SplitContainer();
			this.checkBoxIntSave = new System.Windows.Forms.CheckBox();
			this.splitContainer58 = new System.Windows.Forms.SplitContainer();
			this.labelIntSave = new System.Windows.Forms.Label();
			this.labelIntSaveMod = new System.Windows.Forms.Label();
			this.splitContainer11 = new System.Windows.Forms.SplitContainer();
			this.checkBoxConSave = new System.Windows.Forms.CheckBox();
			this.splitContainer12 = new System.Windows.Forms.SplitContainer();
			this.labelConSave = new System.Windows.Forms.Label();
			this.labelConSaveMod = new System.Windows.Forms.Label();
			this.splitContainer9 = new System.Windows.Forms.SplitContainer();
			this.checkBoxDexSave = new System.Windows.Forms.CheckBox();
			this.splitContainer10 = new System.Windows.Forms.SplitContainer();
			this.labelDexSave = new System.Windows.Forms.Label();
			this.labelDexSaveMod = new System.Windows.Forms.Label();
			this.splitContainer7 = new System.Windows.Forms.SplitContainer();
			this.checkBoxStrSave = new System.Windows.Forms.CheckBox();
			this.splitContainer8 = new System.Windows.Forms.SplitContainer();
			this.labelStrSave = new System.Windows.Forms.Label();
			this.labelStrSaveMod = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.splitContainer49 = new System.Windows.Forms.SplitContainer();
			this.checkBoxPers = new System.Windows.Forms.CheckBox();
			this.splitContainer50 = new System.Windows.Forms.SplitContainer();
			this.labelPers = new System.Windows.Forms.Label();
			this.labelPersMod = new System.Windows.Forms.Label();
			this.splitContainer51 = new System.Windows.Forms.SplitContainer();
			this.checkBoxPerf = new System.Windows.Forms.CheckBox();
			this.splitContainer52 = new System.Windows.Forms.SplitContainer();
			this.labelPerf = new System.Windows.Forms.Label();
			this.labelPerfMod = new System.Windows.Forms.Label();
			this.splitContainer47 = new System.Windows.Forms.SplitContainer();
			this.checkBoxRel = new System.Windows.Forms.CheckBox();
			this.splitContainer48 = new System.Windows.Forms.SplitContainer();
			this.labelRel = new System.Windows.Forms.Label();
			this.labelRelMod = new System.Windows.Forms.Label();
			this.splitContainer33 = new System.Windows.Forms.SplitContainer();
			this.checkBoxInti = new System.Windows.Forms.CheckBox();
			this.splitContainer34 = new System.Windows.Forms.SplitContainer();
			this.labelInti = new System.Windows.Forms.Label();
			this.labelIntiMod = new System.Windows.Forms.Label();
			this.splitContainer35 = new System.Windows.Forms.SplitContainer();
			this.checkBoxDec = new System.Windows.Forms.CheckBox();
			this.splitContainer36 = new System.Windows.Forms.SplitContainer();
			this.labelDec = new System.Windows.Forms.Label();
			this.labelDecMod = new System.Windows.Forms.Label();
			this.splitContainer37 = new System.Windows.Forms.SplitContainer();
			this.checkBoxSur = new System.Windows.Forms.CheckBox();
			this.splitContainer38 = new System.Windows.Forms.SplitContainer();
			this.labelSur = new System.Windows.Forms.Label();
			this.labelSurMod = new System.Windows.Forms.Label();
			this.splitContainer39 = new System.Windows.Forms.SplitContainer();
			this.checkBoxPer = new System.Windows.Forms.CheckBox();
			this.splitContainer40 = new System.Windows.Forms.SplitContainer();
			this.labelPer = new System.Windows.Forms.Label();
			this.labelPerMod = new System.Windows.Forms.Label();
			this.splitContainer41 = new System.Windows.Forms.SplitContainer();
			this.checkBoxMed = new System.Windows.Forms.CheckBox();
			this.splitContainer42 = new System.Windows.Forms.SplitContainer();
			this.labelMed = new System.Windows.Forms.Label();
			this.labelMedMod = new System.Windows.Forms.Label();
			this.splitContainer43 = new System.Windows.Forms.SplitContainer();
			this.checkBoxIns = new System.Windows.Forms.CheckBox();
			this.splitContainer44 = new System.Windows.Forms.SplitContainer();
			this.labelIns = new System.Windows.Forms.Label();
			this.labelInsMod = new System.Windows.Forms.Label();
			this.splitContainer45 = new System.Windows.Forms.SplitContainer();
			this.checkBoxAnH = new System.Windows.Forms.CheckBox();
			this.splitContainer46 = new System.Windows.Forms.SplitContainer();
			this.labelAnH = new System.Windows.Forms.Label();
			this.labelAnHMod = new System.Windows.Forms.Label();
			this.splitContainer25 = new System.Windows.Forms.SplitContainer();
			this.checkBoxNat = new System.Windows.Forms.CheckBox();
			this.splitContainer26 = new System.Windows.Forms.SplitContainer();
			this.labelNat = new System.Windows.Forms.Label();
			this.labelNatMod = new System.Windows.Forms.Label();
			this.splitContainer27 = new System.Windows.Forms.SplitContainer();
			this.checkBoxInv = new System.Windows.Forms.CheckBox();
			this.splitContainer28 = new System.Windows.Forms.SplitContainer();
			this.labelInv = new System.Windows.Forms.Label();
			this.labelInvMod = new System.Windows.Forms.Label();
			this.splitContainer29 = new System.Windows.Forms.SplitContainer();
			this.checkBoxHis = new System.Windows.Forms.CheckBox();
			this.splitContainer30 = new System.Windows.Forms.SplitContainer();
			this.labelHis = new System.Windows.Forms.Label();
			this.labelHisMod = new System.Windows.Forms.Label();
			this.splitContainer31 = new System.Windows.Forms.SplitContainer();
			this.checkBoxArc = new System.Windows.Forms.CheckBox();
			this.splitContainer32 = new System.Windows.Forms.SplitContainer();
			this.labelArc = new System.Windows.Forms.Label();
			this.labelArcMod = new System.Windows.Forms.Label();
			this.splitContainer21 = new System.Windows.Forms.SplitContainer();
			this.checkBoxSte = new System.Windows.Forms.CheckBox();
			this.splitContainer22 = new System.Windows.Forms.SplitContainer();
			this.labeSte = new System.Windows.Forms.Label();
			this.labelSteMod = new System.Windows.Forms.Label();
			this.splitContainer23 = new System.Windows.Forms.SplitContainer();
			this.checkBoxSOH = new System.Windows.Forms.CheckBox();
			this.splitContainer24 = new System.Windows.Forms.SplitContainer();
			this.labelSOH = new System.Windows.Forms.Label();
			this.labelSOHMod = new System.Windows.Forms.Label();
			this.splitContainer19 = new System.Windows.Forms.SplitContainer();
			this.checkBoxAcr = new System.Windows.Forms.CheckBox();
			this.splitContainer20 = new System.Windows.Forms.SplitContainer();
			this.labelAcr = new System.Windows.Forms.Label();
			this.labelAcrMod = new System.Windows.Forms.Label();
			this.splitContainer15 = new System.Windows.Forms.SplitContainer();
			this.checkBoxAth = new System.Windows.Forms.CheckBox();
			this.splitContainer16 = new System.Windows.Forms.SplitContainer();
			this.labelAth = new System.Windows.Forms.Label();
			this.labelAthMod = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.splitContainer18 = new System.Windows.Forms.SplitContainer();
			this.numericUpDownTakeDamage = new System.Windows.Forms.NumericUpDown();
			this.buttonTakeDamage = new System.Windows.Forms.Button();
			this.buttonResetHealth = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.splitContainer62 = new System.Windows.Forms.SplitContainer();
			this.labelTotalHealth = new System.Windows.Forms.Label();
			this.splitContainer61 = new System.Windows.Forms.SplitContainer();
			this.numericUpDownCurrentHealth = new System.Windows.Forms.NumericUpDown();
			this.splitContainer60 = new System.Windows.Forms.SplitContainer();
			this.numericUpDownTempHealth = new System.Windows.Forms.NumericUpDown();
			this.splitContainer59 = new System.Windows.Forms.SplitContainer();
			this.numericUpDownMaxHealth = new System.Windows.Forms.NumericUpDown();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.groupBoxCoreStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownInt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStr)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer17)).BeginInit();
			this.splitContainer17.Panel1.SuspendLayout();
			this.splitContainer17.Panel2.SuspendLayout();
			this.splitContainer17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).BeginInit();
			this.splitContainer14.Panel1.SuspendLayout();
			this.splitContainer14.Panel2.SuspendLayout();
			this.splitContainer14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownInspiration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).BeginInit();
			this.splitContainer13.Panel1.SuspendLayout();
			this.splitContainer13.Panel2.SuspendLayout();
			this.splitContainer13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownProficiencyBonus)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer53)).BeginInit();
			this.splitContainer53.Panel1.SuspendLayout();
			this.splitContainer53.Panel2.SuspendLayout();
			this.splitContainer53.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer54)).BeginInit();
			this.splitContainer54.Panel1.SuspendLayout();
			this.splitContainer54.Panel2.SuspendLayout();
			this.splitContainer54.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer55)).BeginInit();
			this.splitContainer55.Panel1.SuspendLayout();
			this.splitContainer55.Panel2.SuspendLayout();
			this.splitContainer55.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer56)).BeginInit();
			this.splitContainer56.Panel1.SuspendLayout();
			this.splitContainer56.Panel2.SuspendLayout();
			this.splitContainer56.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer57)).BeginInit();
			this.splitContainer57.Panel1.SuspendLayout();
			this.splitContainer57.Panel2.SuspendLayout();
			this.splitContainer57.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer58)).BeginInit();
			this.splitContainer58.Panel1.SuspendLayout();
			this.splitContainer58.Panel2.SuspendLayout();
			this.splitContainer58.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
			this.splitContainer11.Panel1.SuspendLayout();
			this.splitContainer11.Panel2.SuspendLayout();
			this.splitContainer11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
			this.splitContainer12.Panel1.SuspendLayout();
			this.splitContainer12.Panel2.SuspendLayout();
			this.splitContainer12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
			this.splitContainer9.Panel1.SuspendLayout();
			this.splitContainer9.Panel2.SuspendLayout();
			this.splitContainer9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
			this.splitContainer10.Panel1.SuspendLayout();
			this.splitContainer10.Panel2.SuspendLayout();
			this.splitContainer10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
			this.splitContainer7.Panel1.SuspendLayout();
			this.splitContainer7.Panel2.SuspendLayout();
			this.splitContainer7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
			this.splitContainer8.Panel1.SuspendLayout();
			this.splitContainer8.Panel2.SuspendLayout();
			this.splitContainer8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer49)).BeginInit();
			this.splitContainer49.Panel1.SuspendLayout();
			this.splitContainer49.Panel2.SuspendLayout();
			this.splitContainer49.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer50)).BeginInit();
			this.splitContainer50.Panel1.SuspendLayout();
			this.splitContainer50.Panel2.SuspendLayout();
			this.splitContainer50.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer51)).BeginInit();
			this.splitContainer51.Panel1.SuspendLayout();
			this.splitContainer51.Panel2.SuspendLayout();
			this.splitContainer51.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer52)).BeginInit();
			this.splitContainer52.Panel1.SuspendLayout();
			this.splitContainer52.Panel2.SuspendLayout();
			this.splitContainer52.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer47)).BeginInit();
			this.splitContainer47.Panel1.SuspendLayout();
			this.splitContainer47.Panel2.SuspendLayout();
			this.splitContainer47.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer48)).BeginInit();
			this.splitContainer48.Panel1.SuspendLayout();
			this.splitContainer48.Panel2.SuspendLayout();
			this.splitContainer48.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer33)).BeginInit();
			this.splitContainer33.Panel1.SuspendLayout();
			this.splitContainer33.Panel2.SuspendLayout();
			this.splitContainer33.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer34)).BeginInit();
			this.splitContainer34.Panel1.SuspendLayout();
			this.splitContainer34.Panel2.SuspendLayout();
			this.splitContainer34.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer35)).BeginInit();
			this.splitContainer35.Panel1.SuspendLayout();
			this.splitContainer35.Panel2.SuspendLayout();
			this.splitContainer35.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer36)).BeginInit();
			this.splitContainer36.Panel1.SuspendLayout();
			this.splitContainer36.Panel2.SuspendLayout();
			this.splitContainer36.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer37)).BeginInit();
			this.splitContainer37.Panel1.SuspendLayout();
			this.splitContainer37.Panel2.SuspendLayout();
			this.splitContainer37.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer38)).BeginInit();
			this.splitContainer38.Panel1.SuspendLayout();
			this.splitContainer38.Panel2.SuspendLayout();
			this.splitContainer38.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer39)).BeginInit();
			this.splitContainer39.Panel1.SuspendLayout();
			this.splitContainer39.Panel2.SuspendLayout();
			this.splitContainer39.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer40)).BeginInit();
			this.splitContainer40.Panel1.SuspendLayout();
			this.splitContainer40.Panel2.SuspendLayout();
			this.splitContainer40.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer41)).BeginInit();
			this.splitContainer41.Panel1.SuspendLayout();
			this.splitContainer41.Panel2.SuspendLayout();
			this.splitContainer41.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer42)).BeginInit();
			this.splitContainer42.Panel1.SuspendLayout();
			this.splitContainer42.Panel2.SuspendLayout();
			this.splitContainer42.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer43)).BeginInit();
			this.splitContainer43.Panel1.SuspendLayout();
			this.splitContainer43.Panel2.SuspendLayout();
			this.splitContainer43.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer44)).BeginInit();
			this.splitContainer44.Panel1.SuspendLayout();
			this.splitContainer44.Panel2.SuspendLayout();
			this.splitContainer44.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer45)).BeginInit();
			this.splitContainer45.Panel1.SuspendLayout();
			this.splitContainer45.Panel2.SuspendLayout();
			this.splitContainer45.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer46)).BeginInit();
			this.splitContainer46.Panel1.SuspendLayout();
			this.splitContainer46.Panel2.SuspendLayout();
			this.splitContainer46.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer25)).BeginInit();
			this.splitContainer25.Panel1.SuspendLayout();
			this.splitContainer25.Panel2.SuspendLayout();
			this.splitContainer25.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer26)).BeginInit();
			this.splitContainer26.Panel1.SuspendLayout();
			this.splitContainer26.Panel2.SuspendLayout();
			this.splitContainer26.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer27)).BeginInit();
			this.splitContainer27.Panel1.SuspendLayout();
			this.splitContainer27.Panel2.SuspendLayout();
			this.splitContainer27.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer28)).BeginInit();
			this.splitContainer28.Panel1.SuspendLayout();
			this.splitContainer28.Panel2.SuspendLayout();
			this.splitContainer28.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer29)).BeginInit();
			this.splitContainer29.Panel1.SuspendLayout();
			this.splitContainer29.Panel2.SuspendLayout();
			this.splitContainer29.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer30)).BeginInit();
			this.splitContainer30.Panel1.SuspendLayout();
			this.splitContainer30.Panel2.SuspendLayout();
			this.splitContainer30.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer31)).BeginInit();
			this.splitContainer31.Panel1.SuspendLayout();
			this.splitContainer31.Panel2.SuspendLayout();
			this.splitContainer31.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer32)).BeginInit();
			this.splitContainer32.Panel1.SuspendLayout();
			this.splitContainer32.Panel2.SuspendLayout();
			this.splitContainer32.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer21)).BeginInit();
			this.splitContainer21.Panel1.SuspendLayout();
			this.splitContainer21.Panel2.SuspendLayout();
			this.splitContainer21.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer22)).BeginInit();
			this.splitContainer22.Panel1.SuspendLayout();
			this.splitContainer22.Panel2.SuspendLayout();
			this.splitContainer22.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer23)).BeginInit();
			this.splitContainer23.Panel1.SuspendLayout();
			this.splitContainer23.Panel2.SuspendLayout();
			this.splitContainer23.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer24)).BeginInit();
			this.splitContainer24.Panel1.SuspendLayout();
			this.splitContainer24.Panel2.SuspendLayout();
			this.splitContainer24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer19)).BeginInit();
			this.splitContainer19.Panel1.SuspendLayout();
			this.splitContainer19.Panel2.SuspendLayout();
			this.splitContainer19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer20)).BeginInit();
			this.splitContainer20.Panel1.SuspendLayout();
			this.splitContainer20.Panel2.SuspendLayout();
			this.splitContainer20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer15)).BeginInit();
			this.splitContainer15.Panel1.SuspendLayout();
			this.splitContainer15.Panel2.SuspendLayout();
			this.splitContainer15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer16)).BeginInit();
			this.splitContainer16.Panel1.SuspendLayout();
			this.splitContainer16.Panel2.SuspendLayout();
			this.splitContainer16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer18)).BeginInit();
			this.splitContainer18.Panel1.SuspendLayout();
			this.splitContainer18.Panel2.SuspendLayout();
			this.splitContainer18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTakeDamage)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer62)).BeginInit();
			this.splitContainer62.Panel1.SuspendLayout();
			this.splitContainer62.Panel2.SuspendLayout();
			this.splitContainer62.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer61)).BeginInit();
			this.splitContainer61.Panel1.SuspendLayout();
			this.splitContainer61.Panel2.SuspendLayout();
			this.splitContainer61.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentHealth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer60)).BeginInit();
			this.splitContainer60.Panel1.SuspendLayout();
			this.splitContainer60.Panel2.SuspendLayout();
			this.splitContainer60.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempHealth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer59)).BeginInit();
			this.splitContainer59.Panel1.SuspendLayout();
			this.splitContainer59.Panel2.SuspendLayout();
			this.splitContainer59.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHealth)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(904, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menu1ToolStripMenuItem
			// 
			this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.entry1ToolStripMenuItem});
			this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
			this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.menu1ToolStripMenuItem.Text = "Menu1";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// entry1ToolStripMenuItem
			// 
			this.entry1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entry11ToolStripMenuItem});
			this.entry1ToolStripMenuItem.Name = "entry1ToolStripMenuItem";
			this.entry1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.entry1ToolStripMenuItem.Text = "Entry1";
			// 
			// entry11ToolStripMenuItem
			// 
			this.entry11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entry111ToolStripMenuItem});
			this.entry11ToolStripMenuItem.Name = "entry11ToolStripMenuItem";
			this.entry11ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.entry11ToolStripMenuItem.Text = "Entry1-1";
			// 
			// entry111ToolStripMenuItem
			// 
			this.entry111ToolStripMenuItem.Name = "entry111ToolStripMenuItem";
			this.entry111ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.entry111ToolStripMenuItem.Text = "Entry1-1-1";
			this.entry111ToolStripMenuItem.Click += new System.EventHandler(this.entry111ToolStripMenuItem_Click);
			// 
			// groupBoxCoreStats
			// 
			this.groupBoxCoreStats.Controls.Add(this.labelChaMod);
			this.groupBoxCoreStats.Controls.Add(this.labelWisMod);
			this.groupBoxCoreStats.Controls.Add(this.labelIntMod);
			this.groupBoxCoreStats.Controls.Add(this.labelConMod);
			this.groupBoxCoreStats.Controls.Add(this.labelDexMod);
			this.groupBoxCoreStats.Controls.Add(this.labelStrMod);
			this.groupBoxCoreStats.Controls.Add(this.splitContainer3);
			this.groupBoxCoreStats.Controls.Add(this.splitContainer5);
			this.groupBoxCoreStats.Controls.Add(this.splitContainer6);
			this.groupBoxCoreStats.Controls.Add(this.splitContainer2);
			this.groupBoxCoreStats.Controls.Add(this.splitContainer1);
			this.groupBoxCoreStats.Controls.Add(this.splitContainer4);
			this.groupBoxCoreStats.Location = new System.Drawing.Point(6, 19);
			this.groupBoxCoreStats.Name = "groupBoxCoreStats";
			this.groupBoxCoreStats.Size = new System.Drawing.Size(161, 206);
			this.groupBoxCoreStats.TabIndex = 14;
			this.groupBoxCoreStats.TabStop = false;
			this.groupBoxCoreStats.Text = "CoreStats";
			// 
			// labelChaMod
			// 
			this.labelChaMod.AutoSize = true;
			this.labelChaMod.Location = new System.Drawing.Point(135, 179);
			this.labelChaMod.Name = "labelChaMod";
			this.labelChaMod.Size = new System.Drawing.Size(47, 13);
			this.labelChaMod.TabIndex = 31;
			this.labelChaMod.Text = "ChaMod";
			// 
			// labelWisMod
			// 
			this.labelWisMod.AutoSize = true;
			this.labelWisMod.Location = new System.Drawing.Point(135, 148);
			this.labelWisMod.Name = "labelWisMod";
			this.labelWisMod.Size = new System.Drawing.Size(46, 13);
			this.labelWisMod.TabIndex = 30;
			this.labelWisMod.Text = "WisMod";
			// 
			// labelIntMod
			// 
			this.labelIntMod.AutoSize = true;
			this.labelIntMod.Location = new System.Drawing.Point(135, 117);
			this.labelIntMod.Name = "labelIntMod";
			this.labelIntMod.Size = new System.Drawing.Size(40, 13);
			this.labelIntMod.TabIndex = 29;
			this.labelIntMod.Text = "IntMod";
			// 
			// labelConMod
			// 
			this.labelConMod.AutoSize = true;
			this.labelConMod.Location = new System.Drawing.Point(135, 86);
			this.labelConMod.Name = "labelConMod";
			this.labelConMod.Size = new System.Drawing.Size(47, 13);
			this.labelConMod.TabIndex = 28;
			this.labelConMod.Text = "ConMod";
			// 
			// labelDexMod
			// 
			this.labelDexMod.AutoSize = true;
			this.labelDexMod.Location = new System.Drawing.Point(135, 55);
			this.labelDexMod.Name = "labelDexMod";
			this.labelDexMod.Size = new System.Drawing.Size(47, 13);
			this.labelDexMod.TabIndex = 27;
			this.labelDexMod.Text = "DexMod";
			// 
			// labelStrMod
			// 
			this.labelStrMod.AutoSize = true;
			this.labelStrMod.Location = new System.Drawing.Point(135, 24);
			this.labelStrMod.Name = "labelStrMod";
			this.labelStrMod.Size = new System.Drawing.Size(41, 13);
			this.labelStrMod.TabIndex = 26;
			this.labelStrMod.Text = "StrMod";
			// 
			// splitContainer3
			// 
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer3.IsSplitterFixed = true;
			this.splitContainer3.Location = new System.Drawing.Point(6, 174);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.labelCha);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.numericUpDownCha);
			this.splitContainer3.Size = new System.Drawing.Size(123, 25);
			this.splitContainer3.SplitterDistance = 71;
			this.splitContainer3.TabIndex = 25;
			this.splitContainer3.TabStop = false;
			// 
			// labelCha
			// 
			this.labelCha.AutoSize = true;
			this.labelCha.Location = new System.Drawing.Point(3, 5);
			this.labelCha.Name = "labelCha";
			this.labelCha.Size = new System.Drawing.Size(50, 13);
			this.labelCha.TabIndex = 18;
			this.labelCha.Text = "Charisma";
			// 
			// numericUpDownCha
			// 
			this.numericUpDownCha.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownCha.Name = "numericUpDownCha";
			this.numericUpDownCha.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownCha.TabIndex = 17;
			this.numericUpDownCha.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownCha.ValueChanged += new System.EventHandler(this.numericUpDownCha_ValueChanged);
			// 
			// splitContainer5
			// 
			this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer5.IsSplitterFixed = true;
			this.splitContainer5.Location = new System.Drawing.Point(6, 143);
			this.splitContainer5.Name = "splitContainer5";
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.labelWis);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.numericUpDownWis);
			this.splitContainer5.Size = new System.Drawing.Size(123, 25);
			this.splitContainer5.SplitterDistance = 71;
			this.splitContainer5.TabIndex = 24;
			this.splitContainer5.TabStop = false;
			// 
			// labelWis
			// 
			this.labelWis.AutoSize = true;
			this.labelWis.Location = new System.Drawing.Point(3, 5);
			this.labelWis.Name = "labelWis";
			this.labelWis.Size = new System.Drawing.Size(45, 13);
			this.labelWis.TabIndex = 18;
			this.labelWis.Text = "Wisdom";
			// 
			// numericUpDownWis
			// 
			this.numericUpDownWis.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownWis.Name = "numericUpDownWis";
			this.numericUpDownWis.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownWis.TabIndex = 17;
			this.numericUpDownWis.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownWis.ValueChanged += new System.EventHandler(this.numericUpDownWisdom_ValueChanged);
			// 
			// splitContainer6
			// 
			this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer6.IsSplitterFixed = true;
			this.splitContainer6.Location = new System.Drawing.Point(6, 112);
			this.splitContainer6.Name = "splitContainer6";
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.Controls.Add(this.labelInt);
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.Controls.Add(this.numericUpDownInt);
			this.splitContainer6.Size = new System.Drawing.Size(123, 25);
			this.splitContainer6.SplitterDistance = 71;
			this.splitContainer6.TabIndex = 23;
			this.splitContainer6.TabStop = false;
			// 
			// labelInt
			// 
			this.labelInt.AutoSize = true;
			this.labelInt.Location = new System.Drawing.Point(3, 5);
			this.labelInt.Name = "labelInt";
			this.labelInt.Size = new System.Drawing.Size(61, 13);
			this.labelInt.TabIndex = 18;
			this.labelInt.Text = "Intelligence";
			// 
			// numericUpDownInt
			// 
			this.numericUpDownInt.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownInt.Name = "numericUpDownInt";
			this.numericUpDownInt.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownInt.TabIndex = 17;
			this.numericUpDownInt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownInt.ValueChanged += new System.EventHandler(this.numericUpDownInt_ValueChanged);
			// 
			// splitContainer2
			// 
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(6, 81);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.labelCon);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.numericUpDownCon);
			this.splitContainer2.Size = new System.Drawing.Size(123, 25);
			this.splitContainer2.SplitterDistance = 71;
			this.splitContainer2.TabIndex = 22;
			this.splitContainer2.TabStop = false;
			// 
			// labelCon
			// 
			this.labelCon.AutoSize = true;
			this.labelCon.Location = new System.Drawing.Point(3, 5);
			this.labelCon.Name = "labelCon";
			this.labelCon.Size = new System.Drawing.Size(62, 13);
			this.labelCon.TabIndex = 18;
			this.labelCon.Text = "Constitution";
			// 
			// numericUpDownCon
			// 
			this.numericUpDownCon.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownCon.Name = "numericUpDownCon";
			this.numericUpDownCon.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownCon.TabIndex = 17;
			this.numericUpDownCon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownCon.ValueChanged += new System.EventHandler(this.numericUpDownCon_ValueChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(6, 50);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.labelDex);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.numericUpDownDex);
			this.splitContainer1.Size = new System.Drawing.Size(123, 25);
			this.splitContainer1.SplitterDistance = 71;
			this.splitContainer1.TabIndex = 21;
			this.splitContainer1.TabStop = false;
			// 
			// labelDex
			// 
			this.labelDex.AutoSize = true;
			this.labelDex.Location = new System.Drawing.Point(3, 5);
			this.labelDex.Name = "labelDex";
			this.labelDex.Size = new System.Drawing.Size(48, 13);
			this.labelDex.TabIndex = 18;
			this.labelDex.Text = "Dexterity";
			// 
			// numericUpDownDex
			// 
			this.numericUpDownDex.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownDex.Name = "numericUpDownDex";
			this.numericUpDownDex.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownDex.TabIndex = 17;
			this.numericUpDownDex.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownDex.ValueChanged += new System.EventHandler(this.numericUpDownDex_ValueChanged);
			// 
			// splitContainer4
			// 
			this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer4.IsSplitterFixed = true;
			this.splitContainer4.Location = new System.Drawing.Point(6, 19);
			this.splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.labelStr);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.numericUpDownStr);
			this.splitContainer4.Size = new System.Drawing.Size(123, 25);
			this.splitContainer4.SplitterDistance = 71;
			this.splitContainer4.TabIndex = 20;
			this.splitContainer4.TabStop = false;
			// 
			// labelStr
			// 
			this.labelStr.AutoSize = true;
			this.labelStr.Location = new System.Drawing.Point(3, 5);
			this.labelStr.Name = "labelStr";
			this.labelStr.Size = new System.Drawing.Size(47, 13);
			this.labelStr.TabIndex = 18;
			this.labelStr.Text = "Strength";
			// 
			// numericUpDownStr
			// 
			this.numericUpDownStr.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownStr.Name = "numericUpDownStr";
			this.numericUpDownStr.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownStr.TabIndex = 17;
			this.numericUpDownStr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownStr.ValueChanged += new System.EventHandler(this.numericUpDownStr_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.splitContainer17);
			this.groupBox1.Controls.Add(this.splitContainer14);
			this.groupBox1.Controls.Add(this.splitContainer13);
			this.groupBox1.Controls.Add(this.groupBoxCoreStats);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(340, 515);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stats";
			// 
			// splitContainer17
			// 
			this.splitContainer17.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer17.IsSplitterFixed = true;
			this.splitContainer17.Location = new System.Drawing.Point(6, 477);
			this.splitContainer17.Name = "splitContainer17";
			// 
			// splitContainer17.Panel1
			// 
			this.splitContainer17.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer17.Panel2
			// 
			this.splitContainer17.Panel2.Controls.Add(this.labelPasPer);
			this.splitContainer17.Size = new System.Drawing.Size(161, 25);
			this.splitContainer17.SplitterDistance = 109;
			this.splitContainer17.TabIndex = 23;
			this.splitContainer17.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Passive Perception";
			this.toolTip1.SetToolTip(this.label1, "10 + Perception Modifier");
			// 
			// labelPasPer
			// 
			this.labelPasPer.AutoSize = true;
			this.labelPasPer.Location = new System.Drawing.Point(4, 5);
			this.labelPasPer.Name = "labelPasPer";
			this.labelPasPer.Size = new System.Drawing.Size(41, 13);
			this.labelPasPer.TabIndex = 0;
			this.labelPasPer.Text = "PasPer";
			// 
			// splitContainer14
			// 
			this.splitContainer14.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer14.IsSplitterFixed = true;
			this.splitContainer14.Location = new System.Drawing.Point(6, 446);
			this.splitContainer14.Name = "splitContainer14";
			// 
			// splitContainer14.Panel1
			// 
			this.splitContainer14.Panel1.Controls.Add(this.labelInspiration);
			// 
			// splitContainer14.Panel2
			// 
			this.splitContainer14.Panel2.Controls.Add(this.numericUpDownInspiration);
			this.splitContainer14.Size = new System.Drawing.Size(161, 25);
			this.splitContainer14.SplitterDistance = 109;
			this.splitContainer14.TabIndex = 22;
			this.splitContainer14.TabStop = false;
			// 
			// labelInspiration
			// 
			this.labelInspiration.AutoSize = true;
			this.labelInspiration.Location = new System.Drawing.Point(3, 5);
			this.labelInspiration.Name = "labelInspiration";
			this.labelInspiration.Size = new System.Drawing.Size(55, 13);
			this.labelInspiration.TabIndex = 18;
			this.labelInspiration.Text = "Inspiration";
			// 
			// numericUpDownInspiration
			// 
			this.numericUpDownInspiration.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownInspiration.Name = "numericUpDownInspiration";
			this.numericUpDownInspiration.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownInspiration.TabIndex = 17;
			// 
			// splitContainer13
			// 
			this.splitContainer13.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer13.IsSplitterFixed = true;
			this.splitContainer13.Location = new System.Drawing.Point(6, 415);
			this.splitContainer13.Name = "splitContainer13";
			// 
			// splitContainer13.Panel1
			// 
			this.splitContainer13.Panel1.Controls.Add(this.labelProficiencyBonus);
			// 
			// splitContainer13.Panel2
			// 
			this.splitContainer13.Panel2.Controls.Add(this.numericUpDownProficiencyBonus);
			this.splitContainer13.Size = new System.Drawing.Size(161, 25);
			this.splitContainer13.SplitterDistance = 109;
			this.splitContainer13.TabIndex = 21;
			this.splitContainer13.TabStop = false;
			// 
			// labelProficiencyBonus
			// 
			this.labelProficiencyBonus.AutoSize = true;
			this.labelProficiencyBonus.Location = new System.Drawing.Point(3, 5);
			this.labelProficiencyBonus.Name = "labelProficiencyBonus";
			this.labelProficiencyBonus.Size = new System.Drawing.Size(92, 13);
			this.labelProficiencyBonus.TabIndex = 18;
			this.labelProficiencyBonus.Text = "Proficiency Bonus";
			// 
			// numericUpDownProficiencyBonus
			// 
			this.numericUpDownProficiencyBonus.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownProficiencyBonus.Name = "numericUpDownProficiencyBonus";
			this.numericUpDownProficiencyBonus.Size = new System.Drawing.Size(42, 20);
			this.numericUpDownProficiencyBonus.TabIndex = 17;
			this.numericUpDownProficiencyBonus.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownProficiencyBonus.ValueChanged += new System.EventHandler(this.numericUpDownProficiencyBonus_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.splitContainer53);
			this.groupBox3.Controls.Add(this.splitContainer55);
			this.groupBox3.Controls.Add(this.splitContainer57);
			this.groupBox3.Controls.Add(this.splitContainer11);
			this.groupBox3.Controls.Add(this.splitContainer9);
			this.groupBox3.Controls.Add(this.splitContainer7);
			this.groupBox3.Location = new System.Drawing.Point(6, 231);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(161, 178);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Saving Throws";
			// 
			// splitContainer53
			// 
			this.splitContainer53.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer53.IsSplitterFixed = true;
			this.splitContainer53.Location = new System.Drawing.Point(6, 149);
			this.splitContainer53.Name = "splitContainer53";
			// 
			// splitContainer53.Panel1
			// 
			this.splitContainer53.Panel1.Controls.Add(this.checkBoxChaSave);
			// 
			// splitContainer53.Panel2
			// 
			this.splitContainer53.Panel2.Controls.Add(this.splitContainer54);
			this.splitContainer53.Size = new System.Drawing.Size(149, 20);
			this.splitContainer53.SplitterDistance = 25;
			this.splitContainer53.TabIndex = 22;
			// 
			// checkBoxChaSave
			// 
			this.checkBoxChaSave.AutoSize = true;
			this.checkBoxChaSave.Location = new System.Drawing.Point(7, 3);
			this.checkBoxChaSave.Name = "checkBoxChaSave";
			this.checkBoxChaSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxChaSave.TabIndex = 0;
			this.checkBoxChaSave.UseVisualStyleBackColor = true;
			this.checkBoxChaSave.CheckedChanged += new System.EventHandler(this.checkBoxChaSave_CheckedChanged);
			// 
			// splitContainer54
			// 
			this.splitContainer54.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer54.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer54.IsSplitterFixed = true;
			this.splitContainer54.Location = new System.Drawing.Point(0, 0);
			this.splitContainer54.Name = "splitContainer54";
			// 
			// splitContainer54.Panel1
			// 
			this.splitContainer54.Panel1.Controls.Add(this.labelChaSave);
			// 
			// splitContainer54.Panel2
			// 
			this.splitContainer54.Panel2.Controls.Add(this.labelChaSaveMod);
			this.splitContainer54.Size = new System.Drawing.Size(120, 20);
			this.splitContainer54.SplitterDistance = 86;
			this.splitContainer54.TabIndex = 17;
			// 
			// labelChaSave
			// 
			this.labelChaSave.AutoSize = true;
			this.labelChaSave.Location = new System.Drawing.Point(0, 0);
			this.labelChaSave.Name = "labelChaSave";
			this.labelChaSave.Size = new System.Drawing.Size(50, 13);
			this.labelChaSave.TabIndex = 0;
			this.labelChaSave.Text = "Charisma";
			// 
			// labelChaSaveMod
			// 
			this.labelChaSaveMod.AutoSize = true;
			this.labelChaSaveMod.Location = new System.Drawing.Point(3, 0);
			this.labelChaSaveMod.Name = "labelChaSaveMod";
			this.labelChaSaveMod.Size = new System.Drawing.Size(72, 13);
			this.labelChaSaveMod.TabIndex = 0;
			this.labelChaSaveMod.Text = "ChaSaveMod";
			// 
			// splitContainer55
			// 
			this.splitContainer55.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer55.IsSplitterFixed = true;
			this.splitContainer55.Location = new System.Drawing.Point(6, 123);
			this.splitContainer55.Name = "splitContainer55";
			// 
			// splitContainer55.Panel1
			// 
			this.splitContainer55.Panel1.Controls.Add(this.checkBoxWisSave);
			// 
			// splitContainer55.Panel2
			// 
			this.splitContainer55.Panel2.Controls.Add(this.splitContainer56);
			this.splitContainer55.Size = new System.Drawing.Size(149, 20);
			this.splitContainer55.SplitterDistance = 25;
			this.splitContainer55.TabIndex = 21;
			// 
			// checkBoxWisSave
			// 
			this.checkBoxWisSave.AutoSize = true;
			this.checkBoxWisSave.Location = new System.Drawing.Point(7, 3);
			this.checkBoxWisSave.Name = "checkBoxWisSave";
			this.checkBoxWisSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxWisSave.TabIndex = 0;
			this.checkBoxWisSave.UseVisualStyleBackColor = true;
			this.checkBoxWisSave.CheckedChanged += new System.EventHandler(this.checkBoxWisSave_CheckedChanged);
			// 
			// splitContainer56
			// 
			this.splitContainer56.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer56.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer56.IsSplitterFixed = true;
			this.splitContainer56.Location = new System.Drawing.Point(0, 0);
			this.splitContainer56.Name = "splitContainer56";
			// 
			// splitContainer56.Panel1
			// 
			this.splitContainer56.Panel1.Controls.Add(this.labelWisSave);
			// 
			// splitContainer56.Panel2
			// 
			this.splitContainer56.Panel2.Controls.Add(this.labelWisSaveMod);
			this.splitContainer56.Size = new System.Drawing.Size(120, 20);
			this.splitContainer56.SplitterDistance = 86;
			this.splitContainer56.TabIndex = 17;
			// 
			// labelWisSave
			// 
			this.labelWisSave.AutoSize = true;
			this.labelWisSave.Location = new System.Drawing.Point(0, 0);
			this.labelWisSave.Name = "labelWisSave";
			this.labelWisSave.Size = new System.Drawing.Size(45, 13);
			this.labelWisSave.TabIndex = 0;
			this.labelWisSave.Text = "Wisdom";
			// 
			// labelWisSaveMod
			// 
			this.labelWisSaveMod.AutoSize = true;
			this.labelWisSaveMod.Location = new System.Drawing.Point(3, 0);
			this.labelWisSaveMod.Name = "labelWisSaveMod";
			this.labelWisSaveMod.Size = new System.Drawing.Size(71, 13);
			this.labelWisSaveMod.TabIndex = 0;
			this.labelWisSaveMod.Text = "WisSaveMod";
			// 
			// splitContainer57
			// 
			this.splitContainer57.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer57.IsSplitterFixed = true;
			this.splitContainer57.Location = new System.Drawing.Point(6, 97);
			this.splitContainer57.Name = "splitContainer57";
			// 
			// splitContainer57.Panel1
			// 
			this.splitContainer57.Panel1.Controls.Add(this.checkBoxIntSave);
			// 
			// splitContainer57.Panel2
			// 
			this.splitContainer57.Panel2.Controls.Add(this.splitContainer58);
			this.splitContainer57.Size = new System.Drawing.Size(149, 20);
			this.splitContainer57.SplitterDistance = 25;
			this.splitContainer57.TabIndex = 20;
			// 
			// checkBoxIntSave
			// 
			this.checkBoxIntSave.AutoSize = true;
			this.checkBoxIntSave.Location = new System.Drawing.Point(7, 3);
			this.checkBoxIntSave.Name = "checkBoxIntSave";
			this.checkBoxIntSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxIntSave.TabIndex = 0;
			this.checkBoxIntSave.UseVisualStyleBackColor = true;
			this.checkBoxIntSave.CheckedChanged += new System.EventHandler(this.checkBoxIntSave_CheckedChanged);
			// 
			// splitContainer58
			// 
			this.splitContainer58.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer58.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer58.IsSplitterFixed = true;
			this.splitContainer58.Location = new System.Drawing.Point(0, 0);
			this.splitContainer58.Name = "splitContainer58";
			// 
			// splitContainer58.Panel1
			// 
			this.splitContainer58.Panel1.Controls.Add(this.labelIntSave);
			// 
			// splitContainer58.Panel2
			// 
			this.splitContainer58.Panel2.Controls.Add(this.labelIntSaveMod);
			this.splitContainer58.Size = new System.Drawing.Size(120, 20);
			this.splitContainer58.SplitterDistance = 86;
			this.splitContainer58.TabIndex = 17;
			// 
			// labelIntSave
			// 
			this.labelIntSave.AutoSize = true;
			this.labelIntSave.Location = new System.Drawing.Point(0, 0);
			this.labelIntSave.Name = "labelIntSave";
			this.labelIntSave.Size = new System.Drawing.Size(61, 13);
			this.labelIntSave.TabIndex = 0;
			this.labelIntSave.Text = "Intelligence";
			// 
			// labelIntSaveMod
			// 
			this.labelIntSaveMod.AutoSize = true;
			this.labelIntSaveMod.Location = new System.Drawing.Point(3, 0);
			this.labelIntSaveMod.Name = "labelIntSaveMod";
			this.labelIntSaveMod.Size = new System.Drawing.Size(65, 13);
			this.labelIntSaveMod.TabIndex = 0;
			this.labelIntSaveMod.Text = "IntSaveMod";
			// 
			// splitContainer11
			// 
			this.splitContainer11.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer11.Location = new System.Drawing.Point(6, 71);
			this.splitContainer11.Name = "splitContainer11";
			// 
			// splitContainer11.Panel1
			// 
			this.splitContainer11.Panel1.Controls.Add(this.checkBoxConSave);
			// 
			// splitContainer11.Panel2
			// 
			this.splitContainer11.Panel2.Controls.Add(this.splitContainer12);
			this.splitContainer11.Size = new System.Drawing.Size(149, 20);
			this.splitContainer11.SplitterDistance = 25;
			this.splitContainer11.TabIndex = 19;
			// 
			// checkBoxConSave
			// 
			this.checkBoxConSave.AutoSize = true;
			this.checkBoxConSave.Location = new System.Drawing.Point(7, 3);
			this.checkBoxConSave.Name = "checkBoxConSave";
			this.checkBoxConSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxConSave.TabIndex = 0;
			this.checkBoxConSave.UseVisualStyleBackColor = true;
			this.checkBoxConSave.CheckedChanged += new System.EventHandler(this.checkBoxConSave_CheckedChanged);
			// 
			// splitContainer12
			// 
			this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer12.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer12.IsSplitterFixed = true;
			this.splitContainer12.Location = new System.Drawing.Point(0, 0);
			this.splitContainer12.Name = "splitContainer12";
			// 
			// splitContainer12.Panel1
			// 
			this.splitContainer12.Panel1.Controls.Add(this.labelConSave);
			// 
			// splitContainer12.Panel2
			// 
			this.splitContainer12.Panel2.Controls.Add(this.labelConSaveMod);
			this.splitContainer12.Size = new System.Drawing.Size(120, 20);
			this.splitContainer12.SplitterDistance = 86;
			this.splitContainer12.TabIndex = 17;
			// 
			// labelConSave
			// 
			this.labelConSave.AutoSize = true;
			this.labelConSave.Location = new System.Drawing.Point(0, 0);
			this.labelConSave.Name = "labelConSave";
			this.labelConSave.Size = new System.Drawing.Size(62, 13);
			this.labelConSave.TabIndex = 0;
			this.labelConSave.Text = "Constitution";
			// 
			// labelConSaveMod
			// 
			this.labelConSaveMod.AutoSize = true;
			this.labelConSaveMod.Location = new System.Drawing.Point(3, 0);
			this.labelConSaveMod.Name = "labelConSaveMod";
			this.labelConSaveMod.Size = new System.Drawing.Size(72, 13);
			this.labelConSaveMod.TabIndex = 0;
			this.labelConSaveMod.Text = "ConSaveMod";
			// 
			// splitContainer9
			// 
			this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer9.IsSplitterFixed = true;
			this.splitContainer9.Location = new System.Drawing.Point(6, 45);
			this.splitContainer9.Name = "splitContainer9";
			// 
			// splitContainer9.Panel1
			// 
			this.splitContainer9.Panel1.Controls.Add(this.checkBoxDexSave);
			// 
			// splitContainer9.Panel2
			// 
			this.splitContainer9.Panel2.Controls.Add(this.splitContainer10);
			this.splitContainer9.Size = new System.Drawing.Size(149, 20);
			this.splitContainer9.SplitterDistance = 25;
			this.splitContainer9.TabIndex = 18;
			// 
			// checkBoxDexSave
			// 
			this.checkBoxDexSave.AutoSize = true;
			this.checkBoxDexSave.Location = new System.Drawing.Point(7, 3);
			this.checkBoxDexSave.Name = "checkBoxDexSave";
			this.checkBoxDexSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxDexSave.TabIndex = 0;
			this.checkBoxDexSave.UseVisualStyleBackColor = true;
			this.checkBoxDexSave.CheckedChanged += new System.EventHandler(this.checkBoxDexSave_CheckedChanged);
			// 
			// splitContainer10
			// 
			this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer10.IsSplitterFixed = true;
			this.splitContainer10.Location = new System.Drawing.Point(0, 0);
			this.splitContainer10.Name = "splitContainer10";
			// 
			// splitContainer10.Panel1
			// 
			this.splitContainer10.Panel1.Controls.Add(this.labelDexSave);
			// 
			// splitContainer10.Panel2
			// 
			this.splitContainer10.Panel2.Controls.Add(this.labelDexSaveMod);
			this.splitContainer10.Size = new System.Drawing.Size(120, 20);
			this.splitContainer10.SplitterDistance = 86;
			this.splitContainer10.TabIndex = 17;
			// 
			// labelDexSave
			// 
			this.labelDexSave.AutoSize = true;
			this.labelDexSave.Location = new System.Drawing.Point(0, 0);
			this.labelDexSave.Name = "labelDexSave";
			this.labelDexSave.Size = new System.Drawing.Size(48, 13);
			this.labelDexSave.TabIndex = 0;
			this.labelDexSave.Text = "Dexterity";
			// 
			// labelDexSaveMod
			// 
			this.labelDexSaveMod.AutoSize = true;
			this.labelDexSaveMod.Location = new System.Drawing.Point(3, 0);
			this.labelDexSaveMod.Name = "labelDexSaveMod";
			this.labelDexSaveMod.Size = new System.Drawing.Size(72, 13);
			this.labelDexSaveMod.TabIndex = 0;
			this.labelDexSaveMod.Text = "DexSaveMod";
			// 
			// splitContainer7
			// 
			this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer7.IsSplitterFixed = true;
			this.splitContainer7.Location = new System.Drawing.Point(6, 19);
			this.splitContainer7.Name = "splitContainer7";
			// 
			// splitContainer7.Panel1
			// 
			this.splitContainer7.Panel1.Controls.Add(this.checkBoxStrSave);
			// 
			// splitContainer7.Panel2
			// 
			this.splitContainer7.Panel2.Controls.Add(this.splitContainer8);
			this.splitContainer7.Size = new System.Drawing.Size(149, 20);
			this.splitContainer7.SplitterDistance = 25;
			this.splitContainer7.TabIndex = 17;
			// 
			// checkBoxStrSave
			// 
			this.checkBoxStrSave.AutoSize = true;
			this.checkBoxStrSave.Location = new System.Drawing.Point(7, 3);
			this.checkBoxStrSave.Name = "checkBoxStrSave";
			this.checkBoxStrSave.Size = new System.Drawing.Size(15, 14);
			this.checkBoxStrSave.TabIndex = 0;
			this.checkBoxStrSave.UseVisualStyleBackColor = true;
			this.checkBoxStrSave.CheckedChanged += new System.EventHandler(this.checkBoxStrSave_CheckedChanged);
			// 
			// splitContainer8
			// 
			this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer8.IsSplitterFixed = true;
			this.splitContainer8.Location = new System.Drawing.Point(0, 0);
			this.splitContainer8.Name = "splitContainer8";
			// 
			// splitContainer8.Panel1
			// 
			this.splitContainer8.Panel1.Controls.Add(this.labelStrSave);
			// 
			// splitContainer8.Panel2
			// 
			this.splitContainer8.Panel2.Controls.Add(this.labelStrSaveMod);
			this.splitContainer8.Size = new System.Drawing.Size(120, 20);
			this.splitContainer8.SplitterDistance = 86;
			this.splitContainer8.TabIndex = 17;
			// 
			// labelStrSave
			// 
			this.labelStrSave.AutoSize = true;
			this.labelStrSave.Location = new System.Drawing.Point(0, 0);
			this.labelStrSave.Name = "labelStrSave";
			this.labelStrSave.Size = new System.Drawing.Size(47, 13);
			this.labelStrSave.TabIndex = 0;
			this.labelStrSave.Text = "Strength";
			// 
			// labelStrSaveMod
			// 
			this.labelStrSaveMod.AutoSize = true;
			this.labelStrSaveMod.Location = new System.Drawing.Point(3, 0);
			this.labelStrSaveMod.Name = "labelStrSaveMod";
			this.labelStrSaveMod.Size = new System.Drawing.Size(66, 13);
			this.labelStrSaveMod.TabIndex = 0;
			this.labelStrSaveMod.Text = "StrSaveMod";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.splitContainer49);
			this.groupBox2.Controls.Add(this.splitContainer51);
			this.groupBox2.Controls.Add(this.splitContainer47);
			this.groupBox2.Controls.Add(this.splitContainer33);
			this.groupBox2.Controls.Add(this.splitContainer35);
			this.groupBox2.Controls.Add(this.splitContainer37);
			this.groupBox2.Controls.Add(this.splitContainer39);
			this.groupBox2.Controls.Add(this.splitContainer41);
			this.groupBox2.Controls.Add(this.splitContainer43);
			this.groupBox2.Controls.Add(this.splitContainer45);
			this.groupBox2.Controls.Add(this.splitContainer25);
			this.groupBox2.Controls.Add(this.splitContainer27);
			this.groupBox2.Controls.Add(this.splitContainer29);
			this.groupBox2.Controls.Add(this.splitContainer31);
			this.groupBox2.Controls.Add(this.splitContainer21);
			this.groupBox2.Controls.Add(this.splitContainer23);
			this.groupBox2.Controls.Add(this.splitContainer19);
			this.groupBox2.Controls.Add(this.splitContainer15);
			this.groupBox2.Location = new System.Drawing.Point(173, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 490);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Skill Proficiencies";
			// 
			// splitContainer49
			// 
			this.splitContainer49.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer49.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer49.IsSplitterFixed = true;
			this.splitContainer49.Location = new System.Drawing.Point(6, 461);
			this.splitContainer49.Name = "splitContainer49";
			// 
			// splitContainer49.Panel1
			// 
			this.splitContainer49.Panel1.Controls.Add(this.checkBoxPers);
			// 
			// splitContainer49.Panel2
			// 
			this.splitContainer49.Panel2.Controls.Add(this.splitContainer50);
			this.splitContainer49.Size = new System.Drawing.Size(148, 20);
			this.splitContainer49.SplitterDistance = 25;
			this.splitContainer49.TabIndex = 34;
			// 
			// checkBoxPers
			// 
			this.checkBoxPers.AutoSize = true;
			this.checkBoxPers.Location = new System.Drawing.Point(7, 3);
			this.checkBoxPers.Name = "checkBoxPers";
			this.checkBoxPers.Size = new System.Drawing.Size(15, 14);
			this.checkBoxPers.TabIndex = 0;
			this.checkBoxPers.UseVisualStyleBackColor = true;
			this.checkBoxPers.CheckedChanged += new System.EventHandler(this.checkBoxPers_CheckedChanged);
			// 
			// splitContainer50
			// 
			this.splitContainer50.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer50.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer50.IsSplitterFixed = true;
			this.splitContainer50.Location = new System.Drawing.Point(0, 0);
			this.splitContainer50.Name = "splitContainer50";
			// 
			// splitContainer50.Panel1
			// 
			this.splitContainer50.Panel1.Controls.Add(this.labelPers);
			// 
			// splitContainer50.Panel2
			// 
			this.splitContainer50.Panel2.Controls.Add(this.labelPersMod);
			this.splitContainer50.Size = new System.Drawing.Size(119, 20);
			this.splitContainer50.SplitterDistance = 90;
			this.splitContainer50.TabIndex = 17;
			// 
			// labelPers
			// 
			this.labelPers.AutoSize = true;
			this.labelPers.Location = new System.Drawing.Point(0, 0);
			this.labelPers.Name = "labelPers";
			this.labelPers.Size = new System.Drawing.Size(59, 13);
			this.labelPers.TabIndex = 0;
			this.labelPers.Text = "Persuasion";
			// 
			// labelPersMod
			// 
			this.labelPersMod.AutoSize = true;
			this.labelPersMod.Location = new System.Drawing.Point(3, 0);
			this.labelPersMod.Name = "labelPersMod";
			this.labelPersMod.Size = new System.Drawing.Size(44, 13);
			this.labelPersMod.TabIndex = 0;
			this.labelPersMod.Text = "PerMod";
			this.toolTip1.SetToolTip(this.labelPersMod, "Charisma Modifier");
			// 
			// splitContainer51
			// 
			this.splitContainer51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer51.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer51.IsSplitterFixed = true;
			this.splitContainer51.Location = new System.Drawing.Point(6, 435);
			this.splitContainer51.Name = "splitContainer51";
			// 
			// splitContainer51.Panel1
			// 
			this.splitContainer51.Panel1.Controls.Add(this.checkBoxPerf);
			// 
			// splitContainer51.Panel2
			// 
			this.splitContainer51.Panel2.Controls.Add(this.splitContainer52);
			this.splitContainer51.Size = new System.Drawing.Size(148, 20);
			this.splitContainer51.SplitterDistance = 25;
			this.splitContainer51.TabIndex = 33;
			// 
			// checkBoxPerf
			// 
			this.checkBoxPerf.AutoSize = true;
			this.checkBoxPerf.Location = new System.Drawing.Point(7, 3);
			this.checkBoxPerf.Name = "checkBoxPerf";
			this.checkBoxPerf.Size = new System.Drawing.Size(15, 14);
			this.checkBoxPerf.TabIndex = 0;
			this.checkBoxPerf.UseVisualStyleBackColor = true;
			this.checkBoxPerf.CheckedChanged += new System.EventHandler(this.checkBoxPerf_CheckedChanged);
			// 
			// splitContainer52
			// 
			this.splitContainer52.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer52.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer52.IsSplitterFixed = true;
			this.splitContainer52.Location = new System.Drawing.Point(0, 0);
			this.splitContainer52.Name = "splitContainer52";
			// 
			// splitContainer52.Panel1
			// 
			this.splitContainer52.Panel1.Controls.Add(this.labelPerf);
			// 
			// splitContainer52.Panel2
			// 
			this.splitContainer52.Panel2.Controls.Add(this.labelPerfMod);
			this.splitContainer52.Size = new System.Drawing.Size(119, 20);
			this.splitContainer52.SplitterDistance = 90;
			this.splitContainer52.TabIndex = 17;
			// 
			// labelPerf
			// 
			this.labelPerf.AutoSize = true;
			this.labelPerf.Location = new System.Drawing.Point(0, 0);
			this.labelPerf.Name = "labelPerf";
			this.labelPerf.Size = new System.Drawing.Size(67, 13);
			this.labelPerf.TabIndex = 0;
			this.labelPerf.Text = "Performance";
			// 
			// labelPerfMod
			// 
			this.labelPerfMod.AutoSize = true;
			this.labelPerfMod.Location = new System.Drawing.Point(3, 0);
			this.labelPerfMod.Name = "labelPerfMod";
			this.labelPerfMod.Size = new System.Drawing.Size(44, 13);
			this.labelPerfMod.TabIndex = 0;
			this.labelPerfMod.Text = "PerMod";
			this.toolTip1.SetToolTip(this.labelPerfMod, "Charisma Modifier");
			// 
			// splitContainer47
			// 
			this.splitContainer47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer47.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer47.IsSplitterFixed = true;
			this.splitContainer47.Location = new System.Drawing.Point(6, 227);
			this.splitContainer47.Name = "splitContainer47";
			// 
			// splitContainer47.Panel1
			// 
			this.splitContainer47.Panel1.Controls.Add(this.checkBoxRel);
			// 
			// splitContainer47.Panel2
			// 
			this.splitContainer47.Panel2.Controls.Add(this.splitContainer48);
			this.splitContainer47.Size = new System.Drawing.Size(148, 20);
			this.splitContainer47.SplitterDistance = 25;
			this.splitContainer47.TabIndex = 25;
			// 
			// checkBoxRel
			// 
			this.checkBoxRel.AutoSize = true;
			this.checkBoxRel.Location = new System.Drawing.Point(7, 3);
			this.checkBoxRel.Name = "checkBoxRel";
			this.checkBoxRel.Size = new System.Drawing.Size(15, 14);
			this.checkBoxRel.TabIndex = 0;
			this.checkBoxRel.UseVisualStyleBackColor = true;
			this.checkBoxRel.CheckedChanged += new System.EventHandler(this.checkBoxRel_CheckedChanged);
			// 
			// splitContainer48
			// 
			this.splitContainer48.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer48.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer48.IsSplitterFixed = true;
			this.splitContainer48.Location = new System.Drawing.Point(0, 0);
			this.splitContainer48.Name = "splitContainer48";
			// 
			// splitContainer48.Panel1
			// 
			this.splitContainer48.Panel1.Controls.Add(this.labelRel);
			// 
			// splitContainer48.Panel2
			// 
			this.splitContainer48.Panel2.Controls.Add(this.labelRelMod);
			this.splitContainer48.Size = new System.Drawing.Size(119, 20);
			this.splitContainer48.SplitterDistance = 90;
			this.splitContainer48.TabIndex = 17;
			// 
			// labelRel
			// 
			this.labelRel.AutoSize = true;
			this.labelRel.Location = new System.Drawing.Point(0, 0);
			this.labelRel.Name = "labelRel";
			this.labelRel.Size = new System.Drawing.Size(45, 13);
			this.labelRel.TabIndex = 0;
			this.labelRel.Text = "Religion";
			// 
			// labelRelMod
			// 
			this.labelRelMod.AutoSize = true;
			this.labelRelMod.Location = new System.Drawing.Point(3, 0);
			this.labelRelMod.Name = "labelRelMod";
			this.labelRelMod.Size = new System.Drawing.Size(44, 13);
			this.labelRelMod.TabIndex = 0;
			this.labelRelMod.Text = "RelMod";
			this.toolTip1.SetToolTip(this.labelRelMod, "Intelligence Modifier");
			// 
			// splitContainer33
			// 
			this.splitContainer33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer33.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer33.IsSplitterFixed = true;
			this.splitContainer33.Location = new System.Drawing.Point(6, 409);
			this.splitContainer33.Name = "splitContainer33";
			// 
			// splitContainer33.Panel1
			// 
			this.splitContainer33.Panel1.Controls.Add(this.checkBoxInti);
			// 
			// splitContainer33.Panel2
			// 
			this.splitContainer33.Panel2.Controls.Add(this.splitContainer34);
			this.splitContainer33.Size = new System.Drawing.Size(148, 20);
			this.splitContainer33.SplitterDistance = 25;
			this.splitContainer33.TabIndex = 32;
			// 
			// checkBoxInti
			// 
			this.checkBoxInti.AutoSize = true;
			this.checkBoxInti.Location = new System.Drawing.Point(7, 3);
			this.checkBoxInti.Name = "checkBoxInti";
			this.checkBoxInti.Size = new System.Drawing.Size(15, 14);
			this.checkBoxInti.TabIndex = 0;
			this.checkBoxInti.UseVisualStyleBackColor = true;
			this.checkBoxInti.CheckedChanged += new System.EventHandler(this.checkBoxInti_CheckedChanged);
			// 
			// splitContainer34
			// 
			this.splitContainer34.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer34.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer34.IsSplitterFixed = true;
			this.splitContainer34.Location = new System.Drawing.Point(0, 0);
			this.splitContainer34.Name = "splitContainer34";
			// 
			// splitContainer34.Panel1
			// 
			this.splitContainer34.Panel1.Controls.Add(this.labelInti);
			// 
			// splitContainer34.Panel2
			// 
			this.splitContainer34.Panel2.Controls.Add(this.labelIntiMod);
			this.splitContainer34.Size = new System.Drawing.Size(119, 20);
			this.splitContainer34.SplitterDistance = 90;
			this.splitContainer34.TabIndex = 17;
			// 
			// labelInti
			// 
			this.labelInti.AutoSize = true;
			this.labelInti.Location = new System.Drawing.Point(0, 0);
			this.labelInti.Name = "labelInti";
			this.labelInti.Size = new System.Drawing.Size(60, 13);
			this.labelInti.TabIndex = 0;
			this.labelInti.Text = "Intimidation";
			// 
			// labelIntiMod
			// 
			this.labelIntiMod.AutoSize = true;
			this.labelIntiMod.Location = new System.Drawing.Point(3, 0);
			this.labelIntiMod.Name = "labelIntiMod";
			this.labelIntiMod.Size = new System.Drawing.Size(40, 13);
			this.labelIntiMod.TabIndex = 0;
			this.labelIntiMod.Text = "IntMod";
			this.toolTip1.SetToolTip(this.labelIntiMod, "Charisma Modifier");
			// 
			// splitContainer35
			// 
			this.splitContainer35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer35.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer35.IsSplitterFixed = true;
			this.splitContainer35.Location = new System.Drawing.Point(6, 383);
			this.splitContainer35.Name = "splitContainer35";
			// 
			// splitContainer35.Panel1
			// 
			this.splitContainer35.Panel1.Controls.Add(this.checkBoxDec);
			// 
			// splitContainer35.Panel2
			// 
			this.splitContainer35.Panel2.Controls.Add(this.splitContainer36);
			this.splitContainer35.Size = new System.Drawing.Size(148, 20);
			this.splitContainer35.SplitterDistance = 25;
			this.splitContainer35.TabIndex = 31;
			// 
			// checkBoxDec
			// 
			this.checkBoxDec.AutoSize = true;
			this.checkBoxDec.Location = new System.Drawing.Point(7, 3);
			this.checkBoxDec.Name = "checkBoxDec";
			this.checkBoxDec.Size = new System.Drawing.Size(15, 14);
			this.checkBoxDec.TabIndex = 0;
			this.checkBoxDec.UseVisualStyleBackColor = true;
			this.checkBoxDec.CheckedChanged += new System.EventHandler(this.checkBoxDec_CheckedChanged);
			// 
			// splitContainer36
			// 
			this.splitContainer36.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer36.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer36.IsSplitterFixed = true;
			this.splitContainer36.Location = new System.Drawing.Point(0, 0);
			this.splitContainer36.Name = "splitContainer36";
			// 
			// splitContainer36.Panel1
			// 
			this.splitContainer36.Panel1.Controls.Add(this.labelDec);
			// 
			// splitContainer36.Panel2
			// 
			this.splitContainer36.Panel2.Controls.Add(this.labelDecMod);
			this.splitContainer36.Size = new System.Drawing.Size(119, 20);
			this.splitContainer36.SplitterDistance = 90;
			this.splitContainer36.TabIndex = 17;
			// 
			// labelDec
			// 
			this.labelDec.AutoSize = true;
			this.labelDec.Location = new System.Drawing.Point(0, 0);
			this.labelDec.Name = "labelDec";
			this.labelDec.Size = new System.Drawing.Size(56, 13);
			this.labelDec.TabIndex = 0;
			this.labelDec.Text = "Deception";
			// 
			// labelDecMod
			// 
			this.labelDecMod.AutoSize = true;
			this.labelDecMod.Location = new System.Drawing.Point(3, 0);
			this.labelDecMod.Name = "labelDecMod";
			this.labelDecMod.Size = new System.Drawing.Size(48, 13);
			this.labelDecMod.TabIndex = 0;
			this.labelDecMod.Text = "DecMod";
			this.toolTip1.SetToolTip(this.labelDecMod, "Charisma Modifier");
			// 
			// splitContainer37
			// 
			this.splitContainer37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer37.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer37.IsSplitterFixed = true;
			this.splitContainer37.Location = new System.Drawing.Point(6, 357);
			this.splitContainer37.Name = "splitContainer37";
			// 
			// splitContainer37.Panel1
			// 
			this.splitContainer37.Panel1.Controls.Add(this.checkBoxSur);
			// 
			// splitContainer37.Panel2
			// 
			this.splitContainer37.Panel2.Controls.Add(this.splitContainer38);
			this.splitContainer37.Size = new System.Drawing.Size(148, 20);
			this.splitContainer37.SplitterDistance = 25;
			this.splitContainer37.TabIndex = 30;
			// 
			// checkBoxSur
			// 
			this.checkBoxSur.AutoSize = true;
			this.checkBoxSur.Location = new System.Drawing.Point(7, 3);
			this.checkBoxSur.Name = "checkBoxSur";
			this.checkBoxSur.Size = new System.Drawing.Size(15, 14);
			this.checkBoxSur.TabIndex = 0;
			this.checkBoxSur.UseVisualStyleBackColor = true;
			this.checkBoxSur.CheckedChanged += new System.EventHandler(this.checkBoxSur_CheckedChanged);
			// 
			// splitContainer38
			// 
			this.splitContainer38.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer38.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer38.IsSplitterFixed = true;
			this.splitContainer38.Location = new System.Drawing.Point(0, 0);
			this.splitContainer38.Name = "splitContainer38";
			// 
			// splitContainer38.Panel1
			// 
			this.splitContainer38.Panel1.Controls.Add(this.labelSur);
			// 
			// splitContainer38.Panel2
			// 
			this.splitContainer38.Panel2.Controls.Add(this.labelSurMod);
			this.splitContainer38.Size = new System.Drawing.Size(119, 20);
			this.splitContainer38.SplitterDistance = 90;
			this.splitContainer38.TabIndex = 17;
			// 
			// labelSur
			// 
			this.labelSur.AutoSize = true;
			this.labelSur.Location = new System.Drawing.Point(0, 0);
			this.labelSur.Name = "labelSur";
			this.labelSur.Size = new System.Drawing.Size(45, 13);
			this.labelSur.TabIndex = 0;
			this.labelSur.Text = "Survival";
			// 
			// labelSurMod
			// 
			this.labelSurMod.AutoSize = true;
			this.labelSurMod.Location = new System.Drawing.Point(3, 0);
			this.labelSurMod.Name = "labelSurMod";
			this.labelSurMod.Size = new System.Drawing.Size(44, 13);
			this.labelSurMod.TabIndex = 0;
			this.labelSurMod.Text = "SurMod";
			this.toolTip1.SetToolTip(this.labelSurMod, "Wisdom Modifier");
			// 
			// splitContainer39
			// 
			this.splitContainer39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer39.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer39.IsSplitterFixed = true;
			this.splitContainer39.Location = new System.Drawing.Point(6, 331);
			this.splitContainer39.Name = "splitContainer39";
			// 
			// splitContainer39.Panel1
			// 
			this.splitContainer39.Panel1.Controls.Add(this.checkBoxPer);
			// 
			// splitContainer39.Panel2
			// 
			this.splitContainer39.Panel2.Controls.Add(this.splitContainer40);
			this.splitContainer39.Size = new System.Drawing.Size(148, 20);
			this.splitContainer39.SplitterDistance = 25;
			this.splitContainer39.TabIndex = 29;
			// 
			// checkBoxPer
			// 
			this.checkBoxPer.AutoSize = true;
			this.checkBoxPer.Location = new System.Drawing.Point(7, 3);
			this.checkBoxPer.Name = "checkBoxPer";
			this.checkBoxPer.Size = new System.Drawing.Size(15, 14);
			this.checkBoxPer.TabIndex = 0;
			this.checkBoxPer.UseVisualStyleBackColor = true;
			this.checkBoxPer.CheckedChanged += new System.EventHandler(this.checkBoxPer_CheckedChanged);
			// 
			// splitContainer40
			// 
			this.splitContainer40.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer40.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer40.Location = new System.Drawing.Point(0, 0);
			this.splitContainer40.Name = "splitContainer40";
			// 
			// splitContainer40.Panel1
			// 
			this.splitContainer40.Panel1.Controls.Add(this.labelPer);
			// 
			// splitContainer40.Panel2
			// 
			this.splitContainer40.Panel2.Controls.Add(this.labelPerMod);
			this.splitContainer40.Size = new System.Drawing.Size(119, 20);
			this.splitContainer40.SplitterDistance = 90;
			this.splitContainer40.TabIndex = 17;
			// 
			// labelPer
			// 
			this.labelPer.AutoSize = true;
			this.labelPer.Location = new System.Drawing.Point(0, 0);
			this.labelPer.Name = "labelPer";
			this.labelPer.Size = new System.Drawing.Size(58, 13);
			this.labelPer.TabIndex = 0;
			this.labelPer.Text = "Perception";
			// 
			// labelPerMod
			// 
			this.labelPerMod.AutoSize = true;
			this.labelPerMod.Location = new System.Drawing.Point(3, 0);
			this.labelPerMod.Name = "labelPerMod";
			this.labelPerMod.Size = new System.Drawing.Size(44, 13);
			this.labelPerMod.TabIndex = 0;
			this.labelPerMod.Text = "PerMod";
			this.toolTip1.SetToolTip(this.labelPerMod, "Wisdom Modifier");
			// 
			// splitContainer41
			// 
			this.splitContainer41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer41.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer41.IsSplitterFixed = true;
			this.splitContainer41.Location = new System.Drawing.Point(6, 305);
			this.splitContainer41.Name = "splitContainer41";
			// 
			// splitContainer41.Panel1
			// 
			this.splitContainer41.Panel1.Controls.Add(this.checkBoxMed);
			// 
			// splitContainer41.Panel2
			// 
			this.splitContainer41.Panel2.Controls.Add(this.splitContainer42);
			this.splitContainer41.Size = new System.Drawing.Size(148, 20);
			this.splitContainer41.SplitterDistance = 25;
			this.splitContainer41.TabIndex = 28;
			// 
			// checkBoxMed
			// 
			this.checkBoxMed.AutoSize = true;
			this.checkBoxMed.Location = new System.Drawing.Point(7, 3);
			this.checkBoxMed.Name = "checkBoxMed";
			this.checkBoxMed.Size = new System.Drawing.Size(15, 14);
			this.checkBoxMed.TabIndex = 0;
			this.checkBoxMed.UseVisualStyleBackColor = true;
			this.checkBoxMed.CheckedChanged += new System.EventHandler(this.checkBoxMed_CheckedChanged);
			// 
			// splitContainer42
			// 
			this.splitContainer42.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer42.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer42.IsSplitterFixed = true;
			this.splitContainer42.Location = new System.Drawing.Point(0, 0);
			this.splitContainer42.Name = "splitContainer42";
			// 
			// splitContainer42.Panel1
			// 
			this.splitContainer42.Panel1.Controls.Add(this.labelMed);
			// 
			// splitContainer42.Panel2
			// 
			this.splitContainer42.Panel2.Controls.Add(this.labelMedMod);
			this.splitContainer42.Size = new System.Drawing.Size(119, 20);
			this.splitContainer42.SplitterDistance = 90;
			this.splitContainer42.TabIndex = 17;
			// 
			// labelMed
			// 
			this.labelMed.AutoSize = true;
			this.labelMed.Location = new System.Drawing.Point(0, 0);
			this.labelMed.Name = "labelMed";
			this.labelMed.Size = new System.Drawing.Size(50, 13);
			this.labelMed.TabIndex = 0;
			this.labelMed.Text = "Medicine";
			// 
			// labelMedMod
			// 
			this.labelMedMod.AutoSize = true;
			this.labelMedMod.Location = new System.Drawing.Point(3, 0);
			this.labelMedMod.Name = "labelMedMod";
			this.labelMedMod.Size = new System.Drawing.Size(49, 13);
			this.labelMedMod.TabIndex = 0;
			this.labelMedMod.Text = "MedMod";
			this.toolTip1.SetToolTip(this.labelMedMod, "Wisdom Modifier");
			// 
			// splitContainer43
			// 
			this.splitContainer43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer43.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer43.IsSplitterFixed = true;
			this.splitContainer43.Location = new System.Drawing.Point(6, 279);
			this.splitContainer43.Name = "splitContainer43";
			// 
			// splitContainer43.Panel1
			// 
			this.splitContainer43.Panel1.Controls.Add(this.checkBoxIns);
			// 
			// splitContainer43.Panel2
			// 
			this.splitContainer43.Panel2.Controls.Add(this.splitContainer44);
			this.splitContainer43.Size = new System.Drawing.Size(148, 20);
			this.splitContainer43.SplitterDistance = 25;
			this.splitContainer43.TabIndex = 27;
			// 
			// checkBoxIns
			// 
			this.checkBoxIns.AutoSize = true;
			this.checkBoxIns.Location = new System.Drawing.Point(7, 3);
			this.checkBoxIns.Name = "checkBoxIns";
			this.checkBoxIns.Size = new System.Drawing.Size(15, 14);
			this.checkBoxIns.TabIndex = 0;
			this.checkBoxIns.UseVisualStyleBackColor = true;
			this.checkBoxIns.CheckedChanged += new System.EventHandler(this.checkBoxIns_CheckedChanged);
			// 
			// splitContainer44
			// 
			this.splitContainer44.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer44.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer44.IsSplitterFixed = true;
			this.splitContainer44.Location = new System.Drawing.Point(0, 0);
			this.splitContainer44.Name = "splitContainer44";
			// 
			// splitContainer44.Panel1
			// 
			this.splitContainer44.Panel1.Controls.Add(this.labelIns);
			// 
			// splitContainer44.Panel2
			// 
			this.splitContainer44.Panel2.Controls.Add(this.labelInsMod);
			this.splitContainer44.Size = new System.Drawing.Size(119, 20);
			this.splitContainer44.SplitterDistance = 90;
			this.splitContainer44.TabIndex = 17;
			// 
			// labelIns
			// 
			this.labelIns.AutoSize = true;
			this.labelIns.Location = new System.Drawing.Point(0, 0);
			this.labelIns.Name = "labelIns";
			this.labelIns.Size = new System.Drawing.Size(38, 13);
			this.labelIns.TabIndex = 0;
			this.labelIns.Text = "Insight";
			// 
			// labelInsMod
			// 
			this.labelInsMod.AutoSize = true;
			this.labelInsMod.Location = new System.Drawing.Point(3, 0);
			this.labelInsMod.Name = "labelInsMod";
			this.labelInsMod.Size = new System.Drawing.Size(42, 13);
			this.labelInsMod.TabIndex = 0;
			this.labelInsMod.Text = "InsMod";
			this.toolTip1.SetToolTip(this.labelInsMod, "Wisdom Modifier");
			// 
			// splitContainer45
			// 
			this.splitContainer45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer45.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer45.IsSplitterFixed = true;
			this.splitContainer45.Location = new System.Drawing.Point(6, 253);
			this.splitContainer45.Name = "splitContainer45";
			// 
			// splitContainer45.Panel1
			// 
			this.splitContainer45.Panel1.Controls.Add(this.checkBoxAnH);
			// 
			// splitContainer45.Panel2
			// 
			this.splitContainer45.Panel2.Controls.Add(this.splitContainer46);
			this.splitContainer45.Size = new System.Drawing.Size(148, 20);
			this.splitContainer45.SplitterDistance = 25;
			this.splitContainer45.TabIndex = 26;
			// 
			// checkBoxAnH
			// 
			this.checkBoxAnH.AutoSize = true;
			this.checkBoxAnH.Location = new System.Drawing.Point(7, 3);
			this.checkBoxAnH.Name = "checkBoxAnH";
			this.checkBoxAnH.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAnH.TabIndex = 0;
			this.checkBoxAnH.UseVisualStyleBackColor = true;
			this.checkBoxAnH.CheckedChanged += new System.EventHandler(this.checkBoxAnH_CheckedChanged);
			// 
			// splitContainer46
			// 
			this.splitContainer46.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer46.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer46.IsSplitterFixed = true;
			this.splitContainer46.Location = new System.Drawing.Point(0, 0);
			this.splitContainer46.Name = "splitContainer46";
			// 
			// splitContainer46.Panel1
			// 
			this.splitContainer46.Panel1.Controls.Add(this.labelAnH);
			// 
			// splitContainer46.Panel2
			// 
			this.splitContainer46.Panel2.Controls.Add(this.labelAnHMod);
			this.splitContainer46.Size = new System.Drawing.Size(119, 20);
			this.splitContainer46.SplitterDistance = 90;
			this.splitContainer46.TabIndex = 17;
			// 
			// labelAnH
			// 
			this.labelAnH.AutoSize = true;
			this.labelAnH.Location = new System.Drawing.Point(0, 0);
			this.labelAnH.Name = "labelAnH";
			this.labelAnH.Size = new System.Drawing.Size(83, 13);
			this.labelAnH.TabIndex = 0;
			this.labelAnH.Text = "Animal Handling";
			// 
			// labelAnHMod
			// 
			this.labelAnHMod.AutoSize = true;
			this.labelAnHMod.Location = new System.Drawing.Point(3, 0);
			this.labelAnHMod.Name = "labelAnHMod";
			this.labelAnHMod.Size = new System.Drawing.Size(44, 13);
			this.labelAnHMod.TabIndex = 0;
			this.labelAnHMod.Text = "AthMod";
			this.toolTip1.SetToolTip(this.labelAnHMod, "Wisdom Modifier");
			// 
			// splitContainer25
			// 
			this.splitContainer25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer25.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer25.IsSplitterFixed = true;
			this.splitContainer25.Location = new System.Drawing.Point(6, 201);
			this.splitContainer25.Name = "splitContainer25";
			// 
			// splitContainer25.Panel1
			// 
			this.splitContainer25.Panel1.Controls.Add(this.checkBoxNat);
			// 
			// splitContainer25.Panel2
			// 
			this.splitContainer25.Panel2.Controls.Add(this.splitContainer26);
			this.splitContainer25.Size = new System.Drawing.Size(148, 20);
			this.splitContainer25.SplitterDistance = 25;
			this.splitContainer25.TabIndex = 24;
			// 
			// checkBoxNat
			// 
			this.checkBoxNat.AutoSize = true;
			this.checkBoxNat.Location = new System.Drawing.Point(7, 3);
			this.checkBoxNat.Name = "checkBoxNat";
			this.checkBoxNat.Size = new System.Drawing.Size(15, 14);
			this.checkBoxNat.TabIndex = 0;
			this.checkBoxNat.UseVisualStyleBackColor = true;
			this.checkBoxNat.CheckedChanged += new System.EventHandler(this.checkBoxNat_CheckedChanged);
			// 
			// splitContainer26
			// 
			this.splitContainer26.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer26.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer26.IsSplitterFixed = true;
			this.splitContainer26.Location = new System.Drawing.Point(0, 0);
			this.splitContainer26.Name = "splitContainer26";
			// 
			// splitContainer26.Panel1
			// 
			this.splitContainer26.Panel1.Controls.Add(this.labelNat);
			// 
			// splitContainer26.Panel2
			// 
			this.splitContainer26.Panel2.Controls.Add(this.labelNatMod);
			this.splitContainer26.Size = new System.Drawing.Size(119, 20);
			this.splitContainer26.SplitterDistance = 90;
			this.splitContainer26.TabIndex = 17;
			// 
			// labelNat
			// 
			this.labelNat.AutoSize = true;
			this.labelNat.Location = new System.Drawing.Point(0, 0);
			this.labelNat.Name = "labelNat";
			this.labelNat.Size = new System.Drawing.Size(39, 13);
			this.labelNat.TabIndex = 0;
			this.labelNat.Text = "Nature";
			// 
			// labelNatMod
			// 
			this.labelNatMod.AutoSize = true;
			this.labelNatMod.Location = new System.Drawing.Point(3, 0);
			this.labelNatMod.Name = "labelNatMod";
			this.labelNatMod.Size = new System.Drawing.Size(45, 13);
			this.labelNatMod.TabIndex = 0;
			this.labelNatMod.Text = "NatMod";
			this.toolTip1.SetToolTip(this.labelNatMod, "Intelligence Modifier");
			// 
			// splitContainer27
			// 
			this.splitContainer27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer27.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer27.IsSplitterFixed = true;
			this.splitContainer27.Location = new System.Drawing.Point(6, 175);
			this.splitContainer27.Name = "splitContainer27";
			// 
			// splitContainer27.Panel1
			// 
			this.splitContainer27.Panel1.Controls.Add(this.checkBoxInv);
			// 
			// splitContainer27.Panel2
			// 
			this.splitContainer27.Panel2.Controls.Add(this.splitContainer28);
			this.splitContainer27.Size = new System.Drawing.Size(148, 20);
			this.splitContainer27.SplitterDistance = 25;
			this.splitContainer27.TabIndex = 23;
			// 
			// checkBoxInv
			// 
			this.checkBoxInv.AutoSize = true;
			this.checkBoxInv.Location = new System.Drawing.Point(7, 3);
			this.checkBoxInv.Name = "checkBoxInv";
			this.checkBoxInv.Size = new System.Drawing.Size(15, 14);
			this.checkBoxInv.TabIndex = 0;
			this.checkBoxInv.UseVisualStyleBackColor = true;
			this.checkBoxInv.CheckedChanged += new System.EventHandler(this.checkBoxInv_CheckedChanged);
			// 
			// splitContainer28
			// 
			this.splitContainer28.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer28.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer28.IsSplitterFixed = true;
			this.splitContainer28.Location = new System.Drawing.Point(0, 0);
			this.splitContainer28.Name = "splitContainer28";
			// 
			// splitContainer28.Panel1
			// 
			this.splitContainer28.Panel1.Controls.Add(this.labelInv);
			// 
			// splitContainer28.Panel2
			// 
			this.splitContainer28.Panel2.Controls.Add(this.labelInvMod);
			this.splitContainer28.Size = new System.Drawing.Size(119, 20);
			this.splitContainer28.SplitterDistance = 90;
			this.splitContainer28.TabIndex = 17;
			// 
			// labelInv
			// 
			this.labelInv.AutoSize = true;
			this.labelInv.Location = new System.Drawing.Point(0, 0);
			this.labelInv.Name = "labelInv";
			this.labelInv.Size = new System.Drawing.Size(67, 13);
			this.labelInv.TabIndex = 0;
			this.labelInv.Text = "Investigation";
			// 
			// labelInvMod
			// 
			this.labelInvMod.AutoSize = true;
			this.labelInvMod.Location = new System.Drawing.Point(3, 0);
			this.labelInvMod.Name = "labelInvMod";
			this.labelInvMod.Size = new System.Drawing.Size(43, 13);
			this.labelInvMod.TabIndex = 0;
			this.labelInvMod.Text = "InvMod";
			this.toolTip1.SetToolTip(this.labelInvMod, "Intelligence Modifier");
			// 
			// splitContainer29
			// 
			this.splitContainer29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer29.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer29.IsSplitterFixed = true;
			this.splitContainer29.Location = new System.Drawing.Point(6, 149);
			this.splitContainer29.Name = "splitContainer29";
			// 
			// splitContainer29.Panel1
			// 
			this.splitContainer29.Panel1.Controls.Add(this.checkBoxHis);
			// 
			// splitContainer29.Panel2
			// 
			this.splitContainer29.Panel2.Controls.Add(this.splitContainer30);
			this.splitContainer29.Size = new System.Drawing.Size(148, 20);
			this.splitContainer29.SplitterDistance = 25;
			this.splitContainer29.TabIndex = 22;
			// 
			// checkBoxHis
			// 
			this.checkBoxHis.AutoSize = true;
			this.checkBoxHis.Location = new System.Drawing.Point(7, 3);
			this.checkBoxHis.Name = "checkBoxHis";
			this.checkBoxHis.Size = new System.Drawing.Size(15, 14);
			this.checkBoxHis.TabIndex = 0;
			this.checkBoxHis.UseVisualStyleBackColor = true;
			this.checkBoxHis.CheckedChanged += new System.EventHandler(this.checkBoxHis_CheckedChanged);
			// 
			// splitContainer30
			// 
			this.splitContainer30.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer30.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer30.Location = new System.Drawing.Point(0, 0);
			this.splitContainer30.Name = "splitContainer30";
			// 
			// splitContainer30.Panel1
			// 
			this.splitContainer30.Panel1.Controls.Add(this.labelHis);
			// 
			// splitContainer30.Panel2
			// 
			this.splitContainer30.Panel2.Controls.Add(this.labelHisMod);
			this.splitContainer30.Size = new System.Drawing.Size(119, 20);
			this.splitContainer30.SplitterDistance = 90;
			this.splitContainer30.TabIndex = 17;
			// 
			// labelHis
			// 
			this.labelHis.AutoSize = true;
			this.labelHis.Location = new System.Drawing.Point(0, 0);
			this.labelHis.Name = "labelHis";
			this.labelHis.Size = new System.Drawing.Size(39, 13);
			this.labelHis.TabIndex = 0;
			this.labelHis.Text = "History";
			// 
			// labelHisMod
			// 
			this.labelHisMod.AutoSize = true;
			this.labelHisMod.Location = new System.Drawing.Point(3, 0);
			this.labelHisMod.Name = "labelHisMod";
			this.labelHisMod.Size = new System.Drawing.Size(43, 13);
			this.labelHisMod.TabIndex = 0;
			this.labelHisMod.Text = "HisMod";
			this.toolTip1.SetToolTip(this.labelHisMod, "Intelligence Modifier");
			// 
			// splitContainer31
			// 
			this.splitContainer31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer31.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer31.IsSplitterFixed = true;
			this.splitContainer31.Location = new System.Drawing.Point(6, 123);
			this.splitContainer31.Name = "splitContainer31";
			// 
			// splitContainer31.Panel1
			// 
			this.splitContainer31.Panel1.Controls.Add(this.checkBoxArc);
			// 
			// splitContainer31.Panel2
			// 
			this.splitContainer31.Panel2.Controls.Add(this.splitContainer32);
			this.splitContainer31.Size = new System.Drawing.Size(148, 20);
			this.splitContainer31.SplitterDistance = 25;
			this.splitContainer31.TabIndex = 21;
			// 
			// checkBoxArc
			// 
			this.checkBoxArc.AutoSize = true;
			this.checkBoxArc.Location = new System.Drawing.Point(7, 3);
			this.checkBoxArc.Name = "checkBoxArc";
			this.checkBoxArc.Size = new System.Drawing.Size(15, 14);
			this.checkBoxArc.TabIndex = 0;
			this.checkBoxArc.UseVisualStyleBackColor = true;
			this.checkBoxArc.CheckedChanged += new System.EventHandler(this.checkBoxArc_CheckedChanged);
			// 
			// splitContainer32
			// 
			this.splitContainer32.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer32.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer32.Location = new System.Drawing.Point(0, 0);
			this.splitContainer32.Name = "splitContainer32";
			// 
			// splitContainer32.Panel1
			// 
			this.splitContainer32.Panel1.Controls.Add(this.labelArc);
			// 
			// splitContainer32.Panel2
			// 
			this.splitContainer32.Panel2.Controls.Add(this.labelArcMod);
			this.splitContainer32.Size = new System.Drawing.Size(119, 20);
			this.splitContainer32.SplitterDistance = 90;
			this.splitContainer32.TabIndex = 17;
			// 
			// labelArc
			// 
			this.labelArc.AutoSize = true;
			this.labelArc.Location = new System.Drawing.Point(0, 0);
			this.labelArc.Name = "labelArc";
			this.labelArc.Size = new System.Drawing.Size(41, 13);
			this.labelArc.TabIndex = 0;
			this.labelArc.Text = "Arcana";
			// 
			// labelArcMod
			// 
			this.labelArcMod.AutoSize = true;
			this.labelArcMod.Location = new System.Drawing.Point(3, 0);
			this.labelArcMod.Name = "labelArcMod";
			this.labelArcMod.Size = new System.Drawing.Size(44, 13);
			this.labelArcMod.TabIndex = 0;
			this.labelArcMod.Text = "ArcMod";
			this.toolTip1.SetToolTip(this.labelArcMod, "Intelligence Modifier");
			// 
			// splitContainer21
			// 
			this.splitContainer21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer21.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer21.IsSplitterFixed = true;
			this.splitContainer21.Location = new System.Drawing.Point(6, 97);
			this.splitContainer21.Name = "splitContainer21";
			// 
			// splitContainer21.Panel1
			// 
			this.splitContainer21.Panel1.Controls.Add(this.checkBoxSte);
			// 
			// splitContainer21.Panel2
			// 
			this.splitContainer21.Panel2.Controls.Add(this.splitContainer22);
			this.splitContainer21.Size = new System.Drawing.Size(148, 20);
			this.splitContainer21.SplitterDistance = 25;
			this.splitContainer21.TabIndex = 20;
			// 
			// checkBoxSte
			// 
			this.checkBoxSte.AutoSize = true;
			this.checkBoxSte.Location = new System.Drawing.Point(7, 3);
			this.checkBoxSte.Name = "checkBoxSte";
			this.checkBoxSte.Size = new System.Drawing.Size(15, 14);
			this.checkBoxSte.TabIndex = 0;
			this.checkBoxSte.UseVisualStyleBackColor = true;
			this.checkBoxSte.CheckedChanged += new System.EventHandler(this.checkBoxSte_CheckedChanged);
			// 
			// splitContainer22
			// 
			this.splitContainer22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer22.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer22.Location = new System.Drawing.Point(0, 0);
			this.splitContainer22.Name = "splitContainer22";
			// 
			// splitContainer22.Panel1
			// 
			this.splitContainer22.Panel1.Controls.Add(this.labeSte);
			// 
			// splitContainer22.Panel2
			// 
			this.splitContainer22.Panel2.Controls.Add(this.labelSteMod);
			this.splitContainer22.Size = new System.Drawing.Size(119, 20);
			this.splitContainer22.SplitterDistance = 90;
			this.splitContainer22.TabIndex = 17;
			// 
			// labeSte
			// 
			this.labeSte.AutoSize = true;
			this.labeSte.Location = new System.Drawing.Point(0, 0);
			this.labeSte.Name = "labeSte";
			this.labeSte.Size = new System.Drawing.Size(40, 13);
			this.labeSte.TabIndex = 0;
			this.labeSte.Text = "Stealth";
			// 
			// labelSteMod
			// 
			this.labelSteMod.AutoSize = true;
			this.labelSteMod.Location = new System.Drawing.Point(3, 0);
			this.labelSteMod.Name = "labelSteMod";
			this.labelSteMod.Size = new System.Drawing.Size(44, 13);
			this.labelSteMod.TabIndex = 0;
			this.labelSteMod.Text = "SteMod";
			this.toolTip1.SetToolTip(this.labelSteMod, "Dexterity Modifier");
			// 
			// splitContainer23
			// 
			this.splitContainer23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer23.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer23.IsSplitterFixed = true;
			this.splitContainer23.Location = new System.Drawing.Point(6, 71);
			this.splitContainer23.Name = "splitContainer23";
			// 
			// splitContainer23.Panel1
			// 
			this.splitContainer23.Panel1.Controls.Add(this.checkBoxSOH);
			// 
			// splitContainer23.Panel2
			// 
			this.splitContainer23.Panel2.Controls.Add(this.splitContainer24);
			this.splitContainer23.Size = new System.Drawing.Size(148, 20);
			this.splitContainer23.SplitterDistance = 25;
			this.splitContainer23.TabIndex = 19;
			// 
			// checkBoxSOH
			// 
			this.checkBoxSOH.AutoSize = true;
			this.checkBoxSOH.Location = new System.Drawing.Point(7, 3);
			this.checkBoxSOH.Name = "checkBoxSOH";
			this.checkBoxSOH.Size = new System.Drawing.Size(15, 14);
			this.checkBoxSOH.TabIndex = 0;
			this.checkBoxSOH.UseVisualStyleBackColor = true;
			this.checkBoxSOH.CheckedChanged += new System.EventHandler(this.checkBoxSOH_CheckedChanged);
			// 
			// splitContainer24
			// 
			this.splitContainer24.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer24.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer24.Location = new System.Drawing.Point(0, 0);
			this.splitContainer24.Name = "splitContainer24";
			// 
			// splitContainer24.Panel1
			// 
			this.splitContainer24.Panel1.Controls.Add(this.labelSOH);
			// 
			// splitContainer24.Panel2
			// 
			this.splitContainer24.Panel2.Controls.Add(this.labelSOHMod);
			this.splitContainer24.Size = new System.Drawing.Size(119, 20);
			this.splitContainer24.SplitterDistance = 90;
			this.splitContainer24.TabIndex = 17;
			// 
			// labelSOH
			// 
			this.labelSOH.AutoSize = true;
			this.labelSOH.Location = new System.Drawing.Point(0, 0);
			this.labelSOH.Name = "labelSOH";
			this.labelSOH.Size = new System.Drawing.Size(80, 13);
			this.labelSOH.TabIndex = 0;
			this.labelSOH.Text = "Sleight of Hand";
			// 
			// labelSOHMod
			// 
			this.labelSOHMod.AutoSize = true;
			this.labelSOHMod.Location = new System.Drawing.Point(3, 0);
			this.labelSOHMod.Name = "labelSOHMod";
			this.labelSOHMod.Size = new System.Drawing.Size(51, 13);
			this.labelSOHMod.TabIndex = 0;
			this.labelSOHMod.Text = "SOHMod";
			this.toolTip1.SetToolTip(this.labelSOHMod, "Dexterity Modifier");
			// 
			// splitContainer19
			// 
			this.splitContainer19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer19.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer19.IsSplitterFixed = true;
			this.splitContainer19.Location = new System.Drawing.Point(6, 45);
			this.splitContainer19.Name = "splitContainer19";
			// 
			// splitContainer19.Panel1
			// 
			this.splitContainer19.Panel1.Controls.Add(this.checkBoxAcr);
			// 
			// splitContainer19.Panel2
			// 
			this.splitContainer19.Panel2.Controls.Add(this.splitContainer20);
			this.splitContainer19.Size = new System.Drawing.Size(148, 20);
			this.splitContainer19.SplitterDistance = 25;
			this.splitContainer19.TabIndex = 18;
			// 
			// checkBoxAcr
			// 
			this.checkBoxAcr.AutoSize = true;
			this.checkBoxAcr.Location = new System.Drawing.Point(7, 3);
			this.checkBoxAcr.Name = "checkBoxAcr";
			this.checkBoxAcr.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAcr.TabIndex = 0;
			this.checkBoxAcr.UseVisualStyleBackColor = true;
			this.checkBoxAcr.CheckedChanged += new System.EventHandler(this.checkBoxAcr_CheckedChanged);
			// 
			// splitContainer20
			// 
			this.splitContainer20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer20.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer20.Location = new System.Drawing.Point(0, 0);
			this.splitContainer20.Name = "splitContainer20";
			// 
			// splitContainer20.Panel1
			// 
			this.splitContainer20.Panel1.Controls.Add(this.labelAcr);
			// 
			// splitContainer20.Panel2
			// 
			this.splitContainer20.Panel2.Controls.Add(this.labelAcrMod);
			this.splitContainer20.Size = new System.Drawing.Size(119, 20);
			this.splitContainer20.SplitterDistance = 90;
			this.splitContainer20.TabIndex = 17;
			// 
			// labelAcr
			// 
			this.labelAcr.AutoSize = true;
			this.labelAcr.Location = new System.Drawing.Point(0, 0);
			this.labelAcr.Name = "labelAcr";
			this.labelAcr.Size = new System.Drawing.Size(57, 13);
			this.labelAcr.TabIndex = 0;
			this.labelAcr.Text = "Acrobatics";
			// 
			// labelAcrMod
			// 
			this.labelAcrMod.AutoSize = true;
			this.labelAcrMod.Location = new System.Drawing.Point(3, 0);
			this.labelAcrMod.Name = "labelAcrMod";
			this.labelAcrMod.Size = new System.Drawing.Size(44, 13);
			this.labelAcrMod.TabIndex = 0;
			this.labelAcrMod.Text = "AcrMod";
			this.toolTip1.SetToolTip(this.labelAcrMod, "Dexterity Modifier");
			// 
			// splitContainer15
			// 
			this.splitContainer15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer15.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer15.IsSplitterFixed = true;
			this.splitContainer15.Location = new System.Drawing.Point(6, 19);
			this.splitContainer15.Name = "splitContainer15";
			// 
			// splitContainer15.Panel1
			// 
			this.splitContainer15.Panel1.Controls.Add(this.checkBoxAth);
			// 
			// splitContainer15.Panel2
			// 
			this.splitContainer15.Panel2.Controls.Add(this.splitContainer16);
			this.splitContainer15.Size = new System.Drawing.Size(148, 20);
			this.splitContainer15.SplitterDistance = 25;
			this.splitContainer15.TabIndex = 17;
			// 
			// checkBoxAth
			// 
			this.checkBoxAth.AutoSize = true;
			this.checkBoxAth.Location = new System.Drawing.Point(7, 3);
			this.checkBoxAth.Name = "checkBoxAth";
			this.checkBoxAth.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAth.TabIndex = 0;
			this.checkBoxAth.UseVisualStyleBackColor = true;
			this.checkBoxAth.CheckedChanged += new System.EventHandler(this.checkBoxAth_CheckedChanged);
			// 
			// splitContainer16
			// 
			this.splitContainer16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer16.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer16.Location = new System.Drawing.Point(0, 0);
			this.splitContainer16.Name = "splitContainer16";
			// 
			// splitContainer16.Panel1
			// 
			this.splitContainer16.Panel1.Controls.Add(this.labelAth);
			// 
			// splitContainer16.Panel2
			// 
			this.splitContainer16.Panel2.Controls.Add(this.labelAthMod);
			this.splitContainer16.Size = new System.Drawing.Size(119, 20);
			this.splitContainer16.SplitterDistance = 90;
			this.splitContainer16.TabIndex = 17;
			// 
			// labelAth
			// 
			this.labelAth.AutoSize = true;
			this.labelAth.Location = new System.Drawing.Point(0, 0);
			this.labelAth.Name = "labelAth";
			this.labelAth.Size = new System.Drawing.Size(47, 13);
			this.labelAth.TabIndex = 0;
			this.labelAth.Text = "Athletics";
			// 
			// labelAthMod
			// 
			this.labelAthMod.AutoSize = true;
			this.labelAthMod.Location = new System.Drawing.Point(3, 0);
			this.labelAthMod.Name = "labelAthMod";
			this.labelAthMod.Size = new System.Drawing.Size(44, 13);
			this.labelAthMod.TabIndex = 0;
			this.labelAthMod.Text = "AthMod";
			this.toolTip1.SetToolTip(this.labelAthMod, "Strength Modifier");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Max Health";
			this.toolTip1.SetToolTip(this.label2, "Maximum natural health");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Temp Health";
			this.toolTip1.SetToolTip(this.label5, "Health that will be used first");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Current Health";
			this.toolTip1.SetToolTip(this.label6, "current natural health");
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Total Health";
			this.toolTip1.SetToolTip(this.label7, "Current Health + Temp Health");
			// 
			// splitContainer18
			// 
			this.splitContainer18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.splitContainer18.Location = new System.Drawing.Point(6, 102);
			this.splitContainer18.Name = "splitContainer18";
			// 
			// splitContainer18.Panel1
			// 
			this.splitContainer18.Panel1.Controls.Add(this.numericUpDownTakeDamage);
			// 
			// splitContainer18.Panel2
			// 
			this.splitContainer18.Panel2.Controls.Add(this.buttonTakeDamage);
			this.splitContainer18.Size = new System.Drawing.Size(272, 28);
			this.splitContainer18.SplitterDistance = 135;
			this.splitContainer18.TabIndex = 22;
			this.splitContainer18.TabStop = false;
			// 
			// numericUpDownTakeDamage
			// 
			this.numericUpDownTakeDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownTakeDamage.Location = new System.Drawing.Point(4, 4);
			this.numericUpDownTakeDamage.Name = "numericUpDownTakeDamage";
			this.numericUpDownTakeDamage.Size = new System.Drawing.Size(128, 20);
			this.numericUpDownTakeDamage.TabIndex = 0;
			// 
			// buttonTakeDamage
			// 
			this.buttonTakeDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTakeDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTakeDamage.Location = new System.Drawing.Point(3, 3);
			this.buttonTakeDamage.Name = "buttonTakeDamage";
			this.buttonTakeDamage.Size = new System.Drawing.Size(127, 23);
			this.buttonTakeDamage.TabIndex = 0;
			this.buttonTakeDamage.Text = "Take Damage";
			this.buttonTakeDamage.UseVisualStyleBackColor = true;
			this.buttonTakeDamage.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonResetHealth
			// 
			this.buttonResetHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonResetHealth.Location = new System.Drawing.Point(148, 76);
			this.buttonResetHealth.Name = "buttonResetHealth";
			this.buttonResetHealth.Size = new System.Drawing.Size(127, 23);
			this.buttonResetHealth.TabIndex = 17;
			this.buttonResetHealth.Text = "Reset Health";
			this.buttonResetHealth.UseVisualStyleBackColor = true;
			this.buttonResetHealth.Click += new System.EventHandler(this.buttonResetHealth_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.splitContainer62);
			this.groupBox4.Controls.Add(this.splitContainer61);
			this.groupBox4.Controls.Add(this.splitContainer60);
			this.groupBox4.Controls.Add(this.buttonResetHealth);
			this.groupBox4.Controls.Add(this.splitContainer18);
			this.groupBox4.Controls.Add(this.splitContainer59);
			this.groupBox4.Location = new System.Drawing.Point(358, 27);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(284, 136);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Health";
			// 
			// splitContainer62
			// 
			this.splitContainer62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer62.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer62.IsSplitterFixed = true;
			this.splitContainer62.Location = new System.Drawing.Point(147, 48);
			this.splitContainer62.Name = "splitContainer62";
			// 
			// splitContainer62.Panel1
			// 
			this.splitContainer62.Panel1.Controls.Add(this.label7);
			// 
			// splitContainer62.Panel2
			// 
			this.splitContainer62.Panel2.Controls.Add(this.labelTotalHealth);
			this.splitContainer62.Size = new System.Drawing.Size(131, 25);
			this.splitContainer62.SplitterDistance = 80;
			this.splitContainer62.TabIndex = 29;
			this.splitContainer62.TabStop = false;
			// 
			// labelTotalHealth
			// 
			this.labelTotalHealth.AutoSize = true;
			this.labelTotalHealth.Location = new System.Drawing.Point(3, 5);
			this.labelTotalHealth.Name = "labelTotalHealth";
			this.labelTotalHealth.Size = new System.Drawing.Size(62, 13);
			this.labelTotalHealth.TabIndex = 0;
			this.labelTotalHealth.Text = "TotalHealth";
			// 
			// splitContainer61
			// 
			this.splitContainer61.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer61.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer61.IsSplitterFixed = true;
			this.splitContainer61.Location = new System.Drawing.Point(147, 19);
			this.splitContainer61.Name = "splitContainer61";
			// 
			// splitContainer61.Panel1
			// 
			this.splitContainer61.Panel1.Controls.Add(this.label6);
			// 
			// splitContainer61.Panel2
			// 
			this.splitContainer61.Panel2.Controls.Add(this.numericUpDownCurrentHealth);
			this.splitContainer61.Size = new System.Drawing.Size(131, 25);
			this.splitContainer61.SplitterDistance = 80;
			this.splitContainer61.TabIndex = 28;
			this.splitContainer61.TabStop = false;
			// 
			// numericUpDownCurrentHealth
			// 
			this.numericUpDownCurrentHealth.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownCurrentHealth.Name = "numericUpDownCurrentHealth";
			this.numericUpDownCurrentHealth.Size = new System.Drawing.Size(41, 20);
			this.numericUpDownCurrentHealth.TabIndex = 17;
			this.numericUpDownCurrentHealth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownCurrentHealth.ValueChanged += new System.EventHandler(this.numericUpDownCurrentHealth_ValueChanged);
			// 
			// splitContainer60
			// 
			this.splitContainer60.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer60.IsSplitterFixed = true;
			this.splitContainer60.Location = new System.Drawing.Point(6, 48);
			this.splitContainer60.Name = "splitContainer60";
			// 
			// splitContainer60.Panel1
			// 
			this.splitContainer60.Panel1.Controls.Add(this.label5);
			// 
			// splitContainer60.Panel2
			// 
			this.splitContainer60.Panel2.Controls.Add(this.numericUpDownTempHealth);
			this.splitContainer60.Size = new System.Drawing.Size(131, 25);
			this.splitContainer60.SplitterDistance = 80;
			this.splitContainer60.TabIndex = 27;
			this.splitContainer60.TabStop = false;
			// 
			// numericUpDownTempHealth
			// 
			this.numericUpDownTempHealth.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownTempHealth.Name = "numericUpDownTempHealth";
			this.numericUpDownTempHealth.Size = new System.Drawing.Size(41, 20);
			this.numericUpDownTempHealth.TabIndex = 17;
			this.numericUpDownTempHealth.ValueChanged += new System.EventHandler(this.numericUpDownTempHealth_ValueChanged);
			// 
			// splitContainer59
			// 
			this.splitContainer59.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer59.IsSplitterFixed = true;
			this.splitContainer59.Location = new System.Drawing.Point(6, 19);
			this.splitContainer59.Name = "splitContainer59";
			// 
			// splitContainer59.Panel1
			// 
			this.splitContainer59.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer59.Panel2
			// 
			this.splitContainer59.Panel2.Controls.Add(this.numericUpDownMaxHealth);
			this.splitContainer59.Size = new System.Drawing.Size(131, 25);
			this.splitContainer59.SplitterDistance = 80;
			this.splitContainer59.TabIndex = 26;
			this.splitContainer59.TabStop = false;
			// 
			// numericUpDownMaxHealth
			// 
			this.numericUpDownMaxHealth.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownMaxHealth.Name = "numericUpDownMaxHealth";
			this.numericUpDownMaxHealth.Size = new System.Drawing.Size(41, 20);
			this.numericUpDownMaxHealth.TabIndex = 17;
			this.numericUpDownMaxHealth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownMaxHealth.ValueChanged += new System.EventHandler(this.numericUpDownMaxHealth_ValueChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.CheckFileExists = false;
			this.openFileDialog1.DefaultExt = "xml";
			this.openFileDialog1.FileName = "DnDCharacter";
			this.openFileDialog1.Filter = "xml files|*.xml";
			this.openFileDialog1.InitialDirectory = "./overwatch/";
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "xml";
			this.saveFileDialog1.FileName = "DnDCharacter";
			this.saveFileDialog1.Filter = "xml files|*.xml";
			this.saveFileDialog1.InitialDirectory = "../";
			this.saveFileDialog1.RestoreDirectory = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 835);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "D&D Manager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxCoreStats.ResumeLayout(false);
			this.groupBoxCoreStats.PerformLayout();
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCha)).EndInit();
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel1.PerformLayout();
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWis)).EndInit();
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel1.PerformLayout();
			this.splitContainer6.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
			this.splitContainer6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownInt)).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCon)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDex)).EndInit();
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel1.PerformLayout();
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStr)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.splitContainer17.Panel1.ResumeLayout(false);
			this.splitContainer17.Panel1.PerformLayout();
			this.splitContainer17.Panel2.ResumeLayout(false);
			this.splitContainer17.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer17)).EndInit();
			this.splitContainer17.ResumeLayout(false);
			this.splitContainer14.Panel1.ResumeLayout(false);
			this.splitContainer14.Panel1.PerformLayout();
			this.splitContainer14.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).EndInit();
			this.splitContainer14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownInspiration)).EndInit();
			this.splitContainer13.Panel1.ResumeLayout(false);
			this.splitContainer13.Panel1.PerformLayout();
			this.splitContainer13.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).EndInit();
			this.splitContainer13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownProficiencyBonus)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.splitContainer53.Panel1.ResumeLayout(false);
			this.splitContainer53.Panel1.PerformLayout();
			this.splitContainer53.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer53)).EndInit();
			this.splitContainer53.ResumeLayout(false);
			this.splitContainer54.Panel1.ResumeLayout(false);
			this.splitContainer54.Panel1.PerformLayout();
			this.splitContainer54.Panel2.ResumeLayout(false);
			this.splitContainer54.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer54)).EndInit();
			this.splitContainer54.ResumeLayout(false);
			this.splitContainer55.Panel1.ResumeLayout(false);
			this.splitContainer55.Panel1.PerformLayout();
			this.splitContainer55.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer55)).EndInit();
			this.splitContainer55.ResumeLayout(false);
			this.splitContainer56.Panel1.ResumeLayout(false);
			this.splitContainer56.Panel1.PerformLayout();
			this.splitContainer56.Panel2.ResumeLayout(false);
			this.splitContainer56.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer56)).EndInit();
			this.splitContainer56.ResumeLayout(false);
			this.splitContainer57.Panel1.ResumeLayout(false);
			this.splitContainer57.Panel1.PerformLayout();
			this.splitContainer57.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer57)).EndInit();
			this.splitContainer57.ResumeLayout(false);
			this.splitContainer58.Panel1.ResumeLayout(false);
			this.splitContainer58.Panel1.PerformLayout();
			this.splitContainer58.Panel2.ResumeLayout(false);
			this.splitContainer58.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer58)).EndInit();
			this.splitContainer58.ResumeLayout(false);
			this.splitContainer11.Panel1.ResumeLayout(false);
			this.splitContainer11.Panel1.PerformLayout();
			this.splitContainer11.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
			this.splitContainer11.ResumeLayout(false);
			this.splitContainer12.Panel1.ResumeLayout(false);
			this.splitContainer12.Panel1.PerformLayout();
			this.splitContainer12.Panel2.ResumeLayout(false);
			this.splitContainer12.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
			this.splitContainer12.ResumeLayout(false);
			this.splitContainer9.Panel1.ResumeLayout(false);
			this.splitContainer9.Panel1.PerformLayout();
			this.splitContainer9.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
			this.splitContainer9.ResumeLayout(false);
			this.splitContainer10.Panel1.ResumeLayout(false);
			this.splitContainer10.Panel1.PerformLayout();
			this.splitContainer10.Panel2.ResumeLayout(false);
			this.splitContainer10.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
			this.splitContainer10.ResumeLayout(false);
			this.splitContainer7.Panel1.ResumeLayout(false);
			this.splitContainer7.Panel1.PerformLayout();
			this.splitContainer7.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
			this.splitContainer7.ResumeLayout(false);
			this.splitContainer8.Panel1.ResumeLayout(false);
			this.splitContainer8.Panel1.PerformLayout();
			this.splitContainer8.Panel2.ResumeLayout(false);
			this.splitContainer8.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
			this.splitContainer8.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.splitContainer49.Panel1.ResumeLayout(false);
			this.splitContainer49.Panel1.PerformLayout();
			this.splitContainer49.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer49)).EndInit();
			this.splitContainer49.ResumeLayout(false);
			this.splitContainer50.Panel1.ResumeLayout(false);
			this.splitContainer50.Panel1.PerformLayout();
			this.splitContainer50.Panel2.ResumeLayout(false);
			this.splitContainer50.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer50)).EndInit();
			this.splitContainer50.ResumeLayout(false);
			this.splitContainer51.Panel1.ResumeLayout(false);
			this.splitContainer51.Panel1.PerformLayout();
			this.splitContainer51.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer51)).EndInit();
			this.splitContainer51.ResumeLayout(false);
			this.splitContainer52.Panel1.ResumeLayout(false);
			this.splitContainer52.Panel1.PerformLayout();
			this.splitContainer52.Panel2.ResumeLayout(false);
			this.splitContainer52.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer52)).EndInit();
			this.splitContainer52.ResumeLayout(false);
			this.splitContainer47.Panel1.ResumeLayout(false);
			this.splitContainer47.Panel1.PerformLayout();
			this.splitContainer47.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer47)).EndInit();
			this.splitContainer47.ResumeLayout(false);
			this.splitContainer48.Panel1.ResumeLayout(false);
			this.splitContainer48.Panel1.PerformLayout();
			this.splitContainer48.Panel2.ResumeLayout(false);
			this.splitContainer48.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer48)).EndInit();
			this.splitContainer48.ResumeLayout(false);
			this.splitContainer33.Panel1.ResumeLayout(false);
			this.splitContainer33.Panel1.PerformLayout();
			this.splitContainer33.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer33)).EndInit();
			this.splitContainer33.ResumeLayout(false);
			this.splitContainer34.Panel1.ResumeLayout(false);
			this.splitContainer34.Panel1.PerformLayout();
			this.splitContainer34.Panel2.ResumeLayout(false);
			this.splitContainer34.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer34)).EndInit();
			this.splitContainer34.ResumeLayout(false);
			this.splitContainer35.Panel1.ResumeLayout(false);
			this.splitContainer35.Panel1.PerformLayout();
			this.splitContainer35.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer35)).EndInit();
			this.splitContainer35.ResumeLayout(false);
			this.splitContainer36.Panel1.ResumeLayout(false);
			this.splitContainer36.Panel1.PerformLayout();
			this.splitContainer36.Panel2.ResumeLayout(false);
			this.splitContainer36.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer36)).EndInit();
			this.splitContainer36.ResumeLayout(false);
			this.splitContainer37.Panel1.ResumeLayout(false);
			this.splitContainer37.Panel1.PerformLayout();
			this.splitContainer37.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer37)).EndInit();
			this.splitContainer37.ResumeLayout(false);
			this.splitContainer38.Panel1.ResumeLayout(false);
			this.splitContainer38.Panel1.PerformLayout();
			this.splitContainer38.Panel2.ResumeLayout(false);
			this.splitContainer38.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer38)).EndInit();
			this.splitContainer38.ResumeLayout(false);
			this.splitContainer39.Panel1.ResumeLayout(false);
			this.splitContainer39.Panel1.PerformLayout();
			this.splitContainer39.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer39)).EndInit();
			this.splitContainer39.ResumeLayout(false);
			this.splitContainer40.Panel1.ResumeLayout(false);
			this.splitContainer40.Panel1.PerformLayout();
			this.splitContainer40.Panel2.ResumeLayout(false);
			this.splitContainer40.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer40)).EndInit();
			this.splitContainer40.ResumeLayout(false);
			this.splitContainer41.Panel1.ResumeLayout(false);
			this.splitContainer41.Panel1.PerformLayout();
			this.splitContainer41.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer41)).EndInit();
			this.splitContainer41.ResumeLayout(false);
			this.splitContainer42.Panel1.ResumeLayout(false);
			this.splitContainer42.Panel1.PerformLayout();
			this.splitContainer42.Panel2.ResumeLayout(false);
			this.splitContainer42.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer42)).EndInit();
			this.splitContainer42.ResumeLayout(false);
			this.splitContainer43.Panel1.ResumeLayout(false);
			this.splitContainer43.Panel1.PerformLayout();
			this.splitContainer43.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer43)).EndInit();
			this.splitContainer43.ResumeLayout(false);
			this.splitContainer44.Panel1.ResumeLayout(false);
			this.splitContainer44.Panel1.PerformLayout();
			this.splitContainer44.Panel2.ResumeLayout(false);
			this.splitContainer44.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer44)).EndInit();
			this.splitContainer44.ResumeLayout(false);
			this.splitContainer45.Panel1.ResumeLayout(false);
			this.splitContainer45.Panel1.PerformLayout();
			this.splitContainer45.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer45)).EndInit();
			this.splitContainer45.ResumeLayout(false);
			this.splitContainer46.Panel1.ResumeLayout(false);
			this.splitContainer46.Panel1.PerformLayout();
			this.splitContainer46.Panel2.ResumeLayout(false);
			this.splitContainer46.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer46)).EndInit();
			this.splitContainer46.ResumeLayout(false);
			this.splitContainer25.Panel1.ResumeLayout(false);
			this.splitContainer25.Panel1.PerformLayout();
			this.splitContainer25.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer25)).EndInit();
			this.splitContainer25.ResumeLayout(false);
			this.splitContainer26.Panel1.ResumeLayout(false);
			this.splitContainer26.Panel1.PerformLayout();
			this.splitContainer26.Panel2.ResumeLayout(false);
			this.splitContainer26.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer26)).EndInit();
			this.splitContainer26.ResumeLayout(false);
			this.splitContainer27.Panel1.ResumeLayout(false);
			this.splitContainer27.Panel1.PerformLayout();
			this.splitContainer27.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer27)).EndInit();
			this.splitContainer27.ResumeLayout(false);
			this.splitContainer28.Panel1.ResumeLayout(false);
			this.splitContainer28.Panel1.PerformLayout();
			this.splitContainer28.Panel2.ResumeLayout(false);
			this.splitContainer28.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer28)).EndInit();
			this.splitContainer28.ResumeLayout(false);
			this.splitContainer29.Panel1.ResumeLayout(false);
			this.splitContainer29.Panel1.PerformLayout();
			this.splitContainer29.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer29)).EndInit();
			this.splitContainer29.ResumeLayout(false);
			this.splitContainer30.Panel1.ResumeLayout(false);
			this.splitContainer30.Panel1.PerformLayout();
			this.splitContainer30.Panel2.ResumeLayout(false);
			this.splitContainer30.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer30)).EndInit();
			this.splitContainer30.ResumeLayout(false);
			this.splitContainer31.Panel1.ResumeLayout(false);
			this.splitContainer31.Panel1.PerformLayout();
			this.splitContainer31.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer31)).EndInit();
			this.splitContainer31.ResumeLayout(false);
			this.splitContainer32.Panel1.ResumeLayout(false);
			this.splitContainer32.Panel1.PerformLayout();
			this.splitContainer32.Panel2.ResumeLayout(false);
			this.splitContainer32.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer32)).EndInit();
			this.splitContainer32.ResumeLayout(false);
			this.splitContainer21.Panel1.ResumeLayout(false);
			this.splitContainer21.Panel1.PerformLayout();
			this.splitContainer21.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer21)).EndInit();
			this.splitContainer21.ResumeLayout(false);
			this.splitContainer22.Panel1.ResumeLayout(false);
			this.splitContainer22.Panel1.PerformLayout();
			this.splitContainer22.Panel2.ResumeLayout(false);
			this.splitContainer22.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer22)).EndInit();
			this.splitContainer22.ResumeLayout(false);
			this.splitContainer23.Panel1.ResumeLayout(false);
			this.splitContainer23.Panel1.PerformLayout();
			this.splitContainer23.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer23)).EndInit();
			this.splitContainer23.ResumeLayout(false);
			this.splitContainer24.Panel1.ResumeLayout(false);
			this.splitContainer24.Panel1.PerformLayout();
			this.splitContainer24.Panel2.ResumeLayout(false);
			this.splitContainer24.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer24)).EndInit();
			this.splitContainer24.ResumeLayout(false);
			this.splitContainer19.Panel1.ResumeLayout(false);
			this.splitContainer19.Panel1.PerformLayout();
			this.splitContainer19.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer19)).EndInit();
			this.splitContainer19.ResumeLayout(false);
			this.splitContainer20.Panel1.ResumeLayout(false);
			this.splitContainer20.Panel1.PerformLayout();
			this.splitContainer20.Panel2.ResumeLayout(false);
			this.splitContainer20.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer20)).EndInit();
			this.splitContainer20.ResumeLayout(false);
			this.splitContainer15.Panel1.ResumeLayout(false);
			this.splitContainer15.Panel1.PerformLayout();
			this.splitContainer15.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer15)).EndInit();
			this.splitContainer15.ResumeLayout(false);
			this.splitContainer16.Panel1.ResumeLayout(false);
			this.splitContainer16.Panel1.PerformLayout();
			this.splitContainer16.Panel2.ResumeLayout(false);
			this.splitContainer16.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer16)).EndInit();
			this.splitContainer16.ResumeLayout(false);
			this.splitContainer18.Panel1.ResumeLayout(false);
			this.splitContainer18.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer18)).EndInit();
			this.splitContainer18.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTakeDamage)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.splitContainer62.Panel1.ResumeLayout(false);
			this.splitContainer62.Panel1.PerformLayout();
			this.splitContainer62.Panel2.ResumeLayout(false);
			this.splitContainer62.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer62)).EndInit();
			this.splitContainer62.ResumeLayout(false);
			this.splitContainer61.Panel1.ResumeLayout(false);
			this.splitContainer61.Panel1.PerformLayout();
			this.splitContainer61.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer61)).EndInit();
			this.splitContainer61.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentHealth)).EndInit();
			this.splitContainer60.Panel1.ResumeLayout(false);
			this.splitContainer60.Panel1.PerformLayout();
			this.splitContainer60.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer60)).EndInit();
			this.splitContainer60.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempHealth)).EndInit();
			this.splitContainer59.Panel1.ResumeLayout(false);
			this.splitContainer59.Panel1.PerformLayout();
			this.splitContainer59.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer59)).EndInit();
			this.splitContainer59.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxHealth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		
		// custom variables
		public Character m_character = null;
		InventoryWindow m_invWindow = null;

		// generated variables
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entry1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entry11ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entry111ToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxCoreStats;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.Label labelStr;
		private System.Windows.Forms.NumericUpDown numericUpDownStr;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Label labelCha;
		private System.Windows.Forms.NumericUpDown numericUpDownCha;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.Label labelWis;
		private System.Windows.Forms.NumericUpDown numericUpDownWis;
		private System.Windows.Forms.SplitContainer splitContainer6;
		private System.Windows.Forms.Label labelInt;
		private System.Windows.Forms.NumericUpDown numericUpDownInt;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label labelCon;
		private System.Windows.Forms.NumericUpDown numericUpDownCon;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label labelDex;
		private System.Windows.Forms.NumericUpDown numericUpDownDex;
		private System.Windows.Forms.Label labelStrMod;
		private System.Windows.Forms.Label labelDexMod;
		private System.Windows.Forms.Label labelChaMod;
		private System.Windows.Forms.Label labelWisMod;
		private System.Windows.Forms.Label labelIntMod;
		private System.Windows.Forms.Label labelConMod;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.SplitContainer splitContainer49;
		private System.Windows.Forms.CheckBox checkBoxPers;
		private System.Windows.Forms.SplitContainer splitContainer50;
		private System.Windows.Forms.Label labelPers;
		private System.Windows.Forms.Label labelPersMod;
		private System.Windows.Forms.SplitContainer splitContainer51;
		private System.Windows.Forms.CheckBox checkBoxPerf;
		private System.Windows.Forms.SplitContainer splitContainer52;
		private System.Windows.Forms.Label labelPerf;
		private System.Windows.Forms.Label labelPerfMod;
		private System.Windows.Forms.SplitContainer splitContainer47;
		private System.Windows.Forms.CheckBox checkBoxRel;
		private System.Windows.Forms.SplitContainer splitContainer48;
		private System.Windows.Forms.Label labelRel;
		private System.Windows.Forms.Label labelRelMod;
		private System.Windows.Forms.SplitContainer splitContainer33;
		private System.Windows.Forms.CheckBox checkBoxInti;
		private System.Windows.Forms.SplitContainer splitContainer34;
		private System.Windows.Forms.Label labelInti;
		private System.Windows.Forms.Label labelIntiMod;
		private System.Windows.Forms.SplitContainer splitContainer35;
		private System.Windows.Forms.CheckBox checkBoxDec;
		private System.Windows.Forms.SplitContainer splitContainer36;
		private System.Windows.Forms.Label labelDec;
		private System.Windows.Forms.Label labelDecMod;
		private System.Windows.Forms.SplitContainer splitContainer37;
		private System.Windows.Forms.CheckBox checkBoxSur;
		private System.Windows.Forms.SplitContainer splitContainer38;
		private System.Windows.Forms.Label labelSur;
		private System.Windows.Forms.Label labelSurMod;
		private System.Windows.Forms.SplitContainer splitContainer39;
		private System.Windows.Forms.CheckBox checkBoxPer;
		private System.Windows.Forms.SplitContainer splitContainer40;
		private System.Windows.Forms.Label labelPer;
		private System.Windows.Forms.Label labelPerMod;
		private System.Windows.Forms.SplitContainer splitContainer41;
		private System.Windows.Forms.CheckBox checkBoxMed;
		private System.Windows.Forms.SplitContainer splitContainer42;
		private System.Windows.Forms.Label labelMed;
		private System.Windows.Forms.Label labelMedMod;
		private System.Windows.Forms.SplitContainer splitContainer43;
		private System.Windows.Forms.CheckBox checkBoxIns;
		private System.Windows.Forms.SplitContainer splitContainer44;
		private System.Windows.Forms.Label labelIns;
		private System.Windows.Forms.Label labelInsMod;
		private System.Windows.Forms.SplitContainer splitContainer45;
		private System.Windows.Forms.CheckBox checkBoxAnH;
		private System.Windows.Forms.SplitContainer splitContainer46;
		private System.Windows.Forms.Label labelAnH;
		private System.Windows.Forms.Label labelAnHMod;
		private System.Windows.Forms.SplitContainer splitContainer25;
		private System.Windows.Forms.CheckBox checkBoxNat;
		private System.Windows.Forms.SplitContainer splitContainer26;
		private System.Windows.Forms.Label labelNat;
		private System.Windows.Forms.Label labelNatMod;
		private System.Windows.Forms.SplitContainer splitContainer27;
		private System.Windows.Forms.CheckBox checkBoxInv;
		private System.Windows.Forms.SplitContainer splitContainer28;
		private System.Windows.Forms.Label labelInv;
		private System.Windows.Forms.Label labelInvMod;
		private System.Windows.Forms.SplitContainer splitContainer29;
		private System.Windows.Forms.CheckBox checkBoxHis;
		private System.Windows.Forms.SplitContainer splitContainer30;
		private System.Windows.Forms.Label labelHis;
		private System.Windows.Forms.Label labelHisMod;
		private System.Windows.Forms.SplitContainer splitContainer31;
		private System.Windows.Forms.CheckBox checkBoxArc;
		private System.Windows.Forms.SplitContainer splitContainer32;
		private System.Windows.Forms.Label labelArc;
		private System.Windows.Forms.Label labelArcMod;
		private System.Windows.Forms.SplitContainer splitContainer21;
		private System.Windows.Forms.CheckBox checkBoxSte;
		private System.Windows.Forms.SplitContainer splitContainer22;
		private System.Windows.Forms.Label labeSte;
		private System.Windows.Forms.Label labelSteMod;
		private System.Windows.Forms.SplitContainer splitContainer23;
		private System.Windows.Forms.CheckBox checkBoxSOH;
		private System.Windows.Forms.SplitContainer splitContainer24;
		private System.Windows.Forms.Label labelSOH;
		private System.Windows.Forms.Label labelSOHMod;
		private System.Windows.Forms.SplitContainer splitContainer19;
		private System.Windows.Forms.CheckBox checkBoxAcr;
		private System.Windows.Forms.SplitContainer splitContainer20;
		private System.Windows.Forms.Label labelAcr;
		private System.Windows.Forms.Label labelAcrMod;
		private System.Windows.Forms.SplitContainer splitContainer15;
		private System.Windows.Forms.CheckBox checkBoxAth;
		private System.Windows.Forms.SplitContainer splitContainer16;
		private System.Windows.Forms.Label labelAth;
		private System.Windows.Forms.Label labelAthMod;
		private System.Windows.Forms.SplitContainer splitContainer53;
		private System.Windows.Forms.CheckBox checkBoxChaSave;
		private System.Windows.Forms.SplitContainer splitContainer54;
		private System.Windows.Forms.Label labelChaSave;
		private System.Windows.Forms.Label labelChaSaveMod;
		private System.Windows.Forms.SplitContainer splitContainer55;
		private System.Windows.Forms.CheckBox checkBoxWisSave;
		private System.Windows.Forms.SplitContainer splitContainer56;
		private System.Windows.Forms.Label labelWisSave;
		private System.Windows.Forms.Label labelWisSaveMod;
		private System.Windows.Forms.SplitContainer splitContainer57;
		private System.Windows.Forms.CheckBox checkBoxIntSave;
		private System.Windows.Forms.SplitContainer splitContainer58;
		private System.Windows.Forms.Label labelIntSave;
		private System.Windows.Forms.Label labelIntSaveMod;
		private System.Windows.Forms.SplitContainer splitContainer11;
		private System.Windows.Forms.CheckBox checkBoxConSave;
		private System.Windows.Forms.SplitContainer splitContainer12;
		private System.Windows.Forms.Label labelConSave;
		private System.Windows.Forms.Label labelConSaveMod;
		private System.Windows.Forms.SplitContainer splitContainer9;
		private System.Windows.Forms.CheckBox checkBoxDexSave;
		private System.Windows.Forms.SplitContainer splitContainer10;
		private System.Windows.Forms.Label labelDexSave;
		private System.Windows.Forms.Label labelDexSaveMod;
		private System.Windows.Forms.SplitContainer splitContainer7;
		private System.Windows.Forms.CheckBox checkBoxStrSave;
		private System.Windows.Forms.SplitContainer splitContainer8;
		private System.Windows.Forms.Label labelStrSave;
		private System.Windows.Forms.Label labelStrSaveMod;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.SplitContainer splitContainer13;
		private System.Windows.Forms.Label labelProficiencyBonus;
		private System.Windows.Forms.NumericUpDown numericUpDownProficiencyBonus;
		private System.Windows.Forms.SplitContainer splitContainer17;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelPasPer;
		private System.Windows.Forms.SplitContainer splitContainer14;
		private System.Windows.Forms.Label labelInspiration;
		private System.Windows.Forms.NumericUpDown numericUpDownInspiration;
		private System.Windows.Forms.SplitContainer splitContainer18;
		private System.Windows.Forms.NumericUpDown numericUpDownTakeDamage;
		private System.Windows.Forms.Button buttonTakeDamage;
		private System.Windows.Forms.Button buttonResetHealth;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.SplitContainer splitContainer61;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownCurrentHealth;
		private System.Windows.Forms.SplitContainer splitContainer60;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDownTempHealth;
		private System.Windows.Forms.SplitContainer splitContainer59;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxHealth;
		private System.Windows.Forms.SplitContainer splitContainer62;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelTotalHealth;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
	}
}

