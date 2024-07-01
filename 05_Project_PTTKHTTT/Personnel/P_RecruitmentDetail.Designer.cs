namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_RecruitmentDetail
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
            btn_back = new Button();
            lb_Info = new Label();
            dtGrid_vacancyList = new DataGridView();
            lb_criteria = new Label();
            lb_date = new Label();
            lb_formpost = new Label();
            lb_name = new Label();
            lb_state = new Label();
            tb_compName = new TextBox();
            tb_date = new TextBox();
            tb_state = new TextBox();
            tb_formpost = new TextBox();
            tb_criteria = new TextBox();
            lb_vacancy = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGrid_vacancyList).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.BackgroundImage = Properties.Resources.button_round21;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_back.ForeColor = SystemColors.Window;
            btn_back.Location = new Point(773, 376);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(91, 38);
            btn_back.TabIndex = 126;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(283, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(311, 31);
            lb_Info.TabIndex = 125;
            lb_Info.Text = "Chi tiết thông tin đăng tuyển";
            // 
            // dtGrid_vacancyList
            // 
            dtGrid_vacancyList.BackgroundColor = SystemColors.Control;
            dtGrid_vacancyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_vacancyList.Location = new Point(578, 194);
            dtGrid_vacancyList.Name = "dtGrid_vacancyList";
            dtGrid_vacancyList.RowHeadersWidth = 51;
            dtGrid_vacancyList.Size = new Size(286, 173);
            dtGrid_vacancyList.TabIndex = 124;
            // 
            // lb_criteria
            // 
            lb_criteria.AutoSize = true;
            lb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_criteria.Location = new Point(29, 215);
            lb_criteria.Name = "lb_criteria";
            lb_criteria.Size = new Size(78, 28);
            lb_criteria.TabIndex = 336;
            lb_criteria.Text = "Tiêu chí";
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_date.Location = new Point(29, 109);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(109, 28);
            lb_date.TabIndex = 332;
            lb_date.Text = "Ngày đăng";
            // 
            // lb_formpost
            // 
            lb_formpost.AutoSize = true;
            lb_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_formpost.Location = new Point(29, 163);
            lb_formpost.Name = "lb_formpost";
            lb_formpost.Size = new Size(147, 28);
            lb_formpost.TabIndex = 331;
            lb_formpost.Text = "Hình thức đăng";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(29, 56);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(136, 28);
            lb_name.TabIndex = 330;
            lb_name.Text = "Doanh nghiệp";
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_state.Location = new Point(461, 106);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(98, 28);
            lb_state.TabIndex = 329;
            lb_state.Text = "Trạng thái";
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(182, 53);
            tb_compName.Name = "tb_compName";
            tb_compName.ReadOnly = true;
            tb_compName.Size = new Size(682, 34);
            tb_compName.TabIndex = 338;
            tb_compName.TabStop = false;
            // 
            // tb_date
            // 
            tb_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_date.Location = new Point(182, 106);
            tb_date.Name = "tb_date";
            tb_date.ReadOnly = true;
            tb_date.Size = new Size(252, 34);
            tb_date.TabIndex = 339;
            tb_date.TabStop = false;
            // 
            // tb_state
            // 
            tb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_state.Location = new Point(578, 106);
            tb_state.Name = "tb_state";
            tb_state.ReadOnly = true;
            tb_state.Size = new Size(286, 34);
            tb_state.TabIndex = 340;
            tb_state.TabStop = false;
            // 
            // tb_formpost
            // 
            tb_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_formpost.Location = new Point(182, 160);
            tb_formpost.Name = "tb_formpost";
            tb_formpost.ReadOnly = true;
            tb_formpost.Size = new Size(328, 34);
            tb_formpost.TabIndex = 341;
            tb_formpost.TabStop = false;
            // 
            // tb_criteria
            // 
            tb_criteria.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_criteria.Location = new Point(182, 215);
            tb_criteria.Multiline = true;
            tb_criteria.Name = "tb_criteria";
            tb_criteria.ReadOnly = true;
            tb_criteria.Size = new Size(328, 152);
            tb_criteria.TabIndex = 342;
            tb_criteria.TabStop = false;
            // 
            // lb_vacancy
            // 
            lb_vacancy.AutoSize = true;
            lb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vacancy.Location = new Point(578, 157);
            lb_vacancy.Name = "lb_vacancy";
            lb_vacancy.Size = new Size(265, 28);
            lb_vacancy.TabIndex = 343;
            lb_vacancy.Text = "Vị trí tuyển dụng và số lượng";
            // 
            // P_RecruitmentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(lb_vacancy);
            Controls.Add(tb_criteria);
            Controls.Add(tb_formpost);
            Controls.Add(tb_state);
            Controls.Add(tb_date);
            Controls.Add(tb_compName);
            Controls.Add(lb_criteria);
            Controls.Add(lb_date);
            Controls.Add(lb_formpost);
            Controls.Add(lb_name);
            Controls.Add(lb_state);
            Controls.Add(btn_back);
            Controls.Add(lb_Info);
            Controls.Add(dtGrid_vacancyList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_RecruitmentDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_RecruitmentDetail";
            ((System.ComponentModel.ISupportInitialize)dtGrid_vacancyList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label lb_Info;
        private DataGridView dtGrid_vacancyList;
        private Label lb_criteria;
        private Label lb_date;
        private Label lb_formpost;
        private Label lb_name;
        private Label lb_state;
        private TextBox tb_compName;
        private TextBox tb_date;
        private TextBox tb_state;
        private TextBox tb_formpost;
        private TextBox tb_criteria;
        private Label lb_vacancy;
    }
}