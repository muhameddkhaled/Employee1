using Employee1;
using EmployeeMgmt1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee1
{
    public partial class Employees : Form
    {
        Functions Con;
        private Functions con;

        public Employees()
        {
            InitializeComponent();
            con = new Functions();
            ShowEmp();
            GetDepartment(); 
            
        }


        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTb1"; 
            throw new NotImplementedException();
            EmployeeList.DataSource = con.GetData(Query);
        }
        private void GetDepartment ()
        {
            string query = " select * from DepartmentTb1";
            DepCh.DisplayMember = con.GetData(query).Columns["DepName"].ToString();
            DepCh.ValueMember = con.GetData(query).Columns["DepId"].ToString();
            DepCh.DataSource = Con.GetData(query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCh.SelectedIndex == -1 || DepCh.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCh.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCh.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "insert into EmployeeTb1 values('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Emoloyee Updated!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCh.SelectedIndex = -1;
                    GenCh.SelectedIndex = -1;
            }

                }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }
    }
}
