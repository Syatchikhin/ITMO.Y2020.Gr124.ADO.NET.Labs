using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTask
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //private GasEntities MyTestGasContext;
        private GasEntities MyTestGasContext;

        private void mainForm_Load(object sender, EventArgs e)
        {
            //MyTestGasContext = new GasEntities();
            MyTestGasContext = new GasEntities();

            //var compositions = from d in
            //   MyTestGasContext.Compositions.Include("Compositions")  //"Mixtures" //Compositions
            //                   orderby d.compositionName
            //                   select d;
            //var compositions = from d in
            //   MyTestGasContext.Properties.Include("Property")  //"Mixtures" //Compositions
            //                   orderby d.gasName
            //                   select d;

            //var compositions = MyTestGasContext.Compositions.Include(x => x.compositionName).OrderBy(x => x.compositionName);
            //var compositions = MyTestGasContext.Compositions.Include(x => x.Properties).OrderBy(x => x.compositionName);
            var compositions = MyTestGasContext.Compositions.Include(x => x.property).OrderBy(x => x.compositionName);

            try
            {
                this.mixtureNameComboBox.DisplayMember = "compositionName";
                this.mixtureNameComboBox.DataSource = compositions.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MixtureNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Property properties =
          (Property)this.mixtureNameComboBox.SelectedItem;

                mixtureDataGridView.DataSource = properties.Compositions.ToList();

                //mixtureDataGridView.Columns["Department"].Visible = false;
                //mixtureDataGridView.Columns["StudentGrades"].Visible = false;
                //mixtureDataGridView.Columns["OnlineCourse"].Visible = false;
                //mixtureDataGridView.Columns["OnsiteCourse"].Visible = false;
                //mixtureDataGridView.Columns["People"].Visible = false;
                //mixtureDataGridView.Columns["DepartmentId"].Visible = false;
                mixtureDataGridView.Columns["gasPath"].Visible = false;

                mixtureDataGridView.AllowUserToDeleteRows = false;
                mixtureDataGridView.AllowUserToAddRows = true; // allow user to add rows


                mixtureDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
