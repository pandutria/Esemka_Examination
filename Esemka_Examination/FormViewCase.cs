using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Examination
{
    public partial class FormViewCase : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int currentSelectedRow = -1;
        string mode = "";

        int quetionNumber = 0;
        int numberOfQuestion = 0;

        public FormViewCase()
        {
            InitializeComponent();
        }

 

        private void loadCboAnswer()
        {
            var list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            cboAnswer.DataSource = list;
        }

        private void enableOption(bool e)
        {
            tbText.Enabled = !e;
            tbOptionA.Enabled = !e;
            tbOptionB.Enabled = !e;
            tbOptionC.Enabled = !e;
            tbOptionD.Enabled = !e;
            cboAnswer.Enabled = !e;
        }

        private void enableButton (bool e)
        {
            btnUpdate.Enabled = e;
            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;
        }

        private void enableOptionAndButton(bool e)
        {
            enableOption(e);
            enableButton(e);
        }

        private void loadDgvData()
        {
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();

            var query = db.cases.Where(x => x.user.name.Contains(tbSearch.Text) && (x.deleted_at == null))
                .Select(x => new { x.id, x.code, creator = x.user.name, x.number_of_questions, x.created_at, x.deleted_at});

            dgvData.DataSource = query;

            //dgvData.Columns["text"].Visible = false;
            //dgvData.Columns["option_a"].Visible = false;
            //dgvData.Columns["option_b"].Visible = false;
            //dgvData.Columns["option_c"].Visible = false;
            //dgvData.Columns["option_d"].Visible = false;
            ////dgvData.Columns["correct_answer"].Visible = false;
            //dgvData.Columns["detailId"].Visible = false;
        }

        private void FormViewCase_Load(object sender, EventArgs e)
        {
            enableOptionAndButton(true);
            loadDgvData();
            loadCboAnswer();

            btnPrev.Enabled = false;

            //lblQuestion.Text = string.Empty;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Cells[0].Selected = true;
            }

            

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;
                currentSelectedRow = Convert.ToInt32( dgvData.Rows[e.RowIndex].Cells["id"].Value);
                //quetionNumber = Convert.ToInt32( dgvData.Rows[e.RowIndex].Cells["id"].Value);
                numberOfQuestion = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["number_of_questions"].Value);

                var query = db.cases_details.FirstOrDefault(x => x.case_id == currentSelectedRow);

                if (query != null)
                {
                    quetionNumber = query.id;
                }

                loadData();
                btnNext.Enabled = true;
                btnPrev.Enabled = true;

            }
        }

        private void loadData()
        {

            var query = db.cases_details.FirstOrDefault(x => x.id == quetionNumber);

            if (query != null)
            {
                tbText.Text = query.text;
                tbOptionA.Text = query.option_a;
                tbOptionB.Text = query.option_b;
                tbOptionC.Text = query.option_c;
                tbOptionD.Text = query.option_d;

                if (query.correct_answer == query.option_a)
                {
                    cboAnswer.Text = "A";
                }

                if (query.correct_answer == query.option_b)
                {
                    cboAnswer.Text = "B";
                }

                if (query.correct_answer == query.option_c)
                {
                    cboAnswer.Text = "c";
                }

                if (query.correct_answer == query.option_d)
                {
                    cboAnswer.Text = "D";
                }

            }

            lblQuestion.Text = "Question  " + quetionNumber + "/" + numberOfQuestion;
        }
 
        private void tbSearch_TextChanged(object sender, EventArgs e) 
        {
            loadDgvData();
        }
         
        private void button5_Click(object sender, EventArgs e)
        {

            if (currentSelectedRow == -1)
            {
                Support.MSI("select data first");
            } 

            else
            {
                enableOptionAndButton(false);
                tbSearch.Enabled = false;
                mode = "update";
            }


        }

        private void btnFirstQuestion_Click(object sender, EventArgs e)
        {
            //var query = db.cases_details.FirstOrDefault =

            if (currentSelectedRow == -1)
            {
                Support.MSI("select data");
            } else
            {
                var query = db.cases_details.Where(x => x.case_id == currentSelectedRow).OrderBy(x => x.id).FirstOrDefault();

                if (query != null)
                {
                    quetionNumber = query.id;
                    loadData();

                    btnPrev.Enabled = false;
                    btnNext.Enabled = true;

                }
            }



        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            quetionNumber += 1;

            if (currentSelectedRow == -1)
            {
                Support.MSI("select data");
            }
            else
            {
                var query = db.cases_details.Where(x => x.case_id == currentSelectedRow).OrderByDescending(x => x.id).FirstOrDefault();

                if (quetionNumber == query.id)
                {
                    loadData();

                    btnNext.Enabled = false;
                    btnPrev.Enabled = true;


                }
            }

           

            loadData();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            quetionNumber -= 1;

            if (currentSelectedRow == -1)
            {
                Support.MSI("select data");
            }
            else
            {
                var query = db.cases_details.Where(x => x.case_id == currentSelectedRow).OrderBy(x => x.id).FirstOrDefault();

                if (quetionNumber == query.id)
                {
                    loadData();

                    btnNext.Enabled = true;
                    btnPrev.Enabled = false;


                }
            }

            loadData();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                Support.MSI("select data");
            }
            else
            {
                var query = db.cases_details.Where(x => x.case_id == currentSelectedRow).OrderByDescending(x => x.id).FirstOrDefault();

                if (query != null)
                {
                    quetionNumber = query.id;
                    loadData();

                    btnNext.Enabled = false;
                    btnPrev.Enabled = true;


                }
            }
        }

        private bool validation()
        {
            if (tbOptionA.Text == string.Empty || tbOptionB.Text == string.Empty ||
                tbOptionC.Text == string.Empty || tbOptionD.Text == string.Empty || 
                cboAnswer.Text == string.Empty)
            {
                Support.MSE("all field must be filled");
                return false;
            } 

            return true;
        }

        private void clearField()
        {
            tbOptionA.Text = tbOptionB.Text = tbOptionC.Text = tbOptionD.Text = tbText.Text = cboAnswer.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validation())
                {
                    if (mode == "update")
                    {
                        var query = db.cases_details.FirstOrDefault(x => x.id == quetionNumber);
                        {
                            if (query != null)
                            {
                                query.option_a = tbOptionA.Text;
                                query.option_b = tbOptionB.Text;
                                query.option_c = tbOptionC.Text;
                                query.option_d = tbOptionD.Text;
                                query.text = tbText.Text;
                                query.correct_answer = cboAnswer.SelectedValue.ToString();
                                db.SubmitChanges();
                                clearField();
                                Support.MSI("update data berhasil");
                                enableOptionAndButton(true);
                                tbSearch.Enabled = true;
                            }
                        }

                    }

                }

            } catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            currentSelectedRow = -1;
            enableOptionAndButton(false);
            mode = "";
        }
    }
}
