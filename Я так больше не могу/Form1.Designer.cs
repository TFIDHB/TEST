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
            ClassLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PanelBackground = new Panel();
            ((System.ComponentModel.ISupportInitialize)Num).BeginInit();
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
            ClassComb.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClassComb.FormattingEnabled = true;
            ClassComb.Location = new Point(81, 148);
            ClassComb.Name = "ClassComb";
            ClassComb.Size = new Size(678, 46);
            ClassComb.TabIndex = 1;
            ClassComb.SelectedIndexChanged += ClassComb_SelectedIndexChanged;
            // 
            // SpecComb
            // 
            SpecComb.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecComb.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SpecComb.FormattingEnabled = true;
            SpecComb.Location = new Point(81, 306);
            SpecComb.Name = "SpecComb";
            SpecComb.Size = new Size(678, 46);
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
            Num.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Num.Location = new Point(81, 575);
            Num.Name = "Num";
            Num.Size = new Size(678, 45);
            Num.TabIndex = 4;
            // 
            // BehavComb
            // 
            BehavComb.DropDownStyle = ComboBoxStyle.DropDownList;
            BehavComb.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BehavComb.FormattingEnabled = true;
            BehavComb.Items.AddRange(new object[] { "питается", "охотится", "паразитирует", "бездействует" });
            BehavComb.Location = new Point(81, 433);
            BehavComb.Name = "BehavComb";
            BehavComb.Size = new Size(678, 46);
            BehavComb.TabIndex = 5;
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
            // PanelBackground
            // 
            PanelBackground.Location = new Point(855, 44);
            PanelBackground.Name = "PanelBackground";
            PanelBackground.Size = new Size(993, 791);
            PanelBackground.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1878, 874);
            Controls.Add(PanelBackground);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClassLabel);
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
        private Label ClassLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel PanelBackground;
    }
}
