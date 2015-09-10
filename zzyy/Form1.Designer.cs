namespace zzyy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.医嘱系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.医嘱修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病历系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_inpNo = new System.Windows.Forms.TextBox();
            this.lbl_zyh = new System.Windows.Forms.Label();
            this.lbl_val_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_val_sex = new System.Windows.Forms.Label();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_val_dept = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lbl_bedNo = new System.Windows.Forms.Label();
            this.lbl_val_bedNo = new System.Windows.Forms.Label();
            this.lbl_admissTimes = new System.Windows.Forms.Label();
            this.tb_admissTimes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.order_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.long_once_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effective_time_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_qry = new System.Windows.Forms.Button();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_once = new System.Windows.Forms.RadioButton();
            this.rb_long = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearOrderPrint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.医嘱系统ToolStripMenuItem,
            this.病历系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 医嘱系统ToolStripMenuItem
            // 
            this.医嘱系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.医嘱修改ToolStripMenuItem,
            this.费用删除ToolStripMenuItem});
            this.医嘱系统ToolStripMenuItem.Name = "医嘱系统ToolStripMenuItem";
            this.医嘱系统ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.医嘱系统ToolStripMenuItem.Text = "医嘱系统";
            // 
            // 医嘱修改ToolStripMenuItem
            // 
            this.医嘱修改ToolStripMenuItem.Name = "医嘱修改ToolStripMenuItem";
            this.医嘱修改ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.医嘱修改ToolStripMenuItem.Text = "病人信息修改";
            this.医嘱修改ToolStripMenuItem.Click += new System.EventHandler(this.医嘱修改ToolStripMenuItem_Click);
            // 
            // 费用删除ToolStripMenuItem
            // 
            this.费用删除ToolStripMenuItem.Name = "费用删除ToolStripMenuItem";
            this.费用删除ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.费用删除ToolStripMenuItem.Text = "费用删除";
            this.费用删除ToolStripMenuItem.Click += new System.EventHandler(this.费用删除ToolStripMenuItem_Click);
            // 
            // 病历系统ToolStripMenuItem
            // 
            this.病历系统ToolStripMenuItem.Name = "病历系统ToolStripMenuItem";
            this.病历系统ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.病历系统ToolStripMenuItem.Text = "病历系统";
            // 
            // txt_inpNo
            // 
            this.txt_inpNo.Location = new System.Drawing.Point(57, 27);
            this.txt_inpNo.Name = "txt_inpNo";
            this.txt_inpNo.Size = new System.Drawing.Size(100, 21);
            this.txt_inpNo.TabIndex = 1;
            // 
            // lbl_zyh
            // 
            this.lbl_zyh.AutoSize = true;
            this.lbl_zyh.Location = new System.Drawing.Point(13, 32);
            this.lbl_zyh.Name = "lbl_zyh";
            this.lbl_zyh.Size = new System.Drawing.Size(41, 12);
            this.lbl_zyh.TabIndex = 2;
            this.lbl_zyh.Text = "住院号";
            // 
            // lbl_val_name
            // 
            this.lbl_val_name.AutoSize = true;
            this.lbl_val_name.Location = new System.Drawing.Point(115, 55);
            this.lbl_val_name.Name = "lbl_val_name";
            this.lbl_val_name.Size = new System.Drawing.Size(0, 12);
            this.lbl_val_name.TabIndex = 4;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(194, 55);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(29, 12);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "性别";
            // 
            // lbl_val_sex
            // 
            this.lbl_val_sex.AutoSize = true;
            this.lbl_val_sex.Location = new System.Drawing.Point(241, 55);
            this.lbl_val_sex.Name = "lbl_val_sex";
            this.lbl_val_sex.Size = new System.Drawing.Size(41, 12);
            this.lbl_val_sex.TabIndex = 6;
            this.lbl_val_sex.Text = "label5";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.Location = new System.Drawing.Point(304, 55);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(41, 12);
            this.lbl_dept.TabIndex = 7;
            this.lbl_dept.Text = "科室：";
            // 
            // lbl_val_dept
            // 
            this.lbl_val_dept.AutoSize = true;
            this.lbl_val_dept.Location = new System.Drawing.Point(363, 55);
            this.lbl_val_dept.Name = "lbl_val_dept";
            this.lbl_val_dept.Size = new System.Drawing.Size(41, 12);
            this.lbl_val_dept.TabIndex = 8;
            this.lbl_val_dept.Text = "label7";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(43, 55);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(29, 12);
            this.lbl_.TabIndex = 9;
            this.lbl_.Text = "姓名";
            // 
            // lbl_bedNo
            // 
            this.lbl_bedNo.AutoSize = true;
            this.lbl_bedNo.Location = new System.Drawing.Point(424, 55);
            this.lbl_bedNo.Name = "lbl_bedNo";
            this.lbl_bedNo.Size = new System.Drawing.Size(41, 12);
            this.lbl_bedNo.TabIndex = 10;
            this.lbl_bedNo.Text = "床号：";
            // 
            // lbl_val_bedNo
            // 
            this.lbl_val_bedNo.AutoSize = true;
            this.lbl_val_bedNo.Location = new System.Drawing.Point(498, 55);
            this.lbl_val_bedNo.Name = "lbl_val_bedNo";
            this.lbl_val_bedNo.Size = new System.Drawing.Size(29, 12);
            this.lbl_val_bedNo.TabIndex = 11;
            this.lbl_val_bedNo.Text = "床号";
            // 
            // lbl_admissTimes
            // 
            this.lbl_admissTimes.AutoSize = true;
            this.lbl_admissTimes.Location = new System.Drawing.Point(166, 32);
            this.lbl_admissTimes.Name = "lbl_admissTimes";
            this.lbl_admissTimes.Size = new System.Drawing.Size(53, 12);
            this.lbl_admissTimes.TabIndex = 13;
            this.lbl_admissTimes.Text = "住院次数";
            // 
            // tb_admissTimes
            // 
            this.tb_admissTimes.Location = new System.Drawing.Point(222, 27);
            this.tb_admissTimes.Name = "tb_admissTimes";
            this.tb_admissTimes.Size = new System.Drawing.Size(41, 21);
            this.tb_admissTimes.TabIndex = 12;
            this.tb_admissTimes.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.order_sn,
            this.order_name,
            this.long_once_flag,
            this.effective_time_b,
            this.stop_time,
            this.order_status,
            this.doc_note});
            this.dataGridView1.Location = new System.Drawing.Point(15, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(956, 285);
            this.dataGridView1.TabIndex = 14;
            // 
            // colCheckBox
            // 
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            // 
            // order_sn
            // 
            this.order_sn.HeaderText = "医嘱号";
            this.order_sn.Name = "order_sn";
            this.order_sn.ReadOnly = true;
            // 
            // order_name
            // 
            this.order_name.HeaderText = "医嘱名";
            this.order_name.Name = "order_name";
            // 
            // long_once_flag
            // 
            this.long_once_flag.HeaderText = "长临标示";
            this.long_once_flag.Name = "long_once_flag";
            this.long_once_flag.ReadOnly = true;
            // 
            // effective_time_b
            // 
            dataGridViewCellStyle15.Format = "yyyy-MM-dd HH:mm:ss ";
            this.effective_time_b.DefaultCellStyle = dataGridViewCellStyle15;
            this.effective_time_b.HeaderText = "开始时间";
            this.effective_time_b.Name = "effective_time_b";
            // 
            // stop_time
            // 
            dataGridViewCellStyle16.Format = "yyyy-MM-dd HH:mm:ss ";
            this.stop_time.DefaultCellStyle = dataGridViewCellStyle16;
            this.stop_time.HeaderText = "停止时间";
            this.stop_time.Name = "stop_time";
            // 
            // order_status
            // 
            this.order_status.HeaderText = "医嘱状态";
            this.order_status.Name = "order_status";
            this.order_status.ReadOnly = true;
            // 
            // doc_note
            // 
            this.doc_note.HeaderText = "嘱托";
            this.doc_note.Name = "doc_note";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(344, 72);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(450, 72);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "保存";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_qry
            // 
            this.btn_qry.Location = new System.Drawing.Point(285, 25);
            this.btn_qry.Name = "btn_qry";
            this.btn_qry.Size = new System.Drawing.Size(75, 23);
            this.btn_qry.TabIndex = 20;
            this.btn_qry.Text = "查询";
            this.btn_qry.UseVisualStyleBackColor = true;
            this.btn_qry.Click += new System.EventHandler(this.btn_qry_Click);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(19, 4);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(71, 16);
            this.rb_all.TabIndex = 21;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "全部医嘱";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // rb_once
            // 
            this.rb_once.AutoSize = true;
            this.rb_once.Location = new System.Drawing.Point(160, 3);
            this.rb_once.Name = "rb_once";
            this.rb_once.Size = new System.Drawing.Size(71, 16);
            this.rb_once.TabIndex = 23;
            this.rb_once.Text = "临时医嘱";
            this.rb_once.UseVisualStyleBackColor = true;
            this.rb_once.CheckedChanged += new System.EventHandler(this.rb_once_CheckedChanged);
            // 
            // rb_long
            // 
            this.rb_long.AutoSize = true;
            this.rb_long.Location = new System.Drawing.Point(91, 3);
            this.rb_long.Name = "rb_long";
            this.rb_long.Size = new System.Drawing.Size(71, 16);
            this.rb_long.TabIndex = 22;
            this.rb_long.Text = "长期医嘱";
            this.rb_long.UseVisualStyleBackColor = true;
            this.rb_long.CheckedChanged += new System.EventHandler(this.rb_long_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_once);
            this.panel1.Controls.Add(this.rb_long);
            this.panel1.Controls.Add(this.rb_all);
            this.panel1.Location = new System.Drawing.Point(44, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 26);
            this.panel1.TabIndex = 23;
            // 
            // btn_clearOrderPrint
            // 
            this.btn_clearOrderPrint.Enabled = false;
            this.btn_clearOrderPrint.Location = new System.Drawing.Point(565, 72);
            this.btn_clearOrderPrint.Name = "btn_clearOrderPrint";
            this.btn_clearOrderPrint.Size = new System.Drawing.Size(75, 23);
            this.btn_clearOrderPrint.TabIndex = 24;
            this.btn_clearOrderPrint.Text = "医嘱单清空";
            this.btn_clearOrderPrint.UseVisualStyleBackColor = true;
            this.btn_clearOrderPrint.Click += new System.EventHandler(this.btn_clearOrderPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 420);
            this.Controls.Add(this.btn_clearOrderPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_qry);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_admissTimes);
            this.Controls.Add(this.tb_admissTimes);
            this.Controls.Add(this.lbl_val_bedNo);
            this.Controls.Add(this.lbl_bedNo);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lbl_val_dept);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.lbl_val_sex);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.lbl_val_name);
            this.Controls.Add(this.lbl_zyh);
            this.Controls.Add(this.txt_inpNo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 医嘱系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 医嘱修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病历系统ToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_inpNo;
        private System.Windows.Forms.Label lbl_zyh;
        private System.Windows.Forms.Label lbl_val_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_val_sex;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.Label lbl_val_dept;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lbl_bedNo;
        private System.Windows.Forms.Label lbl_val_bedNo;
        private System.Windows.Forms.Label lbl_admissTimes;
        private System.Windows.Forms.TextBox tb_admissTimes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn long_once_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn effective_time_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn stop_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_note;
        private System.Windows.Forms.ToolStripMenuItem 费用删除ToolStripMenuItem;
        private System.Windows.Forms.Button btn_qry;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_once;
        private System.Windows.Forms.RadioButton rb_long;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clearOrderPrint;
    }
}

