namespace Contact_Tracing_Application
{
    partial class Contact_Tracer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Tracer));
            this.Add_btn = new System.Windows.Forms.Button();
            this.Find_btn = new System.Windows.Forms.Button();
            this.About_btn = new System.Windows.Forms.Button();
            this.Help_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Add_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(12, 124);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(102, 23);
            this.Add_btn.TabIndex = 0;
            this.Add_btn.Text = "Add contact";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Find_btn
            // 
            this.Find_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Find_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Find_btn.Location = new System.Drawing.Point(120, 124);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(90, 23);
            this.Find_btn.TabIndex = 1;
            this.Find_btn.Text = "Find contact";
            this.Find_btn.UseVisualStyleBackColor = false;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // About_btn
            // 
            this.About_btn.Location = new System.Drawing.Point(-1, -2);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(53, 23);
            this.About_btn.TabIndex = 2;
            this.About_btn.Text = "About";
            this.About_btn.UseVisualStyleBackColor = true;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // Help_btn
            // 
            this.Help_btn.Location = new System.Drawing.Point(46, -2);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Size = new System.Drawing.Size(53, 23);
            this.Help_btn.TabIndex = 3;
            this.Help_btn.Text = "Help";
            this.Help_btn.UseVisualStyleBackColor = true;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // Contact_Tracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Application.Properties.Resources.bgrnd;
            this.ClientSize = new System.Drawing.Size(222, 177);
            this.Controls.Add(this.Help_btn);
            this.Controls.Add(this.About_btn);
            this.Controls.Add(this.Find_btn);
            this.Controls.Add(this.Add_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contact_Tracer";
            this.Text = "Contact Tracer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Find_btn;
        private System.Windows.Forms.Button About_btn;
        private System.Windows.Forms.Button Help_btn;
    }
}

