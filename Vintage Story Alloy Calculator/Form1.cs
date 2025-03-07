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
            TaningOutputLabel.Hide();
        }
        private void CalculateAlloyNeed()
        {
            int ingotsNeeded = Convert.ToInt32(Math.Floor(IngotAmount.Value)); //sets how many ingots total
            int oreUnitsNeeded = ingotsNeeded * 100; //sets how many bits are needed, each ingot costs 100 bits
            double ingotInAMin; // sets the % amount of an alloy needed
            double ingotInAMax;
            double ingotInBMin;
            double ingotInBMax;
            double ingotInCMin;
            double ingotInCMax; // sets the % amount of an alloy needed
            int ingotInAOutMin; // sets the amount of bits needed
            int ingotInAOutMax;
            int ingotInBOutMin;
            int ingotInBOutMax;
            int ingotInCOutMin;
            int ingotInCOutMax; // sets the amount of bits needed
            string alloyNeeded = AlloySelector.Text; // sets the choice of alloy
            switch (alloyNeeded)
            {
                case "Tin Bronze": //ingot a is Copper, ingot b is Tin
                    ingotInAMin = 0.88; 
                    ingotInAMax = 0.92;
                    ingotInBMin = 0.08;
                    ingotInBMax = 0.12;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} copper, and {ingotInBOutMin}-{ingotInBOutMax} tin bits!";
                    break;
                case "Bismuth Bronze": //ingot a is Copper, ingot b is Zinc, ingot c is Bismuth
                    ingotInAMin = 0.50;
                    ingotInAMax = 0.70;
                    ingotInBMin = 0.20;
                    ingotInBMax = 0.30;
                    ingotInCMin = 0.10;
                    ingotInCMax = 0.20;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    ingotInCOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInCMin / 5));
                    ingotInCOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInCMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} copper, {ingotInBOutMin}-{ingotInBOutMax} zinc, and {ingotInCOutMin}-{ingotInCOutMax} bismuth bits!";
                    break;
                case "Black Bronze": //ingot a is Copper, ingot b is Silver, ingot c is Gold
                    ingotInAMin = 0.88;
                    ingotInAMax = 0.92;
                    ingotInBMin = 0.08;
                    ingotInBMax = 0.16;
                    ingotInCMin = 0.08;
                    ingotInCMax = 0.16;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    ingotInCOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInCMin / 5));
                    ingotInCOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInCMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} copper, {ingotInBOutMin}-{ingotInBOutMax} silver, and {ingotInCOutMin}-{ingotInCOutMax} gold bits!";
                    break;
                case "Brass": //ingot a is Copper, ingot b is Zinc
                    ingotInAMin = 0.60;
                    ingotInAMax = 0.70;
                    ingotInBMin = 0.30;
                    ingotInBMax = 0.40;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} copper, and {ingotInBOutMin}-{ingotInBOutMax} zinc bits!";
                    break;
                case "Cupronickel": //ingot a is Copper, ingot b is Nickel
                    ingotInAMin = 0.65;
                    ingotInAMax = 0.75;
                    ingotInBMin = 0.25;
                    ingotInBMax = 0.35;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} copper, and {ingotInBOutMin}-{ingotInBOutMax} nickel bits!";
                    break;
                case "Molybdochalkos": //ingot a is Copper, ingot b is Lead
                    ingotInAMin = 0.08;
                    ingotInAMax = 0.12;
                    ingotInBMin = 0.88;
                    ingotInBMax = 0.92;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} copper, and {ingotInBOutMin}-{ingotInBOutMax} lead bits!";
                    break; 
                case "Electrum": //ingot a is Silver, ingot b is Gold
                    ingotInAMin = 0.40;
                    ingotInAMax = 0.60;
                    ingotInBMin = 0.40;
                    ingotInBMax = 0.60;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} silver, and {ingotInBOutMin}-{ingotInBOutMax} gold bits!";
                    break;
                case "Lead Solder": //ingot a is Tin, ingot b is Lead
                    ingotInAMin = 0.45;
                    ingotInAMax = 0.55;
                    ingotInBMin = 0.45;
                    ingotInBMax = 0.55;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} tin, and {ingotInBOutMin}-{ingotInBOutMax} lead bits!";
                    break;
                case "Silver Solder": //ingot a is Tin, ingot b is Silver
                    ingotInAMin = 0.50;
                    ingotInAMax = 0.60;
                    ingotInBMin = 0.40;
                    ingotInBMax = 0.50;
                    ingotInAOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInAMin / 5));
                    ingotInAOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInAMax / 5));
                    ingotInBOutMin = Convert.ToInt32((oreUnitsNeeded * ingotInBMin / 5));
                    ingotInBOutMax = Convert.ToInt32((oreUnitsNeeded * ingotInBMax / 5));
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {ingotInAOutMin}-{ingotInAOutMax} tin, and {ingotInBOutMin}-{ingotInBOutMax} silver bits!";
                    break;
                case "Meteoric Iron": //too unique to follow previous calculations
                    int meteorPeicesNeeded = ingotsNeeded * 2;
                    int meteorBitsNeeded = ingotsNeeded * 20;
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = $"you want {ingotsNeeded} ingots of {alloyNeeded}? thats {meteorPeicesNeeded} meteoric iron pieces, or {meteorBitsNeeded} meteoric iron bits!";
                    break;
                default: //selection was non-existant or was the seperator between alloys and unique ingots
                    AlloyOutputLabel.Show();
                    AlloyOutputLabel.Text = "No selection/improper selection made, please select a valid option!";
                    break;
            }
        }
        private void CalculateTanningNeed()
        {
            int hidesNeeded = Convert.ToInt32(Math.Floor(HideAmount.Value)); // sets how many hides are being made
            float liquidNeeded; //sets liquid needed, in liters
            int barrelsNeeded; //sets total barrels needed, 50 liters = 1 barrel
            float barrelsRemainder; // sets the remainder of the barrels
            string size = HideSelector.Text;
            switch (size)
            {
                case "Small":
                    liquidNeeded = 2;
                    float smallLiquidNeeded = hidesNeeded * liquidNeeded;
                    barrelsNeeded = Convert.ToInt32(Math.Floor(smallLiquidNeeded / 50));
                    barrelsRemainder = smallLiquidNeeded % 50;
                    TaningOutputLabel.Show();
                    TaningOutputLabel.Text = $"you want {hidesNeeded} cured hides? thats {smallLiquidNeeded} liters ({barrelsNeeded}.{barrelsRemainder} barrels) of Borax, Weak, and Strong Tanin!";
                    break;
                case "Medium":
                    liquidNeeded = 4;
                    float mediumLiquidNeeded = hidesNeeded * liquidNeeded;
                    barrelsNeeded = Convert.ToInt32(Math.Floor(mediumLiquidNeeded / 50));
                    barrelsRemainder = mediumLiquidNeeded % 50;
                    TaningOutputLabel.Show();
                    TaningOutputLabel.Text = $"you want {hidesNeeded} cured hides? thats {mediumLiquidNeeded} liters ({barrelsNeeded}.{barrelsRemainder} barrels) of Borax, Weak, and Strong Tanin!";
                    break;
                case "Large":
                    liquidNeeded = 6;
                    float largeLiquidNeeded = hidesNeeded * liquidNeeded;
                    barrelsNeeded = Convert.ToInt32(Math.Floor(largeLiquidNeeded / 50));
                    barrelsRemainder = largeLiquidNeeded % 50;
                    TaningOutputLabel.Show();
                    TaningOutputLabel.Text = $"you want {hidesNeeded} cured hides? thats {largeLiquidNeeded} liters ({barrelsNeeded}.{barrelsRemainder} barrels) of Borax, Weak, and Strong Tanin!";
                    break;
                case "Huge":
                    liquidNeeded = 10;
                    float hugeLiquidNeeded = hidesNeeded * liquidNeeded;
                    barrelsNeeded = Convert.ToInt32(Math.Floor(hugeLiquidNeeded / 50));
                    barrelsRemainder = hugeLiquidNeeded % 50;
                    TaningOutputLabel.Show();
                    TaningOutputLabel.Text = $"you want {hidesNeeded} cured hides? thats {hugeLiquidNeeded} liters ({barrelsNeeded}.{barrelsRemainder} barrels) of Borax, Weak, and Strong Tanin!";
                    break;
                default:
                    TaningOutputLabel.Show();
                    TaningOutputLabel.Text = "No selection/improper selection made, please select an option!";
                    break;
            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateAlloyNeed();
        }
        private void CalculateButton1_Click(object sender, EventArgs e)
        {
            CalculateTanningNeed();
        }
    }
}
