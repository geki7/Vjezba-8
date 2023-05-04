
namespace ADO_Products
{
    partial class FrmUpdateUnitPrice
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
            this.txtOldUnitPrice = new System.Windows.Forms.TextBox();
            this.txtNewUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Unit Price:";
            // 
            // txtOldUnitPrice
            // 
            this.txtOldUnitPrice.Location = new System.Drawing.Point(100, 21);
            this.txtOldUnitPrice.Name = "txtOldUnitPrice";
            this.txtOldUnitPrice.ReadOnly = true;
            this.txtOldUnitPrice.Size = new System.Drawing.Size(156, 20);
            this.txtOldUnitPrice.TabIndex = 1;
            // 
            // txtNewUnitPrice
            // 
            this.txtNewUnitPrice.Location = new System.Drawing.Point(100, 47);
            this.txtNewUnitPrice.Name = "txtNewUnitPrice";
            this.txtNewUnitPrice.Size = new System.Drawing.Size(156, 20);
            this.txtNewUnitPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Unit Price:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmUpdateUnitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 110);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewUnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldUnitPrice);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateUnitPrice";
            this.Text = "Update Unit Price";
            this.Load += new System.EventHandler(this.FrmUpdateUnitPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldUnitPrice;
        private System.Windows.Forms.TextBox txtNewUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}