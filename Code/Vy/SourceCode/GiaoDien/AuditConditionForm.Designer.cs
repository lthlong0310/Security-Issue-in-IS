namespace GiaoDien
{
    partial class AuditConditionForm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.NoSuccessCheckBox = new System.Windows.Forms.CheckBox();
            this.SuccessCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddActionBtn = new System.Windows.Forms.Button();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddObjectBtn = new System.Windows.Forms.Button();
            this.ObjectComboBox = new System.Windows.Forms.ComboBox();
            this.UserListView = new System.Windows.Forms.ListView();
            this.ActionListView = new System.Windows.Forms.ListView();
            this.ObjectListView = new System.Windows.Forms.ListView();
            this.UsernameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(587, 322);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(95, 43);
            this.CancelBtn.TabIndex = 37;
            this.CancelBtn.Text = "Thoát ra";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(727, 322);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(95, 43);
            this.ExecuteBtn.TabIndex = 36;
            this.ExecuteBtn.Text = "Thực thi";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // NoSuccessCheckBox
            // 
            this.NoSuccessCheckBox.AutoSize = true;
            this.NoSuccessCheckBox.Location = new System.Drawing.Point(177, 284);
            this.NoSuccessCheckBox.Name = "NoSuccessCheckBox";
            this.NoSuccessCheckBox.Size = new System.Drawing.Size(146, 21);
            this.NoSuccessCheckBox.TabIndex = 35;
            this.NoSuccessCheckBox.Text = "Không thành công";
            this.NoSuccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // SuccessCheckBox
            // 
            this.SuccessCheckBox.AutoSize = true;
            this.SuccessCheckBox.Location = new System.Drawing.Point(26, 284);
            this.SuccessCheckBox.Name = "SuccessCheckBox";
            this.SuccessCheckBox.Size = new System.Drawing.Size(106, 21);
            this.SuccessCheckBox.TabIndex = 34;
            this.SuccessCheckBox.Text = "Thành công";
            this.SuccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Người dùng";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(200, 49);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.AddUserBtn.TabIndex = 31;
            this.AddUserBtn.Text = "Thêm";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UserComboBox
            // 
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(26, 48);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(168, 24);
            this.UserComboBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hành động";
            // 
            // AddActionBtn
            // 
            this.AddActionBtn.Location = new System.Drawing.Point(474, 49);
            this.AddActionBtn.Name = "AddActionBtn";
            this.AddActionBtn.Size = new System.Drawing.Size(75, 23);
            this.AddActionBtn.TabIndex = 27;
            this.AddActionBtn.Text = "Thêm";
            this.AddActionBtn.UseVisualStyleBackColor = true;
            this.AddActionBtn.Click += new System.EventHandler(this.AddActionBtn_Click);
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(300, 48);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(168, 24);
            this.ActionComboBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Đối tượng";
            // 
            // AddObjectBtn
            // 
            this.AddObjectBtn.Location = new System.Drawing.Point(747, 49);
            this.AddObjectBtn.Name = "AddObjectBtn";
            this.AddObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.AddObjectBtn.TabIndex = 23;
            this.AddObjectBtn.Text = "Thêm";
            this.AddObjectBtn.UseVisualStyleBackColor = true;
            this.AddObjectBtn.Click += new System.EventHandler(this.AddObjectBtn_Click);
            // 
            // ObjectComboBox
            // 
            this.ObjectComboBox.FormattingEnabled = true;
            this.ObjectComboBox.Location = new System.Drawing.Point(573, 48);
            this.ObjectComboBox.Name = "ObjectComboBox";
            this.ObjectComboBox.Size = new System.Drawing.Size(168, 24);
            this.ObjectComboBox.TabIndex = 22;
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UsernameCol});
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(26, 79);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(249, 177);
            this.UserListView.TabIndex = 38;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            this.UserListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserListView_MouseDoubleClick);
            // 
            // ActionListView
            // 
            this.ActionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionCol});
            this.ActionListView.HideSelection = false;
            this.ActionListView.Location = new System.Drawing.Point(300, 79);
            this.ActionListView.Name = "ActionListView";
            this.ActionListView.Size = new System.Drawing.Size(249, 177);
            this.ActionListView.TabIndex = 39;
            this.ActionListView.UseCompatibleStateImageBehavior = false;
            this.ActionListView.View = System.Windows.Forms.View.Details;
            this.ActionListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ActionListView_MouseDoubleClick);
            // 
            // ObjectListView
            // 
            this.ObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ObjectCol});
            this.ObjectListView.HideSelection = false;
            this.ObjectListView.Location = new System.Drawing.Point(573, 79);
            this.ObjectListView.Name = "ObjectListView";
            this.ObjectListView.Size = new System.Drawing.Size(249, 177);
            this.ObjectListView.TabIndex = 40;
            this.ObjectListView.UseCompatibleStateImageBehavior = false;
            this.ObjectListView.View = System.Windows.Forms.View.Details;
            this.ObjectListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ObjectListView_MouseDoubleClick);
            // 
            // UsernameCol
            // 
            this.UsernameCol.Text = "Username";
            this.UsernameCol.Width = 140;
            // 
            // ActionCol
            // 
            this.ActionCol.Text = "ActionName";
            this.ActionCol.Width = 127;
            // 
            // ObjectCol
            // 
            this.ObjectCol.Text = "ObjectName";
            this.ObjectCol.Width = 114;
            // 
            // AuditConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 381);
            this.Controls.Add(this.ObjectListView);
            this.Controls.Add(this.ActionListView);
            this.Controls.Add(this.UserListView);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.NoSuccessCheckBox);
            this.Controls.Add(this.SuccessCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddActionBtn);
            this.Controls.Add(this.ActionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddObjectBtn);
            this.Controls.Add(this.ObjectComboBox);
            this.Name = "AuditConditionForm";
            this.Text = "AuditConditionForm";
            this.Load += new System.EventHandler(this.AuditConditionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.CheckBox NoSuccessCheckBox;
        private System.Windows.Forms.CheckBox SuccessCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddActionBtn;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddObjectBtn;
        private System.Windows.Forms.ComboBox ObjectComboBox;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.ColumnHeader UsernameCol;
        private System.Windows.Forms.ListView ActionListView;
        private System.Windows.Forms.ListView ObjectListView;
        private System.Windows.Forms.ColumnHeader ActionCol;
        private System.Windows.Forms.ColumnHeader ObjectCol;
    }
}