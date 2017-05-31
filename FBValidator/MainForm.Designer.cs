namespace FBValidator
{
    partial class MainForm
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(151, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Select FictionBook to validate:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(664, 22);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(745, 22);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 3;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(12, 57);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(62, 13);
            this.labelInformation.TabIndex = 4;
            this.labelInformation.Text = "Information:";
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(15, 73);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.Size = new System.Drawing.Size(805, 297);
            this.textBoxInformation.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 382);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInput);
            this.Name = "MainForm";
            this.Text = "FBValidator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.TextBox textBoxInformation;
    }
}

