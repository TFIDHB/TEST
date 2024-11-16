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
            ((System.ComponentModel.ISupportInitialize)Num).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(446, 613);
            Start.Name = "Start";
            Start.Size = new Size(302, 75);
            Start.TabIndex = 0;
            Start.Text = "Начать";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click_1;
            // 
            // ClassComb
            // 
            ClassComb.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComb.FormattingEnabled = true;
            ClassComb.Location = new Point(70, 122);
            ClassComb.Name = "ClassComb";
            ClassComb.Size = new Size(678, 33);
            ClassComb.TabIndex = 1;
            ClassComb.SelectedIndexChanged += ClassComb_SelectedIndexChanged;
            // 
            // SpecComb
            // 
            SpecComb.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecComb.FormattingEnabled = true;
            SpecComb.Location = new Point(70, 260);
            SpecComb.Name = "SpecComb";
            SpecComb.Size = new Size(678, 33);
            SpecComb.TabIndex = 2;
            // 
            // Add
            // 
            Add.Location = new Point(70, 613);
            Add.Name = "Add";
            Add.Size = new Size(302, 75);
            Add.TabIndex = 3;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Num
            // 
            Num.Location = new Point(70, 505);
            Num.Name = "Num";
            Num.Size = new Size(678, 31);
            Num.TabIndex = 4;
            // 
            // BehavComb
            // 
            BehavComb.DropDownStyle = ComboBoxStyle.DropDownList;
            BehavComb.FormattingEnabled = true;
            BehavComb.Items.AddRange(new object[] { "питается", "охотится", "паразитирует", "бездействует" });
            BehavComb.Location = new Point(70, 387);
            BehavComb.Name = "BehavComb";
            BehavComb.Size = new Size(678, 33);
            BehavComb.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 872);
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
        }

        #endregion

        private Button Start;
        private ComboBox ClassComb;
        private ComboBox SpecComb;
        private Button Add;
        private NumericUpDown Num;
        private ComboBox BehavComb;
    }
}
