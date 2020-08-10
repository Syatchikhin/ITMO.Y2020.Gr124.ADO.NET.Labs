namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.newMixtureTextBox = new System.Windows.Forms.TextBox();
            this.mixtureDataGridView = new System.Windows.Forms.DataGridView();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.mixtureNameComboBox = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.loadMixtureButton = new System.Windows.Forms.Button();
            this.newMixtureButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SaveResultsButton = new System.Windows.Forms.Button();
            this.jLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.roLabel = new System.Windows.Forms.Label();
            this.gasConstantTextBox = new System.Windows.Forms.TextBox();
            this.densityTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            this.deleteMixtureButton = new System.Windows.Forms.Button();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.choseLabel = new System.Windows.Forms.Label();
            this.volumePercentLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okNewButton = new System.Windows.Forms.Button();
            this.cancelNewButton = new System.Windows.Forms.Button();
            this.okLoadButton = new System.Windows.Forms.Button();
            this.cancelLoadButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteResultsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(88, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя смеси:";
            // 
            // newMixtureTextBox
            // 
            this.newMixtureTextBox.Location = new System.Drawing.Point(163, 21);
            this.newMixtureTextBox.Name = "newMixtureTextBox";
            this.newMixtureTextBox.Size = new System.Drawing.Size(197, 20);
            this.newMixtureTextBox.TabIndex = 1;
            // 
            // mixtureDataGridView
            // 
            this.mixtureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mixtureDataGridView.Location = new System.Drawing.Point(14, 56);
            this.mixtureDataGridView.Name = "mixtureDataGridView";
            this.mixtureDataGridView.Size = new System.Drawing.Size(510, 345);
            this.mixtureDataGridView.TabIndex = 2;
            this.mixtureDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MixtureDataGridView_CellClick);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(632, 56);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(89, 20);
            this.totalTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelNewButton);
            this.groupBox2.Controls.Add(this.okNewButton);
            this.groupBox2.Controls.Add(this.inputLabel);
            this.groupBox2.Controls.Add(this.newMixtureTextBox);
            this.groupBox2.Location = new System.Drawing.Point(228, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2) Панель работы с новой смесью";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(538, 152);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(181, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // mixtureNameComboBox
            // 
            this.mixtureNameComboBox.Location = new System.Drawing.Point(161, 19);
            this.mixtureNameComboBox.Name = "mixtureNameComboBox";
            this.mixtureNameComboBox.Size = new System.Drawing.Size(197, 21);
            this.mixtureNameComboBox.TabIndex = 10;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(23, 24);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(134, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Ввести имя новой смеси";
            // 
            // loadMixtureButton
            // 
            this.loadMixtureButton.Location = new System.Drawing.Point(17, 49);
            this.loadMixtureButton.Name = "loadMixtureButton";
            this.loadMixtureButton.Size = new System.Drawing.Size(165, 23);
            this.loadMixtureButton.TabIndex = 1;
            this.loadMixtureButton.Text = "Загрузить смесь";
            this.loadMixtureButton.UseVisualStyleBackColor = true;
            this.loadMixtureButton.Click += new System.EventHandler(this.loadMixtureButton_Click);
            // 
            // newMixtureButton
            // 
            this.newMixtureButton.Location = new System.Drawing.Point(17, 20);
            this.newMixtureButton.Name = "newMixtureButton";
            this.newMixtureButton.Size = new System.Drawing.Size(165, 23);
            this.newMixtureButton.TabIndex = 0;
            this.newMixtureButton.Text = "Новая смесь";
            this.newMixtureButton.UseVisualStyleBackColor = true;
            this.newMixtureButton.Click += new System.EventHandler(this.NewMixtureButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.deleteResultsButton);
            this.groupBox5.Controls.Add(this.SaveResultsButton);
            this.groupBox5.Controls.Add(this.jLabel);
            this.groupBox5.Controls.Add(this.kgLabel);
            this.groupBox5.Controls.Add(this.rLabel);
            this.groupBox5.Controls.Add(this.roLabel);
            this.groupBox5.Controls.Add(this.gasConstantTextBox);
            this.groupBox5.Controls.Add(this.densityTextBox);
            this.groupBox5.Controls.Add(this.calculateButton);
            this.groupBox5.Location = new System.Drawing.Point(21, 575);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(738, 58);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4) Расчет свойств смеси";
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.Location = new System.Drawing.Point(586, 22);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(133, 23);
            this.SaveResultsButton.TabIndex = 7;
            this.SaveResultsButton.Text = "Сохранить результаты";
            this.SaveResultsButton.UseVisualStyleBackColor = true;
            this.SaveResultsButton.Click += new System.EventHandler(this.SaveResultsButton_Click);
            // 
            // jLabel
            // 
            this.jLabel.AutoSize = true;
            this.jLabel.Location = new System.Drawing.Point(508, 28);
            this.jLabel.Name = "jLabel";
            this.jLabel.Size = new System.Drawing.Size(57, 13);
            this.jLabel.TabIndex = 6;
            this.jLabel.Text = "Дж/(кг*К)";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Location = new System.Drawing.Point(357, 26);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(37, 13);
            this.kgLabel.TabIndex = 5;
            this.kgLabel.Text = "кг/м3";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(410, 28);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(15, 13);
            this.rLabel.TabIndex = 4;
            this.rLabel.Text = "R";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(558, 59);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Итого, %";
            // 
            // roLabel
            // 
            this.roLabel.AutoSize = true;
            this.roLabel.Location = new System.Drawing.Point(251, 27);
            this.roLabel.Name = "roLabel";
            this.roLabel.Size = new System.Drawing.Size(23, 13);
            this.roLabel.TabIndex = 3;
            this.roLabel.Text = "RO";
            // 
            // gasConstantTextBox
            // 
            this.gasConstantTextBox.Location = new System.Drawing.Point(431, 23);
            this.gasConstantTextBox.Name = "gasConstantTextBox";
            this.gasConstantTextBox.Size = new System.Drawing.Size(71, 20);
            this.gasConstantTextBox.TabIndex = 2;
            // 
            // densityTextBox
            // 
            this.densityTextBox.Location = new System.Drawing.Point(280, 22);
            this.densityTextBox.Name = "densityTextBox";
            this.densityTextBox.Size = new System.Drawing.Size(71, 20);
            this.densityTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(14, 21);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Рассчитать текущую смесь";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // componentComboBox
            // 
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Location = new System.Drawing.Point(148, 21);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(123, 21);
            this.componentComboBox.TabIndex = 6;
            // 
            // addComponentButton
            // 
            this.addComponentButton.Location = new System.Drawing.Point(538, 94);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(183, 23);
            this.addComponentButton.TabIndex = 8;
            this.addComponentButton.Text = "Добавить компонент в смесь";
            this.addComponentButton.UseVisualStyleBackColor = true;
            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.Location = new System.Drawing.Point(538, 123);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(183, 23);
            this.deleteComponentButton.TabIndex = 9;
            this.deleteComponentButton.Text = "Удалить выбранный компонент";
            this.deleteComponentButton.UseVisualStyleBackColor = true;
            // 
            // deleteMixtureButton
            // 
            this.deleteMixtureButton.Location = new System.Drawing.Point(17, 78);
            this.deleteMixtureButton.Name = "deleteMixtureButton";
            this.deleteMixtureButton.Size = new System.Drawing.Size(165, 23);
            this.deleteMixtureButton.TabIndex = 3;
            this.deleteMixtureButton.Text = "Удалить смесь";
            this.deleteMixtureButton.UseVisualStyleBackColor = true;
            this.deleteMixtureButton.Click += new System.EventHandler(this.DeleteMixtureButton_Click);
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(417, 21);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(107, 20);
            this.volumeTextBox.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.choseLabel);
            this.groupBox4.Controls.Add(this.clearButton);
            this.groupBox4.Controls.Add(this.volumePercentLabel);
            this.groupBox4.Controls.Add(this.addComponentButton);
            this.groupBox4.Controls.Add(this.volumeTextBox);
            this.groupBox4.Controls.Add(this.totalLabel);
            this.groupBox4.Controls.Add(this.deleteComponentButton);
            this.groupBox4.Controls.Add(this.componentComboBox);
            this.groupBox4.Controls.Add(this.mixtureDataGridView);
            this.groupBox4.Controls.Add(this.totalTextBox);
            this.groupBox4.Location = new System.Drawing.Point(21, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(738, 420);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3) Компоненты смеси";
            // 
            // choseLabel
            // 
            this.choseLabel.AutoSize = true;
            this.choseLabel.Location = new System.Drawing.Point(75, 25);
            this.choseLabel.Name = "choseLabel";
            this.choseLabel.Size = new System.Drawing.Size(57, 13);
            this.choseLabel.TabIndex = 13;
            this.choseLabel.Text = "Выберите";
            // 
            // volumePercentLabel
            // 
            this.volumePercentLabel.AutoSize = true;
            this.volumePercentLabel.Location = new System.Drawing.Point(316, 24);
            this.volumePercentLabel.Name = "volumePercentLabel";
            this.volumePercentLabel.Size = new System.Drawing.Size(73, 13);
            this.volumePercentLabel.TabIndex = 12;
            this.volumePercentLabel.Text = "Объемный %";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadMixtureButton);
            this.groupBox1.Controls.Add(this.newMixtureButton);
            this.groupBox1.Controls.Add(this.deleteMixtureButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 114);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1) Открыть / Создать";
            // 
            // okNewButton
            // 
            this.okNewButton.Location = new System.Drawing.Point(379, 20);
            this.okNewButton.Name = "okNewButton";
            this.okNewButton.Size = new System.Drawing.Size(61, 23);
            this.okNewButton.TabIndex = 11;
            this.okNewButton.Text = "OK";
            this.okNewButton.UseVisualStyleBackColor = true;
            this.okNewButton.Click += new System.EventHandler(this.okNewButton_Click);
            // 
            // cancelNewButton
            // 
            this.cancelNewButton.Location = new System.Drawing.Point(447, 20);
            this.cancelNewButton.Name = "cancelNewButton";
            this.cancelNewButton.Size = new System.Drawing.Size(67, 23);
            this.cancelNewButton.TabIndex = 12;
            this.cancelNewButton.Text = "Отмена";
            this.cancelNewButton.UseVisualStyleBackColor = true;
            this.cancelNewButton.Click += new System.EventHandler(this.cancelNewButton_Click);
            // 
            // okLoadButton
            // 
            this.okLoadButton.Location = new System.Drawing.Point(377, 19);
            this.okLoadButton.Name = "okLoadButton";
            this.okLoadButton.Size = new System.Drawing.Size(61, 23);
            this.okLoadButton.TabIndex = 13;
            this.okLoadButton.Text = "OK";
            this.okLoadButton.UseVisualStyleBackColor = true;
            this.okLoadButton.Click += new System.EventHandler(this.okLoadButton_Click);
            // 
            // cancelLoadButton
            // 
            this.cancelLoadButton.Location = new System.Drawing.Point(445, 19);
            this.cancelLoadButton.Name = "cancelLoadButton";
            this.cancelLoadButton.Size = new System.Drawing.Size(67, 23);
            this.cancelLoadButton.TabIndex = 14;
            this.cancelLoadButton.Text = "Отмена";
            this.cancelLoadButton.UseVisualStyleBackColor = true;
            this.cancelLoadButton.Click += new System.EventHandler(this.cancelLoadButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mixtureNameComboBox);
            this.groupBox3.Controls.Add(this.cancelLoadButton);
            this.groupBox3.Controls.Add(this.nameLabel);
            this.groupBox3.Controls.Add(this.okLoadButton);
            this.groupBox3.Location = new System.Drawing.Point(228, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 53);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3) Загрузить / удалить";
            // 
            // deleteResultsButton
            // 
            this.deleteResultsButton.Location = new System.Drawing.Point(148, 21);
            this.deleteResultsButton.Name = "deleteResultsButton";
            this.deleteResultsButton.Size = new System.Drawing.Size(84, 23);
            this.deleteResultsButton.TabIndex = 16;
            this.deleteResultsButton.Text = "Очистить";
            this.deleteResultsButton.UseVisualStyleBackColor = true;
            this.deleteResultsButton.Click += new System.EventHandler(this.deleteResultsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Gas Properties with SQL";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox newMixtureTextBox;
        private System.Windows.Forms.DataGridView mixtureDataGridView;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loadMixtureButton;
        private System.Windows.Forms.Button newMixtureButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label jLabel;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label roLabel;
        private System.Windows.Forms.TextBox gasConstantTextBox;
        private System.Windows.Forms.TextBox densityTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox componentComboBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.Button deleteComponentButton;
        private System.Windows.Forms.Button SaveResultsButton;
        private System.Windows.Forms.ComboBox mixtureNameComboBox;
        private System.Windows.Forms.Button deleteMixtureButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label choseLabel;
        private System.Windows.Forms.Label volumePercentLabel;
        private System.Windows.Forms.Button cancelLoadButton;
        private System.Windows.Forms.Button okLoadButton;
        private System.Windows.Forms.Button cancelNewButton;
        private System.Windows.Forms.Button okNewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteResultsButton;
    }
}

