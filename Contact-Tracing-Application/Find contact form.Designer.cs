namespace Contact_Tracing_Application
{
    partial class Find_Contact_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Contact_form));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindContact_btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.GivenName_label = new System.Windows.Forms.Label();
            this.MiddleInitial_label = new System.Windows.Forms.Label();
            this.Help_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.textBox1.Location = new System.Drawing.Point(24, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // FindContact_btn
            // 
            this.FindContact_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FindContact_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.FindContact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindContact_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.FindContact_btn.ForeColor = System.Drawing.Color.Black;
            this.FindContact_btn.Location = new System.Drawing.Point(354, 100);
            this.FindContact_btn.Name = "FindContact_btn";
            this.FindContact_btn.Size = new System.Drawing.Size(131, 23);
            this.FindContact_btn.TabIndex = 1;
            this.FindContact_btn.Text = "Find Contact";
            this.FindContact_btn.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.textBox3.Location = new System.Drawing.Point(258, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 21);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.textBox4.Location = new System.Drawing.Point(142, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 4;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.BackColor = System.Drawing.Color.Transparent;
            this.LastName_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.LastName_label.ForeColor = System.Drawing.Color.White;
            this.LastName_label.Location = new System.Drawing.Point(22, 124);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(55, 12);
            this.LastName_label.TabIndex = 18;
            this.LastName_label.Text = "Surname";
            // 
            // GivenName_label
            // 
            this.GivenName_label.AutoSize = true;
            this.GivenName_label.BackColor = System.Drawing.Color.Transparent;
            this.GivenName_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.GivenName_label.ForeColor = System.Drawing.Color.White;
            this.GivenName_label.Location = new System.Drawing.Point(140, 124);
            this.GivenName_label.Name = "GivenName_label";
            this.GivenName_label.Size = new System.Drawing.Size(72, 12);
            this.GivenName_label.TabIndex = 19;
            this.GivenName_label.Text = "Given Name";
            // 
            // MiddleInitial_label
            // 
            this.MiddleInitial_label.AutoSize = true;
            this.MiddleInitial_label.BackColor = System.Drawing.Color.Transparent;
            this.MiddleInitial_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.MiddleInitial_label.ForeColor = System.Drawing.Color.White;
            this.MiddleInitial_label.Location = new System.Drawing.Point(256, 124);
            this.MiddleInitial_label.Name = "MiddleInitial_label";
            this.MiddleInitial_label.Size = new System.Drawing.Size(74, 12);
            this.MiddleInitial_label.TabIndex = 20;
            this.MiddleInitial_label.Text = "Middle Initial";
            // 
            // Help_btn
            // 
            this.Help_btn.Location = new System.Drawing.Point(0, 0);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Size = new System.Drawing.Size(53, 23);
            this.Help_btn.TabIndex = 21;
            this.Help_btn.Text = "Help";
            this.Help_btn.UseVisualStyleBackColor = true;
            // 
            // Find_Contact_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Application.Properties.Resources.bgrnd31;
            this.ClientSize = new System.Drawing.Size(521, 356);
            this.Controls.Add(this.Help_btn);
            this.Controls.Add(this.MiddleInitial_label);
            this.Controls.Add(this.GivenName_label);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.FindContact_btn);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Find_Contact_form";
            this.Text = "Contact Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindContact_btn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label GivenName_label;
        private System.Windows.Forms.Label MiddleInitial_label;
        private System.Windows.Forms.Button Help_btn;
    }
}