using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVDataDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseDisplay_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txtFilePath.Text);
        }

        private void BindDataCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');

                foreach(string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                int sum=0;
                double avg = 0.0;
                int min = 0;
                int max = 0;
                double sqrt = 0.0;
                for (int r=1; r<lines.Length-200000; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                        for(int i=0; i<=9; i++)
                        {
                            try
                            {
                                int k = 0;
                                bool isnum = int.TryParse(dataWords[i], out k);
                                if(isnum != false)
                                {
                                    sum = sum + int.Parse(dataWords[i]);//합계
                                    sqrt = int.Parse(dataWords[i]) * int.Parse(dataWords[i]) / 10;//표준편차
                                }
                            }
                            catch
                            {
                                throw;
                            }
                        }
                        try
                        {
                            min = lines[r].Min();//최소값
                            max = lines[r].Max();//최대값
                        }
                        catch
                        {
                            throw;
                        }
                        avg = (double)sum / 10;//평균
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                datagridview1.DataSource = dt;
            }
        }
    }
}
