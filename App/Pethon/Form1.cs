using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excelImport;
using System.IO;

namespace Pethon
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ";
        string strSQL = "select A.label_value " +
            "from label_values A, labels B, linkage C " +
            "where A.label_value_index = B.label_value_index and B.label_name_index = 3 and C.label_file_index = 5 and C.linkage_index = B.linkage_index and A.label_value NOT LIKE  ('%End%')";

        string[][] strArrayName;
        string[][] strArrayValue;
        string[][] strArrayStatus;


        string[] strPathDbs;
        string[] strPathAtributes;
        string[] strVueNames;



        Class1 class1 = new Class1();
        public Form1()
        {
            InitializeComponent();
            //string test = "D:\PethonTest\Model1\Model1.mdb";

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

           /* 
            OleDbConnection connection = new OleDbConnection(connectionString);
            //connection.Open();
            //OleDbCommand command = new OleDbCommand(strSQL, connection);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, connection);
            DataSet dataSet = new DataSet();
            
            //dataAdapter.Fill(dataSet, "label_values");
            //listBox1.DataSource = dataSet.Tables[0].DefaultView;
            //listBox1.DisplayMember = "label_value";



            dataGridView1.Columns.Add("Index", "Атрибут");
            //dataGridView1.Columns.Add("Value", "Значение атрибута");
            dataGridView1.Columns.Add("Status", "Статус");

            for (int i = 0; i < strArrayName.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { strArrayName[i], /*strArrayValue[i], strArrayStatus[i] });
            }
           */
        }
           


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            int index = listBox1.SelectedIndex;

            for (int j = 0; j < strArrayName[index].Length; j++)
            {
                dataGridView1.Rows.Add(new object[] { strArrayName[index][j], /*strArrayValue[i], strArrayStatus[2][j]*/ });
            }
        }

        private void loadModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("explorer.exe", @"C:\Users");
            /*using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Intergraph vue files (*.vue)|*.vue";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileSelected = openFileDialog1.FileName;
                    

                    fileSelected = fileSelected.Substring(0, fileSelected.Length - 3);
                    connectionString = connectionString + fileSelected + "mdb";
                    textBox1.Text = class1.PrintDay();
                    selectBd();
                    

                }
            }*/

            dataGridView1.Columns.Add("Index", "Атрибут");
            //dataGridView1.Columns.Add("Value", "Значение атрибута");
            dataGridView1.Columns.Add("Status", "Статус");
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetDirectories(fbd.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Найдено моделей: " + files.Length.ToString(), "Найдено");
                    //System.Windows.Forms.MessageBox.Show("Найдено моделей: " + files[0].ToString(), "Найдено");
                    strPathDbs = new string[files.Length];
                    strPathAtributes = new string[files.Length];
                    strVueNames = new string[files.Length];
                    strArrayValue = new string[files.Length][];
                    strArrayName = new string[files.Length][];
                    strArrayStatus = new string[files.Length][];


                    for(int i = 0; i< files.Length; i++)
                    {
                        strPathDbs[i] = Directory.GetFiles(files[i], "*mdb")[0];
                        strPathAtributes[i] = Directory.GetFiles(files[i], "*xlsx")[0];
                        //System.Windows.Forms.MessageBox.Show("Найдено моделей: " + filesDirectory.Length.ToString(), "Найдено");
                        string[] temp = strPathDbs[i].Split('\\');
                        strVueNames[i] = temp[temp.Length - 1].Split('.')[0] ;

                        //laodFromExcel(strPathAtributes[i]);

                        //Создаём приложение.
                        Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                        //Открываем книгу.                                                                                                                                                        
                        Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(strPathAtributes[i], 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                        //Выбираем таблицу(лист).
                        Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
                        ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

                        // Указываем номер столбца (таблицы Excel) из которого будут считываться данные.
                        int numCol = 1;

                        Range usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
                        System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
                        strArrayName[i] = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();

                        numCol = 2;

                        usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
                        myvalues = (System.Array)usedColumn.Cells.Value2;
                        strArrayValue[i] = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();


                        // Выходим из программы Excel.
                        ObjExcel.Quit();

                      

                        




                    }
                    listBox1.Items.AddRange(strVueNames);

                    
                }

                
            }

        }



        private void selectBd ()
        {
            
             OleDbConnection connection = new OleDbConnection(connectionString);
             connection.Open();
             OleDbCommand command = new OleDbCommand(strSQL, connection);

             OleDbDataAdapter dataAdapter = new OleDbDataAdapter(strSQL, connection);
             DataSet dataSet = new DataSet();

             dataAdapter.Fill(dataSet, "label_values");
             //listBox1.DataSource = dataSet.Tables[0].DefaultView;
             //listBox1.DisplayMember = "label_value";



             
            
        }

        private void дополнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            string fileSelected = "0";
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Excel xlsx files (*.xlsx)|*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileSelected = openFileDialog1.FileName;
                    //fileSelected = fileSelected.Substring(0, fileSelected.Length - 3);
                    //connectionString = connectionString + fileSelected + "mdb";
                    //textBox1.Text = connectionString;
                }  
            }

            //Создаём приложение.
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            //Открываем книгу.                                                                                                                                                        
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(fileSelected, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Выбираем таблицу(лист).
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            // Указываем номер столбца (таблицы Excel) из которого будут считываться данные.
            int numCol = 1;

            Range usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
            System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
            //strArrayName = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();

            numCol = 2;

            usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
            myvalues = (System.Array)usedColumn.Cells.Value2;
            //strArrayValue = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();


            // Выходим из программы Excel.
            ObjExcel.Quit();

            //strArrayStatus = new String[strArrayName.Length];

            for (int i = 0; i < strArrayName.Length; i++)
            {
                //strArrayStatus[i] = "Ошибка";
            }

            dataGridView1.Columns.Add("Index", "Атрибут");
            //dataGridView1.Columns.Add("Value", "Значение атрибута");
            dataGridView1.Columns.Add("Status", "Статус");

            for (int i = 0; i < strArrayName.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { strArrayName[i], strArrayStatus[i] });
            }
            */
        }
    }
}
