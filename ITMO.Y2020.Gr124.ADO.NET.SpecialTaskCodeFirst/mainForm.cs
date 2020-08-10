//using CodeFirstGas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITMO.Y2020.Gr124.ADO.NET.SpecialTaskBF
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //string labelid;
        public Model MyTestGasContext;
        
        

        private void mainForm_Load(object sender, EventArgs e)
        {
            //GROUP2
            groupBox2.Enabled = false;
            //new mixture
            //inputLabel.Enabled = false;
            //newMixtureTextBox.Enabled = false;
            //okNewButton.Enabled = false;
            //cancelNewButton.Enabled = false;
            //newMixtureTextBox.Enabled = false;

            // open mixture
            //nameLabel.Enabled = false;
            //okLoadButton.Enabled = false;
            //cancelLoadButton.Enabled = false;
            //mixtureNameComboBox.Enabled = false;
            //GROUP3
            groupBox3.Enabled = false;
            //GROUP4
            groupBox4.Enabled = false;
            //GROUP5
            groupBox5.Enabled = false;

            //Заполнение комбобокса
            //orderlistBox1.DataSource = context.Orders.ToList();
            //componentComboBox.DataSource = context.Component.ToList();
            //MyTestGasContext = new MyTestGasEntities();
            MyTestGasContext = new Model();

            componentComboBox.DataSource = MyTestGasContext.Components.ToList();
            mixtureNameComboBox.DataSource = MyTestGasContext.Compositions.ToList();

            //var compositions = from d in
            //   MyTestGasContext.Compositions.Include("Air")
            //                   orderby d.compositionName
            //                   select d;

            var compositions = MyTestGasContext.Compositions.Include(x => x.compositionName).OrderBy(x => x.compositionName);
            try
            {
                this.mixtureNameComboBox.DisplayMember = "Composition Name";
                this.mixtureNameComboBox.DataSource = compositions.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NewMixtureButton_Click(object sender, EventArgs e)
        {
            //new 
            groupBox2.Enabled = true;
            newMixtureTextBox.Text = "";
            groupBox3.Enabled = false;
            //on
            //inputLabel.Enabled = true;
            //newMixtureTextBox.Enabled = true;
            //okNewButton.Enabled = true;
            //cancelNewButton.Enabled = true;
            //newMixtureTextBox.Enabled = true;
            // off
            //nameLabel.Enabled = false;
            //okLoadButton.Enabled = false;
            //cancelLoadButton.Enabled = false;
            //mixtureNameComboBox.Enabled = false;
            //GROUP3
            //groupBox4.Enabled = false;
            //GROUP4
            //groupBox5.Enabled = false;


            //try
            //{
            //    Mixture mixture = new Mixture
            //    { 
            //    gasName =this.newMixtureTextBox.Text

            //    };

            //    context.Mixtures.Add(mixture);
            //    context.SaveChanges();
            //    newMixtureTextBox.Text = String.Empty;
            //    //output
            //    mixtureDataGridView.DataSource = context.Mixtures.ToList();
            //}
            //catch(Exception ex)
            //{
            //     MessageBox.Show("Ошибка: " + ex.ToString()); 
            //}


        }

        private void MixtureDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
                //if (mixtureDataGridView.CurrentRow == null) return;
                //var mixture = mixtureDataGridView.CurrentRow.DataBoundItem as Mixture;
                //if (mixture == null) return;

                //labelid = Convert.ToString(mixture.gasMixture);
                //labelid.Text = Convert.ToString(customer.CustomerId);
                //textBoxCustomer.Text = customer.ToString();

                if (mixtureDataGridView.CurrentRow == null) return;
             {  
                var mixture = mixtureDataGridView.CurrentRow.DataBoundItem as Component;
                if (mixture == null) return;

                //labelid = Convert.ToString(mixture.gasMixture);
                //labelid.Text = Convert.ToString(customer.CustomerId);
                //textBoxCustomer.Text = customer.ToString();

            }
        }

        private void SaveMixtureButton_Click(object sender, EventArgs e)
        {
            //if (labelid == String.Empty) return;

            //var id = Convert.ToInt32(labelid);
            //var mixture = context.Mixtures.Find(id);

            //context.SaveChanges();
            //mixtureDataGridView.DataSource = context.Mixtures.ToList();
        }

        private void DeleteMixtureButton_Click(object sender, EventArgs e)
        {
            //if (labelid == String.Empty) return;

            //var id = Convert.ToInt32(labelid);
            //var mixture = context.Mixtures.Find(id);

            //context.Entry(mixture).State = EntityState.Deleted;
            //context.SaveChanges();
            ////Output();
            //mixtureDataGridView.DataSource = context.Mixtures.ToList();
        }

        private void loadMixtureButton_Click(object sender, EventArgs e)
        {
            //GROUP 3 -load
            groupBox3.Enabled = true;
            newMixtureTextBox.Text = "";
            groupBox2.Enabled = false;
            // on
            //nameLabel.Enabled = true;
            //okLoadButton.Enabled = true;
            //cancelLoadButton.Enabled = true;
            //mixtureNameComboBox.Enabled = true;
            // off
            //inputLabel.Enabled = false;
            //newMixtureTextBox.Enabled = false;
            //okNewButton.Enabled = false;
            //cancelNewButton.Enabled = false;
            //newMixtureTextBox.Enabled = false;

            //GROUP3
            //groupBox4.Enabled = true;
            //GROUP4
            //groupBox5.Enabled = true;
        }

        private void cancelNewButton_Click(object sender, EventArgs e)
        {
            // Hide menu 2-4
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void cancelLoadButton_Click(object sender, EventArgs e)
        {
            // Hide menu 2-4
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void okNewButton_Click(object sender, EventArgs e)
        {
            if (newMixtureTextBox.Text.Length > 0)
            {  //on
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                //off
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                //MessageBox.Show("text !=null");
            }
            
        }

        private void okLoadButton_Click(object sender, EventArgs e)
        {
            //on 
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            //off
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            
        }

        private void SaveResultsButton_Click(object sender, EventArgs e)
        {
            //on
            groupBox1.Enabled = true;
            //off
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        
        }

        private void deleteResultsButton_Click(object sender, EventArgs e)
        {
            densityTextBox.Text = "";
            gasConstantTextBox.Text = string.Empty; 
        }
    }
}
