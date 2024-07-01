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
            pn_parents = new Panel();
            tb_unit = new TextBox();
            cbB_compName = new ComboBox();
            tb_criteria = new TextBox();
            lb_content = new Label();
            tb_number = new TextBox();
            lb_number = new Label();
            cbB_compID = new ComboBox();
            cbB_formpost = new ComboBox();
            dt_date = new DateTimePicker();
            lb_date = new Label();
            lb_formpost = new Label();
            label1 = new Label();
            lb_name = new Label();
            btn_next = new Button();
            btn_Back = new Button();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(tb_unit);
            pn_parents.Controls.Add(cbB_compName);
            pn_parents.Controls.Add(tb_criteria);
            pn_parents.Controls.Add(lb_content);
            pn_parents.Controls.Add(tb_number);
            pn_parents.Controls.Add(lb_number);
            pn_parents.Controls.Add(cbB_compID);
            pn_parents.Controls.Add(cbB_formpost);
            pn_parents.Controls.Add(dt_date);
            pn_parents.Controls.Add(lb_date);
            pn_parents.Controls.Add(lb_formpost);
            pn_parents.Controls.Add(label1);
            pn_parents.Controls.Add(lb_name);
            pn_parents.Controls.Add(btn_next);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 314;
            // 
            // tb_unit
            // 
            tb_unit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_unit.Location = new Point(741, 196);
            tb_unit.Name = "tb_unit";
            tb_unit.ReadOnly = true;
            tb_unit.Size = new Size(124, 34);
            tb_unit.TabIndex = 333;
            tb_unit.TabStop = false;
            // 
            // cbB_compName
            // 
            cbB_compName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_compName.FormattingEnabled = true;
            cbB_compName.Location = new Point(197, 146);
            cbB_compName.Name = "cbB_compName";
            cbB_compName.Size = new Size(668, 36);
            cbB_compName.TabIndex = 328;
            // 
            // tb_criteria
            // 
            tb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_criteria.Location = new Point(197, 255);
            tb_criteria.Multiline = true;
            tb_criteria.Name = "tb_criteria";
            tb_criteria.Size = new Size(668, 100);
            tb_criteria.TabIndex = 327;
            tb_criteria.TabStop = false;
            // 
            // lb_content
            // 
            lb_content.AutoSize = true;
            lb_content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_content.Location = new Point(29, 255);
            lb_content.Name = "lb_content";
            lb_content.Size = new Size(95, 28);
            lb_content.TabIndex = 326;
            lb_content.Text = "Nội dung";
            // 
            // tb_number
            // 
            tb_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_number.Location = new Point(684, 196);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(51, 34);
            tb_number.TabIndex = 325;
            tb_number.TabStop = false;
            // 
            // lb_number
            // 
            lb_number.AutoSize = true;
            lb_number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_number.Location = new Point(586, 199);
            lb_number.Name = "lb_number";
            lb_number.Size = new Size(92, 28);
            lb_number.TabIndex = 324;
            lb_number.Text = "Số lượng";
            // 
            // cbB_compID
            // 
            cbB_compID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_compID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_compID.FormattingEnabled = true;
            cbB_compID.Location = new Point(197, 94);
            cbB_compID.Name = "cbB_compID";
            cbB_compID.Size = new Size(297, 36);
            cbB_compID.TabIndex = 323;
            // 
            // cbB_formpost
            // 
            cbB_formpost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_formpost.FormattingEnabled = true;
            cbB_formpost.Location = new Point(197, 196);
            cbB_formpost.Name = "cbB_formpost";
            cbB_formpost.Size = new Size(361, 36);
            cbB_formpost.TabIndex = 323;
            // 
            // dt_date
            // 
            dt_date.CustomFormat = "dd/MM/yyyy";
            dt_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_date.Format = DateTimePickerFormat.Custom;
            dt_date.Location = new Point(615, 96);
            dt_date.MinDate = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(250, 34);
            dt_date.TabIndex = 321;
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_date.Location = new Point(500, 101);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(109, 28);
            lb_date.TabIndex = 320;
            lb_date.Text = "Ngày đăng";
            // 
            // lb_formpost
            // 
            lb_formpost.AutoSize = true;
            lb_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_formpost.Location = new Point(29, 199);
            lb_formpost.Name = "lb_formpost";
            lb_formpost.Size = new Size(147, 28);
            lb_formpost.TabIndex = 319;
            lb_formpost.Text = "Hình thức đăng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 101);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 318;
            label1.Text = "Mã Doanh nghiệp";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(29, 149);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(136, 28);
            lb_name.TabIndex = 318;
            lb_name.Text = "Doanh nghiệp";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.White;
            btn_next.BackgroundImage = Properties.Resources.button_round22;
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_next.ForeColor = SystemColors.Window;
            btn_next.Location = new Point(467, 375);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(91, 37);
            btn_next.TabIndex = 317;
            btn_next.Text = "Tiếp";
            btn_next.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 375);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 316;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(279, 25);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(321, 31);
            lb_Info.TabIndex = 314;
            lb_Info.Text = "Tạo phiếu đăng ký quảng cáo";
            // 
            // P_AddRecruitment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_AddRecruitment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_AddRecruitment";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private TextBox tb_unit;
        private ComboBox cbB_compName;
        private Label lb_content;
        private TextBox tb_number;
        private Label lb_number;
        private ComboBox cbB_formpost;
        private DateTimePicker dt_date;
        private Label lb_date;
        private Label lb_formpost;
        private Label lb_name;
        private Button btn_next;
        private Button btn_Back;
        private Label lb_Info;
        private TextBox tb_criteria;
        private ComboBox cbB_compID;
        private Label label1;
    }
}