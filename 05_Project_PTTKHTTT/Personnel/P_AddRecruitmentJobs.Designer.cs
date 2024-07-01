namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_AddRecruitmentJobs
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
            lb_tittle = new Label();
            pn_parents = new Panel();
            btn_next = new Button();
            btn_Back = new Button();
            tb_quantity = new TextBox();
            lb_quantity = new Label();
            tb_vacancy = new TextBox();
            lb_vacancy = new Label();
            dtGrid_jobList = new DataGridView();
            btn_add = new Button();
            btn_delete = new Button();
            tb_criteria = new TextBox();
            lb_criteria = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_jobList).BeginInit();
            SuspendLayout();
            // 
            // lb_tittle
            // 
            lb_tittle.AutoSize = true;
            lb_tittle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tittle.Location = new Point(337, 9);
            lb_tittle.Name = "lb_tittle";
            lb_tittle.Size = new Size(249, 31);
            lb_tittle.TabIndex = 314;
            lb_tittle.Text = "Thêm vị trí tuyển dụng";
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(lb_criteria);
            pn_parents.Controls.Add(tb_criteria);
            pn_parents.Controls.Add(btn_next);
            pn_parents.Controls.Add(btn_Back);
            pn_parents.Controls.Add(tb_quantity);
            pn_parents.Controls.Add(lb_quantity);
            pn_parents.Controls.Add(tb_vacancy);
            pn_parents.Controls.Add(lb_vacancy);
            pn_parents.Controls.Add(dtGrid_jobList);
            pn_parents.Controls.Add(btn_add);
            pn_parents.Controls.Add(btn_delete);
            pn_parents.Controls.Add(lb_tittle);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 315;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.White;
            btn_next.BackgroundImage = Properties.Resources.button_round22;
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_next.ForeColor = SystemColors.Window;
            btn_next.Location = new Point(562, 376);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(91, 37);
            btn_next.TabIndex = 338;
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
            btn_Back.Location = new Point(223, 376);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 337;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // tb_quantity
            // 
            tb_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_quantity.Location = new Point(642, 248);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(223, 34);
            tb_quantity.TabIndex = 336;
            tb_quantity.TabStop = false;
            // 
            // lb_quantity
            // 
            lb_quantity.AutoSize = true;
            lb_quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_quantity.Location = new Point(439, 251);
            lb_quantity.Name = "lb_quantity";
            lb_quantity.Size = new Size(197, 28);
            lb_quantity.TabIndex = 335;
            lb_quantity.Text = "Số lượng tuyển dụng";
            // 
            // tb_vacancy
            // 
            tb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_vacancy.Location = new Point(120, 248);
            tb_vacancy.Name = "tb_vacancy";
            tb_vacancy.Size = new Size(313, 34);
            tb_vacancy.TabIndex = 334;
            tb_vacancy.TabStop = false;
            // 
            // lb_vacancy
            // 
            lb_vacancy.AutoSize = true;
            lb_vacancy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_vacancy.Location = new Point(19, 251);
            lb_vacancy.Name = "lb_vacancy";
            lb_vacancy.Size = new Size(85, 28);
            lb_vacancy.TabIndex = 333;
            lb_vacancy.Text = "Tên vị trí";
            // 
            // dtGrid_jobList
            // 
            dtGrid_jobList.BackgroundColor = SystemColors.Control;
            dtGrid_jobList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_jobList.Location = new Point(29, 43);
            dtGrid_jobList.Name = "dtGrid_jobList";
            dtGrid_jobList.RowHeadersWidth = 51;
            dtGrid_jobList.Size = new Size(836, 194);
            dtGrid_jobList.TabIndex = 329;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.BackgroundImage = Properties.Resources.button_round22;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_add.ForeColor = SystemColors.Window;
            btn_add.Location = new Point(450, 376);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(91, 37);
            btn_add.TabIndex = 317;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.BackgroundImage = Properties.Resources.button_round22;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_delete.ForeColor = SystemColors.Window;
            btn_delete.Location = new Point(337, 376);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(91, 37);
            btn_delete.TabIndex = 316;
            btn_delete.Text = "Xoá";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // tb_criteria
            // 
            tb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_criteria.Location = new Point(120, 288);
            tb_criteria.Multiline = true;
            tb_criteria.Name = "tb_criteria";
            tb_criteria.Size = new Size(745, 82);
            tb_criteria.TabIndex = 339;
            tb_criteria.TabStop = false;
            // 
            // lb_criteria
            // 
            lb_criteria.AutoSize = true;
            lb_criteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_criteria.Location = new Point(19, 288);
            lb_criteria.Name = "lb_criteria";
            lb_criteria.Size = new Size(78, 28);
            lb_criteria.TabIndex = 340;
            lb_criteria.Text = "Tiêu chí";
            // 
            // P_AddRecruitmentJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            ControlBox = false;
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_AddRecruitmentJobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P_AddRecruitmentJobs";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid_jobList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lb_tittle;
        private Panel pn_parents;
        private DataGridView dtGrid_jobList;
        private TextBox tb_quantity;
        private Label lb_quantity;
        private TextBox tb_vacancy;
        private Label lb_vacancy;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_next;
        private Button btn_Back;
        private TextBox tb_criteria;
        private Label lb_criteria;
    }
}