namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_CompanyList
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
            dtGrid_companyList = new DataGridView();
            tb_compName = new TextBox();
            lb_name = new Label();
            btn_add = new Button();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            this.lb_Info = new Label();
            this.btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrid_companyList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            SuspendLayout();
            // 
            // dtGrid_companyList
            // 
            dtGrid_companyList.BackgroundColor = SystemColors.Control;
            dtGrid_companyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_companyList.Location = new Point(39, 104);
            dtGrid_companyList.Name = "dtGrid_companyList";
            dtGrid_companyList.RowHeadersWidth = 51;
            dtGrid_companyList.Size = new Size(816, 262);
            dtGrid_companyList.TabIndex = 98;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(204, 57);
            tb_compName.Name = "tb_compName";
            tb_compName.Size = new Size(483, 34);
            tb_compName.TabIndex = 97;
            tb_compName.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(39, 60);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(168, 28);
            lb_name.TabIndex = 96;
            lb_name.Text = "Tên doanh nghiệp";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.BackgroundImage = Properties.Resources.button_round21;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_add.ForeColor = SystemColors.Window;
            btn_add.Location = new Point(632, 375);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(91, 38);
            btn_add.TabIndex = 101;
            btn_add.Text = "Tạo mới";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(704, 54);
            ptn_refresh.Name = "ptn_refresh";
            ptn_refresh.Size = new Size(49, 39);
            ptn_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            ptn_refresh.TabIndex = 103;
            ptn_refresh.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round22;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(764, 54);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 102;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lb_Info.Location = new Point(308, 9);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new Size(264, 31);
            this.lb_Info.TabIndex = 104;
            this.lb_Info.Text = "Thông tin doanh nghiệp";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = Color.White;
            this.btn_back.BackgroundImage = Properties.Resources.button_round21;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = FlatStyle.Flat;
            this.btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.btn_back.ForeColor = SystemColors.Window;
            this.btn_back.Location = new Point(764, 375);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new Size(91, 38);
            this.btn_back.TabIndex = 105;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // P_CompanyList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(this.btn_back);
            Controls.Add(this.lb_Info);
            Controls.Add(ptn_refresh);
            Controls.Add(btn_search);
            Controls.Add(btn_add);
            Controls.Add(dtGrid_companyList);
            Controls.Add(tb_compName);
            Controls.Add(lb_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_CompanyList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_CompanyList";
            ((System.ComponentModel.ISupportInitialize)dtGrid_companyList).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGrid_companyList;
        private TextBox tb_compName;
        private Label lb_name;
        private Button btn_add;
        private PictureBox ptn_refresh;
        private Button btn_search;
    }
}