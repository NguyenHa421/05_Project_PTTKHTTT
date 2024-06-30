namespace _05_Project_PTTKHTTT.Candidate
{
    partial class C_AppliedCV
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
            pn_parents = new Panel();
            tb_job = new TextBox();
            lb_nameJob = new Label();
            btn_back = new Button();
            lb_Info = new Label();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            dtGrid_jobList = new DataGridView();
            tb_compName = new TextBox();
            lb_nameComp = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_jobList).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(tb_job);
            pn_parents.Controls.Add(lb_nameJob);
            pn_parents.Controls.Add(btn_back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Controls.Add(ptn_refresh);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(dtGrid_jobList);
            pn_parents.Controls.Add(tb_compName);
            pn_parents.Controls.Add(lb_nameComp);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 2;
            // 
            // tb_job
            // 
            tb_job.Font = new Font("Segoe UI", 10.8F);
            tb_job.Location = new Point(529, 59);
            tb_job.Name = "tb_job";
            tb_job.Size = new Size(207, 31);
            tb_job.TabIndex = 123;
            tb_job.TabStop = false;
            // 
            // lb_nameJob
            // 
            lb_nameJob.AutoSize = true;
            lb_nameJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameJob.Location = new Point(438, 61);
            lb_nameJob.Name = "lb_nameJob";
            lb_nameJob.Size = new Size(85, 28);
            lb_nameJob.TabIndex = 122;
            lb_nameJob.Text = "Tên vị trí";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.BackgroundImage = Properties.Resources.button_round21;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_back.ForeColor = SystemColors.Window;
            btn_back.Location = new Point(798, 376);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(91, 38);
            btn_back.TabIndex = 121;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(323, 10);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(256, 31);
            lb_Info.TabIndex = 120;
            lb_Info.Text = "Thông tin hồ sơ đã nộp";
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(742, 55);
            ptn_refresh.Name = "ptn_refresh";
            ptn_refresh.Size = new Size(49, 39);
            ptn_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            ptn_refresh.TabIndex = 119;
            ptn_refresh.TabStop = false;
            ptn_refresh.Click += ptn_refresh_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round22;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(798, 55);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 118;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // dtGrid_jobList
            // 
            dtGrid_jobList.BackgroundColor = SystemColors.Control;
            dtGrid_jobList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_jobList.Location = new Point(5, 100);
            dtGrid_jobList.Name = "dtGrid_jobList";
            dtGrid_jobList.RowHeadersWidth = 51;
            dtGrid_jobList.Size = new Size(886, 267);
            dtGrid_jobList.TabIndex = 116;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 10.8F);
            tb_compName.Location = new Point(168, 59);
            tb_compName.Name = "tb_compName";
            tb_compName.Size = new Size(256, 31);
            tb_compName.TabIndex = 115;
            tb_compName.TabStop = false;
            // 
            // lb_nameComp
            // 
            lb_nameComp.AutoSize = true;
            lb_nameComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameComp.Location = new Point(2, 61);
            lb_nameComp.Name = "lb_nameComp";
            lb_nameComp.Size = new Size(168, 28);
            lb_nameComp.TabIndex = 114;
            lb_nameComp.Text = "Tên doanh nghiệp";
            // 
            // C_AppliedCV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "C_AppliedCV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "C_AppliedCV";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_jobList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private TextBox tb_job;
        private Label lb_nameJob;
        private Button btn_back;
        private Label lb_Info;
        private PictureBox ptn_refresh;
        private Button btn_search;
        private DataGridView dtGrid_jobList;
        private TextBox tb_compName;
        private Label lb_nameComp;
    }
}