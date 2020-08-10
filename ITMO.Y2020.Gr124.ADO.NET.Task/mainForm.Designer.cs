namespace ITMO.Y2020.Gr124.ADO.NET.Task
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mixtureDataGridView = new System.Windows.Forms.DataGridView();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.mixtureNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compositionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.compositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compositionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mixtureDataGridView2 = new System.Windows.Forms.DataGridView();
            this.gasDatabase3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasDatabase3DataSet = new ITMO.Y2020.Gr124.ADO.NET.Task.GasDatabase3DataSet();
            this.componentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingNavigator)).BeginInit();
            this.compositionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasDatabase3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasDatabase3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mixtureDataGridView
            // 
            this.mixtureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mixtureDataGridView.Location = new System.Drawing.Point(12, 159);
            this.mixtureDataGridView.Name = "mixtureDataGridView";
            this.mixtureDataGridView.Size = new System.Drawing.Size(285, 210);
            this.mixtureDataGridView.TabIndex = 0;
            // 
            // componentComboBox
            // 
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Location = new System.Drawing.Point(42, 120);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(239, 21);
            this.componentComboBox.TabIndex = 1;
            // 
            // mixtureNameComboBox
            // 
            this.mixtureNameComboBox.FormattingEnabled = true;
            this.mixtureNameComboBox.Location = new System.Drawing.Point(288, 43);
            this.mixtureNameComboBox.Name = "mixtureNameComboBox";
            this.mixtureNameComboBox.Size = new System.Drawing.Size(183, 21);
            this.mixtureNameComboBox.TabIndex = 2;
            this.mixtureNameComboBox.SelectedIndexChanged += new System.EventHandler(this.mixtureNameComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compositionName,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(330, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 85);
            this.dataGridView1.TabIndex = 3;
            // 
            // compositionsBindingNavigator
            // 
            this.compositionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.compositionsBindingNavigator.BindingSource = this.compositionsBindingSource;
            this.compositionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.compositionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.compositionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.compositionsBindingNavigatorSaveItem});
            this.compositionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.compositionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.compositionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.compositionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.compositionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.compositionsBindingNavigator.Name = "compositionsBindingNavigator";
            this.compositionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.compositionsBindingNavigator.Size = new System.Drawing.Size(1096, 25);
            this.compositionsBindingNavigator.TabIndex = 4;
            this.compositionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // compositionsBindingSource
            // 
            this.compositionsBindingSource.DataSource = typeof(ITMO.Y2020.Gr124.ADO.NET.Task.Composition);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // compositionsBindingNavigatorSaveItem
            // 
            this.compositionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compositionsBindingNavigatorSaveItem.Enabled = false;
            this.compositionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("compositionsBindingNavigatorSaveItem.Image")));
            this.compositionsBindingNavigatorSaveItem.Name = "compositionsBindingNavigatorSaveItem";
            this.compositionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.compositionsBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // mixtureDataGridView2
            // 
            this.mixtureDataGridView2.AutoGenerateColumns = false;
            this.mixtureDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mixtureDataGridView2.DataSource = this.gasDatabase3DataSetBindingSource;
            this.mixtureDataGridView2.Location = new System.Drawing.Point(384, 159);
            this.mixtureDataGridView2.Name = "mixtureDataGridView2";
            this.mixtureDataGridView2.Size = new System.Drawing.Size(494, 210);
            this.mixtureDataGridView2.TabIndex = 5;
            // 
            // gasDatabase3DataSetBindingSource
            // 
            this.gasDatabase3DataSetBindingSource.DataSource = this.gasDatabase3DataSet;
            this.gasDatabase3DataSetBindingSource.Position = 0;
            // 
            // gasDatabase3DataSet
            // 
            this.gasDatabase3DataSet.DataSetName = "GasDatabase3DataSet";
            this.gasDatabase3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentBindingSource
            // 
            this.componentBindingSource.DataSource = typeof(ITMO.Y2020.Gr124.ADO.NET.Task.Component);
            // 
            // compositionName
            // 
            this.compositionName.DataPropertyName = "compositionName";
            this.compositionName.HeaderText = "compositionName";
            this.compositionName.Name = "compositionName";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "componentNumber";
            this.Column2.HeaderText = "componentNumber";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "componentName";
            this.Column3.HeaderText = "componentName";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "componentNameRu";
            this.Column4.HeaderText = "componentNameRu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "componentFormula";
            this.Column5.HeaderText = "componentFormula";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "componentMolarWeight";
            this.Column6.HeaderText = "componentMolarWeight";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "componentVolume";
            this.Column7.HeaderText = "componentVolume";
            this.Column7.Name = "Column7";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 529);
            this.Controls.Add(this.mixtureDataGridView2);
            this.Controls.Add(this.compositionsBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mixtureNameComboBox);
            this.Controls.Add(this.componentComboBox);
            this.Controls.Add(this.mixtureDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingNavigator)).EndInit();
            this.compositionsBindingNavigator.ResumeLayout(false);
            this.compositionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compositionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixtureDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasDatabase3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasDatabase3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mixtureDataGridView;
        private System.Windows.Forms.ComboBox componentComboBox;
        private System.Windows.Forms.ComboBox mixtureNameComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource compositionsBindingSource;
        private System.Windows.Forms.BindingNavigator compositionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton compositionsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource componentBindingSource;
        private System.Windows.Forms.DataGridView mixtureDataGridView2;
        private System.Windows.Forms.BindingSource gasDatabase3DataSetBindingSource;
        private GasDatabase3DataSet gasDatabase3DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

