using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Я_так_больше_не_могу
{
    public partial class Form1 : Form
    {
        private List<World> animals = new List<World>();
        private Random random = new Random();
        private List<Rectangle> animalPositions = new List<Rectangle>();

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
                PanelBackground.BackgroundImage = Image.FromFile(imagePath);
                PanelBackground.BackgroundImageLayout = ImageLayout.Stretch;
                PanelBackground.BackColor = Color.Transparent;
            }
            else
            {
                PanelBackground.BackgroundImage = null;
                Console.WriteLine($"Изображение для {zoneName} не найдено.");
            }
        }

        private void AddAnimalImage(string animalName, int count)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Животные", $"{animalName}.png");

            if (File.Exists(imagePath))
            {
                using (Bitmap bitmap = new Bitmap(imagePath))
                {
                    PictureBox animalPictureBox = new PictureBox
                    {
                        Image = new Bitmap(bitmap),
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        BackColor = Color.Transparent,
                        Parent = PanelBackground
                    };

                    Point location = GetNonOverlappingLocation(bitmap.Width, bitmap.Height);
                    animalPictureBox.Location = location;

                    animalPositions.Add(new Rectangle(location, bitmap.Size));
                    PanelBackground.Controls.Add(animalPictureBox);
                    animalPictureBox.BringToFront();

                    AddAnimalLabel(animalPictureBox, animalName, count);
                }
            }
            else
            {
                Console.WriteLine($"Изображение для {animalName} не найдено.");
            }
        }


        private Point GetNonOverlappingLocation(int width, int height)
        {
            Point location;
            Rectangle newRect;
            int attempts = 0;
            do
            {
                location = new Point(
                    random.Next(0, PanelBackground.Width - width),
                    random.Next(0, PanelBackground.Height - height)
                );
                newRect = new Rectangle(location, new Size(width, height));
                attempts++;
            } while (IsOverlapping(newRect) && attempts < 100);

            return location;
        }

        private bool IsOverlapping(Rectangle newRect)
        {
            foreach (Rectangle rect in animalPositions)
            {
                if (rect.IntersectsWith(newRect))
                {
                    return true;
                }
            }
            return false;
        }

        private void AddAnimalLabel(PictureBox animalPictureBox, string animalName, int count)
        {
            Label animalLabel = new Label
            {
                Text = $"{animalName}: {count}",
                Name = $"animalLabel_{animalName}_{random.Next()}",
                BackColor = Color.Yellow,
                AutoSize = true,
                Location = new Point(animalPictureBox.Left, animalPictureBox.Bottom + 5)
            };

            PanelBackground.Controls.Add(animalLabel);
            animalLabel.BringToFront();
        }



        private void Start_Click_1(object sender, EventArgs e)
        {
            foreach (var animal in animals)
            {
                animal.Speak(animals);
            }

            UpdateAnimalLabels();
        }

        private void UpdateAnimalLabels()
        {
            foreach (Control control in PanelBackground.Controls)
            {
                if (control is Label label && label.Name.StartsWith("animalLabel_"))
                {
                    string animalName = label.Name.Split('_')[1]; // Изменено на корректное извлечение имени животного
                    World animal = animals.Find(a => a.Name == animalName);
                    if (animal != null)
                    {
                        label.Text = $"{animal.Name}: {animal.Amount}";
                    }
                }
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
            // Проверяем, заполнены ли все поля
            if (SpecComb.SelectedItem == null || ClassComb.SelectedItem == null || BehavComb.SelectedItem == null || Num.Value <= 0)
            {
                MessageBox.Show("Пожалуйста, введите полные данные для добавления объекта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedClass = ClassComb.SelectedItem.ToString();
            string selectedValue = SpecComb.SelectedItem.ToString();
            string selectedBehav = BehavComb.SelectedItem.ToString();

            World newAnimal = null;

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
                AddAnimalImage(newAnimal.Name, newAnimal.Amount);
                Console.WriteLine($"Добавлен объект: {newAnimal.Name}, количество: {(int)Num.Value}");
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


