namespace QuanLyNhanSu
{
    partial class ThanNhan1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TenNV = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.btTimTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // TenNV
            // 
            this.TenNV.Location = new System.Drawing.Point(464, 105);
            this.TenNV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(320, 34);
            this.TenNV.TabIndex = 2;
            // 
            // MaNV
            // 
            this.MaNV.Location = new System.Drawing.Point(464, 184);
            this.MaNV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(320, 34);
            this.MaNV.TabIndex = 3;
            // 
            // btTimTN
            // 
            this.btTimTN.Location = new System.Drawing.Point(1005, 91);
            this.btTimTN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btTimTN.Name = "btTimTN";
            this.btTimTN.Size = new System.Drawing.Size(351, 60);
            this.btTimTN.TabIndex = 4;
            this.btTimTN.Text = "Tìm thân nhân";
            this.btTimTN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm thân nhân";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1388, 276);
            this.dataGridView1.TabIndex = 6;
            // 
            // ThanNhan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1388, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTimTN);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ThanNhan1";
            this.Text = "Thân nhân";
            this.Load += new System.EventHandler(this.ThanNhan1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenNV;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.Button btTimTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

