using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace excelImport
{
    public class ExcelImport
    {

        //Создаём приложение.
        Microsoft.Office.Interop.Excel.Application ObjExcel;
        //Открываем книгу.                                                                                                                                                        
        Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
        //Выбираем таблицу(лист).
        Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
     
               
        public String[] LoadArrayNames(String strPathAtributes)
        {
            //String strPathAtributes[];
            //String[] strArrayName;
            

            //Создаём приложение.
            ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            //Открываем книгу.                                                                                                                                                        
            ObjWorkBook = ObjExcel.Workbooks.Open(strPathAtributes, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Выбираем таблицу(лист).
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            // Указываем номер столбца (таблицы Excel) из которого будут считываться данные.
            int numCol = 1;

            Range usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
            System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
            return (myvalues.OfType<object>().Select(o => o.ToString()).ToArray());
        }


        public String[] LoadArrayValues(String strPathAtributes)
        {

            int numCol = 2;
            Range usedColumn = ObjWorkSheet.UsedRange.Columns[numCol];
            System.Array myvalues = (System.Array)usedColumn.Cells.Value2;
            myvalues = (System.Array)usedColumn.Cells.Value2;
            ObjExcel.Quit();
            return (myvalues.OfType<object>().Select(o => o.ToString()).ToArray());
           
        }

        
    }

}
