using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Я_так_больше_не_могу
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();

        public Form1(string selectedZone)
        {
            InitializeComponent();
            AllocConsole();
            SetZoneBackground(selectedZone);
        }

        private void SetZoneBackground(string zoneName)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Зоны", $"{zoneName}.jpg");

            if (File.Exists(imagePath))
            {
                Zone.BackgroundImage = Image.FromFile(imagePath);
                Zone.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                Zone.BackgroundImage = null;
                Console.WriteLine($"Изображение для {zoneName} не найдено.");
            }
        }



        private void Start_Click_1(object sender, EventArgs e)
        {
            foreach (var animal in animals)
            {
                animal.Speak(animals);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            ClassComb.Items.Clear();
            ClassComb.Items.Add("Хищник");
            ClassComb.Items.Add("Травоядное");
            ClassComb.Items.Add("Растение");
            ClassComb.Items.Add("Насекомое");
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
                string selectedBehav = BehavComb.SelectedItem.ToString();

                Animal newAnimal = null;

                if (selectedClass == "Хищник")
                {
                    newAnimal = new Predator(selectedValue, (int)Num.Value, selectedBehav);
                }
                else if (selectedClass == "Травоядное")
                {
                    newAnimal = new Herbivore(selectedValue, (int)Num.Value, selectedBehav);
                }

                else if (selectedClass == "Растение")
                {
                    newAnimal = new Plant(selectedValue, (int)Num.Value, selectedBehav);
                }

                else if (selectedClass == "Насекомое")
                {
                    newAnimal = new Insect(selectedValue, (int)Num.Value, selectedBehav);
                }

                if (newAnimal != null)
                {
                    animals.Add(newAnimal);
                    Console.WriteLine($"Добавлен объект: {newAnimal.Name}, количество: {(int)Num.Value}");
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

            else if (selectedClass == "Растение")
            {
                SpecComb.Items.AddRange(Plant.PlantNames);
            }

            else if (selectedClass == "Насекомое")
            {
                SpecComb.Items.AddRange(Insect.InsectNames);
            }
        }
    }
}
