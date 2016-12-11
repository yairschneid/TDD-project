namespace WindowsFormsApplication1
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.sort_bubble_bt = new System.Windows.Forms.Button();
            this.timer_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(76, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.Location = new System.Drawing.Point(782, 521);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(75, 23);
            this.exit_bt.TabIndex = 2;
            this.exit_bt.Text = "exit";
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // sort_bubble_bt
            // 
            this.sort_bubble_bt.Location = new System.Drawing.Point(236, 29);
            this.sort_bubble_bt.Name = "sort_bubble_bt";
            this.sort_bubble_bt.Size = new System.Drawing.Size(75, 23);
            this.sort_bubble_bt.TabIndex = 3;
            this.sort_bubble_bt.Text = "bubble sort";
            this.sort_bubble_bt.UseVisualStyleBackColor = true;
            this.sort_bubble_bt.Click += new System.EventHandler(this.sort_bubble_bt_Click);
            // 
            // timer_lb
            // 
            this.timer_lb.AutoSize = true;
            this.timer_lb.Location = new System.Drawing.Point(596, 38);
            this.timer_lb.Name = "timer_lb";
            this.timer_lb.Size = new System.Drawing.Size(61, 13);
            this.timer_lb.TabIndex = 4;
            this.timer_lb.Text = "00 : 00 : 00";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 663);
            this.Controls.Add(this.timer_lb);
            this.Controls.Add(this.sort_bubble_bt);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Button sort_bubble_bt;
        private System.Windows.Forms.Label timer_lb;
    }
}

