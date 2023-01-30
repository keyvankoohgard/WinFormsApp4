namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.txtradius = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(550, 77);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(94, 79);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // txtradius
            // 
            this.txtradius.AutoSize = true;
            this.txtradius.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtradius.Location = new System.Drawing.Point(60, 50);
            this.txtradius.Name = "txtradius";
            this.txtradius.Size = new System.Drawing.Size(23, 31);
            this.txtradius.TabIndex = 1;
            this.txtradius.Text = "r";
            this.txtradius.Click += new System.EventHandler(this.label1_Click);
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(89, 56);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(125, 27);
            this.box.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box);
            this.Controls.Add(this.txtradius);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculate;
        private Label txtradius;
        private TextBox box;
    }
}