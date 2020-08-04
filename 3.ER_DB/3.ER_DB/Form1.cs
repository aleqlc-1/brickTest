using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.ER_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string myConnection = "datasource=db.brique.kr; Database=employees; username=codingtest; password=12brique!@";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * employees", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);

                myConn.Open();

                DataSet ds = new DataSet();
                MessageBox.Show("연결되었습니다.");

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string constring = "datasource=db.brique.kr; Database=employees; username=codingtest; password=12brique!@";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand
                ("select emp_no as '종업원 번호',first_name as '이름', last_name as '성'," +
                " gender as '성별', profile as '프로필',gender as '성별', hire_date as '고용일자'," +
                "dept_name as '부서 이름', title as 직급, select max(salary) from employees GROUP BY emp_no as 최대 급여 from employees" +
                "where YEAR(hire_date)>=2000;", conDataBase);
             
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
