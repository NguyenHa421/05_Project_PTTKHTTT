namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_UpdateApplication
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
            cbB_state = new ComboBox();
            lb_nameCandidate = new Label();
            lb_vacancy = new Label();
            tb_nameComp = new TextBox();
            lb_nameComp = new Label();
            btn_confirm = new Button();
            btn_Back = new Button();
            lb_state = new Label();
            lb_Info = new Label();
            tb_nameCandidate = new TextBox();
            tb_vacancy = new TextBox();
            tb_idCV = new TextBox();
            lb_idCV = new Label();
            ln_idRegister = new Label();
            tb_idCandidate = new TextBox();
            lb_idCandidate = new Label();
            tb_idRegister = new TextBox();
            SuspendLayout();
            // 
            // cbB_state
            // 
            cbB_state.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_state.FormattingEnabled = true;
            cbB_state.Location = new Point(264, 309);
            cbB_state.Name = "cbB_state";
            cbB_state.Size = new Size(508, 36);
            cbB_state.TabIndex = 300;
            // 
            // lb_nameCandidate
            // 
            lb_nameCandidate.AutoSize = true;
            lb_nameCandidate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameCandidate.Location = new Point(390, 183);
            lb_nameCandidate.Name = "lb_nameCandidate";
            lb_nameCandidate.Size = new Size(122, 28);
            lb_nameCandidate.TabIndex = 297;
            lb_nameCandidate.Text = "Tên ứng viên";
            // 
            // lb_vacancy
            // 
            lb_vacancy.AutoSize = true;
            lb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vacancy.Location = new Point(96, 249);
            lb_vacancy.Name = "lb_vacancy";
            lb_vacancy.Size = new Size(85, 28);
            lb_vacancy.TabIndex = 296;
            lb_vacancy.Text = "Tên vị trí";
            // 
            // tb_nameComp
            // 
            tb_nameComp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nameComp.Location = new Point(264, 126);
            tb_nameComp.Name = "tb_nameComp";
            tb_nameComp.ReadOnly = true;
            tb_nameComp.Size = new Size(508, 30);
            tb_nameComp.TabIndex = 294;
            tb_nameComp.TabStop = false;
            // 
            // lb_nameComp
            // 
            lb_nameComp.AutoSize = true;
            lb_nameComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameComp.Location = new Point(96, 127);
            lb_nameComp.Name = "lb_nameComp";
            lb_nameComp.Size = new Size(168, 28);
            lb_nameComp.TabIndex = 292;
            lb_nameComp.Text = "Tên doanh nghiệp";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.White;
            btn_confirm.BackgroundImage = Properties.Resources.button_round22;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_confirm.ForeColor = SystemColors.Window;
            btn_confirm.Location = new Point(467, 374);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(91, 37);
            btn_confirm.TabIndex = 291;
            btn_confirm.Text = "Cập nhật";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 374);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 290;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_state.Location = new Point(96, 312);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(98, 28);
            lb_state.TabIndex = 289;
            lb_state.Text = "Trạng thái";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(311, 9);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(265, 31);
            lb_Info.TabIndex = 288;
            lb_Info.Text = "Cập nhật hồ sơ ứng viên";
            // 
            // tb_nameCandidate
            // 
            tb_nameCandidate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nameCandidate.Location = new Point(512, 180);
            tb_nameCandidate.Name = "tb_nameCandidate";
            tb_nameCandidate.ReadOnly = true;
            tb_nameCandidate.Size = new Size(260, 34);
            tb_nameCandidate.TabIndex = 307;
            tb_nameCandidate.TabStop = false;
            // 
            // tb_vacancy
            // 
            tb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_vacancy.Location = new Point(264, 246);
            tb_vacancy.Name = "tb_vacancy";
            tb_vacancy.ReadOnly = true;
            tb_vacancy.Size = new Size(508, 34);
            tb_vacancy.TabIndex = 309;
            tb_vacancy.TabStop = false;
            // 
            // tb_idCV
            // 
            tb_idCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_idCV.Location = new Point(264, 63);
            tb_idCV.Name = "tb_idCV";
            tb_idCV.ReadOnly = true;
            tb_idCV.Size = new Size(169, 34);
            tb_idCV.TabIndex = 313;
            tb_idCV.TabStop = false;
            // 
            // lb_idCV
            // 
            lb_idCV.AutoSize = true;
            lb_idCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idCV.Location = new Point(96, 66);
            lb_idCV.Name = "lb_idCV";
            lb_idCV.Size = new Size(93, 28);
            lb_idCV.TabIndex = 312;
            lb_idCV.Text = "Mã hồ sơ";
            // 
            // ln_idRegister
            // 
            ln_idRegister.AutoSize = true;
            ln_idRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ln_idRegister.Location = new Point(474, 66);
            ln_idRegister.Name = "ln_idRegister";
            ln_idRegister.Size = new Size(115, 28);
            ln_idRegister.TabIndex = 314;
            ln_idRegister.Text = "Mã đăng ký";
            // 
            // tb_idCandidate
            // 
            tb_idCandidate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_idCandidate.Location = new Point(264, 183);
            tb_idCandidate.Name = "tb_idCandidate";
            tb_idCandidate.ReadOnly = true;
            tb_idCandidate.Size = new Size(114, 34);
            tb_idCandidate.TabIndex = 317;
            tb_idCandidate.TabStop = false;
            // 
            // lb_idCandidate
            // 
            lb_idCandidate.AutoSize = true;
            lb_idCandidate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idCandidate.Location = new Point(96, 186);
            lb_idCandidate.Name = "lb_idCandidate";
            lb_idCandidate.Size = new Size(121, 28);
            lb_idCandidate.TabIndex = 316;
            lb_idCandidate.Text = "Mã ứng viên";
            // 
            // tb_idRegister
            // 
            tb_idRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_idRegister.Location = new Point(610, 63);
            tb_idRegister.Name = "tb_idRegister";
            tb_idRegister.ReadOnly = true;
            tb_idRegister.Size = new Size(162, 34);
            tb_idRegister.TabIndex = 318;
            tb_idRegister.TabStop = false;
            // 
            // P_UpdateApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_idRegister);
            Controls.Add(tb_idCandidate);
            Controls.Add(lb_idCandidate);
            Controls.Add(ln_idRegister);
            Controls.Add(tb_idCV);
            Controls.Add(lb_idCV);
            Controls.Add(tb_vacancy);
            Controls.Add(tb_nameCandidate);
            Controls.Add(cbB_state);
            Controls.Add(lb_nameCandidate);
            Controls.Add(lb_vacancy);
            Controls.Add(tb_nameComp);
            Controls.Add(lb_nameComp);
            Controls.Add(btn_confirm);
            Controls.Add(btn_Back);
            Controls.Add(lb_state);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_UpdateApplication";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_UpdateApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_cost;
        private Label lb_cost;
        private TextBox textBox2;
        private Label label2;
        private ComboBox cbB_state;
        private DateTimePicker dt_date;
        private Label lb_nameCandidate;
        private Label lb_vacancy;
        private TextBox tb_content;
        private TextBox tb_nameComp;
        private Label lb_nameComp;
        private Button btn_confirm;
        private Button btn_Back;
        private Label lb_state;
        private Label lb_Info;
        private TextBox tb_nameCandidate;
        private TextBox tb_vacancy;
        private TextBox tb_cv;
        private Label lb_cv;
        private TextBox tb_idCV;
        private Label lb_idCV;
        private TextBox tb_idComp;
        private Label ln_idRegister;
        private TextBox tb_idCandidate;
        private Label lb_idCandidate;
        private TextBox tb_idRegister;
    }
}