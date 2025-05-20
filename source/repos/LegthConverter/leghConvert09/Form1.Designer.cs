namespace AreaConverter
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(33, 103);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(150, 103);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(120, 24);
            this.cmbFrom.TabIndex = 1;
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(290, 103);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(120, 24);
            this.cmbTo.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(30, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(380, 30);
            this.lblResult.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(150, 156);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 30);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "แปลงหน่วย";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "เครื่องแปลงหน่วยพื้นที่";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "เครื่องแปลงหน่วยพื้นที่";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
    }
}