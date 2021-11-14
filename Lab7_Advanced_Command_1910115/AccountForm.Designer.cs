
namespace Lab7_Advanced_Command_1910115
{
    partial class AccountForm
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
            this.components = new System.ComponentModel.Container();
            this.cbbShow = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowRoleAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiary = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbShow
            // 
            this.cbbShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShow.FormattingEnabled = true;
            this.cbbShow.Items.AddRange(new object[] {
            "Active",
            "UnActive"});
            this.cbbShow.Location = new System.Drawing.Point(97, 12);
            this.cbbShow.Name = "cbbShow";
            this.cbbShow.Size = new System.Drawing.Size(121, 24);
            this.cbbShow.TabIndex = 0;
            this.cbbShow.SelectedIndexChanged += new System.EventHandler(this.cbbShow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hiển thị :";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvAccount.Location = new System.Drawing.Point(0, 44);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(804, 408);
            this.dtgvAccount.TabIndex = 2;
            this.dtgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellContentClick);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(581, 3);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(101, 32);
            this.btnAddOrUpdate.TabIndex = 3;
            this.btnAddOrUpdate.Text = "Thêm mới";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(706, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowRoleAccount,
            this.tsmiDiary});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 52);
            // 
            // tsmiShowRoleAccount
            // 
            this.tsmiShowRoleAccount.Name = "tsmiShowRoleAccount";
            this.tsmiShowRoleAccount.Size = new System.Drawing.Size(250, 24);
            this.tsmiShowRoleAccount.Text = "Xem danh sách các vai trò";
            this.tsmiShowRoleAccount.Click += new System.EventHandler(this.tsmiShowRoleAccount_Click);
            // 
            // tsmiDiary
            // 
            this.tsmiDiary.Name = "tsmiDiary";
            this.tsmiDiary.Size = new System.Drawing.Size(250, 24);
            this.tsmiDiary.Text = "Xem nhật ký hoạt động";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbShow);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowRoleAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiary;
    }
}