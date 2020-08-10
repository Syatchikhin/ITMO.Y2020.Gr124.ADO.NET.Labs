using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ITMO.Y2020.Gr124.ADO.NET.Task
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private GasEntities GasContext;

        private void mainForm_Load(object sender, EventArgs e)
        {
            GasContext = new GasEntities();

            //--Try to reload mix--
            //var mixtures = from o in GasContext.Compositions
            //               join a in GasContext.Components on
            //               new { componentFormula = o.componentFormula } equals
            //               new { componentFormula = a.componentFormula }
            //               select o;
            //-----Mixture output----
            ////var mixtures = from d in
            ////GasContext.Properties.Include("Compositions")
            ////               orderby d.gasName //-->gasName
            ////               select d;
            // --Try 3--
            //mixtures = GasContext.Compositions
            //    foreach (Composition x in "Compositions")
            //{
            //    foreach (Component c in x.componentFormula)
            //    {
            //        courseList.Add(x.compositionName + c.componentName);
            //    }


                //    }
                //----TEST--JOIN---
                //var mix = from t in GasContext.Properties.Include("Compositions")
                //          join a in GasContext.Components.Include("Compositions") on
                //          new {CF = t.gasName,  }
                //          //orderby t.gasName //-->gasName
                //          select t;

                var mixtures = GasContext.Properties.Include(x => x.Compositions).OrderBy(x => x.gasName);

                //----Gas output-----
                var gas = from f in GasContext.Components.Include("Compositions")
                      orderby f.componentFormula
                      select f;
            //var departments = schoolContext.Departments.Include(x => x.Courses).OrderBy(x => x.Name);

            //        var innerJoinQuery =
            //from category in categories
            //join prod in products on category.ID equals prod.CategoryID
            //select new { ProductName = prod.Name, Category = category.Name }; //produces flat sequence



            try
            {
                this.mixtureNameComboBox.DisplayMember = "gasName";
                this.mixtureNameComboBox.DataSource = mixtures.ToList();
                //try-4--
                //foreach (Composition d in "Compositions")
                //{
                //    GasContext.Entry(d).Collection(x => x.componentFormula).Load();
                //        foreach (Component c in d.componentFormula)
                //    {
                //        mixtureDataGridView2.AllowUserToAddRows(d.compositionName+c.componentNameRu)
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //-----Component output----
            var compon = from b in
        GasContext.Components.Include("Compositions")  //
                           orderby b.componentName
                           select b;
            try
            {
                this.componentComboBox.DisplayMember = "componentName";
                this.componentComboBox.DataSource = compon.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mixtureNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                mixtureDataGridView.Columns["Component"].Visible = false;
                mixtureDataGridView.Columns["compositionName"].Visible = false;
                mixtureDataGridView.Columns["Property"].Visible = false;

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
