namespace ITMO.Y2020.Gr124.ADO.NET.Lab09.Ex3
{
    partial class OfficeAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeAssignment));
            this.officeGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // officeGridView
            // 
            this.officeGridView.AllowUserToAddRows = false;
            this.officeGridView.AllowUserToDeleteRows = false;
            this.officeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeGridView.Location = new System.Drawing.Point(22, 90);
            this.officeGridView.Name = "officeGridView";
            this.officeGridView.Size = new System.Drawing.Size(590, 291);
            this.officeGridView.TabIndex = 0;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(637, 90);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(119, 23);
            this.saveChanges.TabIndex = 1;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(637, 132);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(119, 23);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // OfficeAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.officeGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OfficeAssignment";
            this.Text = "Office Assignment";
            this.Load += new System.EventHandler(this.OfficeAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView officeGridView;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button saveChangesButton;
    }
}