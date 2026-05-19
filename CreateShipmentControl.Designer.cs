namespace WindowsFormsApp1
{
    partial class CreateShipmentControl
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Recievername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.final_price_box = new System.Windows.Forms.TextBox();
            this.discountcode_box = new System.Windows.Forms.ComboBox();
            this.calculate_price = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_btn.Location = new System.Drawing.Point(388, 347);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(102, 41);
            this.Save_btn.TabIndex = 12;
            this.Save_btn.Text = "pay";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Recievername
            // 
            this.Recievername.Location = new System.Drawing.Point(251, 40);
            this.Recievername.Name = "Recievername";
            this.Recievername.Size = new System.Drawing.Size(206, 22);
            this.Recievername.TabIndex = 14;
            this.Recievername.TextChanged += new System.EventHandler(this.Recievername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reciever Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Package Details";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Discount_code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Final_price";
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(286, 154);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(84, 22);
            this.price_box.TabIndex = 20;
            this.price_box.TextChanged += new System.EventHandler(this.price_box_TextChanged);
            // 
            // final_price_box
            // 
            this.final_price_box.Location = new System.Drawing.Point(241, 248);
            this.final_price_box.Name = "final_price_box";
            this.final_price_box.Size = new System.Drawing.Size(206, 22);
            this.final_price_box.TabIndex = 21;
            this.final_price_box.TextChanged += new System.EventHandler(this.final_price_box_TextChanged);
            // 
            // discountcode_box
            // 
            this.discountcode_box.FormattingEnabled = true;
            this.discountcode_box.Location = new System.Drawing.Point(274, 210);
            this.discountcode_box.Name = "discountcode_box";
            this.discountcode_box.Size = new System.Drawing.Size(121, 24);
            this.discountcode_box.TabIndex = 22;
            this.discountcode_box.SelectedIndexChanged += new System.EventHandler(this.discountcode_box_SelectedIndexChanged);
            // 
            // calculate_price
            // 
            this.calculate_price.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculate_price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.calculate_price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculate_price.Location = new System.Drawing.Point(113, 347);
            this.calculate_price.Name = "calculate_price";
            this.calculate_price.Size = new System.Drawing.Size(102, 41);
            this.calculate_price.TabIndex = 23;
            this.calculate_price.Text = "Calculate";
            this.calculate_price.UseVisualStyleBackColor = false;
            this.calculate_price.Click += new System.EventHandler(this.calculate_price_Click);
            // 
            // CreateShipmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calculate_price);
            this.Controls.Add(this.discountcode_box);
            this.Controls.Add(this.final_price_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Recievername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_btn);
            this.Name = "CreateShipmentControl";
            this.Size = new System.Drawing.Size(669, 444);
            this.Load += new System.EventHandler(this.CreateShipmentControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Recievername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox final_price_box;
        private System.Windows.Forms.ComboBox discountcode_box;
        private System.Windows.Forms.Button calculate_price;
    }
}
