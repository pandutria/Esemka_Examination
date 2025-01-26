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
    public partial class FormSchedule : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int selectedScheduleId = -1;
        int selectedParticipantId = -1;

        string mode = "";

        public FormSchedule()
        {
            InitializeComponent();
        }

        private void loadDgvDataSchedule()
        {
            dgvDataSchedule.Rows.Clear();

            var query = db.schedules.Where(x => x.deleted_at == null)
                .Select(x => new { x.id, examiner = x.user.name, room = x.room.code, cases = x.@case.code, x.time, x.created_at, x.deleted_at });
            dgvDataSchedule.DataSource = query;

        }

        private void loadDgvDataParticipant()
        {
            dgvDataParticipant.Columns.Clear();
            dgvDataParticipant.Rows.Clear();

            var query = db.schedules_participants.Where(x => x.schedule_id == selectedScheduleId && x.deleted_at == null)
                .Select(x => new { schedule_id = x.id, x.participant_id, name = x.user.name });

            dgvDataParticipant.DataSource = query;

        }

        private void clearField()
        {
            tbCase.Text = tbCaseId.Text = tbExaminer.Text = tbExaminerId.Text = tbRoom.Text = tbRoomId.Text = tbParticipant.Text = tbParticipantId.Text = string.Empty;
            dtpTime.Value = DateTime.Now;
        }

        private void enableFieldSchedule(bool e)
        {
            
            tbExaminer.Enabled = !e;
            tbRoom.Enabled = !e;
            tbCase.Enabled = !e;
            dtpTime.Enabled = !e;

        }

        private void enableButtonSchedule(bool e)
        {
            btnInsert.Enabled = e;
            btnUpdate.Enabled = e;
            btnDelete.Enabled = e;

            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;
        }

        private void enableFieldScheduleAndButtonSchedule(bool e)
        {
            enableFieldSchedule(e);
            enableButtonSchedule(e);
        }
        private void enableFieldParticipant(bool e)
        {

            tbParticipant.Enabled = !e;
        }

        private void enableButtonParticipant(bool e)
        {
            btnAdd.Enabled = !e;
            btnDeleteAllParticipant.Enabled = !e;
            btnDeleteSelectedParticipant.Enabled = !e;
        }

        private void enableFieldPartcipantAndButtonParticipant(bool e)
        {
            enableFieldParticipant(e);
            enableButtonParticipant(e);
        }

        private void enableFieldAndButton(bool e)
        {
            enableFieldPartcipantAndButtonParticipant(e);
            enableFieldScheduleAndButtonSchedule(e);
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            tbCaseId.Enabled = false;
            tbExaminerId.Enabled = false;
            tbRoomId.Enabled = false;
            tbParticipantId.Enabled = false;

            sugestionExaminer();
            sugestionRoom();
            sugestionCase();
            sugestionParticipant();

            loadDgvDataSchedule();
            loadDgvDataParticipant();
            enableFieldAndButton(true);

            foreach (DataGridViewRow row in dgvDataSchedule.Rows)
            {
                if (row.IsNewRow) continue;

                row.Cells[0].Selected = true;
            }


            foreach (DataGridViewRow row in dgvDataParticipant.Rows)
            {
                if (row.IsNewRow) continue;

                row.Cells[0].Selected = true;
            }
        }

        private void dgvDataSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedScheduleId = e.RowIndex;
                selectedScheduleId = Convert.ToInt32(dgvDataSchedule.Rows[e.RowIndex].Cells["id"].Value);
                tbExaminer.Text = dgvDataSchedule.Rows[e.RowIndex].Cells["examiner"].Value.ToString();
                tbRoom.Text = dgvDataSchedule.Rows[e.RowIndex].Cells["room"].Value.ToString();
                tbCase.Text = dgvDataSchedule.Rows[e.RowIndex].Cells["cases"].Value.ToString();
                dtpTime.Value = Convert.ToDateTime( dgvDataSchedule.Rows[e.RowIndex].Cells["time"].Value);
                loadDgvDataParticipant();
                enableFieldPartcipantAndButtonParticipant(false);

            }
        }

        //private bool validExaminerSchedule()
        //{
        //    var query = db.schedules.FirstOrDefault(x => x.examiner_id.ToString() == tbExaminerId.Text);

        //    if (query.time == dtpTime.Value)
        //    {
        //        Support.MSI("Examiner must be has no other schedule that intersect with this schedule");
        //        return false;
        //    }

        //    return true;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (mode == "delete")
                {
                    var dialog = MessageBox.Show("are you sure you want delete this data?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        var query = db.schedules.FirstOrDefault(x => x.id == selectedScheduleId);
                        if (query != null)
                        {
                            query.deleted_at = DateTime.Now;
                            db.SubmitChanges();
                            loadDgvDataSchedule();
                            enableFieldAndButton(true);
                            Support.MSI("delete data schedule berhasil");
                            clearField();

                        }
                    }

                }

                if (mode == "insert")
                {

                    if (validation())
                    {
                        var sc = new schedule();
                        sc.examiner_id = Convert.ToInt32(tbExaminerId.Text);
                        sc.room_id = Convert.ToInt32(tbRoomId.Text);
                        sc.case_id = Convert.ToInt32(tbCaseId.Text);
                        sc.time = dtpTime.Value;
                        sc.created_at = DateTime.Now;
                        sc.type_id = 1;
                        db.schedules.InsertOnSubmit(sc);
                        db.SubmitChanges();
                        loadDgvDataSchedule();
                        enableFieldAndButton(true);
                        Support.MSI("insert data schedule berhasil");
                        clearField();
                    }
                }

                if (mode == "update")
                {
                    if (validation())
                    {
                        var query = db.schedules.FirstOrDefault(x => x.id == selectedScheduleId);

                        query.examiner_id = Convert.ToInt32( tbExaminerId.Text);
                        query.room_id = Convert.ToInt32(tbRoomId.Text) ;
                        query.case_id = Convert.ToInt32(tbCaseId.Text);
                        query.time = dtpTime.Value;
                        db.SubmitChanges();
                        loadDgvDataSchedule();
                        enableFieldAndButton(true);
                        Support.MSI("update data schedule berhasil");
                        clearField();
                    }
                }
                

            }
            catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void sugestionExaminer()
        {
            var query = db.users.Where(x => x.role.name == "Examiner" && x.deleted_at == null)
                .Select(x => x.name );
            
            tbExaminer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbExaminer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbExaminer.AutoCompleteCustomSource.Clear();
            tbExaminer.AutoCompleteCustomSource.AddRange(query.ToArray());
        }

        private void sugestionRoom()
        {
            var query = db.rooms.Where(x =>x.deleted_at == null)
                .Select(x => x.code);

            tbRoom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbRoom.AutoCompleteCustomSource.Clear();
            tbRoom.AutoCompleteCustomSource.AddRange(query.ToArray());
        }

        private void sugestionCase()
        {
            var query = db.cases.Where(x => x.deleted_at == null)
                .Select(x => x.code);

            tbCase.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbCase.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbCase.AutoCompleteCustomSource.Clear();
            tbCase.AutoCompleteCustomSource.AddRange(query.ToArray());
        }

        private void sugestionParticipant()
        {
            var query = db.users.Where(x => x.deleted_at == null && x.role.name == "Participant")
                .Select(x => x.name);

            tbParticipant.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbParticipant.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbParticipant.AutoCompleteCustomSource.Clear();
            tbParticipant.AutoCompleteCustomSource.AddRange(query.ToArray());
        }


        private bool validation()
        {
            if (tbExaminer.Text == string.Empty || tbRoom.Text == string.Empty ||
                tbCase.Text == string.Empty)
            {
                Support.MSI("all field must be filled");
                return false;
            }

            if (dtpTime.Value <= DateTime.Now)
            {
                Support.MSI("time Must be greater than current time");
                return false;
            }

            return true;
        }

        private void tbExaminer_TextChanged(object sender, EventArgs e)
        {
            //var query = db.users.Where(x => x.role.name == "Examiner");

            //validExaminerSchedule();

            var query = db.users.FirstOrDefault( x => x.name == tbExaminer.Text );

            if (query != null)
            {
                tbExaminerId.Text = query.id.ToString();
                
            } 

        }

        private void tbRoom_TextChanged(object sender, EventArgs e)
        {
            var query = db.rooms.FirstOrDefault(x => x.code == tbRoom.Text );

            if (query != null)
            {
                tbRoomId.Text = query.id.ToString();
            } 
        }

        private void tbCase_TextChanged(object sender, EventArgs e)
        {
            var query = db.cases.FirstOrDefault(x => x.code == tbCase.Text );

            if (query != null)
            {
                tbCaseId.Text = query.id.ToString();
            } 
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tbParticipant_TextChanged(object sender, EventArgs e)
        {
            var query = db.users.FirstOrDefault(x => x.name == tbParticipant.Text);

            if (query != null)
            {
                tbParticipantId.Text = query.id.ToString();
            }
        }

        private void dgvDataParticipant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedParticipantId = e.RowIndex;
                selectedParticipantId = Convert.ToInt32( dgvDataParticipant.Rows[e.RowIndex].Cells["schedule_id"].Value); 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbParticipant.Text == string.Empty)
                {
                    Support.MSI("participant must be filled");
                } else
                {
                    var sp = new schedules_participant();
                    sp.schedule_id = selectedScheduleId;
                    sp.participant_id = Convert.ToInt32(tbParticipantId.Text);
                    sp.created_at = DateTime.Now;
                    db.schedules_participants.InsertOnSubmit(sp);
                    db.SubmitChanges();
                    loadDgvDataParticipant();
                    Support.MSI("berhasil add participant");
                }

            } catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void btnDeleteSelectedParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                var query = db.schedules_participants.FirstOrDefault(x => x.id == selectedParticipantId);

                if (query != null)
                {
                    query.deleted_at = DateTime.Now;
                    db.SubmitChanges();
                    Support.MSI("berhasil delete selected participant");
                    loadDgvDataParticipant();
                }

            } catch (Exception ex)
            {
                Support.MSE(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            enableFieldAndButton(false);
            clearField();
            mode = "insert";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedScheduleId == -1)
            {
                Support.MSI("select data first");
            }
            else
            {
                enableFieldAndButton(false);
                mode = "update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedScheduleId == -1)
            {
                Support.MSI("select data first");
            }
            else
            {
                enableButtonSchedule(false);
                mode = "delete";
            }
        }

        private void btnDeleteAllParticipant_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDataParticipant.Rows)
            {
                if (row.IsNewRow) continue;

                var query = db.schedules_participants.Where(x => x.id == Convert.ToInt32( row.Cells["schedule_id"].Value));

                foreach (var participant in query)
                {
                    participant.deleted_at = DateTime.Now;
                }
            }

            db.SubmitChanges();
            loadDgvDataParticipant();
            Support.MSI("berhasil delete selected participant");

        }
    }
}
