namespace Admin.AdminGame
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
            this.dgvGameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGameTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGameLevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGameLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGameQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCboGameLevel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 13);
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
            this.dgvGameId,
            this.dgvGameName,
            this.dgvGameTime,
            this.dgvGameLevelId,
            this.dgvGameLevel,
            this.dgvGameQuestions,
            this.dgvCboGameLevel});
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(495, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dgvGameId
            // 
            this.dgvGameId.DataPropertyName = "Id";
            this.dgvGameId.HeaderText = "Mã trò chơi";
            this.dgvGameId.Name = "dgvGameId";
            this.dgvGameId.ReadOnly = true;
            // 
            // dgvGameName
            // 
            this.dgvGameName.DataPropertyName = "GameName";
            this.dgvGameName.HeaderText = "Tên trò chơi";
            this.dgvGameName.Name = "dgvGameName";
            this.dgvGameName.ReadOnly = true;
            // 
            // dgvGameTime
            // 
            this.dgvGameTime.DataPropertyName = "GameTime";
            this.dgvGameTime.HeaderText = "Thời gian";
            this.dgvGameTime.Name = "dgvGameTime";
            this.dgvGameTime.ReadOnly = true;
            // 
            // dgvGameLevelId
            // 
            this.dgvGameLevelId.DataPropertyName = "LevelId";
            this.dgvGameLevelId.HeaderText = "LevelId";
            this.dgvGameLevelId.Name = "dgvGameLevelId";
            this.dgvGameLevelId.ReadOnly = true;
            this.dgvGameLevelId.Visible = false;
            // 
            // dgvGameLevel
            // 
            this.dgvGameLevel.DataPropertyName = "Level";
            this.dgvGameLevel.HeaderText = "Level";
            this.dgvGameLevel.Name = "dgvGameLevel";
            this.dgvGameLevel.ReadOnly = true;
            this.dgvGameLevel.Visible = false;
            // 
            // dgvGameQuestions
            // 
            this.dgvGameQuestions.DataPropertyName = "Questions";
            this.dgvGameQuestions.HeaderText = "Questions";
            this.dgvGameQuestions.Name = "dgvGameQuestions";
            this.dgvGameQuestions.ReadOnly = true;
            this.dgvGameQuestions.Visible = false;
            // 
            // dgvCboGameLevel
            // 
            this.dgvCboGameLevel.DataPropertyName = "LevelId";
            this.dgvCboGameLevel.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgvCboGameLevel.HeaderText = "Khối thi";
            this.dgvCboGameLevel.Name = "dgvCboGameLevel";
            this.dgvCboGameLevel.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Cập nhật";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 317);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListForm";
            this.Text = "Danh sách trò chơi";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameLevelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameQuestions;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvCboGameLevel;
        private System.Windows.Forms.Button btnRefresh;
    }
}