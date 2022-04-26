
namespace WindowsFormsApp4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.result = new System.Windows.Forms.Label();
            this.tbStudentsCount = new System.Windows.Forms.TextBox();
            this.lblEnterHowMany = new System.Windows.Forms.Label();
            this.tbStudentsName = new System.Windows.Forms.TextBox();
            this.lblStudentsName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(32, 233);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(544, 172);
            this.listBox1.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(188, 192);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(137, 28);
            this.result.TabIndex = 2;
            this.result.Text = "Total Students: ";
            // 
            // tbStudentsCount
            // 
            this.tbStudentsCount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentsCount.Location = new System.Drawing.Point(288, 36);
            this.tbStudentsCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentsCount.Name = "tbStudentsCount";
            this.tbStudentsCount.Size = new System.Drawing.Size(288, 34);
            this.tbStudentsCount.TabIndex = 3;
            // 
            // lblEnterHowMany
            // 
            this.lblEnterHowMany.AutoSize = true;
            this.lblEnterHowMany.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterHowMany.Location = new System.Drawing.Point(27, 39);
            this.lblEnterHowMany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterHowMany.Name = "lblEnterHowMany";
            this.lblEnterHowMany.Size = new System.Drawing.Size(234, 28);
            this.lblEnterHowMany.TabIndex = 4;
            this.lblEnterHowMany.Text = "Enter how many students: ";
            // 
            // tbStudentsName
            // 
            this.tbStudentsName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentsName.Location = new System.Drawing.Point(193, 79);
            this.tbStudentsName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentsName.Name = "tbStudentsName";
            this.tbStudentsName.Size = new System.Drawing.Size(383, 34);
            this.tbStudentsName.TabIndex = 3;
            // 
            // lblStudentsName
            // 
            this.lblStudentsName.AutoSize = true;
            this.lblStudentsName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentsName.Location = new System.Drawing.Point(27, 89);
            this.lblStudentsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentsName.Name = "lblStudentsName";
            this.lblStudentsName.Size = new System.Drawing.Size(149, 28);
            this.lblStudentsName.TabIndex = 4;
            this.lblStudentsName.Text = "Student\'s name: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(193, 122);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(399, 122);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 46);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(413, 413);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(165, 35);
            this.btnClearList.TabIndex = 0;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(240, 414);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(165, 35);
            this.btnRemoveStudent.TabIndex = 0;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(609, 462);
            this.Controls.Add(this.lblStudentsName);
            this.Controls.Add(this.lblEnterHowMany);
            this.Controls.Add(this.tbStudentsName);
            this.Controls.Add(this.tbStudentsCount);
            this.Controls.Add(this.result);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox tbStudentsCount;
        private System.Windows.Forms.Label lblEnterHowMany;
        private System.Windows.Forms.TextBox tbStudentsName;
        private System.Windows.Forms.Label lblStudentsName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}

