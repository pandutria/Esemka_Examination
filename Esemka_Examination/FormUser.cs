using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Examination
{
    public partial class FormUser : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int currentSeelctedRow = -1;
        string mode = "";
        public FormUser()
        {
            InitializeComponent();
        }

        private void loadCboFilter()
        {

            var all = new List<dynamic>();
            all.Add(new { id = 0, name = "All" });

            var query = db.roles.Select(x => new { id = x.id, name = x.name });
            all.AddRange(query);

            cboFilter.DataSource = all;
            cboFilter.ValueMember = "id";
            cboFilter.DisplayMember = "name";
        }

        private void loadCboRole()
        {
            cboRole.DataSource = db.roles;
            cboRole.ValueMember = "id";
            cboRole.DisplayMember = "name";
        }

        private void loadDgvData()
        {
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();

            if (cboFilter.Text == "All")
            {
                var query = db.users.Where(x => (x.name.Contains(tbSearch.Text)) && (x.deleted_at == null))
                .Select(x => new { id = x.id, role = x.role.name, x.username, x.password, x.name, x.email, x.phone, x.gender, x.address, x.created_at, x.deleted_at, x.role_id });

                dgvData.DataSource = query;
            } else
            {
                var query = db.users.Where(x => (x.name.Contains(tbSearch.Text)) && ( x.deleted_at == null) && (x.role_id.ToString() == cboFilter.SelectedValue.ToString()) )
                .Select(x => new { id = x.id, role = x.role.name, x.username, x.password, x.name, x.email, x.phone, x.gender, x.address, x.created_at, x.deleted_at, x.role_id });

                dgvData.DataSource = query;
            }

            dgvData.Columns["role_id"].Visible = false;
        }

        private void loadCboGender()
        {
            var list = new List<string>();
            list.Add("Male");
            list.Add("Female");

            cboGender.DataSource = list;
        }

        private void enableField(bool e)
        {
            tbId.Enabled = !e;
            cboRole.Enabled = !e;
            tbUsername.Enabled = !e;
            tbPassword.Enabled = !e;
            tbName.Enabled = !e;
            tbEmail.Enabled = !e;
            tbPhone.Enabled = !e;
            cboGender.Enabled = !e;
            tbAddress.Enabled = !e;
        }

        private void enableButton(bool e)
        {
            btnInsert.Enabled = e;
            btnUpdate.Enabled = e;
            btnDelete.Enabled = e;

            btnCancel.Enabled = !e;
            btnSave.Enabled = !e;
        }

        private void enableSearchAndFilter(bool e)
        {
            cboFilter.Enabled = e;
            tbSearch.Enabled = e;
        }

        private void enableFieldAndButton(bool e)
        {
            enableButton(e);
            enableField(e);
        }

        private void clearField()
        {
            tbId.Text  = tbUsername.Text = tbPassword.Text = tbName.Text = tbEmail.Text = tbPhone.Text = cboGender.Text = tbAddress.Text = string.Empty;
            cboRole.Text = string.Empty;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            loadCboGender();
            loadCboFilter();
            loadDgvData();
            loadCboRole();
            enableFieldAndButton(true);
            enableSearchAndFilter(true);

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Cells[0].Selected = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void cboFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSeelctedRow = e.RowIndex;
                //tbId.Text = dgvData.Rows[e.RowIndex].Cells["id"].Value.ToString();
                currentSeelctedRow = Convert.ToInt32( dgvData.Rows[e.RowIndex].Cells["id"].Value);
                cboRole.Text = dgvData.Rows[e.RowIndex].Cells["role"].Value.ToString();
                tbUsername.Text = dgvData.Rows[e.RowIndex].Cells["username"].Value.ToString();
                tbPassword.Text = dgvData.Rows[e.RowIndex].Cells["password"].Value.ToString();
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tbEmail.Text = dgvData.Rows[e.RowIndex].Cells["email"].Value.ToString();
                tbPhone.Text = dgvData.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                cboGender.Text = dgvData.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["address"].Value.ToString();
            }
        }

        private bool isValidEmail(string email)
        {
            var regex = @"^\S+@\S+\.\S+$";
            return Regex.IsMatch(email, regex);
        }

        private bool IsNumeric(string phone)
        {
            var regex = @"^\d+$"; 
            return Regex.IsMatch(phone, regex);
        }

        private string HashMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password); 
                byte[] hashBytes = md5.ComputeHash(inputBytes); 

                var sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); 
                }
                return sb.ToString();
            }
        }

        private bool validation()
        {
            if ( tbUsername.Text == string.Empty || tbPassword.Text == string.Empty || 
                tbName.Text == string.Empty || tbEmail.Text == string.Empty || tbPhone.Text == string.Empty ||
                tbAddress.Text == string.Empty || cboRole.Text == string.Empty || cboGender.Text == string.Empty) {

                Support.MSI("all input must be filled");
                return false;
            } 

            if (tbUsername.Text.Length < 3)
            {
                Support.MSI("Username must more than 3 characters");
                return false;
            }

            if (tbPassword.Text.Length < 5 || tbPassword.Text.Length > 12)
            {
                Support.MSI("Pssword must between 5 and 12 characters");
                return false;
            }

            if (!isValidEmail(tbEmail.Text))
            {
                Support.MSI("email must be email format");
                return false;
            }

            if (!IsNumeric(tbPhone.Text))
            {
                Support.MSI("phone must be phone format");
                return false;
            }

            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            clearField();
            enableFieldAndButton(false);
            enableSearchAndFilter(false);
            tbId.Enabled= false;
            mode = "insert";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentSeelctedRow == -1)
            {
                Support.MSW("click row");
            } else
            {
                enableFieldAndButton(false);
                enableSearchAndFilter(false);
                mode = "update";
                tbId.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentSeelctedRow == -1)
            {
                Support.MSW("click row");
            } else
            {
                enableButton(false);
                mode = "delete";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (mode == "insert")
                {
                    if (validation())
                    {
                        var user = new user();
                        user.role_id = Convert.ToInt32(cboRole.SelectedValue);
                        user.username = tbUsername.Text;
                        user.password = HashMD5(tbPassword.Text);
                        user.name = tbName.Text;
                        user.email = tbEmail.Text;
                        user.phone = tbPhone.Text;
                        user.address = tbAddress.Text;
                        user.gender = cboGender.SelectedValue.ToString();
                        user.created_at = DateTime.Now;
                        user.deleted_at = null;
                        db.users.InsertOnSubmit(user);
                        db.SubmitChanges();
                        loadDgvData();
                        Support.MSI("berhasil");
                        clearField();
                        enableFieldAndButton(true);
                    }
                    
                } 

                if (mode == "update")
                {
                    if (validation())
                    {
                        var queryUpdate = db.users.FirstOrDefault(x => x.id == currentSeelctedRow);

                        if (queryUpdate != null)
                        {
                            queryUpdate.role_id = Convert.ToInt32(cboRole.SelectedValue);
                            queryUpdate.username = tbUsername.Text;
                            queryUpdate.password = HashMD5(tbPassword.Text);
                            queryUpdate.name = tbName.Text;
                            queryUpdate.email = tbEmail.Text;
                            queryUpdate.phone = tbPhone.Text;
                            queryUpdate.address = tbAddress.Text;
                            queryUpdate.gender = cboGender.SelectedValue.ToString();
                            queryUpdate.created_at = DateTime.Now;
                            queryUpdate.deleted_at = null;

                            Support.MSI("berhasil");
                            clearField();
                            db.SubmitChanges();
                            loadDgvData();
                            enableFieldAndButton(true);
                        }
                    }
                    
                }

                if (mode == "delete")
                {
                    var msg = MessageBox.Show("confirmation", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msg == DialogResult.Yes)
                    {
                        var queryDelete = db.users.FirstOrDefault(x => x.id == currentSeelctedRow);

                        if (queryDelete != null)
                        {
                            queryDelete.deleted_at = DateTime.Now;
                            db.SubmitChanges();
                            loadDgvData();
                            clearField();
                            enableFieldAndButton(true);
                        }
                    } else
                    {
                        mode = "";
                    }
                    
                }

            } catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = "";
            clearField();
            enableFieldAndButton(true);
            enableSearchAndFilter(true);
        }
    }
}
