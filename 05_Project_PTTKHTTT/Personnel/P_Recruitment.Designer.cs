namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_Recruitment
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
            btn_detail = new Button();
            btn_back = new Button();
            lb_Info = new Label();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            btn_add = new Button();
            dtGrid_recruitmentList = new DataGridView();
            tb_compName = new TextBox();
            lb_nameComp = new Label();
            btn_Update = new Button();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_recruitmentList).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(btn_Update);
            pn_parents.Controls.Add(btn_detail);
            pn_parents.Controls.Add(btn_back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Controls.Add(ptn_refresh);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(btn_add);
            pn_parents.Controls.Add(dtGrid_recruitmentList);
            pn_parents.Controls.Add(tb_compName);
            pn_parents.Controls.Add(lb_nameComp);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 2;
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.White;
            btn_detail.BackgroundImage = Properties.Resources.button_round21;
            btn_detail.FlatAppearance.BorderSize = 0;
            btn_detail.FlatStyle = FlatStyle.Flat;
            btn_detail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_detail.ForeColor = SystemColors.Window;
            btn_detail.Location = new Point(508, 376);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(91, 38);
            btn_detail.TabIndex = 122;
            btn_detail.Text = "Chi tiết";
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += btn_detail_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.BackgroundImage = Properties.Resources.button_round21;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_back.ForeColor = SystemColors.Window;
            btn_back.Location = new Point(775, 376);
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
            lb_Info.Location = new Point(325, 10);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(237, 31);
            lb_Info.TabIndex = 120;
            lb_Info.Text = "Thông tin đăng tuyển";
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(708, 52);
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
            btn_search.Location = new Point(775, 52);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 118;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.BackgroundImage = Properties.Resources.button_round21;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_add.ForeColor = SystemColors.Window;
            btn_add.Location = new Point(643, 376);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(91, 38);
            btn_add.TabIndex = 117;
            btn_add.Text = "Tạo mới";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dtGrid_recruitmentList
            // 
            dtGrid_recruitmentList.BackgroundColor = SystemColors.Control;
            dtGrid_recruitmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_recruitmentList.Location = new Point(32, 100);
            dtGrid_recruitmentList.Name = "dtGrid_recruitmentList";
            dtGrid_recruitmentList.RowHeadersWidth = 51;
            dtGrid_recruitmentList.Size = new Size(834, 267);
            dtGrid_recruitmentList.TabIndex = 116;
            dtGrid_recruitmentList.CellContentClick += dtGrid_recruitmentList_CellContentClick;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(198, 54);
            tb_compName.Name = "tb_compName";
            tb_compName.Size = new Size(494, 34);
            tb_compName.TabIndex = 115;
            tb_compName.TabStop = false;
            // 
            // lb_nameComp
            // 
            lb_nameComp.AutoSize = true;
            lb_nameComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameComp.Location = new Point(32, 57);
            lb_nameComp.Name = "lb_nameComp";
            lb_nameComp.Size = new Size(168, 28);
            lb_nameComp.TabIndex = 114;
            lb_nameComp.Text = "Tên doanh nghiệp";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.BackgroundImage = Properties.Resources.button_round21;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Update.ForeColor = SystemColors.Window;
            btn_Update.Location = new Point(368, 376);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(91, 38);
            btn_Update.TabIndex = 123;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // P_Recruitment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_Recruitment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P_Recruitment";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_recruitmentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button btn_back;
        private Label lb_Info;
        private PictureBox ptn_refresh;
        private Button btn_search;
        private Button btn_add;
        private DataGridView dtGrid_recruitmentList;
        private TextBox tb_compName;
        private Label lb_nameComp;
        private Button btn_detail;
        private Button btn_Update;
    }
}