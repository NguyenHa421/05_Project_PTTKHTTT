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
            lb_content = new Label();
            lb_name = new Label();
            btn_confirm = new Button();
            btn_Back = new Button();
            lb_state = new Label();
            lb_Info = new Label();
            dt_date = new DateTimePicker();
            cbB_state = new ComboBox();
            cbB_formpost = new ComboBox();
            lb_number = new Label();
            tb_number = new TextBox();
            tb_criteria = new TextBox();
            lb_criteria = new Label();
            cbB_nameComp = new ComboBox();
            tb_vacancy = new TextBox();
            lb_vacancy = new Label();
            tb_quantity = new TextBox();
            lb_quantity = new Label();
            tb_unit = new TextBox();
            SuspendLayout();
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_date.Location = new Point(29, 166);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(109, 28);
            lb_date.TabIndex = 278;
            lb_date.Text = "Ngày đăng";
            // 
            // lb_formpost
            // 
            lb_formpost.AutoSize = true;
            lb_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_formpost.Location = new Point(29, 219);
            lb_formpost.Name = "lb_formpost";
            lb_formpost.Size = new Size(147, 28);
            lb_formpost.TabIndex = 275;
            lb_formpost.Text = "Hình thức đăng";
            // 
            // tb_content
            // 
            tb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_content.Location = new Point(586, 276);
            tb_content.Multiline = true;
            tb_content.Name = "tb_content";
            tb_content.Size = new Size(279, 75);
            tb_content.TabIndex = 273;
            tb_content.TabStop = false;
            // 
            // lb_content
            // 
            lb_content.AutoSize = true;
            lb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_content.Location = new Point(488, 279);
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
            lb_name.Size = new Size(136, 28);
            lb_name.TabIndex = 270;
            lb_name.Text = "Doanh nghiệp";
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
            lb_state.Location = new Point(488, 166);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(98, 28);
            lb_state.TabIndex = 267;
            lb_state.Text = "Trạng thái";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(276, 9);
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
            dt_date.Location = new Point(197, 161);
            dt_date.MinDate = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(250, 34);
            dt_date.TabIndex = 279;
            // 
            // cbB_state
            // 
            cbB_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_state.FormattingEnabled = true;
            cbB_state.Location = new Point(600, 163);
            cbB_state.Name = "cbB_state";
            cbB_state.Size = new Size(265, 36);
            cbB_state.TabIndex = 280;
            // 
            // cbB_formpost
            // 
            cbB_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_formpost.FormattingEnabled = true;
            cbB_formpost.Location = new Point(197, 216);
            cbB_formpost.Name = "cbB_formpost";
            cbB_formpost.Size = new Size(361, 36);
            cbB_formpost.TabIndex = 281;
            // 
            // lb_number
            // 
            lb_number.AutoSize = true;
            lb_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_number.Location = new Point(586, 219);
            lb_number.Name = "lb_number";
            lb_number.Size = new Size(92, 28);
            lb_number.TabIndex = 282;
            lb_number.Text = "Số lượng";
            // 
            // tb_number
            // 
            tb_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_number.Location = new Point(684, 216);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(51, 34);
            tb_number.TabIndex = 283;
            tb_number.TabStop = false;
            // 
            // tb_criteria
            // 
            tb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_criteria.Location = new Point(197, 276);
            tb_criteria.Multiline = true;
            tb_criteria.Name = "tb_criteria";
            tb_criteria.Size = new Size(273, 75);
            tb_criteria.TabIndex = 285;
            tb_criteria.TabStop = false;
            // 
            // lb_criteria
            // 
            lb_criteria.AutoSize = true;
            lb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_criteria.Location = new Point(29, 279);
            lb_criteria.Name = "lb_criteria";
            lb_criteria.Size = new Size(78, 28);
            lb_criteria.TabIndex = 284;
            lb_criteria.Text = "Tiêu chí";
            // 
            // cbB_nameComp
            // 
            cbB_nameComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameComp.FormattingEnabled = true;
            cbB_nameComp.Location = new Point(197, 55);
            cbB_nameComp.Name = "cbB_nameComp";
            cbB_nameComp.Size = new Size(668, 36);
            cbB_nameComp.TabIndex = 286;
            // 
            // tb_vacancy
            // 
            tb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_vacancy.Location = new Point(197, 109);
            tb_vacancy.Name = "tb_vacancy";
            tb_vacancy.Size = new Size(250, 34);
            tb_vacancy.TabIndex = 288;
            tb_vacancy.TabStop = false;
            // 
            // lb_vacancy
            // 
            lb_vacancy.AutoSize = true;
            lb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vacancy.Location = new Point(29, 112);
            lb_vacancy.Name = "lb_vacancy";
            lb_vacancy.Size = new Size(85, 28);
            lb_vacancy.TabIndex = 287;
            lb_vacancy.Text = "Tên vị trí";
            // 
            // tb_quantity
            // 
            tb_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_quantity.Location = new Point(684, 109);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(181, 34);
            tb_quantity.TabIndex = 290;
            tb_quantity.TabStop = false;
            // 
            // lb_quantity
            // 
            lb_quantity.AutoSize = true;
            lb_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_quantity.Location = new Point(488, 112);
            lb_quantity.Name = "lb_quantity";
            lb_quantity.Size = new Size(197, 28);
            lb_quantity.TabIndex = 289;
            lb_quantity.Text = "Số lượng tuyển dụng";
            // 
            // tb_unit
            // 
            tb_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_unit.Location = new Point(741, 216);
            tb_unit.Name = "tb_unit";
            tb_unit.ReadOnly = true;
            tb_unit.Size = new Size(124, 34);
            tb_unit.TabIndex = 291;
            tb_unit.TabStop = false;
            // 
            // P_AddRecruitment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_unit);
            Controls.Add(tb_quantity);
            Controls.Add(lb_quantity);
            Controls.Add(tb_vacancy);
            Controls.Add(lb_vacancy);
            Controls.Add(cbB_nameComp);
            Controls.Add(tb_criteria);
            Controls.Add(lb_criteria);
            Controls.Add(tb_number);
            Controls.Add(lb_number);
            Controls.Add(cbB_formpost);
            Controls.Add(cbB_state);
            Controls.Add(dt_date);
            Controls.Add(lb_date);
            Controls.Add(lb_formpost);
            Controls.Add(tb_content);
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
        private Label lb_content;
        private Label lb_name;
        private Button btn_confirm;
        private Button btn_Back;
        private Label lb_state;
        private Label lb_Info;
        private DateTimePicker dt_date;
        private ComboBox cbB_state;
        private ComboBox cbB_formpost;
        private Label lb_number;
        private TextBox tb_number;
        private TextBox tb_criteria;
        private Label lb_criteria;
        private ComboBox cbB_nameComp;
        private TextBox tb_vacancy;
        private Label lb_vacancy;
        private TextBox tb_quantity;
        private Label lb_quantity;
        private TextBox tb_unit;
    }
}