namespace WindowsFormsApp1
{
    partial class assignCourier
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
            this.label2 = new System.Windows.Forms.Label();
            this.shipments_cmb = new System.Windows.Forms.ComboBox();
            this.courier_cmb = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the Shipment Id ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(297, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the Courier ";
            // 
            // shipments_cmb
            // 
            this.shipments_cmb.FormattingEnabled = true;
            this.shipments_cmb.Location = new System.Drawing.Point(35, 97);
            this.shipments_cmb.Name = "shipments_cmb";
            this.shipments_cmb.Size = new System.Drawing.Size(142, 21);
            this.shipments_cmb.TabIndex = 5;
            this.shipments_cmb.Text = "Select shipment ID";
            // 
            // courier_cmb
            // 
            this.courier_cmb.FormattingEnabled = true;
            this.courier_cmb.Location = new System.Drawing.Point(311, 97);
            this.courier_cmb.Name = "courier_cmb";
            this.courier_cmb.Size = new System.Drawing.Size(142, 21);
            this.courier_cmb.TabIndex = 6;
            this.courier_cmb.Text = "Select Courier";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAssign.Location = new System.Drawing.Point(177, 251);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(172, 40);
            this.btnAssign.TabIndex = 14;
            this.btnAssign.Text = "Assign Shipment";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click_1);
            // 
            // assignCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.courier_cmb);
            this.Controls.Add(this.shipments_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "assignCourier";
            this.Size = new System.Drawing.Size(597, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shipments_cmb;
        private System.Windows.Forms.ComboBox courier_cmb;
        private System.Windows.Forms.Button btnAssign;
    }
}
