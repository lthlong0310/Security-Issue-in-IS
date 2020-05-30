namespace GiaoDien
{
    partial class FormObject
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
            this.objectlv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // objectlv
            // 
            this.objectlv.HideSelection = false;
            this.objectlv.Location = new System.Drawing.Point(32, 33);
            this.objectlv.Name = "objectlv";
            this.objectlv.Size = new System.Drawing.Size(742, 353);
            this.objectlv.TabIndex = 0;
            this.objectlv.UseCompatibleStateImageBehavior = false;
            // 
            // FormObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.objectlv);
            this.Name = "FormObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormObject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView objectlv;
    }
}