using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using excelImport;
using mdbWrite;

namespace Pethon
{
    public partial class Form1 : Form
    {     

        string connectionStringMain = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ";
        string strSQL = "select A.label_value " +
            "from label_values A, labels B, linkage C " +
            "where A.label_value_index = B.label_value_index and B.label_name_index = 3 and C.label_file_index = 5 and C.linkage_index = B.linkage_index and A.label_value NOT LIKE  ('%End%')";
        
        string[][] strArrayName;
        string[][] strArrayValue;
        string[][] strArrayStatus;

        string[] strPathDbs;
        string[] strPathAtributes;
        string[] strVueNames;

        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
                   
        private void showRows ()
        {
            dataGridView1.Rows.Clear();
            int index = listBox1.SelectedIndex;

            try
            {
                for (int j = 0; j < strArrayName[index].Length; j++)
                {
                    dataGridView1.Rows.Add(new object[] { strArrayName[index][j], strArrayStatus[index][j]});
                }
            }
            catch (IndexOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("Что-то пошло не так");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRows();            
        }

        private void loadModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excelImport.ExcelImport excel = new ExcelImport();

            dataGridView1.Columns.Add("Index", "Атрибут");            
            dataGridView1.Columns.Add("Status", "Статус");
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetDirectories(fbd.SelectedPath);
                   
                    strPathDbs = new string[files.Length];
                    strPathAtributes = new string[files.Length];
                    strVueNames = new string[files.Length];
                    strArrayValue = new string[files.Length][];
                    strArrayName = new string[files.Length][];
                    strArrayStatus = new string[files.Length][];

                    for (int i = 0; i< files.Length; i++)
                    {
                        strPathDbs[i] = Directory.GetFiles(files[i], "*mdb2")[0];
                        strPathAtributes[i] = Directory.GetFiles(files[i], "*xlsx")[0];
                        
                        System.IO.File.Move(strPathDbs[i], strPathDbs[i].Substring(0, strPathDbs[i].Length - 1));
                        strPathDbs[i] = strPathDbs[i].Substring(0, strPathDbs[i].Length - 1);

                        string[] temp = strPathDbs[i].Split('\\');
                        strVueNames[i] = temp[temp.Length - 1].Split('.')[0] ;

                        //загрузка атрибутов из excel с помощью dll
                        strArrayName[i] = excel.LoadArrayNames(strPathAtributes[i]);
                        strArrayValue[i] = excel.LoadArrayValues(strPathAtributes[i]);
                       
                        strArrayStatus[i] = new string[strArrayValue[i].Length];
                    }
                    listBox1.Items.AddRange(strVueNames);                    
                }
            }

        }
      
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdbWrite.MdbWrite mdb = new MdbWrite();

            int index = listBox1.SelectedIndex;
            int n = 0;
            string connectionString = connectionStringMain;
            if(index != -1)
            {
                connectionString += strPathDbs[index];
                n = strArrayName[index].Length;
            }
            else 
            {
                
                MessageBox.Show("Что-то пошло не так");
                this.Close();
                return;
                Application.Exit();
            }
            MessageBox.Show(connectionString);

                     

            //c помощью dll добовляем атрибуты
            mdb.addAtributes(connectionString, strArrayName[index], strArrayValue[index]);

            for (int i = 0; i < n; i++)
            {
                strArrayStatus[index][i] = "добавлен";
            }

            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command;

            for (int i = 0; i < n; i++)
            {
                strSQL = "select Count(1) from label_names where label_name = '" + strArrayName[index][i] + "'";
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand(strSQL, connection);
                int response = (int)command.ExecuteScalar();
                if (response == 0)
                {
                    strArrayStatus[index][i] = "ошибка";
                }
                connection.Close();
            }
            showRows();
        }

        private void button1_Click(object sender, EventArgs e)
        { }       

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if(strPathDbs != null)
            for (int i = 0; i < strPathDbs.Length; i++)
                System.IO.File.Move(strPathDbs[i], strPathDbs[i] + "2");
        }
    }
}
