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
            string selectedZone = ZoneComb.SelectedItem.ToString();
            if (selectedZone == null)
            {
                MessageBox.Show("Пожалуйста, выберите зону!");
                return;
            }

            Form form = new Form1(selectedZone);
            form.ShowDialog();
            Hide();
        }
    }
}
