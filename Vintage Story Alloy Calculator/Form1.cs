using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vintage_Story_Alloy_Calculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlloyOutputLabel.Hide();
        }

        private void CalculateAlloyNeed()
        {
            int ingotsNeeded = Convert.ToInt32(Math.Round(IngotAmount.Value, 0));
            int oreUnitsNeeded = ingotsNeeded * 100;
            string alloyNeeded = AlloySelector.Text;
            switch (alloyNeeded)
            {
                case "Tin Bronze":
                    double copperInMin = 0.88;
                    double copperInMax = 0.92;
                    double tinInMin = 0.08;
                    double tinInMax = 0.12;
                    int copperNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * copperInMin / 5));
                    int copperNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * copperInMax / 5));
                    int tinNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * tinInMin / 5));
                    int tinNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * tinInMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {copperNeededBitsMin}-{copperNeededBitsMax} copper, and {tinNeededBitsMin}-{tinNeededBitsMax} tin bits!";
                    break;
                case "Bismuth Bronze":
                    double copperInMin1 = 0.50;
                    double copperInMax1 = 0.70;
                    double zincInMin = 0.08;
                    double zincInMax = 0.12;
                    double bismuthInMin = 0.08;
                    double bismuthInMax = 0.12;
                    int copperNeededBitsMin1 = Convert.ToInt32((oreUnitsNeeded * copperInMin1 / 5));
                    int copperNeededBitsMax1 = Convert.ToInt32((oreUnitsNeeded * copperInMax1 / 5));
                    int zincNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * zincInMin / 5));
                    int zincNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * zincInMax / 5));
                    int bismuthNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * bismuthInMin / 5));
                    int bismuthNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * bismuthInMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {copperNeededBitsMin1}-{copperNeededBitsMax1} copper, {zincNeededBitsMin}-{zincNeededBitsMax} zinc, and {bismuthNeededBitsMin}-{bismuthNeededBitsMax} bismuth bits!";
                    break;
                case "Black Bronze":
                    double copperInMin2 = 0.88;
                    double copperInMax2 = 0.92;
                    double silverInMin = 0.08;
                    double silverInMax = 0.16;
                    double goldInMin = 0.08;
                    double goldInMax = 0.16;
                    int copperNeededBitsMin2 = Convert.ToInt32((oreUnitsNeeded * copperInMin2 / 5));
                    int copperNeededBitsMax2 = Convert.ToInt32((oreUnitsNeeded * copperInMax2 / 5));
                    int silverNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * silverInMin / 5));
                    int silverNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * silverInMax / 5));
                    int goldNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * goldInMin / 5));
                    int goldNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * goldInMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {copperNeededBitsMin2}-{copperNeededBitsMax2} copper, {silverNeededBitsMin}-{silverNeededBitsMax} silver, and {goldNeededBitsMin}-{goldNeededBitsMax} gold bits!";
                    break;
                case "Brass":
                    double copperInMin3 = 0.60;
                    double copperInMax3 = 0.70;
                    double zincInMin1 = 0.30;
                    double zincInMax1 = 0.40;
                    int copperNeededBitsMin3 = Convert.ToInt32((oreUnitsNeeded * copperInMin3 / 5));
                    int copperNeededBitsMax3 = Convert.ToInt32((oreUnitsNeeded * copperInMax3 / 5));
                    int zincNeededBitsMin1 = Convert.ToInt32((oreUnitsNeeded * zincInMin1 / 5));
                    int zincNeededBitsMax1 = Convert.ToInt32((oreUnitsNeeded * zincInMax1 / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {copperNeededBitsMin3}-{copperNeededBitsMax3} copper, and {zincNeededBitsMin1}-{zincNeededBitsMax1} zinc bits!";
                    break;
                case "Cupronickel":
                    double copperInMin4 = 0.65;
                    double copperInMax4 = 0.75;
                    double nickelInMin = 0.25;
                    double nickelInMax = 0.35;
                    int copperNeededBitsMin4 = Convert.ToInt32((oreUnitsNeeded * copperInMin4 / 5));
                    int copperNeededBitsMax4 = Convert.ToInt32((oreUnitsNeeded * copperInMax4 / 5));
                    int nickelNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * nickelInMin / 5));
                    int nickelNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * nickelInMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {copperNeededBitsMin4}-{copperNeededBitsMax4} copper, and {nickelNeededBitsMin}-{nickelNeededBitsMax} nickel bits!";
                    break;
                case "Molybdochalkos":
                    double copperInMin5 = 0.08;
                    double copperInMax5 = 0.12;
                    double leadInMin = 0.88;
                    double leadInMax = 0.92;
                    int copperNeededBitsMin5 = Convert.ToInt32((oreUnitsNeeded * copperInMin5 / 5));
                    int copperNeededBitsMax5 = Convert.ToInt32((oreUnitsNeeded * copperInMax5 / 5));
                    int leadNeededBitsMin = Convert.ToInt32((oreUnitsNeeded * leadInMin / 5));
                    int leadNeededBitsMax = Convert.ToInt32((oreUnitsNeeded * leadInMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {copperNeededBitsMin5}-{copperNeededBitsMax5} copper, and {leadNeededBitsMin}-{leadNeededBitsMax} lead bits!";
                    break;
                case "Electrum":
                    double silverInMin1 = 0.40;
                    double silverInMax1 = 0.60;
                    double goldInMin1 = 0.40;
                    double goldInMax1 = 0.60;
                    int silverNeededBitsMin1 = Convert.ToInt32((oreUnitsNeeded * silverInMin1 / 5));
                    int silverNeededBitsMax1 = Convert.ToInt32((oreUnitsNeeded * silverInMax1 / 5));
                    int goldNeededBitsMin1 = Convert.ToInt32((oreUnitsNeeded * goldInMin1 / 5));
                    int goldNeededBitsMax1 = Convert.ToInt32((oreUnitsNeeded * goldInMax1 / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {silverNeededBitsMin1}-{silverNeededBitsMax1} silver, and {goldNeededBitsMin1}-{goldNeededBitsMax1} gold bits!";
                    break;
                case "Lead Solder":
                    double tinInMin1 = 0.45;
                    double tinInMax1 = 0.55;
                    double leadInMin1 = 0.45;
                    double leadInMax1 = 0.55;
                    int tinNeededBitsMin1 = Convert.ToInt32((oreUnitsNeeded * tinInMin1 / 5));
                    int tinNeededBitsMax1 = Convert.ToInt32((oreUnitsNeeded * tinInMax1 / 5));
                    int leadNeededBitsMin1 = Convert.ToInt32((oreUnitsNeeded * leadInMin1 / 5));
                    int leadNeededBitsMax1 = Convert.ToInt32((oreUnitsNeeded * leadInMax1 / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {tinNeededBitsMin1}-{tinNeededBitsMax1} tin, and {leadNeededBitsMin1}-{leadNeededBitsMax1} lead bits!";
                    break;
                case "Silver Solder":
                    double tinInMin2 = 0.50;
                    double tinInMax2 = 0.60;
                    double silverInMin2 = 0.40;
                    double silverInMax2 = 0.50;
                    int tinNeededBitsMin2 = Convert.ToInt32((oreUnitsNeeded * silverInMin2 / 5));
                    int tinNeededBitsMax2 = Convert.ToInt32((oreUnitsNeeded * silverInMax2 / 5));
                    int silverNeededBitsMin2 = Convert.ToInt32((oreUnitsNeeded * silverInMin2 / 5));
                    int silverNeededBitsMax2 = Convert.ToInt32((oreUnitsNeeded * silverInMax2 / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {tinNeededBitsMin2}-{tinNeededBitsMax2} tin, and {silverNeededBitsMin2}-{silverNeededBitsMax2} silver bits!";
                    break;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateAlloyNeed();
        }

        
    }
}
