namespace OrganizationProfile
{
    partial class FrmStudentRecord
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
            this.lvViewRecord = new System.Windows.Forms.ListView();
            this.btnRegisterReturn = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Record";
            // 
            // lvViewRecord
            // 
            this.lvViewRecord.HideSelection = false;
            this.lvViewRecord.Location = new System.Drawing.Point(17, 50);
            this.lvViewRecord.Name = "lvViewRecord";
            this.lvViewRecord.Size = new System.Drawing.Size(621, 282);
            this.lvViewRecord.TabIndex = 1;
            this.lvViewRecord.UseCompatibleStateImageBehavior = false;
            this.lvViewRecord.View = System.Windows.Forms.View.List;
            // 
            // btnRegisterReturn
            // 
            this.btnRegisterReturn.Location = new System.Drawing.Point(644, 50);
            this.btnRegisterReturn.Name = "btnRegisterReturn";
            this.btnRegisterReturn.Size = new System.Drawing.Size(129, 47);
            this.btnRegisterReturn.TabIndex = 2;
            this.btnRegisterReturn.Text = "Register";
            this.btnRegisterReturn.UseVisualStyleBackColor = true;
            this.btnRegisterReturn.Click += new System.EventHandler(this.btnRegisterReturn_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(644, 156);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(129, 47);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(644, 103);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(129, 47);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 354);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnRegisterReturn);
            this.Controls.Add(this.lvViewRecord);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvViewRecord;
        private System.Windows.Forms.Button btnRegisterReturn;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}