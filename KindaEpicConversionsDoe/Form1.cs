//eh
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindaEpicConversionsDoe
{
    public partial class Form1 : Form
    {
        int convChoice;
        double value;
        double conversion;
        const double inchConv = 2.54;
        const double footConv = 30.48;
        const double yardConv = 0.9144;
        const double mileConv = 1.60934;

        public Form1()
        {
            InitializeComponent();
        }

        private void convButton_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(valueBox.Text);
                convChoice = Convert.ToInt16(convBox.Text);

                if (convChoice == 1)
                {
                    InchestoCm();
                }
                else if (convChoice == 2)
                {
                    FeettoCm();
                }
                else if (convChoice == 3)
                {
                    YardstoMetres();
                }
                else if (convChoice == 4)
                {
                    MilestoKm();
                }
            } catch { 
              answer.Text = "Error, please input your values again";
            }
        }

        public void InchestoCm()
        {
            conversion = value / inchConv;
            answer.Text = value + " inches = " + conversion + " centimetres";
        }
        public void FeettoCm()
        {
            conversion = value / footConv;
            answer.Text = value + " feet = " + conversion + " centimetres";
        }
        public void YardstoMetres()
        {
            conversion = value / yardConv;
            answer.Text = value + " yards = " + conversion + " metres";
        }
        public void MilestoKm()
        {
            conversion = value / mileConv;
            answer.Text = value + " miles = " + conversion + " kilometres";
        }
    }
}
