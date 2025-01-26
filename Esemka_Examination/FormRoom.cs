using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Esemka_Examination
{
    public partial class FormRoom : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int currentSelectedRow = -1;
        string mode = "";
        public FormRoom()
        {
            InitializeComponent();
        }

        private void enableField(bool e)
        {
            tbId.Enabled = !e;
            tbCode.Enabled = !e;
            tbCapacity.Enabled = !e;
        }

        private void enableButton(bool e)
        {
            btnInsert.Enabled = e;
            btnUpdate.Enabled = e;
            btnDelete.Enabled = e;

            btnCancel.Enabled = !e;
            btnSave.Enabled = !e;
        }

        private void enableFieldAndButton(bool e)
        {
            enableButton(e);
            enableField(e);
        }

        private bool validation()
        {
            if (tbCode.Text == string.Empty || tbCapacity.Text == string.Empty)
            {
                Support.MSI("all input must be filled");
                return false;
            }

            if (tbCapacity.Text.Length <= 0)
            {
                Support.MSI("Must be numeric greater than 0");
            }

            return true;
        }

        private void clearField()
        {
            tbCapacity.Text = tbId.Text = tbCode.Text = string.Empty;
        }

        private void loadDgvData()  
        {
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();

            var query = db.rooms.Where(x => (x.code.Contains(tbSearch.Text)) && (x.deleted_at == null))
                .Select(x => new { id = x.id, x.code, x.capacity, x.created_at, x.deleted_at, roomId = x.id });

            dgvData.DataSource = query;

            dgvData.Columns["roomId"].Visible = false;
        }
        private void FormRoom_Load(object sender, EventArgs e)
        {
            loadDgvData();
            enableFieldAndButton(true);

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Cells[0].Selected = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadDgvData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentSelectedRow = e.RowIndex;
                currentSelectedRow = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["roomId"].Value);
                tbId.Text = dgvData.Rows[e.RowIndex].Cells["id"].Value.ToString();
                tbCapacity.Text = dgvData.Rows[e.RowIndex].Cells["capacity"].Value.ToString();
                tbCode.Text = dgvData.Rows[e.RowIndex].Cells["code"].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            clearField();
            enableFieldAndButton(false);
            tbId.Enabled = false;
            tbSearch.Enabled = false;
            mode = "insert";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                Support.MSW("click row");
            }
            else
            {
                enableFieldAndButton(false);
                tbId.Enabled = false;
                tbSearch.Enabled = false;
                mode = "update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentSelectedRow == -1)
            {
                Support.MSW("click row");
            }
            else
            {
                enableFieldAndButton(false);
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
                        var rooms = new room();
                        rooms.capacity = Convert.ToInt32( tbCapacity.Text);
                        rooms.code = tbCode.Text;
                        rooms.created_at = DateTime.Now;
                        db.rooms.InsertOnSubmit(rooms);
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
                        var queryUpdate = db.rooms.FirstOrDefault(x => x.id == currentSelectedRow);

                        if (queryUpdate != null)
                        {
                            queryUpdate.code = tbCode.Text;
                            queryUpdate.capacity = Convert.ToInt32(tbCapacity.Text);

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
                        var queryDelete = db.rooms.FirstOrDefault(x => x.id == currentSelectedRow);

                        if (queryDelete != null)
                        {
                            queryDelete.deleted_at = DateTime.Now;
                            db.SubmitChanges();
                            loadDgvData();
                            clearField();
                            enableFieldAndButton(true);
                        }
                    }
                    else
                    {
                        mode = "";
                    }

                }

            }
            catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = "";
            clearField();
            enableFieldAndButton(true);
            tbSearch.Enabled = true;
            tbId.Enabled = true;
        }
    }
}
