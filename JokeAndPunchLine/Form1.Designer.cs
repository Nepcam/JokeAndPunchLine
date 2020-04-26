namespace JokeAndPunchLine
{
    partial class FormJoke
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
            this.labelJoke = new System.Windows.Forms.Label();
            this.buttonSetUp = new System.Windows.Forms.Button();
            this.buttonPunchLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelJoke
            // 
            this.labelJoke.AutoSize = true;
            this.labelJoke.Location = new System.Drawing.Point(346, 91);
            this.labelJoke.Name = "labelJoke";
            this.labelJoke.Size = new System.Drawing.Size(0, 13);
            this.labelJoke.TabIndex = 0;
            // 
            // buttonSetUp
            // 
            this.buttonSetUp.Location = new System.Drawing.Point(146, 213);
            this.buttonSetUp.Name = "buttonSetUp";
            this.buttonSetUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSetUp.TabIndex = 1;
            this.buttonSetUp.Text = "Set Up";
            this.buttonSetUp.UseVisualStyleBackColor = true;
            this.buttonSetUp.Click += new System.EventHandler(this.buttonSetUp_Click);
            // 
            // buttonPunchLine
            // 
            this.buttonPunchLine.Location = new System.Drawing.Point(548, 213);
            this.buttonPunchLine.Name = "buttonPunchLine";
            this.buttonPunchLine.Size = new System.Drawing.Size(75, 23);
            this.buttonPunchLine.TabIndex = 2;
            this.buttonPunchLine.Text = "Punch Line";
            this.buttonPunchLine.UseVisualStyleBackColor = true;
            this.buttonPunchLine.Click += new System.EventHandler(this.buttonPunchLine_Click);
            // 
            // FormJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPunchLine);
            this.Controls.Add(this.buttonSetUp);
            this.Controls.Add(this.labelJoke);
            this.Name = "FormJoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOKE";
            this.Load += new System.EventHandler(this.FormJoke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJoke;
        private System.Windows.Forms.Button buttonSetUp;
        private System.Windows.Forms.Button buttonPunchLine;
    }
}

