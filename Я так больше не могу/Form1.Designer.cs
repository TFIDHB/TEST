namespace Я_так_больше_не_могу
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Start = new Button();
            ClassComb = new ComboBox();
            SpecComb = new ComboBox();
            Add = new Button();
            Num = new NumericUpDown();
            BehavComb = new ComboBox();
            Zone = new PictureBox();
            ClassLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zone).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.NavajoWhite;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Font = new Font("Sitka Small", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.Location = new Point(472, 700);
            Start.Name = "Start";
            Start.Size = new Size(302, 75);
            Start.TabIndex = 0;
            Start.Text = "Начать";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click_1;
            // 
            // ClassComb
            // 
            ClassComb.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComb.FormattingEnabled = true;
            ClassComb.Location = new Point(81, 148);
            ClassComb.Name = "ClassComb";
            ClassComb.Size = new Size(678, 33);
            ClassComb.TabIndex = 1;
            ClassComb.SelectedIndexChanged += ClassComb_SelectedIndexChanged;
            // 
            // SpecComb
            // 
            SpecComb.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecComb.FormattingEnabled = true;
            SpecComb.Location = new Point(81, 306);
            SpecComb.Name = "SpecComb";
            SpecComb.Size = new Size(678, 33);
            SpecComb.TabIndex = 2;
            // 
            // Add
            // 
            Add.BackColor = Color.NavajoWhite;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Sitka Small", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Add.Location = new Point(81, 700);
            Add.Name = "Add";
            Add.Size = new Size(302, 75);
            Add.TabIndex = 3;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Num
            // 
            Num.Location = new Point(81, 575);
            Num.Name = "Num";
            Num.Size = new Size(678, 31);
            Num.TabIndex = 4;
            // 
            // BehavComb
            // 
            BehavComb.DropDownStyle = ComboBoxStyle.DropDownList;
            BehavComb.FormattingEnabled = true;
            BehavComb.Items.AddRange(new object[] { "питается", "охотится", "паразитирует", "бездействует" });
            BehavComb.Location = new Point(81, 433);
            BehavComb.Name = "BehavComb";
            BehavComb.Size = new Size(678, 33);
            BehavComb.TabIndex = 5;
            // 
            // Zone
            // 
            Zone.Location = new Point(880, 31);
            Zone.Name = "Zone";
            Zone.Size = new Size(963, 806);
            Zone.TabIndex = 6;
            Zone.TabStop = false;
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ClassLabel.Location = new Point(81, 79);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(134, 52);
            ClassLabel.TabIndex = 7;
            ClassLabel.Text = "Класс";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(81, 220);
            label1.Name = "label1";
            label1.Size = new Size(100, 52);
            label1.TabIndex = 8;
            label1.Text = "Вид";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(81, 364);
            label2.Name = "label2";
            label2.Size = new Size(240, 52);
            label2.TabIndex = 9;
            label2.Text = "Поведение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(81, 497);
            label3.Name = "label3";
            label3.Size = new Size(257, 52);
            label3.TabIndex = 10;
            label3.Text = "Количество";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1878, 874);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClassLabel);
            Controls.Add(Zone);
            Controls.Add(BehavComb);
            Controls.Add(Num);
            Controls.Add(Add);
            Controls.Add(SpecComb);
            Controls.Add(ClassComb);
            Controls.Add(Start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)Num).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private ComboBox ClassComb;
        private ComboBox SpecComb;
        private Button Add;
        private NumericUpDown Num;
        private ComboBox BehavComb;
        private PictureBox Zone;
        private Label ClassLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
