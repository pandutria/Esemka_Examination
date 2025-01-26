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
    public partial class FormNewQuestion : Form
    {
        public string text;
        public string option_a;
        public string option_b;
        public string option_c;
        public string option_d;
        public string correct_answer;
        public FormNewQuestion()
        {
            InitializeComponent(); 
        }

        private void loadCbAnswer()
        {
            var answer = new List<string>();
            answer.Add("A");
            answer.Add("B");
            answer.Add("C");
            answer.Add("D");

            cboAnswer.DataSource = answer;
        }

        private void FormNewQuestion_Load(object sender, EventArgs e)
        {
            loadCbAnswer();

            tbText.Text = "text";
            tbOptionA.Text = "option a";
            tbOptionB.Text = "option b";
            tbOptionC.Text = "option c";
            tbOptionD.Text = "option d";
            

           
        }

        private bool validation()
        {
            if (tbText.Text == string.Empty || tbOptionA.Text== string.Empty ||
                tbOptionB.Text == string.Empty || tbOptionC.Text == string.Empty
                || tbOptionD.Text == string.Empty || cboAnswer.SelectedValue == null)
            {
                Support.MSI("all field must be filled");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                
                text = tbText.Text;
                option_a = tbOptionA.Text;
                option_b = tbOptionB.Text;
                option_c = tbOptionC.Text;
                option_d = tbOptionD.Text;
                correct_answer = cboAnswer.SelectedValue.ToString();

                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
