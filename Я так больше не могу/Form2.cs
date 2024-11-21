using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Я_так_больше_не_могу
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (ZoneComb.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите зону!");
                return;
            }

            string selectedZone = ZoneComb.SelectedItem.ToString();
            Form1 form1 = new Form1(selectedZone);
            form1.FormClosed += (s, args) => this.Show();
            this.Hide();
            form1.Show();
        }
    }
}
