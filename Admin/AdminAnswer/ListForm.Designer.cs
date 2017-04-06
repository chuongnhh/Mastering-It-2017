namespace Admin.AdminAnswer
{
    partial class ListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvAnswerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnswerLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnswerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsTrue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvQuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAnswerId,
            this.dgvAnswerLabel,
            this.dgvAnswerName,
            this.dgvIsTrue,
            this.dgvQuestionId,
            this.dgvQuestion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(255, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Cập nhật";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvAnswerId
            // 
            this.dgvAnswerId.DataPropertyName = "Id";
            this.dgvAnswerId.HeaderText = "Mã đáp án";
            this.dgvAnswerId.Name = "dgvAnswerId";
            this.dgvAnswerId.ReadOnly = true;
            // 
            // dgvAnswerLabel
            // 
            this.dgvAnswerLabel.DataPropertyName = "AnswerLabel";
            this.dgvAnswerLabel.HeaderText = "Nhãn đáp án";
            this.dgvAnswerLabel.Name = "dgvAnswerLabel";
            this.dgvAnswerLabel.ReadOnly = true;
            // 
            // dgvAnswerName
            // 
            this.dgvAnswerName.DataPropertyName = "AnswerName";
            this.dgvAnswerName.HeaderText = "Đáp án";
            this.dgvAnswerName.Name = "dgvAnswerName";
            this.dgvAnswerName.ReadOnly = true;
            // 
            // dgvIsTrue
            // 
            this.dgvIsTrue.DataPropertyName = "IsTrue";
            this.dgvIsTrue.HeaderText = "Là đúng";
            this.dgvIsTrue.Name = "dgvIsTrue";
            this.dgvIsTrue.ReadOnly = true;
            this.dgvIsTrue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsTrue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvQuestionId
            // 
            this.dgvQuestionId.DataPropertyName = "QuestionId";
            this.dgvQuestionId.HeaderText = "Mã câu hỏi";
            this.dgvQuestionId.Name = "dgvQuestionId";
            this.dgvQuestionId.ReadOnly = true;
            this.dgvQuestionId.Visible = false;
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.DataPropertyName = "Question";
            this.dgvQuestion.HeaderText = "Question";
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.ReadOnly = true;
            this.dgvQuestion.Visible = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đáp án";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnswerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnswerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnswerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvIsTrue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestion;
    }
}