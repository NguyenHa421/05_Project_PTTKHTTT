namespace _05_Project_PTTKHTTT.Candidate
{
    partial class C_JobDetail
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
            lb_criteria = new Label();
            tb_criteria = new TextBox();
            lb_postdate = new Label();
            tb_state = new TextBox();
            tb_postdate = new TextBox();
            tb_amount = new TextBox();
            tb_jobName = new TextBox();
            tb_compName = new TextBox();
            lb_jobName = new Label();
            lb_compName = new Label();
            btn_apply = new Button();
            btn_Back = new Button();
            lb_amount = new Label();
            lb_state = new Label();
            lb_Info = new Label();
            SuspendLayout();
            // 
            // lb_criteria
            // 
            lb_criteria.AutoSize = true;
            lb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_criteria.Location = new Point(27, 200);
            lb_criteria.Name = "lb_criteria";
            lb_criteria.Size = new Size(78, 28);
            lb_criteria.TabIndex = 282;
            lb_criteria.Text = "Tiêu chí";
            // 
            // tb_criteria
            // 
            tb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_criteria.Location = new Point(195, 197);
            tb_criteria.Multiline = true;
            tb_criteria.Name = "tb_criteria";
            tb_criteria.ReadOnly = true;
            tb_criteria.Size = new Size(668, 83);
            tb_criteria.TabIndex = 280;
            tb_criteria.TabStop = false;
            // 
            // lb_postdate
            // 
            lb_postdate.AutoSize = true;
            lb_postdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_postdate.Location = new Point(27, 314);
            lb_postdate.Name = "lb_postdate";
            lb_postdate.Size = new Size(109, 28);
            lb_postdate.TabIndex = 279;
            lb_postdate.Text = "Ngày đăng";
            // 
            // tb_state
            // 
            tb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_state.Location = new Point(582, 311);
            tb_state.Name = "tb_state";
            tb_state.ReadOnly = true;
            tb_state.Size = new Size(281, 34);
            tb_state.TabIndex = 278;
            tb_state.TabStop = false;
            // 
            // tb_postdate
            // 
            tb_postdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_postdate.Location = new Point(195, 311);
            tb_postdate.Name = "tb_postdate";
            tb_postdate.ReadOnly = true;
            tb_postdate.Size = new Size(254, 34);
            tb_postdate.TabIndex = 277;
            tb_postdate.TabStop = false;
            // 
            // tb_amount
            // 
            tb_amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_amount.Location = new Point(716, 134);
            tb_amount.Name = "tb_amount";
            tb_amount.ReadOnly = true;
            tb_amount.Size = new Size(147, 34);
            tb_amount.TabIndex = 276;
            tb_amount.TabStop = false;
            // 
            // tb_jobName
            // 
            tb_jobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_jobName.Location = new Point(195, 134);
            tb_jobName.Name = "tb_jobName";
            tb_jobName.ReadOnly = true;
            tb_jobName.Size = new Size(403, 34);
            tb_jobName.TabIndex = 275;
            tb_jobName.TabStop = false;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(195, 71);
            tb_compName.Name = "tb_compName";
            tb_compName.ReadOnly = true;
            tb_compName.Size = new Size(668, 34);
            tb_compName.TabIndex = 274;
            tb_compName.TabStop = false;
            // 
            // lb_jobName
            // 
            lb_jobName.AutoSize = true;
            lb_jobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_jobName.Location = new Point(27, 137);
            lb_jobName.Name = "lb_jobName";
            lb_jobName.Size = new Size(158, 28);
            lb_jobName.TabIndex = 273;
            lb_jobName.Text = "Vị trí tuyển dụng";
            // 
            // lb_compName
            // 
            lb_compName.AutoSize = true;
            lb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_compName.Location = new Point(27, 74);
            lb_compName.Name = "lb_compName";
            lb_compName.Size = new Size(168, 28);
            lb_compName.TabIndex = 272;
            lb_compName.Text = "Tên doanh nghiệp";
            // 
            // btn_apply
            // 
            btn_apply.BackColor = Color.White;
            btn_apply.BackgroundImage = Properties.Resources.button_round22;
            btn_apply.FlatAppearance.BorderSize = 0;
            btn_apply.FlatStyle = FlatStyle.Flat;
            btn_apply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_apply.ForeColor = SystemColors.Window;
            btn_apply.Location = new Point(467, 377);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(91, 37);
            btn_apply.TabIndex = 271;
            btn_apply.Text = "Ứng tuyển";
            btn_apply.UseVisualStyleBackColor = false;
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 377);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 270;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_amount
            // 
            lb_amount.AutoSize = true;
            lb_amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_amount.Location = new Point(618, 137);
            lb_amount.Name = "lb_amount";
            lb_amount.Size = new Size(92, 28);
            lb_amount.TabIndex = 268;
            lb_amount.Text = "Số lượng";
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_state.Location = new Point(476, 314);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(98, 28);
            lb_state.TabIndex = 267;
            lb_state.Text = "Trạng thái";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(304, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(281, 31);
            lb_Info.TabIndex = 266;
            lb_Info.Text = "Thông tin chi tiết việc làm";
            // 
            // C_JobDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(lb_criteria);
            Controls.Add(tb_criteria);
            Controls.Add(lb_postdate);
            Controls.Add(tb_state);
            Controls.Add(tb_postdate);
            Controls.Add(tb_amount);
            Controls.Add(tb_jobName);
            Controls.Add(tb_compName);
            Controls.Add(lb_jobName);
            Controls.Add(lb_compName);
            Controls.Add(btn_apply);
            Controls.Add(btn_Back);
            Controls.Add(lb_amount);
            Controls.Add(lb_state);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "C_JobDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "C_JobContent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_criteria;
        private TextBox tb_content;
        private TextBox tb_criteria;
        private Label lb_postdate;
        private TextBox tb_state;
        private TextBox tb_postdate;
        private TextBox tb_amount;
        private TextBox tb_jobName;
        private TextBox tb_compName;
        private Label lb_jobName;
        private Label lb_compName;
        private Button btn_apply;
        private Button btn_Back;
        private Label lb_content;
        private Label lb_amount;
        private Label lb_state;
        private Label lb_Info;
    }
}