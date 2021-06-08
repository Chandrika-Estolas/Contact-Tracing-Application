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
            this.surname_box = new System.Windows.Forms.TextBox();
            this.FindContact_btn = new System.Windows.Forms.Button();
            this.MiddleInitial_box = new System.Windows.Forms.TextBox();
            this.GivenName_box = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.GivenName_label = new System.Windows.Forms.Label();
            this.MiddleInitial_label = new System.Windows.Forms.Label();
            this.Help_btn = new System.Windows.Forms.Button();
            this.Ouput_box = new System.Windows.Forms.RichTextBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surname_box
            // 
            this.surname_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.surname_box.Location = new System.Drawing.Point(24, 100);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(100, 21);
            this.surname_box.TabIndex = 0;
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
            this.FindContact_btn.Size = new System.Drawing.Size(148, 23);
            this.FindContact_btn.TabIndex = 1;
            this.FindContact_btn.Text = "Find Contact";
            this.FindContact_btn.UseVisualStyleBackColor = false;
            this.FindContact_btn.Click += new System.EventHandler(this.FindContact_btn_Click);
            // 
            // MiddleInitial_box
            // 
            this.MiddleInitial_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.MiddleInitial_box.Location = new System.Drawing.Point(258, 100);
            this.MiddleInitial_box.Name = "MiddleInitial_box";
            this.MiddleInitial_box.Size = new System.Drawing.Size(74, 21);
            this.MiddleInitial_box.TabIndex = 3;
            // 
            // GivenName_box
            // 
            this.GivenName_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.GivenName_box.Location = new System.Drawing.Point(142, 100);
            this.GivenName_box.Name = "GivenName_box";
            this.GivenName_box.Size = new System.Drawing.Size(100, 21);
            this.GivenName_box.TabIndex = 4;
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
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // Ouput_box
            // 
            this.Ouput_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Ouput_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Ouput_box.ForeColor = System.Drawing.Color.White;
            this.Ouput_box.Location = new System.Drawing.Point(58, 153);
            this.Ouput_box.Name = "Ouput_box";
            this.Ouput_box.Size = new System.Drawing.Size(402, 159);
            this.Ouput_box.TabIndex = 22;
            this.Ouput_box.Text = "";
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Back_btn.ForeColor = System.Drawing.Color.Black;
            this.Back_btn.Location = new System.Drawing.Point(12, 321);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(65, 23);
            this.Back_btn.TabIndex = 23;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_click);
            // 
            // Find_Contact_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Application.Properties.Resources.bgrnd31;
            this.ClientSize = new System.Drawing.Size(521, 356);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Ouput_box);
            this.Controls.Add(this.Help_btn);
            this.Controls.Add(this.MiddleInitial_label);
            this.Controls.Add(this.GivenName_label);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.GivenName_box);
            this.Controls.Add(this.MiddleInitial_box);
            this.Controls.Add(this.FindContact_btn);
            this.Controls.Add(this.surname_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Find_Contact_form";
            this.Text = "Contact Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.Button FindContact_btn;
        private System.Windows.Forms.TextBox MiddleInitial_box;
        private System.Windows.Forms.TextBox GivenName_box;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label GivenName_label;
        private System.Windows.Forms.Label MiddleInitial_label;
        private System.Windows.Forms.Button Help_btn;
        private System.Windows.Forms.RichTextBox Ouput_box;
        private System.Windows.Forms.Button Back_btn;
    }
}