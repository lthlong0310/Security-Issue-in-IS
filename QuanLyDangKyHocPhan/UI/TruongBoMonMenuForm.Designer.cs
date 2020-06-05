namespace UI
{
    partial class TruongBoMonMenuForm
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
            this.logoutbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutbttn
            // 
            this.logoutbttn.Location = new System.Drawing.Point(325, 363);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(134, 45);
            this.logoutbttn.TabIndex = 5;
            this.logoutbttn.Text = "Logout";
            this.logoutbttn.UseVisualStyleBackColor = true;
            this.logoutbttn.Click += new System.EventHandler(this.logoutbttn_Click);
            // 
            // TruongBoMonMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutbttn);
            this.Name = "TruongBoMonMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruongBoMonMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutbttn;
    }
}