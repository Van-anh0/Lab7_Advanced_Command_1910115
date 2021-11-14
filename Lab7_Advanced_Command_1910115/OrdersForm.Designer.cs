
namespace Lab7_Advanced_Command_1910115
{
    partial class OrdersForm
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
            this.dtpHD = new System.Windows.Forms.DateTimePicker();
            this.dtgHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHD
            // 
            this.dtpHD.CustomFormat = "dd/MM/yyyy";
            this.dtpHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHD.Location = new System.Drawing.Point(144, 17);
            this.dtpHD.Name = "dtpHD";
            this.dtpHD.Size = new System.Drawing.Size(112, 22);
            this.dtpHD.TabIndex = 0;
            this.dtpHD.Value = new System.DateTime(2019, 8, 12, 20, 14, 0, 0);
            this.dtpHD.ValueChanged += new System.EventHandler(this.dtpHD_ValueChanged);
            // 
            // dtgHD
            // 
            this.dtgHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHD.Location = new System.Drawing.Point(0, 50);
            this.dtgHD.Name = "dtgHD";
            this.dtgHD.RowHeadersWidth = 51;
            this.dtgHD.RowTemplate.Height = 24;
            this.dtgHD.Size = new System.Drawing.Size(804, 407);
            this.dtgHD.TabIndex = 1;
            this.dtgHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHD_CellContentClick);
            this.dtgHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHD_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hóa đơn ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(582, 17);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(32, 17);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "VNĐ";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgHD);
            this.Controls.Add(this.dtpHD);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHD;
        private System.Windows.Forms.DataGridView dtgHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label3;
    }
}