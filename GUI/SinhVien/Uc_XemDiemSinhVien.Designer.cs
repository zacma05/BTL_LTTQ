namespace BTL_LTTQ.GUI.SinhVien
{
    partial class Uc_XemDiemSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lBIntro = new System.Windows.Forms.Label();
            this.lBMaSinhVien = new System.Windows.Forms.Label();
            this.lBTenSinhVien = new System.Windows.Forms.Label();
            this.lBTimKiem = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lBIntro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lBTenSinhVien);
            this.panel2.Controls.Add(this.lBMaSinhVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 458);
            this.panel2.TabIndex = 1;
            // 
            // lBIntro
            // 
            this.lBIntro.AutoSize = true;
            this.lBIntro.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBIntro.Location = new System.Drawing.Point(378, 19);
            this.lBIntro.Name = "lBIntro";
            this.lBIntro.Size = new System.Drawing.Size(171, 31);
            this.lBIntro.TabIndex = 0;
            this.lBIntro.Text = "Điểm học phần";
            // 
            // lBMaSinhVien
            // 
            this.lBMaSinhVien.AutoSize = true;
            this.lBMaSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBMaSinhVien.Location = new System.Drawing.Point(84, 31);
            this.lBMaSinhVien.Name = "lBMaSinhVien";
            this.lBMaSinhVien.Size = new System.Drawing.Size(88, 17);
            this.lBMaSinhVien.TabIndex = 0;
            this.lBMaSinhVien.Text = "Mã sinh viên:";
            // 
            // lBTenSinhVien
            // 
            this.lBTenSinhVien.AutoSize = true;
            this.lBTenSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBTenSinhVien.Location = new System.Drawing.Point(487, 31);
            this.lBTenSinhVien.Name = "lBTenSinhVien";
            this.lBTenSinhVien.Size = new System.Drawing.Size(90, 17);
            this.lBTenSinhVien.TabIndex = 1;
            this.lBTenSinhVien.Text = "Tên sinh viên:";
            // 
            // lBTimKiem
            // 
            this.lBTimKiem.AutoSize = true;
            this.lBTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBTimKiem.Location = new System.Drawing.Point(23, 19);
            this.lBTimKiem.Name = "lBTimKiem";
            this.lBTimKiem.Size = new System.Drawing.Size(66, 17);
            this.lBTimKiem.TabIndex = 2;
            this.lBTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(236, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTimKiem.Location = new System.Drawing.Point(109, 17);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(100, 25);
            this.tBTimKiem.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sinh viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 376);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc kết quả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 352);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tBTimKiem);
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.lBTimKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 100);
            this.panel3.TabIndex = 6;
            // 
            // Uc_XemDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_XemDiemSinhVien";
            this.Size = new System.Drawing.Size(935, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lBIntro;
        private System.Windows.Forms.Label lBTimKiem;
        private System.Windows.Forms.Label lBTenSinhVien;
        private System.Windows.Forms.Label lBMaSinhVien;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
