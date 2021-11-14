
namespace Lab7_Advanced_Command_1910115
{
    partial class AddNewRoleAccount
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
            this.txtAccountNa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMS = new System.Windows.Forms.ComboBox();
            this.P = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbbActived = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAccountNa
            // 
            this.txtAccountNa.Enabled = false;
            this.txtAccountNa.Location = new System.Drawing.Point(114, 59);
            this.txtAccountNa.Name = "txtAccountNa";
            this.txtAccountNa.Size = new System.Drawing.Size(163, 22);
            this.txtAccountNa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã vai trò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản";
            // 
            // cbbMS
            // 
            this.cbbMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMS.FormattingEnabled = true;
            this.cbbMS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbMS.Location = new System.Drawing.Point(114, 21);
            this.cbbMS.Name = "cbbMS";
            this.cbbMS.Size = new System.Drawing.Size(163, 24);
            this.cbbMS.TabIndex = 3;
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(330, 21);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(89, 17);
            this.P.TabIndex = 4;
            this.P.Text = "Kích hoạt TK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghi chú";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(432, 64);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(172, 22);
            this.txtNotes.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "AddNew";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbbActived
            // 
            this.cbbActived.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbActived.FormattingEnabled = true;
            this.cbbActived.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbActived.Location = new System.Drawing.Point(432, 18);
            this.cbbActived.Name = "cbbActived";
            this.cbbActived.Size = new System.Drawing.Size(172, 24);
            this.cbbActived.TabIndex = 10;
            // 
            // AddNewRoleAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 175);
            this.Controls.Add(this.cbbActived);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.P);
            this.Controls.Add(this.cbbMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNa);
            this.Name = "AddNewRoleAccount";
            this.Text = "AddNewRoleAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMS;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbActived;
    }
}