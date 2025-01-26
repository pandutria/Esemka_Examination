namespace Esemka_Examination
{
    partial class FormSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbCase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbCaseId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            this.tbExaminer = new System.Windows.Forms.TextBox();
            this.dgvDataSchedule = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExaminerId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAllParticipant = new System.Windows.Forms.Button();
            this.btnDeleteSelectedParticipant = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbParticipantId = new System.Windows.Forms.TextBox();
            this.tbParticipant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDataParticipant = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataParticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 47;
            this.label2.Text = "Schedule";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbCase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tbCaseId);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.tbRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbRoomId);
            this.groupBox1.Controls.Add(this.tbExaminer);
            this.groupBox1.Controls.Add(this.dgvDataSchedule);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbExaminerId);
            this.groupBox1.Location = new System.Drawing.Point(33, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 467);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(272, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 41);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(136, 294);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(356, 22);
            this.dtpTime.TabIndex = 49;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Time";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(131, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 41);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCase
            // 
            this.tbCase.Location = new System.Drawing.Point(324, 258);
            this.tbCase.Name = "tbCase";
            this.tbCase.Size = new System.Drawing.Size(168, 22);
            this.tbCase.TabIndex = 46;
            this.tbCase.TextChanged += new System.EventHandler(this.tbCase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "Case";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(341, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 41);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbCaseId
            // 
            this.tbCaseId.Location = new System.Drawing.Point(136, 258);
            this.tbCaseId.Name = "tbCaseId";
            this.tbCaseId.Size = new System.Drawing.Size(168, 22);
            this.tbCaseId.TabIndex = 45;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(207, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 41);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(70, 339);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 41);
            this.btnInsert.TabIndex = 50;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(324, 222);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(168, 22);
            this.tbRoom.TabIndex = 43;
            this.tbRoom.TextChanged += new System.EventHandler(this.tbRoom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Room";
            // 
            // tbRoomId
            // 
            this.tbRoomId.Location = new System.Drawing.Point(136, 222);
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.Size = new System.Drawing.Size(168, 22);
            this.tbRoomId.TabIndex = 42;
            // 
            // tbExaminer
            // 
            this.tbExaminer.Location = new System.Drawing.Point(324, 184);
            this.tbExaminer.Name = "tbExaminer";
            this.tbExaminer.Size = new System.Drawing.Size(168, 22);
            this.tbExaminer.TabIndex = 40;
            this.tbExaminer.TextChanged += new System.EventHandler(this.tbExaminer_TextChanged);
            // 
            // dgvDataSchedule
            // 
            this.dgvDataSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSchedule.Location = new System.Drawing.Point(26, 33);
            this.dgvDataSchedule.Name = "dgvDataSchedule";
            this.dgvDataSchedule.RowHeadersWidth = 51;
            this.dgvDataSchedule.RowTemplate.Height = 24;
            this.dgvDataSchedule.Size = new System.Drawing.Size(466, 122);
            this.dgvDataSchedule.TabIndex = 39;
            this.dgvDataSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataSchedule_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Examiner";
            // 
            // tbExaminerId
            // 
            this.tbExaminerId.Location = new System.Drawing.Point(136, 184);
            this.tbExaminerId.Name = "tbExaminerId";
            this.tbExaminerId.Size = new System.Drawing.Size(168, 22);
            this.tbExaminerId.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAllParticipant);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedParticipant);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvDataParticipant);
            this.groupBox2.Location = new System.Drawing.Point(576, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 467);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Participant";
            // 
            // btnDeleteAllParticipant
            // 
            this.btnDeleteAllParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllParticipant.Location = new System.Drawing.Point(272, 322);
            this.btnDeleteAllParticipant.Name = "btnDeleteAllParticipant";
            this.btnDeleteAllParticipant.Size = new System.Drawing.Size(220, 41);
            this.btnDeleteAllParticipant.TabIndex = 57;
            this.btnDeleteAllParticipant.Text = "Delete All Participant";
            this.btnDeleteAllParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteAllParticipant.Click += new System.EventHandler(this.btnDeleteAllParticipant_Click);
            // 
            // btnDeleteSelectedParticipant
            // 
            this.btnDeleteSelectedParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedParticipant.Location = new System.Drawing.Point(27, 322);
            this.btnDeleteSelectedParticipant.Name = "btnDeleteSelectedParticipant";
            this.btnDeleteSelectedParticipant.Size = new System.Drawing.Size(239, 41);
            this.btnDeleteSelectedParticipant.TabIndex = 56;
            this.btnDeleteSelectedParticipant.Text = "Delete Selected Participant";
            this.btnDeleteSelectedParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedParticipant.Click += new System.EventHandler(this.btnDeleteSelectedParticipant_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.tbParticipantId);
            this.groupBox3.Controls.Add(this.tbParticipant);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(27, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 128);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Participant";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(335, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 41);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbParticipantId
            // 
            this.tbParticipantId.Location = new System.Drawing.Point(127, 32);
            this.tbParticipantId.Name = "tbParticipantId";
            this.tbParticipantId.Size = new System.Drawing.Size(112, 22);
            this.tbParticipantId.TabIndex = 38;
            // 
            // tbParticipant
            // 
            this.tbParticipant.Location = new System.Drawing.Point(245, 32);
            this.tbParticipant.Name = "tbParticipant";
            this.tbParticipant.Size = new System.Drawing.Size(198, 22);
            this.tbParticipant.TabIndex = 40;
            this.tbParticipant.TextChanged += new System.EventHandler(this.tbParticipant_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 28);
            this.label9.TabIndex = 37;
            this.label9.Text = "Participant";
            // 
            // dgvDataParticipant
            // 
            this.dgvDataParticipant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataParticipant.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataParticipant.Location = new System.Drawing.Point(26, 33);
            this.dgvDataParticipant.Name = "dgvDataParticipant";
            this.dgvDataParticipant.RowHeadersWidth = 51;
            this.dgvDataParticipant.RowTemplate.Height = 24;
            this.dgvDataParticipant.Size = new System.Drawing.Size(466, 122);
            this.dgvDataParticipant.TabIndex = 39;
            this.dgvDataParticipant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataParticipant_CellClick);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1136, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataParticipant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDataSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExaminerId;
        private System.Windows.Forms.TextBox tbExaminer;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCaseId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbParticipant;
        private System.Windows.Forms.DataGridView dgvDataParticipant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbParticipantId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteAllParticipant;
        private System.Windows.Forms.Button btnDeleteSelectedParticipant;
        private System.Windows.Forms.Button btnAdd;
    }
}