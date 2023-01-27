using EmployeeMgmt1;
using System;
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
    public partial class Departments : Form
    {
        Functions con;
        public Departments()
        {
            InitializeComponent();
            con = new Functions();
            ShowDepartments();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void ListerDepartments()
        {
            string Query = "Select from DepartmentTb1";
            Deplist.DataSource = con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }
        int key = 0;

        private void ShowDepartments()
        {
            throw new NotImplementedException();
        }

        private void EditBon_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "update  DepartmentTb1 set DepName = '{0}'where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text,key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void Deplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepNameTb.Text = Deplist.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(Deplist.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTb1 where Depid = {0}";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();

        }
    }
}
