namespace WindowsFormsApp1
{
    partial class Admin_Form
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.track_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSidebar.Controls.Add(this.tableLayoutPanel1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 714);
            this.panelSidebar.TabIndex = 2;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.back_button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cancel_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.track_btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.create_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 714);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(3, 289);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(194, 137);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel Shipment";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // track_btn
            // 
            this.track_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.track_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_btn.FlatAppearance.BorderSize = 0;
            this.track_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.track_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.track_btn.Location = new System.Drawing.Point(3, 146);
            this.track_btn.Name = "track_btn";
            this.track_btn.Size = new System.Drawing.Size(194, 137);
            this.track_btn.TabIndex = 1;
            this.track_btn.Text = "Track Shipment";
            this.track_btn.UseVisualStyleBackColor = false;
            this.track_btn.Click += new System.EventHandler(this.track_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.create_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_btn.FlatAppearance.BorderSize = 0;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create_btn.Location = new System.Drawing.Point(3, 3);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(194, 137);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "Create Shipment";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 137);
            this.button1.TabIndex = 3;
            this.button1.Text = "report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(778, 714);
            this.panelContent.TabIndex = 3;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_button.Location = new System.Drawing.Point(3, 575);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(194, 136);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 714);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Admin_Form";
            this.panelSidebar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button track_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_button;
    }
}