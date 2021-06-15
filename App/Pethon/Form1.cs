using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pethon
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Pethon\Model\EQUI_PIPE.mdb";
        string strSQL = "select A.label_value " +
            "from label_values A, labels B " +
            "where A.label_value_index = B.label_value_index and B.label_name_index = 3";
        public Form1()
        {
            InitializeComponent();

            //string[] models = { "EQUI_PIPE" };
            //listBox1.DataSource
        }

        private void all_sites_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.all_sites_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eQUI_PIPEDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUI_PIPEDataSet.label_values". При необходимости она может быть перемещена или удалена.
            //this.label_valuesTableAdapter.Fill(this.eQUI_PIPEDataSet.label_values);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUI_PIPEDataSet.labels". При необходимости она может быть перемещена или удалена.
            //this.labelsTableAdapter.Fill(this.eQUI_PIPEDataSet.labels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eQUI_PIPEDataSet.all_sites_table". При необходимости она может быть перемещена или удалена.
            //this.all_sites_tableTableAdapter.Fill(this.eQUI_PIPEDataSet.all_sites_table);

            
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = new OleDbCommand(strSQL, connection);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, connection);
            // Create a dataset object and fill with data using data adapter's Fill method 
            DataSet dataSet = new DataSet();
            
            dataAdapter.Fill(dataSet, "label_values");

            // Attach dataset's DefaultView to the combobox 
            //listBox1.DataSource = dataSet.Tables[0];
            //listBox1.DataSource(command.ExecuteScalar());

            //string[] models = command.ExecuteScalar().ToString;
            //listBox1.DataSource
            //listBox1.Items.AddRange(models);



             //Attach dataset's DefaultView to the combobox 
        listBox1.DataSource = dataSet.Tables[0].DefaultView;
            listBox1.DisplayMember = "label_value";





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
