using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Examination
{
    public partial class FormNewCase : Form
    {
        int questionId = +1;
        int currentSelectedRow = -1;

        private DataBaseDataContext db = new DataBaseDataContext();

        public FormNewCase()
        {
            InitializeComponent();
        }

        private void FormNewCase_Load(object sender, EventArgs e)
        {
            tbNumberOfQuestion.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var formNewQuestion = new FormNewQuestion();
            if (formNewQuestion.ShowDialog() == DialogResult.OK)
            {
                dgvData.Rows.Add( formNewQuestion.text, formNewQuestion.option_a, formNewQuestion.option_b, formNewQuestion.option_c, formNewQuestion.option_d, formNewQuestion.correct_answer, btnRemove.Text = "Remove", 1);
                generateNumberOfQustion();
            }
        }

        private void generateNumberOfQustion()
        {
            int question = 0;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.IsNewRow) continue;

                question += Convert.ToInt32( row.Cells[7].Value);
            }

            tbNumberOfQuestion.Text = question.ToString();
        }

        private bool isValidCode(string code)
        {
            string regex = @"^CASE\d{5}$";
            return Regex.IsMatch(code, regex);
        }

        private bool validation()
        {
            if (tbCode.Text == string.Empty || tbNumberOfQuestion.Text == string.Empty || tbNumberOfQuestion.Text == "0")
            {
                Support.MSI("all input must be filled");
                return false;
            }

            if (!isValidCode(tbCode.Text))
            {
                Support.MSI("code must be valid format");
                return false;
            }

            return true;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;
                dgvData.Rows.RemoveAt(e.RowIndex);
                generateNumberOfQustion();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validation())
                {
                    var cs = new @case();
                    cs.creator_id = DataStorage.userId;
                    cs.code = tbCode.Text;
                    cs.number_of_questions = Convert.ToInt32(tbNumberOfQuestion.Text);
                    cs.created_at = DateTime.Now;
                    db.cases.InsertOnSubmit(cs);
                    db.SubmitChanges();

                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var csd = new cases_detail();
                        csd.case_id = cs.id;
                        csd.text = row.Cells[0].Value.ToString();
                        csd.option_a = row.Cells[1].Value.ToString();
                        csd.option_b = row.Cells[2].Value.ToString();
                        csd.option_c = row.Cells[3].Value.ToString();
                        csd.option_d = row.Cells[4].Value.ToString();
                        csd.correct_answer = row.Cells[5].Value.ToString();
                        csd.created_at = DateTime.Now;
                        db.cases_details.InsertOnSubmit(csd);
                        db.SubmitChanges();
                    }

                    db.SubmitChanges();
                    Support.MSI("berhasil");
                    dgvData.Rows.Clear();
                    tbCode.Text = tbNumberOfQuestion.Text = string.Empty;

                }


            } catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear();
            tbCode.Text = tbNumberOfQuestion.Text = string.Empty;
        }
    }
}
