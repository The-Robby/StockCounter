namespace StockCounter
{
    partial class UpdateConfirmationForm
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
            this.chkUpdateName = new System.Windows.Forms.CheckBox();
            this.chkUpdateHulpnummer = new System.Windows.Forms.CheckBox();
            this.chkUpdateType = new System.Windows.Forms.CheckBox();
            this.chkUpdateLeverancier = new System.Windows.Forms.CheckBox();
            this.chkUpdateStockCount = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkUpdateName
            // 
            this.chkUpdateName.AutoSize = true;
            this.chkUpdateName.Location = new System.Drawing.Point(88, 28);
            this.chkUpdateName.Name = "chkUpdateName";
            this.chkUpdateName.Size = new System.Drawing.Size(64, 20);
            this.chkUpdateName.TabIndex = 0;
            this.chkUpdateName.Text = "Name";
            this.chkUpdateName.UseVisualStyleBackColor = true;
            // 
            // chkUpdateHulpnummer
            // 
            this.chkUpdateHulpnummer.AutoSize = true;
            this.chkUpdateHulpnummer.Location = new System.Drawing.Point(88, 54);
            this.chkUpdateHulpnummer.Name = "chkUpdateHulpnummer";
            this.chkUpdateHulpnummer.Size = new System.Drawing.Size(103, 20);
            this.chkUpdateHulpnummer.TabIndex = 1;
            this.chkUpdateHulpnummer.Text = "Hulpnummer";
            this.chkUpdateHulpnummer.UseVisualStyleBackColor = true;
            // 
            // chkUpdateType
            // 
            this.chkUpdateType.AutoSize = true;
            this.chkUpdateType.Location = new System.Drawing.Point(88, 80);
            this.chkUpdateType.Name = "chkUpdateType";
            this.chkUpdateType.Size = new System.Drawing.Size(59, 20);
            this.chkUpdateType.TabIndex = 2;
            this.chkUpdateType.Text = "Type";
            this.chkUpdateType.UseVisualStyleBackColor = true;
            // 
            // chkUpdateLeverancier
            // 
            this.chkUpdateLeverancier.AutoSize = true;
            this.chkUpdateLeverancier.Location = new System.Drawing.Point(88, 106);
            this.chkUpdateLeverancier.Name = "chkUpdateLeverancier";
            this.chkUpdateLeverancier.Size = new System.Drawing.Size(98, 20);
            this.chkUpdateLeverancier.TabIndex = 3;
            this.chkUpdateLeverancier.Text = "Leverancier";
            this.chkUpdateLeverancier.UseVisualStyleBackColor = true;
            // 
            // chkUpdateStockCount
            // 
            this.chkUpdateStockCount.AutoSize = true;
            this.chkUpdateStockCount.Location = new System.Drawing.Point(88, 132);
            this.chkUpdateStockCount.Name = "chkUpdateStockCount";
            this.chkUpdateStockCount.Size = new System.Drawing.Size(95, 20);
            this.chkUpdateStockCount.TabIndex = 4;
            this.chkUpdateStockCount.Text = "StockCount";
            this.chkUpdateStockCount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check what you want to be updated:\r\n";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 37);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // UpdateConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 268);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkUpdateStockCount);
            this.Controls.Add(this.chkUpdateLeverancier);
            this.Controls.Add(this.chkUpdateType);
            this.Controls.Add(this.chkUpdateHulpnummer);
            this.Controls.Add(this.chkUpdateName);
            this.Name = "UpdateConfirmationForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUpdateName;
        private System.Windows.Forms.CheckBox chkUpdateHulpnummer;
        private System.Windows.Forms.CheckBox chkUpdateType;
        private System.Windows.Forms.CheckBox chkUpdateLeverancier;
        private System.Windows.Forms.CheckBox chkUpdateStockCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}