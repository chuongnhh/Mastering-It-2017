namespace Admin.AdminTeam
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvTeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeamLevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeamLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeamMembers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCboTeamLevel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.dgvTeamId,
            this.dgvTeamName,
            this.dgvTeamLevelId,
            this.dgvTeamLevel,
            this.dgvTeamMembers,
            this.dgvCboTeamLevel,
            this.Scores});
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(434, 224);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Cập nhật";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvTeamId
            // 
            this.dgvTeamId.DataPropertyName = "Id";
            this.dgvTeamId.HeaderText = "Mã đội";
            this.dgvTeamId.Name = "dgvTeamId";
            this.dgvTeamId.ReadOnly = true;
            // 
            // dgvTeamName
            // 
            this.dgvTeamName.DataPropertyName = "TeamName";
            this.dgvTeamName.HeaderText = "Tên đội";
            this.dgvTeamName.Name = "dgvTeamName";
            this.dgvTeamName.ReadOnly = true;
            // 
            // dgvTeamLevelId
            // 
            this.dgvTeamLevelId.DataPropertyName = "LevelId";
            this.dgvTeamLevelId.HeaderText = "LevelId";
            this.dgvTeamLevelId.Name = "dgvTeamLevelId";
            this.dgvTeamLevelId.ReadOnly = true;
            this.dgvTeamLevelId.Visible = false;
            // 
            // dgvTeamLevel
            // 
            this.dgvTeamLevel.DataPropertyName = "Level";
            this.dgvTeamLevel.HeaderText = "TeamLevel";
            this.dgvTeamLevel.Name = "dgvTeamLevel";
            this.dgvTeamLevel.ReadOnly = true;
            this.dgvTeamLevel.Visible = false;
            // 
            // dgvTeamMembers
            // 
            this.dgvTeamMembers.DataPropertyName = "Members";
            this.dgvTeamMembers.HeaderText = "Members";
            this.dgvTeamMembers.Name = "dgvTeamMembers";
            this.dgvTeamMembers.ReadOnly = true;
            this.dgvTeamMembers.Visible = false;
            // 
            // dgvCboTeamLevel
            // 
            this.dgvCboTeamLevel.DataPropertyName = "LevelId";
            this.dgvCboTeamLevel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgvCboTeamLevel.HeaderText = "Khối thi";
            this.dgvCboTeamLevel.Name = "dgvCboTeamLevel";
            this.dgvCboTeamLevel.ReadOnly = true;
            // 
            // Scores
            // 
            this.Scores.DataPropertyName = "Scores";
            this.Scores.HeaderText = "Scores";
            this.Scores.Name = "Scores";
            this.Scores.ReadOnly = true;
            this.Scores.Visible = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 278);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListForm";
            this.Text = "Danh sách đội thi";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeamLevelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeamLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeamMembers;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvCboTeamLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
    }
}