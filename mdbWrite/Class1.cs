using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdbWrite
{
    public class MdbWrite
    {

        public void addAtributes(string connectionString,  string[] strArrayName, string[] strArrayValue)
        {

            string strSQL = "select C.linkage_index " +
               "from label_values A, labels B, linkage C " +
               "where A.label_value_index = B.label_value_index and B.label_name_index = 3 and C.label_file_index = 5 and C.linkage_index = B.linkage_index and A.label_value NOT LIKE  ('%End%')";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            OleDbDataReader dataReader = command.ExecuteReader();
            List<int> eqiupmentNames = new List<int>();
            while (dataReader.Read())
            {
                eqiupmentNames.Add(dataReader.GetInt32(0));
            }
            connection.Close();

            int n = strArrayName.Length;
            int[] names = new int[n];
            int[] values = new int[n];



            //добовляем в бд атрибуты
            for (int i = 0; i < n; i++)
            {
                strSQL = "select max(label_name_index) from label_names";
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand(strSQL, connection);
                int ind = (int)command.ExecuteScalar();
                ind++;
                names[i] = ind;
                connection.Close();


                strSQL = "insert into label_names values (" + ind + ", '" + strArrayName[i] + "', 1, -1, -1)";
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand(strSQL, connection);
                command.ExecuteNonQuery();
                connection.Close();

                strSQL = "select max(label_value_index) from label_values";
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand(strSQL, connection);
                ind = (int)command.ExecuteScalar();
                ind++;
                values[i] = ind;
                connection.Close();


                strSQL = "insert into label_values values (" + ind + ", '" + strArrayValue[i] + "', 0)";
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand(strSQL, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            //добовляем атарибуты в модели
            for (int j = 0; j < eqiupmentNames.Count(); j++)
            {
                strSQL = "select max(label_line_number) from labels where linkage_index = " + eqiupmentNames[j];
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = new OleDbCommand(strSQL, connection);
                int ind = (int)((Int16)command.ExecuteScalar());
                ind++;
                connection.Close();

                for (int i = 0; i < n; i++)
                {
                    strSQL = "insert into labels values (" + eqiupmentNames[j] + ", '" + names[i] + "', '" + values[i] + "', " + ind + ", 0)";
                    connection = new OleDbConnection(connectionString);
                    connection.Open();
                    command = new OleDbCommand(strSQL, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

        }
    }
}
