namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_AddRecruitment
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
            lb_date = new Label();
            lb_formpost = new Label();
            tb_content = new TextBox();
            tb_name = new TextBox();
            lb_content = new Label();
            lb_name = new Label();
            btn_confirm = new Button();
            btn_Back = new Button();
            lb_state = new Label();
            lb_Info = new Label();
            dt_date = new DateTimePicker();
            cbB_state = new ComboBox();
            cbB_formpost = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_date.Location = new Point(29, 112);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(109, 28);
            lb_date.TabIndex = 278;
            lb_date.Text = "Ngày đăng";
            // 
            // lb_formpost
            // 
            lb_formpost.AutoSize = true;
            lb_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_formpost.Location = new Point(29, 165);
            lb_formpost.Name = "lb_formpost";
            lb_formpost.Size = new Size(147, 28);
            lb_formpost.TabIndex = 275;
            lb_formpost.Text = "Hình thức đăng";
            // 
            // tb_content
            // 
            tb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_content.Location = new Point(197, 281);
            tb_content.Multiline = true;
            tb_content.Name = "tb_content";
            tb_content.Size = new Size(668, 75);
            tb_content.TabIndex = 273;
            tb_content.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(197, 55);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(668, 34);
            tb_name.TabIndex = 272;
            tb_name.TabStop = false;
            // 
            // lb_content
            // 
            lb_content.AutoSize = true;
            lb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_content.Location = new Point(29, 284);
            lb_content.Name = "lb_content";
            lb_content.Size = new Size(95, 28);
            lb_content.TabIndex = 271;
            lb_content.Text = "Nội dung";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(29, 58);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(168, 28);
            lb_name.TabIndex = 270;
            lb_name.Text = "Tên doanh nghiệp";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.White;
            btn_confirm.BackgroundImage = Properties.Resources.button_round22;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_confirm.ForeColor = SystemColors.Window;
            btn_confirm.Location = new Point(467, 371);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(91, 37);
            btn_confirm.TabIndex = 269;
            btn_confirm.Text = "Đăng ký";
            btn_confirm.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 371);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 268;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_state.Location = new Point(495, 112);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(98, 28);
            lb_state.TabIndex = 267;
            lb_state.Text = "Trạng thái";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(308, 11);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(321, 31);
            lb_Info.TabIndex = 266;
            lb_Info.Text = "Tạo phiếu đăng ký quảng cáo";
            // 
            // dt_date
            // 
            dt_date.CustomFormat = "dd/MM/yyyy";
            dt_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_date.Format = DateTimePickerFormat.Custom;
            dt_date.Location = new Point(197, 107);
            dt_date.MinDate = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(250, 34);
            dt_date.TabIndex = 279;
            // 
            // cbB_state
            // 
            cbB_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_state.FormattingEnabled = true;
            cbB_state.Location = new Point(600, 109);
            cbB_state.Name = "cbB_state";
            cbB_state.Size = new Size(265, 36);
            cbB_state.TabIndex = 280;
            // 
            // cbB_formpost
            // 
            cbB_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_formpost.FormattingEnabled = true;
            cbB_formpost.Location = new Point(197, 162);
            cbB_formpost.Name = "cbB_formpost";
            cbB_formpost.Size = new Size(396, 36);
            cbB_formpost.TabIndex = 281;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(623, 165);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 282;
            label1.Text = "Số lượng";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(730, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 34);
            textBox1.TabIndex = 283;
            textBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(197, 202);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(668, 75);
            textBox2.TabIndex = 285;
            textBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 205);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 284;
            label2.Text = "Tiêu chí";
            // 
            // P_AddRecruitment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(cbB_formpost);
            Controls.Add(cbB_state);
            Controls.Add(dt_date);
            Controls.Add(lb_date);
            Controls.Add(lb_formpost);
            Controls.Add(tb_content);
            Controls.Add(tb_name);
            Controls.Add(lb_content);
            Controls.Add(lb_name);
            Controls.Add(btn_confirm);
            Controls.Add(btn_Back);
            Controls.Add(lb_state);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_AddRecruitment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_AddRecruitment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_date;
        private Label lb_formpost;
        private TextBox tb_content;
        private TextBox tb_name;
        private Label lb_content;
        private Label lb_name;
        private Button btn_confirm;
        private Button btn_Back;
        private Label lb_state;
        private Label lb_Info;
        private DateTimePicker dt_date;
        private ComboBox cbB_state;
        private ComboBox cbB_formpost;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}