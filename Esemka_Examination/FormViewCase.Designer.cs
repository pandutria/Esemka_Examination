namespace Esemka_Examination
{
    partial class FormViewCase
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOptionA = new System.Windows.Forms.TextBox();
            this.tbOptionC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOptionD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOptionB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboAnswer = new System.Windows.Forms.ComboBox();
            this.btnFirstQuestion = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(48, 106);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(705, 150);
            this.dgvData.TabIndex = 51;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(585, 67);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(168, 22);
            this.tbSearch.TabIndex = 50;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 28);
            this.label3.TabIndex = 49;
            this.label3.Text = "Search by Creator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 46;
            this.label2.Text = "View Case";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(44, 260);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(128, 28);
            this.lblQuestion.TabIndex = 52;
            this.lblQuestion.Text = "Question 1/5";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(48, 299);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(705, 92);
            this.tbText.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "A.";
            // 
            // tbOptionA
            // 
            this.tbOptionA.Location = new System.Drawing.Point(80, 412);
            this.tbOptionA.Multiline = true;
            this.tbOptionA.Name = "tbOptionA";
            this.tbOptionA.Size = new System.Drawing.Size(287, 56);
            this.tbOptionA.TabIndex = 55;
            // 
            // tbOptionC
            // 
            this.tbOptionC.Location = new System.Drawing.Point(466, 412);
            this.tbOptionC.Multiline = true;
            this.tbOptionC.Name = "tbOptionC";
            this.tbOptionC.Size = new System.Drawing.Size(287, 56);
            this.tbOptionC.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 28);
            this.label5.TabIndex = 56;
            this.label5.Text = "C.";
            // 
            // tbOptionD
            // 
            this.tbOptionD.Location = new System.Drawing.Point(466, 488);
            this.tbOptionD.Multiline = true;
            this.tbOptionD.Name = "tbOptionD";
            this.tbOptionD.Size = new System.Drawing.Size(287, 56);
            this.tbOptionD.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 28);
            this.label6.TabIndex = 60;
            this.label6.Text = "D.";
            // 
            // tbOptionB
            // 
            this.tbOptionB.Location = new System.Drawing.Point(80, 488);
            this.tbOptionB.Multiline = true;
            this.tbOptionB.Name = "tbOptionB";
            this.tbOptionB.Size = new System.Drawing.Size(287, 56);
            this.tbOptionB.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 28);
            this.label7.TabIndex = 58;
            this.label7.Text = "B.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 28);
            this.label8.TabIndex = 62;
            this.label8.Text = "Answer";
            // 
            // cboAnswer
            // 
            this.cboAnswer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboAnswer.FormattingEnabled = true;
            this.cboAnswer.Location = new System.Drawing.Point(128, 564);
            this.cboAnswer.Name = "cboAnswer";
            this.cboAnswer.Size = new System.Drawing.Size(116, 24);
            this.cboAnswer.TabIndex = 63;
            // 
            // btnFirstQuestion
            // 
            this.btnFirstQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstQuestion.Location = new System.Drawing.Point(157, 607);
            this.btnFirstQuestion.Name = "btnFirstQuestion";
            this.btnFirstQuestion.Size = new System.Drawing.Size(105, 37);
            this.btnFirstQuestion.TabIndex = 64;
            this.btnFirstQuestion.Text = "<<";
            this.btnFirstQuestion.UseVisualStyleBackColor = true;
            this.btnFirstQuestion.Click += new System.EventHandler(this.btnFirstQuestion_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(283, 607);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(105, 37);
            this.btnPrev.TabIndex = 65;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(412, 607);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 37);
            this.btnNext.TabIndex = 66;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(539, 607);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(105, 37);
            this.btn.TabIndex = 67;
            this.btn.Text = ">>";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(220, 664);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 37);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(358, 664);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 37);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(497, 664);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormViewCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirstQuestion);
            this.Controls.Add(this.cboAnswer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOptionD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbOptionB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOptionC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOptionA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormViewCase";
            this.Text = "FormViewCase";
            this.Load += new System.EventHandler(this.FormViewCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOptionA;
        private System.Windows.Forms.TextBox tbOptionC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOptionD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOptionB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAnswer;
        private System.Windows.Forms.Button btnFirstQuestion;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}