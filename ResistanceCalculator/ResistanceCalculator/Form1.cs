using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Burak Dogucu
/// 3/1/2019 (dd/mm/yyyy)
/// A program that calculates the resistance of a resistor
/// using colour codes 
/// </summary>


namespace ResistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int band1Var = 0;
            int band2Var = 0;
            int band3Var = 0;
            float multiplierVar = 0.0f;
            float toleranceVar = 0.0f;
            float calc;
            float range1 = 0.0f;
            float range2 = 0.0f;

            //these switch statements assign the values accordingly
            switch (band1.SelectedItem)
            {
                case "Black":
                    band1Pbx.BackColor = Color.Black;
                    band1Pbx.Visible = true;
                    band1Var = 0;
                    break;
                case "Brown":
                    band1Pbx.BackColor = Color.Brown;
                    band1Var = 1;
                    band1Pbx.Visible = true;
                    break;
                case "Red":
                    band1Pbx.BackColor = Color.Red;
                    band1Var = 2;
                    band1Pbx.Visible = true;
                    break;
                case "Orange":
                    band1Pbx.BackColor = Color.Orange;
                    band1Var = 3;
                    band1Pbx.Visible = true;
                    break;
                case "Yellow":
                    band1Pbx.BackColor = Color.Yellow;
                    band1Var = 4;
                    band1Pbx.Visible = true;
                    break;
                case "Green":
                    band1Pbx.BackColor = Color.Green;
                    band1Var = 5;
                    band1Pbx.Visible = true;
                    break;
                case "Blue":
                    band1Pbx.BackColor = Color.Blue;
                    band1Var = 6;
                    band1Pbx.Visible = true;
                    break;
                case "Purple":
                    band1Pbx.BackColor = Color.Purple;
                    band1Var = 7;
                    band1Pbx.Visible = true;
                    break;
                case "Gray":
                    band1Pbx.BackColor = Color.Gray;
                    band1Var = 8;
                    band1Pbx.Visible = true;
                    break;
                case "White":
                    band1Pbx.BackColor = Color.White;
                    band1Var = 9;
                    band1Pbx.Visible = true;
                    break;
            }
            switch (band2.SelectedItem)
            {
                case "Black":
                    band2Pbx.BackColor = Color.Black;
                    band2Var = 0;
                    band2Pbx.Visible = true;
                    break;
                case "Brown":
                    band2Pbx.BackColor = Color.Brown;
                    band2Var = 1;
                    band2Pbx.Visible = true;
                    break;
                case "Red":
                    band2Pbx.BackColor = Color.Red;
                    band2Var = 2;
                    band2Pbx.Visible = true;
                    break;
                case "Orange":
                    band2Pbx.BackColor = Color.Orange;
                    band2Var = 3;
                    band2Pbx.Visible = true;
                    break;
                case "Yellow":
                    band2Pbx.BackColor = Color.Yellow;
                    band2Var = 4;
                    band2Pbx.Visible = true;
                    break;
                case "Green":
                    band2Pbx.BackColor = Color.Green;
                    band2Var = 5;
                    band2Pbx.Visible = true;
                    break;
                case "Blue":
                    band2Pbx.BackColor = Color.Blue;
                    band2Var = 6;
                    band2Pbx.Visible = true;
                    break;
                case "Purple":
                    band2Pbx.BackColor = Color.Purple;
                    band2Var = 7;
                    band2Pbx.Visible = true;
                    break;
                case "Gray":
                    band2Pbx.BackColor = Color.Gray;
                    band2Var = 8;
                    band2Pbx.Visible = true;
                    break;
                case "White":
                    band2Pbx.BackColor = Color.White;
                    band2Var = 9;
                    band2Pbx.Visible = true;
                    break;
            }
            switch (band3.SelectedItem)
            {
                case "Black":
                    band3Pbx.BackColor = Color.Black;
                    band3Var = 0;
                    band3Pbx.Visible = true;
                    break;
                case "Brown":
                    band3Pbx.BackColor = Color.Brown;
                    band3Var = 1;
                    band3Pbx.Visible = true;
                    break;
                case "Red":
                    band3Pbx.BackColor = Color.Red;
                    band3Var = 2;
                    band3Pbx.Visible = true;
                    break;
                case "Orange":
                    band3Pbx.BackColor = Color.Orange;
                    band3Var = 3;
                    band3Pbx.Visible = true;
                    break;
                case "Yellow":
                    band3Pbx.BackColor = Color.Yellow;
                    band3Var = 4;
                    band3Pbx.Visible = true;
                    break;
                case "Green":
                    band3Pbx.BackColor = Color.Green;
                    band3Var = 5;
                    band3Pbx.Visible = true;
                    break;
                case "Blue":
                    band3Pbx.BackColor = Color.Blue;
                    band3Var = 6;
                    band3Pbx.Visible = true;
                    break;
                case "Purple":
                    band3Pbx.BackColor = Color.Purple;
                    band3Var = 7;
                    band3Pbx.Visible = true;
                    break;
                case "Gray":
                    band3Pbx.BackColor = Color.Gray;
                    band3Var = 8;
                    band3Pbx.Visible = true;
                    break;
                case "White":
                    band3Pbx.BackColor = Color.White;
                    band3Var = 9;
                    band3Pbx.Visible = true;
                    break;
            }
            switch (multiplier.SelectedItem)
            {
                case "Black":
                    multiplierPbx.BackColor = Color.Black;
                    multiplierVar = 1.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Brown":
                    multiplierPbx.BackColor = Color.Brown;
                    multiplierVar = 10.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Red":
                    multiplierPbx.BackColor = Color.Red;
                    multiplierVar = 100.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Orange":
                    multiplierPbx.BackColor = Color.Orange;
                    multiplierVar = 1000.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Yellow":
                    multiplierPbx.BackColor = Color.Yellow;
                    multiplierVar = 10000.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Green":
                    multiplierPbx.BackColor = Color.Green;
                    multiplierVar = 100000.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Blue":
                    multiplierPbx.BackColor = Color.Blue;
                    multiplierVar = 1000000.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Purple":
                    multiplierPbx.BackColor = Color.Purple;
                    multiplierVar = 10000000.0f;
                    multiplierPbx.Visible = true;
                    break;
                case "Gray":
                    multiplierPbx.BackColor = Color.Gray;
                    multiplierVar = 0;
                    multiplierPbx.Visible = true;
                    break;
                case "White":
                    multiplierPbx.BackColor = Color.White;
                    multiplierVar = 0;
                    multiplierPbx.Visible = true;
                    break;
                case "Gold":
                    multiplierPbx.BackColor = Color.Gold;
                    multiplierVar = 0.1f;
                    multiplierPbx.Visible = true;
                    break;
                case "Silver":
                    multiplierPbx.BackColor = Color.Silver;
                    multiplierVar = 0.01f;
                    multiplierPbx.Visible = true;
                    break;
            }
            switch (tolerance.SelectedItem)
            {
                case "Black":
                    tolerancePbx.BackColor = Color.Black;
                    tolerancePbx.Visible = true;

                    break;
                case "Brown":
                    tolerancePbx.BackColor = Color.Brown;
                    toleranceVar = 0.01f;
                    tolerancePbx.Visible = true;
                    break;
                case "Red":
                    tolerancePbx.BackColor = Color.Red;
                    toleranceVar = 0.02f;
                    tolerancePbx.Visible = true;
                    break;
                case "Orange":
                    tolerancePbx.BackColor = Color.Orange;
                    tolerancePbx.Visible = true;
                    break;
                case "Yellow":
                    tolerancePbx.BackColor = Color.Yellow;
                    tolerancePbx.Visible = true;
                    break;
                case "Green":
                    tolerancePbx.BackColor = Color.Green;
                    toleranceVar = 0.005f;
                    tolerancePbx.Visible = true;
                    break;
                case "Blue":
                    tolerancePbx.BackColor = Color.Blue;
                    toleranceVar = 0.025f;
                    tolerancePbx.Visible = true;
                    break;
                case "Purple":
                    tolerancePbx.BackColor = Color.Purple;
                    toleranceVar = 0.001f;
                    tolerancePbx.Visible = true;
                    break;
                case "Gray":
                    tolerancePbx.BackColor = Color.Gray;
                    toleranceVar = 0.0005f;
                    tolerancePbx.Visible = true;
                    break;
                case "White":
                    tolerancePbx.BackColor = Color.White;
                    tolerancePbx.Visible = true;
                    break;
                case "Gold":
                    tolerancePbx.BackColor = Color.Gold;
                    toleranceVar = 0.05f;
                    tolerancePbx.Visible = true;
                    break;
                case "Silver":
                    tolerancePbx.BackColor = Color.Silver;
                    toleranceVar = 0.1f;
                    tolerancePbx.Visible = true;
                    break;
            }


            //if the resistor is a 4 band type
            if (band3.SelectedText == "")
            {
                calc = (band2Var + (band1Var * 10)) * multiplierVar;
                range1 = calc * (1 - toleranceVar);
                range2 = calc * (1 + toleranceVar);
            }
            //if the resistor is a 5 band type
            else
            {
                calc = (band3Var + (band2Var * 10) + (band1Var * 100)) * multiplierVar;
                range1 = calc * (1 - toleranceVar);
                range2 = calc * (1 + toleranceVar);
            }


            //this part formats the values and writes them to their lables
            if (calc / 1000000.0f >= 1)
            {
                valueLbl.Text = (calc / 1000000.0f) + "M";
                range1Lbl.Text = (range1 / 100000.0f) + "M";
                range2Lbl.Text = (range2 / 100000.0f) + "M";
            }
            else if (calc / 1000.0f >= 1)
            {
                valueLbl.Text = (calc / 1000.0f) + "K";
                range1Lbl.Text = (range1 / 1000.0f) + "K";
                range2Lbl.Text = (range2 / 1000.0f) + "K";
            }
            else
            {
                valueLbl.Text = calc + "R";
                range1Lbl.Text = range1 + "R";
                range2Lbl.Text = range2 + "R";
            }

        }
    }
    
}
