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
	public partial class Form1 : Form
	{



		public Form1()
		{
			InitializeComponent();
			if (m_character == null)
			{
				m_character = new Character();
			}
		}
		
		void newCharacter()
		{
			// load new character
			m_character = new Character();
			updateForm();
		}

		void loadCharacter()
		{
			openFileDialog1.ShowDialog();
		}

		void saveCharacter()
		{
			saveFileDialog1.ShowDialog();
		}

		public void updateCharacter()
		{
			// update core stats
			m_character.m_str = (int)numericUpDownStr.Value;
			m_character.m_dex = (int)numericUpDownDex.Value;
			m_character.m_con = (int)numericUpDownCon.Value;
			m_character.m_int = (int)numericUpDownInt.Value;
			m_character.m_wis = (int)numericUpDownWis.Value;
			m_character.m_cha = (int)numericUpDownCha.Value;

			// saving throws
			m_character.m_stStr = checkBoxStrSave.Checked;
			m_character.m_stDex = checkBoxDexSave.Checked;
			m_character.m_stCon = checkBoxConSave.Checked;
			m_character.m_stInt = checkBoxIntSave.Checked;
			m_character.m_stWis = checkBoxWisSave.Checked;
			m_character.m_stCha = checkBoxChaSave.Checked;


			// skill proficencies
			m_character.m_sAcrobatics = checkBoxAcr.Checked;
			m_character.m_sAnimalHandling = checkBoxAnH.Checked;
			m_character.m_sArcana = checkBoxArc.Checked;
			m_character.m_sAthletics = checkBoxAth.Checked;
			m_character.m_sDeception = checkBoxDec.Checked;
			m_character.m_sHistory = checkBoxHis.Checked;
			m_character.m_sInsight = checkBoxIns.Checked;
			m_character.m_sIntimidation = checkBoxInti.Checked;
			m_character.m_sInvestigation = checkBoxInv.Checked;
			m_character.m_sMedicine = checkBoxMed.Checked;
			m_character.m_sNature = checkBoxNat.Checked;
			m_character.m_sPerception = checkBoxPer.Checked;
			m_character.m_sPerformance = checkBoxPerf.Checked;
			m_character.m_sPersuasion = checkBoxPers.Checked;
			m_character.m_sReligion = checkBoxRel.Checked;
			m_character.m_sSlightOfHand = checkBoxSOH.Checked;
			m_character.m_sStealth = checkBoxSte.Checked;
			m_character.m_sSurvival = checkBoxSur.Checked;

			// set proficiency bonus
			m_character.m_proficencyBonus = (int)numericUpDownProficiencyBonus.Value;

			// update health
			m_character.m_maxHealth = (float)numericUpDownMaxHealth.Value;
			m_character.m_currentHealth = (float)numericUpDownCurrentHealth.Value;
			m_character.m_tempHealth = (float)numericUpDownTempHealth.Value;
		}

		public void updateForm()
		{
			// core stats
			numericUpDownStr.Value = m_character.m_str;
			numericUpDownDex.Value = m_character.m_dex;
			numericUpDownCon.Value = m_character.m_con;
			numericUpDownInt.Value = m_character.m_int;
			numericUpDownWis.Value = m_character.m_wis;
			numericUpDownCha.Value = m_character.m_cha;

			// saving throws
			checkBoxStrSave.Checked = m_character.m_stStr;
			checkBoxDexSave.Checked = m_character.m_stDex;
			checkBoxConSave.Checked = m_character.m_stCon;
			checkBoxIntSave.Checked = m_character.m_stInt;
			checkBoxWisSave.Checked = m_character.m_stWis;
			checkBoxChaSave.Checked = m_character.m_stCha;


			// skill proficencies
			checkBoxAcr.Checked = m_character.m_sAcrobatics;
			checkBoxAnH.Checked = m_character.m_sAnimalHandling;
			checkBoxArc.Checked = m_character.m_sArcana;
			checkBoxAth.Checked = m_character.m_sAthletics;
			checkBoxDec.Checked = m_character.m_sDeception;
			checkBoxHis.Checked = m_character.m_sHistory;
			checkBoxIns.Checked = m_character.m_sInsight;
			checkBoxInti.Checked = m_character.m_sIntimidation;
			checkBoxInv.Checked = m_character.m_sInvestigation;
			checkBoxMed.Checked = m_character.m_sMedicine;
			checkBoxNat.Checked = m_character.m_sNature;
			checkBoxPer.Checked = m_character.m_sPerception;
			checkBoxPerf.Checked = m_character.m_sPerformance;
			checkBoxPers.Checked = m_character.m_sPersuasion;
			checkBoxRel.Checked = m_character.m_sReligion;
			checkBoxSOH.Checked = m_character.m_sSlightOfHand;
			checkBoxSte.Checked = m_character.m_sStealth;
			checkBoxSur.Checked = m_character.m_sSurvival;

			// set proficiency bonus
			numericUpDownProficiencyBonus.Value = m_character.m_proficencyBonus;

			// reset and health
			numericUpDownMaxHealth.Value = (decimal)m_character.m_maxHealth;
			numericUpDownCurrentHealth.Value = (decimal)m_character.m_currentHealth;
			numericUpDownTempHealth.Value = (decimal)m_character.m_tempHealth;


			// update labels

			labelTotalHealth.Text = (numericUpDownCurrentHealth.Value + numericUpDownTempHealth.Value).ToString();

			// set modifier text
			int val = (int)Math.Floor((numericUpDownStr.Value - 10) / 2);
			labelStrMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (m_character.m_stStr)
			{
				labelStrSaveMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelStrSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelStrSaveMod, "Strength Modifier" + (m_character.m_stStr ? " + Proficiency Bonus" : ""));
			if (m_character.m_sAthletics)
			{
				labelAthMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelAthMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelAthMod, "Strength Modifier" + (m_character.m_sAthletics ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownDex.Value - 10) / 2);
			labelDexMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (m_character.m_stDex)
			{
				labelDexSaveMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelDexSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelDexSaveMod, "Dexterity Modifier" + (m_character.m_stDex ? " + Proficiency Bonus" : ""));
			if (m_character.m_sAcrobatics)
			{
				labelAcrMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelAcrMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelAcrMod, "Dexterity Modifier" + (m_character.m_sAcrobatics ? " + Proficiency Bonus" : ""));
			if (m_character.m_sSlightOfHand)
			{
				labelSOHMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelSOHMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelSOHMod, "Dexterity Modifier" + (m_character.m_sSlightOfHand ? " + Proficiency Bonus" : ""));
			if (m_character.m_sStealth)
			{
				labelSteMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelSteMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelSteMod, "Dexterity Modifier" + (m_character.m_sStealth ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownCon.Value - 10) / 2);
			labelConMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (m_character.m_stCon)
			{
				labelConSaveMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelConSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelConSaveMod, "Constitution Modifier" + (m_character.m_stCon ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownInt.Value - 10) / 2);
			labelIntMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (m_character.m_stInt)
			{
				labelIntSaveMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelIntSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelIntSaveMod, "Intelligence Modifier" + (m_character.m_stInt ? " + Proficiency Bonus" : ""));
			if (m_character.m_sArcana)
			{
				labelArcMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelArcMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelArcMod, "Intelligence Modifier" + (m_character.m_sArcana ? " + Proficiency Bonus" : ""));
			if (m_character.m_sHistory)
			{
				labelHisMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelHisMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelHisMod, "Intelligence Modifier" + (m_character.m_sHistory ? " + Proficiency Bonus" : ""));
			if (m_character.m_sInvestigation)
			{
				labelInvMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelInvMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelInvMod, "Intelligence Modifier" + (m_character.m_sInvestigation ? " + Proficiency Bonus" : ""));
			if (m_character.m_sNature)
			{
				labelNatMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelNatMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelNatMod, "Intelligence Modifier" + (m_character.m_sNature ? " + Proficiency Bonus" : ""));
			if (m_character.m_sReligion)
			{
				labelRelMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelRelMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelRelMod, "Intelligence Modifier" + (m_character.m_sReligion ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownWis.Value - 10) / 2);
			labelWisMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (m_character.m_stWis)
			{
				labelWisSaveMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelWisSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelWisSaveMod, "Wisdom Modifier" + (m_character.m_stWis ? " + Proficiency Bonus" : ""));
			if (m_character.m_sAnimalHandling)
			{
				labelAnHMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelAnHMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelAnHMod, "Wisdom Modifier" + (m_character.m_sAnimalHandling ? " + Proficiency Bonus" : ""));
			if (m_character.m_sInsight)
			{
				labelInsMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelInsMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelInsMod, "Wisdom Modifier" + (m_character.m_sInsight ? " + Proficiency Bonus" : ""));
			if (m_character.m_sMedicine)
			{
				labelMedMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelMedMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelMedMod, "Wisdom Modifier" + (m_character.m_sMedicine ? " + Proficiency Bonus" : ""));
			if (m_character.m_sPerception)
			{
				labelPerMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelPerMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelPerMod, "Wisdom Modifier" + (m_character.m_sPerception ? " + Proficiency Bonus" : ""));
			// set passive perception
			labelPasPer.Text = (10 + (m_character.m_sPerception ? val + m_character.m_proficencyBonus : val)).ToString();
			if (m_character.m_sSurvival)
			{
				labelSurMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelSurMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelSurMod, "Wisdom Modifier" + (m_character.m_sSurvival ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownCha.Value - 10) / 2);
			labelChaMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (m_character.m_stCha)
			{
				labelChaSaveMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelChaSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelChaSaveMod, "Charisma Modifier" + (m_character.m_stCha ? " + Proficiency Bonus" : ""));
			if (m_character.m_sDeception)
			{
				labelDecMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelDecMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelDecMod, "Charisma Modifier" + (m_character.m_sDeception ? " + Proficiency Bonus" : ""));
			if (m_character.m_sIntimidation)
			{
				labelIntiMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelIntiMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelIntiMod, "Charisma Modifier" + (m_character.m_sIntimidation ? " + Proficiency Bonus" : ""));
			if (m_character.m_sPerformance)
			{
				labelPerfMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelPerfMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelPerfMod, "Charisma Modifier" + (m_character.m_sPerformance ? " + Proficiency Bonus" : ""));
			if (m_character.m_sPersuasion)
			{
				labelPersMod.Text = (val + m_character.m_proficencyBonus > 0 ? "+" + (val + m_character.m_proficencyBonus).ToString() : (val + m_character.m_proficencyBonus).ToString());
			}
			else
			{
				labelPersMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelPersMod, "Charisma Modifier" + (m_character.m_sPersuasion ? " + Proficiency Bonus" : ""));
		}

		// does not update any input, only the labels
		public void updateLabels()
		{
			labelTotalHealth.Text = (numericUpDownCurrentHealth.Value + numericUpDownTempHealth.Value).ToString();

			// set modifier text
			int val = (int)Math.Floor((numericUpDownStr.Value - 10) / 2);
			labelStrMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (checkBoxStrSave.Checked)
			{
				labelStrSaveMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelStrSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelStrSaveMod, "Strength Modifier" + (checkBoxStrSave.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxAth.Checked)
			{
				labelAthMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelAthMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelAthMod, "Strength Modifier" + (checkBoxAth.Checked ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownDex.Value - 10) / 2);
			labelDexMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (checkBoxDexSave.Checked)
			{
				labelDexSaveMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelDexSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelDexSaveMod, "Dexterity Modifier" + (checkBoxDexSave.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxAcr.Checked)
			{
				labelAcrMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelAcrMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelAcrMod, "Dexterity Modifier" + (checkBoxAcr.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxSOH.Checked)
			{
				labelSOHMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelSOHMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelSOHMod, "Dexterity Modifier" + (checkBoxSOH.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxSte.Checked)
			{
				labelSteMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelSteMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelSteMod, "Dexterity Modifier" + (checkBoxSte.Checked ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownCon.Value - 10) / 2);
			labelConMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (checkBoxConSave.Checked)
			{
				labelConSaveMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelConSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelConSaveMod, "Constitution Modifier" + (checkBoxConSave.Checked ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownInt.Value - 10) / 2);
			labelIntMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (checkBoxIntSave.Checked)
			{
				labelIntSaveMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelIntSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelIntSaveMod, "Intelligence Modifier" + (checkBoxIntSave.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxArc.Checked)
			{
				labelArcMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelArcMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelArcMod, "Intelligence Modifier" + (checkBoxArc.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxHis.Checked)
			{
				labelHisMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelHisMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelHisMod, "Intelligence Modifier" + (checkBoxHis.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxInv.Checked)
			{
				labelInvMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelInvMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelInvMod, "Intelligence Modifier" + (checkBoxInv.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxNat.Checked)
			{
				labelNatMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelNatMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelNatMod, "Intelligence Modifier" + (checkBoxNat.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxRel.Checked)
			{
				labelRelMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelRelMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelRelMod, "Intelligence Modifier" + (checkBoxRel.Checked ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownWis.Value - 10) / 2);
			labelWisMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (checkBoxWisSave.Checked)
			{
				labelWisSaveMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelWisSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelWisSaveMod, "Wisdom Modifier" + (checkBoxWisSave.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxAnH.Checked)
			{
				labelAnHMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelAnHMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelAnHMod, "Wisdom Modifier" + (checkBoxAnH.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxIns.Checked)
			{
				labelInsMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelInsMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelInsMod, "Wisdom Modifier" + (checkBoxIns.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxMed.Checked)
			{
				labelMedMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelMedMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelMedMod, "Wisdom Modifier" + (checkBoxMed.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxPer.Checked)
			{
				labelPerMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelPerMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelPerMod, "Wisdom Modifier" + (checkBoxPer.Checked ? " + Proficiency Bonus" : ""));
			// set passive perception
			labelPasPer.Text = (10 + (m_character.m_sPerception ? val + numericUpDownProficiencyBonus.Value : val)).ToString();
			if (checkBoxSur.Checked)
			{
				labelSurMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelSurMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelSurMod, "Wisdom Modifier" + (checkBoxSur.Checked ? " + Proficiency Bonus" : ""));

			val = (int)Math.Floor((numericUpDownCha.Value - 10) / 2);
			labelChaMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			if (checkBoxChaSave.Checked)
			{
				labelChaSaveMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelChaSaveMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelChaSaveMod, "Charisma Modifier" + (checkBoxChaSave.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxDec.Checked)
			{
				labelDecMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelDecMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelDecMod, "Charisma Modifier" + (checkBoxDec.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxInti.Checked)
			{
				labelIntiMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelIntiMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelIntiMod, "Charisma Modifier" + (checkBoxInti.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxPerf.Checked)
			{
				labelPerfMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelPerfMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelPerfMod, "Charisma Modifier" + (checkBoxPerf.Checked ? " + Proficiency Bonus" : ""));
			if (checkBoxPers.Checked)
			{
				labelPersMod.Text = (val + numericUpDownProficiencyBonus.Value > 0 ? "+" + (val + numericUpDownProficiencyBonus.Value).ToString() : (val + numericUpDownProficiencyBonus.Value).ToString());
			}
			else
			{
				labelPersMod.Text = (val > 0 ? "+" + val.ToString() : val.ToString());
			}
			toolTip1.SetToolTip(labelPersMod, "Charisma Modifier" + (checkBoxPers.Checked ? " + Proficiency Bonus" : ""));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownStr_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownDex_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownCon_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownInt_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownWisdom_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownCha_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		// saveing throw proficency

		private void checkBoxStrSave_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxDexSave_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxConSave_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxIntSave_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxWisSave_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxChaSave_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		// skill proficency

		private void checkBoxAth_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxAcr_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxSOH_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxSte_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxArc_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxHis_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxInv_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxNat_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxRel_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxAnH_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxIns_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxMed_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxPer_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxSur_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxDec_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxInti_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxPerf_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void checkBoxPers_CheckedChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownProficiencyBonus_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (numericUpDownTempHealth.Value > 0)
			{
				int taken = (int)numericUpDownTempHealth.Value - (int)numericUpDownTakeDamage.Value;
				numericUpDownTempHealth.Value -= (numericUpDownTakeDamage.Value + (decimal)(taken < 0 ? taken : 0));
				int healthDiff = (int)numericUpDownCurrentHealth.Value - (taken < 0 ? -taken : 0);
				numericUpDownCurrentHealth.Value -= (decimal)((taken < 0 ? -taken : 0) - (healthDiff < 0 ? -healthDiff : 0));
				numericUpDownTakeDamage.Value = (healthDiff < 0 ? -healthDiff : 0);
			}
			else // no temp health, take only form current health
			{
				int healthDiff = (int)(numericUpDownCurrentHealth.Value - numericUpDownTakeDamage.Value);
				numericUpDownCurrentHealth.Value -= numericUpDownTakeDamage.Value + (healthDiff < 0 ? healthDiff : 0);
				numericUpDownTakeDamage.Value = (healthDiff < 0 ? -healthDiff : 0);
			}
			updateLabels();
		}

		private void numericUpDownMaxHealth_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownCurrentHealth_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void numericUpDownTempHealth_ValueChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void buttonResetHealth_Click(object sender, EventArgs e)
		{
			numericUpDownCurrentHealth.Value = numericUpDownMaxHealth.Value;
			numericUpDownTempHealth.Value = 0;
			updateLabels();
		}

		private void entry111ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (m_invWindow == null)
			{
				m_invWindow = new InventoryWindow(this);
			}
			else
			{
				if (m_invWindow.IsDisposed)
				{
					m_invWindow = new InventoryWindow(this);
				}
			}
			if (m_invWindow != null)
			{
				if (m_invWindow.Visible)
				{
					m_invWindow.Activate();
				}
				else
				{
					m_invWindow.Show(this);
				}
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			newCharacter();
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadCharacter();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveCharacter();
		}
	}
}
