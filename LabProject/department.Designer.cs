namespace LabProject
{
    partial class department
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຂມນພນຖານToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ພະນກງານToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ສາຂາToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຕຳແໜງToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ວດທການສສາToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ເງນເດອນToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ເງນເດອນພນຖານToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຄດລເງນເດອນToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຜໃຊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ສາງToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຜໃຊToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ການຕດຕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຕດຕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 37);
            this.button5.TabIndex = 3;
            this.button5.Text = "Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "ADMINSTATIVE",
            "FINANCIAL",
            "IT",
            "DESIGNING"});
            this.cb2.Location = new System.Drawing.Point(63, 266);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(302, 44);
            this.cb2.TabIndex = 2;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "ພະແນກບໍລິຫານ",
            "ພະແນກການເງິນ",
            "ພະແນກໄອທີ",
            "ພະແນກດີໄຊຼ໌"});
            this.cb1.Location = new System.Drawing.Point(63, 173);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(302, 44);
            this.cb1.TabIndex = 2;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department Name ENGLISH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name LAO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 53);
            this.button3.TabIndex = 0;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Saysettha OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.ຂມນພນຖານToolStripMenuItem,
            this.ເງນເດອນToolStripMenuItem,
            this.ຜໃຊToolStripMenuItem,
            this.ການຕດຕToolStripMenuItem,
            this.ຕດຕToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(524, 46);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(80, 38);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // ຂມນພນຖານToolStripMenuItem
            // 
            this.ຂມນພນຖານToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ພະນກງານToolStripMenuItem,
            this.ສາຂາToolStripMenuItem,
            this.ຕຳແໜງToolStripMenuItem,
            this.ວດທການສສາToolStripMenuItem});
            this.ຂມນພນຖານToolStripMenuItem.Name = "ຂມນພນຖານToolStripMenuItem";
            this.ຂມນພນຖານToolStripMenuItem.Size = new System.Drawing.Size(121, 38);
            this.ຂມນພນຖານToolStripMenuItem.Text = "ຂໍ້ມຸນພຶ້ນຖານ";
            // 
            // ພະນກງານToolStripMenuItem
            // 
            this.ພະນກງານToolStripMenuItem.Name = "ພະນກງານToolStripMenuItem";
            this.ພະນກງານToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.ພະນກງານToolStripMenuItem.Text = "ພະນັກງານ";
            // 
            // ສາຂາToolStripMenuItem
            // 
            this.ສາຂາToolStripMenuItem.Name = "ສາຂາToolStripMenuItem";
            this.ສາຂາToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.ສາຂາToolStripMenuItem.Text = "ສາຂາ";
            this.ສາຂາToolStripMenuItem.Click += new System.EventHandler(this.ສາຂາToolStripMenuItem_Click);
            // 
            // ຕຳແໜງToolStripMenuItem
            // 
            this.ຕຳແໜງToolStripMenuItem.Name = "ຕຳແໜງToolStripMenuItem";
            this.ຕຳແໜງToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.ຕຳແໜງToolStripMenuItem.Text = "ຕຳແໜ່ງ";
            // 
            // ວດທການສສາToolStripMenuItem
            // 
            this.ວດທການສສາToolStripMenuItem.Name = "ວດທການສສາToolStripMenuItem";
            this.ວດທການສສາToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.ວດທການສສາToolStripMenuItem.Text = "ວຸດທິການສືກສາ";
            // 
            // ເງນເດອນToolStripMenuItem
            // 
            this.ເງນເດອນToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ເງນເດອນພນຖານToolStripMenuItem,
            this.ຄດລເງນເດອນToolStripMenuItem});
            this.ເງນເດອນToolStripMenuItem.Name = "ເງນເດອນToolStripMenuItem";
            this.ເງນເດອນToolStripMenuItem.Size = new System.Drawing.Size(101, 38);
            this.ເງນເດອນToolStripMenuItem.Text = "ເງິິນເດຶອນ";
            // 
            // ເງນເດອນພນຖານToolStripMenuItem
            // 
            this.ເງນເດອນພນຖານToolStripMenuItem.Name = "ເງນເດອນພນຖານToolStripMenuItem";
            this.ເງນເດອນພນຖານToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.ເງນເດອນພນຖານToolStripMenuItem.Text = "ເງິນເດືອນພື້ນຖານ";
            // 
            // ຄດລເງນເດອນToolStripMenuItem
            // 
            this.ຄດລເງນເດອນToolStripMenuItem.Name = "ຄດລເງນເດອນToolStripMenuItem";
            this.ຄດລເງນເດອນToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.ຄດລເງນເດອນToolStripMenuItem.Text = "ຄິດໄລ່ເງິນເດືອນ";
            // 
            // ຜໃຊToolStripMenuItem
            // 
            this.ຜໃຊToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ສາງToolStripMenuItem,
            this.ຜໃຊToolStripMenuItem1});
            this.ຜໃຊToolStripMenuItem.Name = "ຜໃຊToolStripMenuItem";
            this.ຜໃຊToolStripMenuItem.Size = new System.Drawing.Size(61, 38);
            this.ຜໃຊToolStripMenuItem.Text = "ຜູ້ໃຊ້";
            // 
            // ສາງToolStripMenuItem
            // 
            this.ສາງToolStripMenuItem.Name = "ສາງToolStripMenuItem";
            this.ສາງToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.ສາງToolStripMenuItem.Text = "ສ້າງ account";
            // 
            // ຜໃຊToolStripMenuItem1
            // 
            this.ຜໃຊToolStripMenuItem1.Name = "ຜໃຊToolStripMenuItem1";
            this.ຜໃຊToolStripMenuItem1.Size = new System.Drawing.Size(212, 38);
            this.ຜໃຊToolStripMenuItem1.Text = "ຜູ້ໃຊ້";
            // 
            // ການຕດຕToolStripMenuItem
            // 
            this.ການຕດຕToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkinoutToolStripMenuItem});
            this.ການຕດຕToolStripMenuItem.Name = "ການຕດຕToolStripMenuItem";
            this.ການຕດຕToolStripMenuItem.Size = new System.Drawing.Size(119, 38);
            this.ການຕດຕToolStripMenuItem.Text = "ການເຂົ້າວຽກ";
            // 
            // checkinoutToolStripMenuItem
            // 
            this.checkinoutToolStripMenuItem.Name = "checkinoutToolStripMenuItem";
            this.checkinoutToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.checkinoutToolStripMenuItem.Text = "check-in-out";
            // 
            // ຕດຕToolStripMenuItem
            // 
            this.ຕດຕToolStripMenuItem.Name = "ຕດຕToolStripMenuItem";
            this.ຕດຕToolStripMenuItem.Size = new System.Drawing.Size(65, 38);
            this.ຕດຕToolStripMenuItem.Text = "ຕິດຕໍ່";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 176);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(524, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "department";
            this.Load += new System.EventHandler(this.department_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຂມນພນຖານToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ພະນກງານToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ສາຂາToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຕຳແໜງToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ວດທການສສາToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ເງນເດອນToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ເງນເດອນພນຖານToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຄດລເງນເດອນToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຜໃຊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ສາງToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຜໃຊToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ການຕດຕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຕດຕToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
    }
}