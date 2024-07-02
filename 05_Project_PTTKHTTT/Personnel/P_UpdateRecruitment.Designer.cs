namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_UpdateRecruitment
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
            tb_quantity = new TextBox();
            lb_quantity = new Label();
            tb_vacancy = new TextBox();
            lb_vacancy = new Label();
            dtGrid_jobList = new DataGridView();
            tb_regID = new TextBox();
            lb_regID = new Label();
            tb_compName = new TextBox();
            tb_criteria = new TextBox();
            lb_criteria = new Label();
            cbB_formpost = new ComboBox();
            cbB_state = new ComboBox();
            dt_date = new DateTimePicker();
            lb_date = new Label();
            lb_formpost = new Label();
            lb_name = new Label();
            btn_next = new Button();
            btn_Back = new Button();
            lb_state = new Label();
            lb_Info = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_jobList).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(tb_quantity);
            pn_parents.Controls.Add(lb_quantity);
            pn_parents.Controls.Add(tb_vacancy);
            pn_parents.Controls.Add(lb_vacancy);
            pn_parents.Controls.Add(dtGrid_jobList);
            pn_parents.Controls.Add(tb_regID);
            pn_parents.Controls.Add(lb_regID);
            pn_parents.Controls.Add(tb_compName);
            pn_parents.Controls.Add(tb_criteria);
            pn_parents.Controls.Add(lb_criteria);
            pn_parents.Controls.Add(cbB_formpost);
            pn_parents.Controls.Add(cbB_state);
            pn_parents.Controls.Add(dt_date);
            pn_parents.Controls.Add(lb_date);
            pn_parents.Controls.Add(lb_formpost);
            pn_parents.Controls.Add(lb_name);
            pn_parents.Controls.Add(btn_next);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(lb_state);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 315;
            // 
            // tb_quantity
            // 
            tb_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_quantity.Location = new Point(400, 340);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(158, 34);
            tb_quantity.TabIndex = 340;
            tb_quantity.TabStop = false;
            // 
            // lb_quantity
            // 
            lb_quantity.AutoSize = true;
            lb_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_quantity.Location = new Point(197, 343);
            lb_quantity.Name = "lb_quantity";
            lb_quantity.Size = new Size(197, 28);
            lb_quantity.TabIndex = 339;
            lb_quantity.Text = "Số lượng tuyển dụng";
            // 
            // tb_vacancy
            // 
            tb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_vacancy.Location = new Point(197, 299);
            tb_vacancy.Name = "tb_vacancy";
            tb_vacancy.Size = new Size(361, 34);
            tb_vacancy.TabIndex = 338;
            tb_vacancy.TabStop = false;
            // 
            // lb_vacancy
            // 
            lb_vacancy.AutoSize = true;
            lb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vacancy.Location = new Point(29, 302);
            lb_vacancy.Name = "lb_vacancy";
            lb_vacancy.Size = new Size(85, 28);
            lb_vacancy.TabIndex = 337;
            lb_vacancy.Text = "Tên vị trí";
            // 
            // dtGrid_jobList
            // 
            dtGrid_jobList.BackgroundColor = SystemColors.Control;
            dtGrid_jobList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_jobList.Location = new Point(577, 171);
            dtGrid_jobList.Name = "dtGrid_jobList";
            dtGrid_jobList.RowHeadersWidth = 51;
            dtGrid_jobList.Size = new Size(288, 194);
            dtGrid_jobList.TabIndex = 336;
            dtGrid_jobList.CellContentClick += dtGrid_jobList_CellContentClick;
            // 
            // tb_regID
            // 
            tb_regID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_regID.Location = new Point(197, 44);
            tb_regID.Name = "tb_regID";
            tb_regID.ReadOnly = true;
            tb_regID.Size = new Size(279, 34);
            tb_regID.TabIndex = 335;
            tb_regID.TabStop = false;
            // 
            // lb_regID
            // 
            lb_regID.AutoSize = true;
            lb_regID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_regID.Location = new Point(29, 47);
            lb_regID.Name = "lb_regID";
            lb_regID.Size = new Size(169, 28);
            lb_regID.TabIndex = 334;
            lb_regID.Text = "Mã phiếu đăng ký";
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(197, 87);
            tb_compName.Name = "tb_compName";
            tb_compName.ReadOnly = true;
            tb_compName.Size = new Size(668, 34);
            tb_compName.TabIndex = 333;
            tb_compName.TabStop = false;
            // 
            // tb_criteria
            // 
            tb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_criteria.Location = new Point(197, 171);
            tb_criteria.Multiline = true;
            tb_criteria.Name = "tb_criteria";
            tb_criteria.Size = new Size(361, 123);
            tb_criteria.TabIndex = 327;
            tb_criteria.TabStop = false;
            // 
            // lb_criteria
            // 
            lb_criteria.AutoSize = true;
            lb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_criteria.Location = new Point(29, 174);
            lb_criteria.Name = "lb_criteria";
            lb_criteria.Size = new Size(78, 28);
            lb_criteria.TabIndex = 326;
            lb_criteria.Text = "Tiêu chí";
            // 
            // cbB_formpost
            // 
            cbB_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_formpost.FormattingEnabled = true;
            cbB_formpost.Location = new Point(197, 130);
            cbB_formpost.Name = "cbB_formpost";
            cbB_formpost.Size = new Size(279, 36);
            cbB_formpost.TabIndex = 323;
            // 
            // cbB_state
            // 
            cbB_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_state.FormattingEnabled = true;
            cbB_state.Location = new Point(615, 130);
            cbB_state.Name = "cbB_state";
            cbB_state.Size = new Size(250, 36);
            cbB_state.TabIndex = 322;
            // 
            // dt_date
            // 
            dt_date.CustomFormat = "MM/dd/yyyy";
            dt_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_date.Format = DateTimePickerFormat.Custom;
            dt_date.Location = new Point(615, 42);
            dt_date.MinDate = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(250, 34);
            dt_date.TabIndex = 321;
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_date.Location = new Point(500, 47);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(109, 28);
            lb_date.TabIndex = 320;
            lb_date.Text = "Ngày đăng";
            // 
            // lb_formpost
            // 
            lb_formpost.AutoSize = true;
            lb_formpost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_formpost.Location = new Point(29, 133);
            lb_formpost.Name = "lb_formpost";
            lb_formpost.Size = new Size(147, 28);
            lb_formpost.TabIndex = 319;
            lb_formpost.Text = "Hình thức đăng";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(29, 90);
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
            btn_next.Location = new Point(467, 384);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(91, 37);
            btn_next.TabIndex = 317;
            btn_next.Text = "Tiếp";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round22;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(342, 384);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 316;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_state.Location = new Point(500, 133);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(98, 28);
            lb_state.TabIndex = 315;
            lb_state.Text = "Trạng thái";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(253, 3);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(374, 31);
            lb_Info.TabIndex = 314;
            lb_Info.Text = "Cập nhật phiếu đăng ký quảng cáo";
            // 
            // P_UpdateRecruitment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_UpdateRecruitment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_UpdateRecruitment";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_jobList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private TextBox tb_compName;
        private TextBox tb_criteria;
        private Label lb_criteria;
        private ComboBox cbB_formpost;
        private ComboBox cbB_state;
        private DateTimePicker dt_date;
        private Label lb_date;
        private Label lb_formpost;
        private Label lb_name;
        private Button btn_next;
        private Button btn_Back;
        private Label lb_state;
        private Label lb_Info;
        private TextBox tb_regID;
        private Label lb_regID;
        private DataGridView dtGrid_jobList;
        private TextBox tb_quantity;
        private Label lb_quantity;
        private TextBox tb_vacancy;
        private Label lb_vacancy;
    }
}