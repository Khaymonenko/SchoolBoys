using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolboys
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
        }

        int rowIndex, ID;

        private void Main_Load(object sender, EventArgs e)
        {
            
            this.data_about_the_studentTableAdapter.Fill(this.schoolboysDataSet.data_about_the_student);

        }

        private void tbLastNameSearch_TextChanged(object sender, EventArgs e)
        {
            this.data_about_the_studentTableAdapter.search(this.schoolboysDataSet.data_about_the_student, tbLastNameSearch.Text, " ", " ", " ", " ");           
        }

        private void tbFirstNameSearch_TextChanged(object sender, EventArgs e)
        {
            this.data_about_the_studentTableAdapter.search(this.schoolboysDataSet.data_about_the_student, " ", tbFirstNameSearch.Text, " ", " ", " ");
        }

        private void tbMiddleNameSearch_TextChanged(object sender, EventArgs e)
        {
            this.data_about_the_studentTableAdapter.search(this.schoolboysDataSet.data_about_the_student, " ", " ", tbMiddleNameSearch.Text, " ", " ");
        }

        private void tbClassSearch_TextChanged(object sender, EventArgs e)
        {
            this.data_about_the_studentTableAdapter.search(this.schoolboysDataSet.data_about_the_student, " ", " ", " ", tbClassSearch.Text, tbClassSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.data_about_the_studentTableAdapter.Insert(tbLastName.Text, tbFirstName.Text, tbMiddleName.Text, dateTimePicker1.Value, rtbAddress.Text, tbPhoneNumber.Text, tbClassTeacher.Text, tbClass.Text);
            this.data_about_the_studentTableAdapter.Fill(this.schoolboysDataSet.data_about_the_student);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            this.data_about_the_studentTableAdapter.Update(tbLastName.Text, tbFirstName.Text, tbMiddleName.Text, dateTimePicker1.Value, rtbAddress.Text, tbPhoneNumber.Text, tbClassTeacher.Text, tbClass.Text, ID);
            this.data_about_the_studentTableAdapter.Fill(this.schoolboysDataSet.data_about_the_student);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.data_about_the_studentTableAdapter.Delete(ID);
            this.data_about_the_studentTableAdapter.Fill(this.schoolboysDataSet.data_about_the_student);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            tbLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbMiddleName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            rtbAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbPhoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbClassTeacher.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbClass.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

    }
}
