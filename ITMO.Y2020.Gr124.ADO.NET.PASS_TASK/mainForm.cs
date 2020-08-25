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
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Linq;


namespace GasCalculationProgram4
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            
        }


        private GasEntities gasContext;

        public class Results
        {
            public decimal? resultD { get; set; }
            public decimal? resultR { get; set; }
        }
        

        private void mainForm_Load(object sender, EventArgs e)
        {
            gasContext = new GasEntities();
            
            var mix = gasContext.Gases
                .Include(x => x.Mixtures)
                .OrderBy(x => x.gasName);

            

            try
            {
                this.mixtureNameComboBox.DisplayMember = "gasName";
                this.mixtureNameComboBox.DataSource = mix.ToList();

                mixtureDataGridView.Columns[0].Width = 150;
                DataGridViewColumn column = mixtureDataGridView.Columns[1];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //mixtureDataGridView.Columns[0].Width = 10;
                // mixtureDataGridView.Columns[1].Width = 140;
                //mixtureDataGridView.Columns[2].Width = 150;
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
                Gas mygas = (Gas)this.mixtureNameComboBox.SelectedItem;

                

                mixtureDataGridView.DataSource = mygas.Mixtures.ToList();

                

                mixtureDataGridView.Columns["gasName"].Visible = false;
                mixtureDataGridView.Columns["Gas"].Visible = false;
                mixtureDataGridView.Columns["Component"].Visible = false;
                mixtureDataGridView.Columns["Gas_gasName"].Visible = false;
                mixtureDataGridView.Columns["Component_componentName"].Visible = false;

                mixtureDataGridView.AllowUserToDeleteRows = false;
                mixtureDataGridView.AllowUserToAddRows = false; // allow user to add rows


                mixtureDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //clean fields
           //densityTextBox.Text = string.Empty;
           //gasConstantTextBox.Text = string.Empty;

            // считываю значение из комбо-бокса в переменную mix
            string mix = mixtureNameComboBox.Text;

            // Загружаем данные из таблицы в кэш
            gasContext.SaveChanges();


            gasContext.mixtureCalculation(mix);

            gasContext.Gases.Load();

            //find parameters in current gas under var mix
            var currentGas = gasContext.Gases.Find(mix);

            //output to textfields
            densityTextBox.Text = Convert.ToString(currentGas.gasDensity);

            gasConstantTextBox.Text = Convert.ToString(currentGas.gasConstant);

            //mixtureNameComboBox.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //присваиваю переменной mix значение из comboBox
            string mix = mixtureNameComboBox.Text;

            // Загружаю данные из таблицы в кэш
            gasContext.Gases.Load();

            // Ищу в контексте смесь с имененм из переменной mix
            var currentGas = gasContext.Gases.Find(mix);

            // зануляю параметры
            //currentGas.gasDensity = 0;
            //currentGas.gasConstant = 0;
            //currentGas.gasSize = 0;

            //сохраняю изменения
            gasContext.SaveChanges();
            densityTextBox.Text = "";
            gasConstantTextBox.Text = string.Empty;
        }
    }
}
