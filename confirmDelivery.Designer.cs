namespace WindowsFormsApp1
{
    partial class confirmDelivery
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShipmentID = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment ID";
            // 
            // cmbShipmentID
            // 
            this.cmbShipmentID.FormattingEnabled = true;
            this.cmbShipmentID.Location = new System.Drawing.Point(280, 186);
            this.cmbShipmentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbShipmentID.Name = "cmbShipmentID";
            this.cmbShipmentID.Size = new System.Drawing.Size(187, 24);
            this.cmbShipmentID.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(247, 297);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 41);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Delivered";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(31, 411);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 65);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // confirmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbShipmentID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "confirmDelivery";
            this.Size = new System.Drawing.Size(645, 492);
            this.Load += new System.EventHandler(this.confirmDelivery_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShipmentID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button back_button;
    }
}
