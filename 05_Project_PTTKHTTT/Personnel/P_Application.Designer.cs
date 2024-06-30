namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_Application
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
            cbB_compName = new ComboBox();
            btn_update = new Button();
            btn_back = new Button();
            lb_Info = new Label();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            dtGrid_application = new DataGridView();
            lb_compName = new Label();
            lb_candidateName = new Label();
            tb_candidateName = new TextBox();
            tb_vancancyName = new TextBox();
            lb_vacancyName = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_application).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(tb_vancancyName);
            pn_parents.Controls.Add(lb_vacancyName);
            pn_parents.Controls.Add(tb_candidateName);
            pn_parents.Controls.Add(lb_candidateName);
            pn_parents.Controls.Add(cbB_compName);
            pn_parents.Controls.Add(btn_update);
            pn_parents.Controls.Add(btn_back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Controls.Add(ptn_refresh);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(dtGrid_application);
            pn_parents.Controls.Add(lb_compName);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 4;
            // 
            // cbB_compName
            // 
            cbB_compName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_compName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_compName.FormattingEnabled = true;
            cbB_compName.Location = new Point(206, 90);
            cbB_compName.Name = "cbB_compName";
            cbB_compName.Size = new Size(496, 33);
            cbB_compName.TabIndex = 124;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.White;
            btn_update.BackgroundImage = Properties.Resources.button_round21;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_update.ForeColor = SystemColors.Window;
            btn_update.Location = new Point(648, 376);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(91, 38);
            btn_update.TabIndex = 123;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
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
            lb_Info.Location = new Point(293, 7);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(280, 31);
            lb_Info.TabIndex = 120;
            lb_Info.Text = "Danh sách hồ sơ ứng viên";
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(711, 87);
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
            btn_search.Location = new Point(775, 88);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 118;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // dtGrid_application
            // 
            dtGrid_application.BackgroundColor = SystemColors.Control;
            dtGrid_application.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_application.Location = new Point(32, 134);
            dtGrid_application.Name = "dtGrid_application";
            dtGrid_application.RowHeadersWidth = 51;
            dtGrid_application.Size = new Size(834, 233);
            dtGrid_application.TabIndex = 116;
            dtGrid_application.CellContentClick += dtGrid_application_CellContentClick;
            // 
            // lb_compName
            // 
            lb_compName.AutoSize = true;
            lb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_compName.Location = new Point(32, 96);
            lb_compName.Name = "lb_compName";
            lb_compName.Size = new Size(168, 28);
            lb_compName.TabIndex = 114;
            lb_compName.Text = "Tên doanh nghiệp";
            // 
            // lb_candidateName
            // 
            lb_candidateName.AutoSize = true;
            lb_candidateName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_candidateName.Location = new Point(32, 50);
            lb_candidateName.Name = "lb_candidateName";
            lb_candidateName.Size = new Size(122, 28);
            lb_candidateName.TabIndex = 125;
            lb_candidateName.Text = "Tên ứng viên";
            // 
            // tb_candidateName
            // 
            tb_candidateName.Font = new Font("Segoe UI", 10.8F);
            tb_candidateName.Location = new Point(206, 47);
            tb_candidateName.Name = "tb_candidateName";
            tb_candidateName.Size = new Size(275, 31);
            tb_candidateName.TabIndex = 126;
            tb_candidateName.TabStop = false;
            // 
            // tb_vancancyName
            // 
            tb_vancancyName.Font = new Font("Segoe UI", 10.8F);
            tb_vancancyName.Location = new Point(600, 47);
            tb_vancancyName.Name = "tb_vancancyName";
            tb_vancancyName.Size = new Size(266, 31);
            tb_vancancyName.TabIndex = 128;
            tb_vancancyName.TabStop = false;
            // 
            // lb_vacancyName
            // 
            lb_vacancyName.AutoSize = true;
            lb_vacancyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vacancyName.Location = new Point(509, 50);
            lb_vacancyName.Name = "lb_vacancyName";
            lb_vacancyName.Size = new Size(85, 28);
            lb_vacancyName.TabIndex = 127;
            lb_vacancyName.Text = "Tên vị trí";
            // 
            // P_Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_Application";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_CandidateProfile";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_application).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button btn_update;
        private Button btn_back;
        private Label lb_Info;
        private PictureBox ptn_refresh;
        private Button btn_search;
        private DataGridView dtGrid_application;
        private Label lb_compName;
        private ComboBox cbB_compName;
        private ComboBox comboBox1;
        private Label lb_candidateName;
        private TextBox tb_candidateName;
        private TextBox tb_vancancyName;
        private Label lb_vacancyName;
    }
}