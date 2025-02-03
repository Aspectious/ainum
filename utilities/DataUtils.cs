using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace ainum.utilities
{
    public class DataUtils
    {
        public static DataTable TwoDFloatArrayToDataTable<T>(float[,] numbers)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                dt.Columns.Add("Column" + (i + 1));
            }

            for (var i = 0; i < numbers.GetLength(0); ++i)
            {
                DataRow row = dt.NewRow();
                for (var j = 0; j < numbers.GetLength(1); ++j)
                {
                    row[j] = numbers[i, j];
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        

        public static String ConvertDataTableToCSV(DataTable dt)
        {
            StringBuilder sb = new StringBuilder(); 

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                Select(column => column.ColumnName).
                ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                    ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            return sb.ToString();
        }
    }
}