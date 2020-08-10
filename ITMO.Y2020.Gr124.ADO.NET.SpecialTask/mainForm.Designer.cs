namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTask
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MixtureNameTextBox = new System.Windows.Forms.TextBox();
            this.mixtureDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveMixtureButton = new System.Windows.Forms.Button();
            this.LoadMixtureButton = new System.Windows.Forms.Button();
            this.NewMixtureButton = new System.Windows.Forms.Button();
            this.CalculationGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveResultsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GasConstantTextBox = new System.Windows.Forms.TextBox();
            this.DensityTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ComponentcComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteTextBox = new System.Windows.Forms.Button();
            this.mixtureNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView)).BeginInit();
            this.FileGroupBox.SuspendLayout();
            this.CalculationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя смеси:";
            // 
            // MixtureNameTextBox
            // 
            this.MixtureNameTextBox.Location = new System.Drawing.Point(435, 10);
            this.MixtureNameTextBox.Name = "MixtureNameTextBox";
            this.MixtureNameTextBox.Size = new System.Drawing.Size(266, 20);
            this.MixtureNameTextBox.TabIndex = 1;
            // 
            // mixtureDataGridView
            // 
            this.mixtureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mixtureDataGridView.Location = new System.Drawing.Point(16, 45);
            this.mixtureDataGridView.Name = "mixtureDataGridView";
            this.mixtureDataGridView.Size = new System.Drawing.Size(501, 293);
            this.mixtureDataGridView.TabIndex = 2;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(428, 356);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(89, 20);
            this.TotalTextBox.TabIndex = 3;
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.SaveMixtureButton);
            this.FileGroupBox.Controls.Add(this.LoadMixtureButton);
            this.FileGroupBox.Controls.Add(this.NewMixtureButton);
            this.FileGroupBox.Location = new System.Drawing.Point(539, 45);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(209, 142);
            this.FileGroupBox.TabIndex = 4;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "Панель работы с файлами";
            // 
            // SaveMixtureButton
            // 
            this.SaveMixtureButton.Location = new System.Drawing.Point(20, 98);
            this.SaveMixtureButton.Name = "SaveMixtureButton";
            this.SaveMixtureButton.Size = new System.Drawing.Size(165, 22);
            this.SaveMixtureButton.TabIndex = 2;
            this.SaveMixtureButton.Text = "Сохранить смесь";
            this.SaveMixtureButton.UseVisualStyleBackColor = true;
            // 
            // LoadMixtureButton
            // 
            this.LoadMixtureButton.Location = new System.Drawing.Point(20, 61);
            this.LoadMixtureButton.Name = "LoadMixtureButton";
            this.LoadMixtureButton.Size = new System.Drawing.Size(165, 23);
            this.LoadMixtureButton.TabIndex = 1;
            this.LoadMixtureButton.Text = "Загрузить смесь";
            this.LoadMixtureButton.UseVisualStyleBackColor = true;
            // 
            // NewMixtureButton
            // 
            this.NewMixtureButton.Location = new System.Drawing.Point(20, 26);
            this.NewMixtureButton.Name = "NewMixtureButton";
            this.NewMixtureButton.Size = new System.Drawing.Size(165, 23);
            this.NewMixtureButton.TabIndex = 0;
            this.NewMixtureButton.Text = "Новая смесь";
            this.NewMixtureButton.UseVisualStyleBackColor = true;
            // 
            // CalculationGroupBox
            // 
            this.CalculationGroupBox.Controls.Add(this.SaveResultsButton);
            this.CalculationGroupBox.Controls.Add(this.label5);
            this.CalculationGroupBox.Controls.Add(this.label4);
            this.CalculationGroupBox.Controls.Add(this.label3);
            this.CalculationGroupBox.Controls.Add(this.label2);
            this.CalculationGroupBox.Controls.Add(this.GasConstantTextBox);
            this.CalculationGroupBox.Controls.Add(this.DensityTextBox);
            this.CalculationGroupBox.Controls.Add(this.CalculateButton);
            this.CalculationGroupBox.Location = new System.Drawing.Point(539, 203);
            this.CalculationGroupBox.Name = "CalculationGroupBox";
            this.CalculationGroupBox.Size = new System.Drawing.Size(209, 173);
            this.CalculationGroupBox.TabIndex = 5;
            this.CalculationGroupBox.TabStop = false;
            this.CalculationGroupBox.Text = "Панель расчетов";
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.Location = new System.Drawing.Point(24, 128);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(161, 23);
            this.SaveResultsButton.TabIndex = 7;
            this.SaveResultsButton.Text = "Сохранить результаты";
            this.SaveResultsButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дж/(кг*К)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "кг/м3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RO";
            // 
            // GasConstantTextBox
            // 
            this.GasConstantTextBox.Location = new System.Drawing.Point(47, 96);
            this.GasConstantTextBox.Name = "GasConstantTextBox";
            this.GasConstantTextBox.Size = new System.Drawing.Size(71, 20);
            this.GasConstantTextBox.TabIndex = 2;
            // 
            // DensityTextBox
            // 
            this.DensityTextBox.Location = new System.Drawing.Point(47, 67);
            this.DensityTextBox.Name = "DensityTextBox";
            this.DensityTextBox.Size = new System.Drawing.Size(71, 20);
            this.DensityTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(20, 28);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(165, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ComponentcComboBox
            // 
            this.ComponentcComboBox.FormattingEnabled = true;
            this.ComponentcComboBox.Location = new System.Drawing.Point(16, 385);
            this.ComponentcComboBox.Name = "ComponentcComboBox";
            this.ComponentcComboBox.Size = new System.Drawing.Size(176, 21);
            this.ComponentcComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Итого, %";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(213, 385);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить компонент в смесь";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(213, 414);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(183, 23);
            this.DeleteTextBox.TabIndex = 9;
            this.DeleteTextBox.Text = "Удалить выбранный компонент";
            this.DeleteTextBox.UseVisualStyleBackColor = true;
            // 
            // mixtureNameComboBox
            // 
            this.mixtureNameComboBox.Location = new System.Drawing.Point(98, 10);
            this.mixtureNameComboBox.Name = "mixtureNameComboBox";
            this.mixtureNameComboBox.Size = new System.Drawing.Size(257, 21);
            this.mixtureNameComboBox.TabIndex = 10;
            this.mixtureNameComboBox.SelectedIndexChanged += new System.EventHandler(this.MixtureNameComboBox_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.mixtureNameComboBox);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComponentcComboBox);
            this.Controls.Add(this.CalculationGroupBox);
            this.Controls.Add(this.FileGroupBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.mixtureDataGridView);
            this.Controls.Add(this.MixtureNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Gas Properties with SQL";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView)).EndInit();
            this.FileGroupBox.ResumeLayout(false);
            this.CalculationGroupBox.ResumeLayout(false);
            this.CalculationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MixtureNameTextBox;
        private System.Windows.Forms.DataGridView mixtureDataGridView;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.Button SaveMixtureButton;
        private System.Windows.Forms.Button LoadMixtureButton;
        private System.Windows.Forms.Button NewMixtureButton;
        private System.Windows.Forms.GroupBox CalculationGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GasConstantTextBox;
        private System.Windows.Forms.TextBox DensityTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ComboBox ComponentcComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteTextBox;
        private System.Windows.Forms.Button SaveResultsButton;
        private System.Windows.Forms.ComboBox mixtureNameComboBox;
    }
}

