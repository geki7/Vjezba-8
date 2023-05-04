
namespace ADO_Titles
{
    partial class FrmTitles
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
            this.dgvTitles = new System.Windows.Forms.DataGridView();
            this.btnAddTitle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTitles
            // 
            this.dgvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitles.Location = new System.Drawing.Point(12, 12);
            this.dgvTitles.Name = "dgvTitles";
            this.dgvTitles.Size = new System.Drawing.Size(616, 186);
            this.dgvTitles.TabIndex = 0;
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Location = new System.Drawing.Point(531, 206);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(97, 23);
            this.btnAddTitle.TabIndex = 1;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.btnAddTitle_Click);
            // 
            // FrmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 241);
            this.Controls.Add(this.btnAddTitle);
            this.Controls.Add(this.dgvTitles);
            this.Name = "FrmTitles";
            this.Text = "Titles";
            this.Load += new System.EventHandler(this.FrmTitles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTitles;
        private System.Windows.Forms.Button btnAddTitle;
    }
}

