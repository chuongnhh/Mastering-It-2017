namespace Admin.AdminGame
{
    partial class ListQuestion
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
            this.dgvQuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuestionLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuestionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.dgvQuestionId,
            this.dgvQuestionLabel,
            this.dgvQuestionName,
            this.dgvAnswers,
            this.dgvGameId,
            this.dgvGame});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 249);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dgvQuestionId
            // 
            this.dgvQuestionId.DataPropertyName = "Id";
            this.dgvQuestionId.HeaderText = "Mã câu hỏi";
            this.dgvQuestionId.Name = "dgvQuestionId";
            this.dgvQuestionId.ReadOnly = true;
            // 
            // dgvQuestionLabel
            // 
            this.dgvQuestionLabel.DataPropertyName = "QuestionLabel";
            this.dgvQuestionLabel.HeaderText = "Nhãn câu hỏi";
            this.dgvQuestionLabel.Name = "dgvQuestionLabel";
            this.dgvQuestionLabel.ReadOnly = true;
            // 
            // dgvQuestionName
            // 
            this.dgvQuestionName.DataPropertyName = "QuestionName";
            this.dgvQuestionName.HeaderText = "Nội dung câu hỏi";
            this.dgvQuestionName.Name = "dgvQuestionName";
            this.dgvQuestionName.ReadOnly = true;
            // 
            // dgvAnswers
            // 
            this.dgvAnswers.DataPropertyName = "Answers";
            this.dgvAnswers.HeaderText = "Answer";
            this.dgvAnswers.Name = "dgvAnswers";
            this.dgvAnswers.ReadOnly = true;
            this.dgvAnswers.Visible = false;
            // 
            // dgvGameId
            // 
            this.dgvGameId.DataPropertyName = "GameId";
            this.dgvGameId.HeaderText = "GameId";
            this.dgvGameId.Name = "dgvGameId";
            this.dgvGameId.ReadOnly = true;
            this.dgvGameId.Visible = false;
            // 
            // dgvGame
            // 
            this.dgvGame.DataPropertyName = "Game";
            this.dgvGame.HeaderText = "Game";
            this.dgvGame.Name = "dgvGame";
            this.dgvGame.ReadOnly = true;
            this.dgvGame.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(255, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Cập nhật";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 17);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ListQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 307);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "ListQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách câu hỏi";
            this.Load += new System.EventHandler(this.ListQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGame;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}