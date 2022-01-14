namespace Compiler
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
            this.input_txt = new System.Windows.Forms.TextBox();
            this.output_txt = new System.Windows.Forms.TextBox();
            this.token = new System.Windows.Forms.Button();
            this.output_l_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(12, 12);
            this.input_txt.Multiline = true;
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(778, 118);
            this.input_txt.TabIndex = 0;
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(13, 136);
            this.output_txt.Multiline = true;
            this.output_txt.Name = "output_txt";
            this.output_txt.Size = new System.Drawing.Size(380, 334);
            this.output_txt.TabIndex = 1;
            // 
            // token
            // 
            this.token.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.token.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token.Location = new System.Drawing.Point(13, 493);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(380, 49);
            this.token.TabIndex = 2;
            this.token.Text = "Scan";
            this.token.UseVisualStyleBackColor = false;
            this.token.Click += new System.EventHandler(this.token_Click);
            // 
            // output_l_text
            // 
            this.output_l_text.Location = new System.Drawing.Point(412, 136);
            this.output_l_text.Multiline = true;
            this.output_l_text.Name = "output_l_text";
            this.output_l_text.Size = new System.Drawing.Size(378, 334);
            this.output_l_text.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(428, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output_l_text);
            this.Controls.Add(this.token);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.input_txt);
            this.Name = "Form1";
            this.Text = "Arabic Compiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.TextBox output_txt;
        private System.Windows.Forms.Button token;
        private System.Windows.Forms.TextBox output_l_text;
        private System.Windows.Forms.Button button1;
    }
}

