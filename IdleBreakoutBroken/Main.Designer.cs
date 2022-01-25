namespace IdleBreakoutBroken
{
    partial class Main
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
            this.btn_screen = new System.Windows.Forms.Button();
            this.btn_spam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_screen
            // 
            this.btn_screen.Location = new System.Drawing.Point(113, 43);
            this.btn_screen.Name = "btn_screen";
            this.btn_screen.Size = new System.Drawing.Size(168, 95);
            this.btn_screen.TabIndex = 0;
            this.btn_screen.Text = "button1";
            this.btn_screen.UseVisualStyleBackColor = true;
            // 
            // btn_spam
            // 
            this.btn_spam.Location = new System.Drawing.Point(113, 157);
            this.btn_spam.Name = "btn_spam";
            this.btn_spam.Size = new System.Drawing.Size(168, 95);
            this.btn_spam.TabIndex = 1;
            this.btn_spam.Text = "button1";
            this.btn_spam.UseVisualStyleBackColor = true;
            this.btn_spam.Click += new System.EventHandler(this.btn_spam_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 306);
            this.Controls.Add(this.btn_spam);
            this.Controls.Add(this.btn_screen);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_screen;
        private Button btn_spam;
    }
}