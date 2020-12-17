namespace Visual_editor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Shape_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Figure_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Color_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Red_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Green_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Blue_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Size_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Plus_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Minus_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Clear_toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.Clear_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Canvas_Panel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Shape_toolStripLabel,
            this.toolStripSeparator9,
            this.Figure_toolStripComboBox,
            this.toolStripSeparator1,
            this.Color_toolStripLabel,
            this.toolStripSeparator6,
            this.Red_toolStripButton,
            this.toolStripSeparator2,
            this.Green_toolStripButton,
            this.toolStripSeparator3,
            this.Blue_toolStripButton,
            this.toolStripSeparator4,
            this.Size_toolStripLabel,
            this.toolStripSeparator5,
            this.Plus_toolStripButton,
            this.toolStripSeparator7,
            this.Minus_toolStripButton,
            this.toolStripSeparator8,
            this.Clear_toolStripLabel,
            this.toolStripSeparator10,
            this.Clear_toolStripButton,
            this.toolStripSeparator11});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // Shape_toolStripLabel
            // 
            this.Shape_toolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Shape_toolStripLabel.Name = "Shape_toolStripLabel";
            this.Shape_toolStripLabel.Size = new System.Drawing.Size(107, 22);
            this.Shape_toolStripLabel.Text = "Выберите фигуру:";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // Figure_toolStripComboBox
            // 
            this.Figure_toolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Figure_toolStripComboBox.Items.AddRange(new object[] {
            "~Не выбрано",
            "Круг",
            "Треугольник",
            "Квадрат"});
            this.Figure_toolStripComboBox.Name = "Figure_toolStripComboBox";
            this.Figure_toolStripComboBox.SelectedItem = "Круг";
            this.Figure_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.Figure_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Figure_toolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Color_toolStripLabel
            // 
            this.Color_toolStripLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Color_toolStripLabel.Name = "Color_toolStripLabel";
            this.Color_toolStripLabel.Size = new System.Drawing.Size(91, 22);
            this.Color_toolStripLabel.Text = "Выберите цвет:";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Red_toolStripButton
            // 
            this.Red_toolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.Red_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Red_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Red_toolStripButton.Image")));
            this.Red_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red_toolStripButton.Name = "Red_toolStripButton";
            this.Red_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Red_toolStripButton.Text = "toolStripButton2";
            this.Red_toolStripButton.ToolTipText = "Red_toolStripButton";
            this.Red_toolStripButton.Click += new System.EventHandler(this.Red_toolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Green_toolStripButton
            // 
            this.Green_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Green_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Green_toolStripButton.Image")));
            this.Green_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Green_toolStripButton.Name = "Green_toolStripButton";
            this.Green_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Green_toolStripButton.Text = "toolStripButton3";
            this.Green_toolStripButton.Click += new System.EventHandler(this.Green_toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Blue_toolStripButton
            // 
            this.Blue_toolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.Blue_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Blue_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Blue_toolStripButton.Image")));
            this.Blue_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue_toolStripButton.Name = "Blue_toolStripButton";
            this.Blue_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Blue_toolStripButton.Text = "toolStripButton4";
            this.Blue_toolStripButton.Click += new System.EventHandler(this.Blue_toolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Size_toolStripLabel
            // 
            this.Size_toolStripLabel.ForeColor = System.Drawing.Color.Crimson;
            this.Size_toolStripLabel.Name = "Size_toolStripLabel";
            this.Size_toolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.Size_toolStripLabel.Text = "Размер:";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Plus_toolStripButton
            // 
            this.Plus_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Plus_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Plus_toolStripButton.Image")));
            this.Plus_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Plus_toolStripButton.Name = "Plus_toolStripButton";
            this.Plus_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Plus_toolStripButton.Text = "toolStripButton3";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // Minus_toolStripButton
            // 
            this.Minus_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Minus_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Minus_toolStripButton.Image")));
            this.Minus_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Minus_toolStripButton.Name = "Minus_toolStripButton";
            this.Minus_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Minus_toolStripButton.Text = "toolStripButton4";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // Clear_toolStripLabel
            // 
            this.Clear_toolStripLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Clear_toolStripLabel.Name = "Clear_toolStripLabel";
            this.Clear_toolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.Clear_toolStripLabel.Text = "Очистить:";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // Clear_toolStripButton
            // 
            this.Clear_toolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.Clear_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Clear_toolStripButton.Image")));
            this.Clear_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear_toolStripButton.Name = "Clear_toolStripButton";
            this.Clear_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Clear_toolStripButton.Text = "toolStripButton1";
            this.Clear_toolStripButton.ToolTipText = "Choose_toolStripButton";
            this.Clear_toolStripButton.Click += new System.EventHandler(this.Clear_toolStripButton_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // Canvas_Panel
            // 
            this.Canvas_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas_Panel.BackColor = System.Drawing.Color.White;
            this.Canvas_Panel.Location = new System.Drawing.Point(0, 28);
            this.Canvas_Panel.Name = "Canvas_Panel";
            this.Canvas_Panel.Size = new System.Drawing.Size(799, 421);
            this.Canvas_Panel.TabIndex = 1;
            this.Canvas_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_Panel_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canvas_Panel);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Лабораторная работа 6";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox Figure_toolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Clear_toolStripButton;
        private System.Windows.Forms.Panel Canvas_Panel;
        private System.Windows.Forms.ToolStripButton Red_toolStripButton;
        private System.Windows.Forms.ToolStripButton Green_toolStripButton;
        private System.Windows.Forms.ToolStripButton Blue_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel Color_toolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel Size_toolStripLabel;
        private System.Windows.Forms.ToolStripButton Plus_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton Minus_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel Shape_toolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel Clear_toolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    }
}

