namespace WindowsFormsApp1
{
    partial class myShipments
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
            this.myShipments_dgv = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myShipments_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // myShipments_dgv
            // 
            this.myShipments_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myShipments_dgv.Location = new System.Drawing.Point(21, 84);
            this.myShipments_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myShipments_dgv.Name = "myShipments_dgv";
            this.myShipments_dgv.RowHeadersWidth = 51;
            this.myShipments_dgv.Size = new System.Drawing.Size(569, 351);
            this.myShipments_dgv.TabIndex = 0;
            this.myShipments_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myShipments_dgv_CellContentClick);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(211, 454);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(137, 59);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // myShipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.myShipments_dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "myShipments";
            this.Size = new System.Drawing.Size(621, 526);
            this.Load += new System.EventHandler(this.myShipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myShipments_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myShipments_dgv;
        private System.Windows.Forms.Button back_button;
    }
}
