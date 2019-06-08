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
using OblivionUI.Controls;

namespace AceCodeDay2019
{
    public partial class Form1 : Form
    {
        int transport;
        int trash;
        int water;
        int lights;
        int food;

        public Form1()
        {
            InitializeComponent();
            try { File.Delete("trans.txt"); } catch { }
            try { File.Delete("trash.txt"); } catch { }
            try { File.Delete("water.txt"); } catch { }
            try { File.Delete("light.txt"); } catch { }
        }

        private void oblivionTabButton3_Click(object sender, EventArgs e)
        {
            if (transport1.Checked)
                transport = 1;
            else if (transport2.Checked)
                transport = 2;
            else if (transport3.Checked)
                transport = 3;
            else if (transport4.Checked)
                transport = 4;
            File.WriteAllText("trans.txt", transport.ToString());
        }

        private void oblivionTabButton4_Click(object sender, EventArgs e)
        {
            if (trash1.Checked)
                trash = 1;
            else if (trash2.Checked)
                trash = 2;
            else if (trash3.Checked)
                trash = 3;
            else if (trash4.Checked)
                trash = 4;
            File.WriteAllText("trash.txt", transport.ToString());
        }

        private void oblivionTabButton5_Click(object sender, EventArgs e)
        {
            if (water1.Checked)
                water = 1;
            else if (water2.Checked)
                water = 2;
            else if (water3.Checked)
                water = 3;
            else if (water4.Checked)
                water = 4;
            File.WriteAllText("water.txt", transport.ToString());
        }

        private void oblivionTabButton6_Click(object sender, EventArgs e)
        {
            if (lights1.Checked)
                lights = 1;
            else if (lights2.Checked)
                lights = 2;
            else if (lights3.Checked)
                lights = 3;
            else if (lights4.Checked)
                lights = 4;
            File.WriteAllText("light.txt", transport.ToString());
        }

        private void GrowFood_Click(object sender, EventArgs e)
        {

        }

        private void oblivionLabel11_Click(object sender, EventArgs e)
        {

        }

        private void oblivionTabButton7_Click(object sender, EventArgs e)
        {
            if (food1.Checked)
                food = 2;
            else
                food = 1;
            File.WriteAllText("food.txt", transport.ToString());
            MessageBox.Show("Time to view your results!", "Environment Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string url = $"http://obliviontech.ml/ace2019/complete.php?food=" + food + "&trans=" + transport + "&trash=" + trash + "&light=" + lights + "&water=" + water;
            new Form2(url).ShowDialog();
        }
    }
}
