namespace DeweyDecimal_18007979
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
            this.Btn_ReplaceBooks = new System.Windows.Forms.Button();
            this.Btn_AreaIdentify = new System.Windows.Forms.Button();
            this.Btn_FindCallNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ReplaceBooks
            // 
            this.Btn_ReplaceBooks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_ReplaceBooks.Location = new System.Drawing.Point(12, 12);
            this.Btn_ReplaceBooks.Name = "Btn_ReplaceBooks";
            this.Btn_ReplaceBooks.Size = new System.Drawing.Size(102, 45);
            this.Btn_ReplaceBooks.TabIndex = 0;
            this.Btn_ReplaceBooks.Text = "Replacing Books";
            this.Btn_ReplaceBooks.UseVisualStyleBackColor = false;
            this.Btn_ReplaceBooks.Click += new System.EventHandler(this.Btn_ReplaceBooks_Click);
            // 
            // Btn_AreaIdentify
            // 
            this.Btn_AreaIdentify.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_AreaIdentify.Location = new System.Drawing.Point(68, 79);
            this.Btn_AreaIdentify.Name = "Btn_AreaIdentify";
            this.Btn_AreaIdentify.Size = new System.Drawing.Size(102, 45);
            this.Btn_AreaIdentify.TabIndex = 1;
            this.Btn_AreaIdentify.Text = "Identifying Area\'s";
            this.Btn_AreaIdentify.UseVisualStyleBackColor = false;
            this.Btn_AreaIdentify.Click += new System.EventHandler(this.Btn_AreaIdentify_Click);
            // 
            // Btn_FindCallNumbers
            // 
            this.Btn_FindCallNumbers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_FindCallNumbers.Location = new System.Drawing.Point(128, 148);
            this.Btn_FindCallNumbers.Name = "Btn_FindCallNumbers";
            this.Btn_FindCallNumbers.Size = new System.Drawing.Size(102, 45);
            this.Btn_FindCallNumbers.TabIndex = 2;
            this.Btn_FindCallNumbers.Text = "Finding Call Numbers";
            this.Btn_FindCallNumbers.UseVisualStyleBackColor = false;
            this.Btn_FindCallNumbers.Click += new System.EventHandler(this.Btn_FindCallNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeweyDecimal_18007979.Properties.Resources.Library_replacing_books;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 244);
            this.Controls.Add(this.Btn_FindCallNumbers);
            this.Controls.Add(this.Btn_AreaIdentify);
            this.Controls.Add(this.Btn_ReplaceBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ReplaceBooks;
        private System.Windows.Forms.Button Btn_AreaIdentify;
        private System.Windows.Forms.Button Btn_FindCallNumbers;
    }
}

