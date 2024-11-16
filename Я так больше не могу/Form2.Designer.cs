namespace Я_так_больше_не_могу
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ClassLabel = new Label();
            Start = new Button();
            ZoneComb = new ComboBox();
            SuspendLayout();
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ClassLabel.Location = new Point(860, 54);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(960, 104);
            ClassLabel.TabIndex = 8;
            ClassLabel.Text = "Выберите лесную зону";
            // 
            // Start
            // 
            Start.BackColor = Color.NavajoWhite;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.Location = new Point(1120, 581);
            Start.Name = "Start";
            Start.Size = new Size(679, 184);
            Start.TabIndex = 9;
            Start.Text = "Начать";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // ZoneComb
            // 
            ZoneComb.DropDownStyle = ComboBoxStyle.DropDownList;
            ZoneComb.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ZoneComb.FormattingEnabled = true;
            ZoneComb.Items.AddRange(new object[] { "Смешанный лес", "Поляна", "Болото" });
            ZoneComb.Location = new Point(860, 357);
            ZoneComb.Name = "ZoneComb";
            ZoneComb.Size = new Size(960, 82);
            ZoneComb.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1878, 874);
            Controls.Add(ZoneComb);
            Controls.Add(Start);
            Controls.Add(ClassLabel);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClassLabel;
        private Button Start;
        private ComboBox ZoneComb;
    }
}