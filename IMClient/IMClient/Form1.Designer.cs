namespace IMClient
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
            this.sender = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sender
            // 
            this.sender.Location = new System.Drawing.Point(334, 395);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(75, 23);
            this.sender.TabIndex = 1;
            this.sender.Text = "Send";
            this.sender.UseVisualStyleBackColor = true;
            this.sender.Click += new System.EventHandler(this.button3_Click);
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.typeBox.Location = new System.Drawing.Point(12, 385);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(299, 33);
            this.typeBox.TabIndex = 2;
            this.typeBox.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Username";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.chatBox.Location = new System.Drawing.Point(12, 3);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(299, 367);
            this.chatBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(421, 447);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.sender);
            this.Name = "Form1";
            this.Text = "Instant Message Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sender;
        private System.Windows.Forms.RichTextBox typeBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox chatBox;
    }
}

