using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Я_так_больше_не_могу
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            AllocConsole();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            ClassComb.Items.Clear();
            ClassComb.Items.Add("Хищник");
            ClassComb.Items.Add("Травоядное");
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Add_Click(object sender, EventArgs e)
        {
            if (SpecComb.SelectedItem != null && ClassComb.SelectedItem != null)
            {
                string selectedClass = ClassComb.SelectedItem.ToString();
                string selectedValue = SpecComb.SelectedItem.ToString();

                Animal newAnimal = null;

                if (selectedClass == "Хищник")
                {
                    newAnimal = new Predator(selectedValue, (int)Num.Value, "охотится");
                }
                else if (selectedClass == "Травоядное")
                {
                    newAnimal = new Herbivore(selectedValue, (int)Num.Value, "ест");
                }

                if (newAnimal != null)
                {
                    animals.Add(newAnimal);
                    Console.WriteLine($"Добавлен объект: {newAnimal.Name}, {(int)Num.Value}");
                }
            }
        }

        private void ClassComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = ClassComb.SelectedItem.ToString();
            SpecComb.Items.Clear();

            if (selectedClass == "Хищник")
            {
                SpecComb.Items.AddRange(Predator.PredatorNames);
            }
            else if (selectedClass == "Травоядное")
            {
                SpecComb.Items.AddRange(Herbivore.HerbivoreNames);
            }
        }
    }

}


