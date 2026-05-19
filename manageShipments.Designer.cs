namespace WindowsFormsApp1
{
    partial class manageShipments
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
            this.dataGridShipments = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShipments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShipments
            // 
            this.dataGridShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShipments.Location = new System.Drawing.Point(127, 22);
            this.dataGridShipments.Name = "dataGridShipments";
            this.dataGridShipments.RowHeadersWidth = 51;
            this.dataGridShipments.RowTemplate.Height = 24;
            this.dataGridShipments.Size = new System.Drawing.Size(474, 304);
            this.dataGridShipments.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(306, 390);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(102, 41);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // manageShipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridShipments);
            this.Name = "manageShipments";
            this.Size = new System.Drawing.Size(747, 471);
            this.Load += new System.EventHandler(this.manageShipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShipments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShipments;
        private System.Windows.Forms.Button save_btn;
    }
}
