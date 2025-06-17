using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@"F:\Monthly Exm C#\ESAD_CS_R62_M03_D021_Drill_Car_Byike\Ex_01_Car_Byike\Program.cs");
            //textBox1.Text = sr.ReadToEnd();
            //sr.Close();

            using (StreamReader sr = new StreamReader(@"F:\Monthly Exm C#\ESAD_CS_R62_M03_D021_Drill_Car_Byike\Ex_01_Car_Byike\Program.cs"))
            {
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }


        }
    }
}
