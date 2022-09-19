namespace ChatHallaGiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ChatName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.WriteBox = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ChatName
            // 
            this.ChatName.AutoSize = true;
            this.ChatName.Location = new System.Drawing.Point(95, 22);
            this.ChatName.Name = "ChatName";
            this.ChatName.Size = new System.Drawing.Size(123, 15);
            this.ChatName.TabIndex = 0;
            this.ChatName.Text = "Enter your chat name:";
            this.ChatName.Click += new System.EventHandler(this.ChatName_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(330, 20);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(148, 23);
            this.Username.TabIndex = 1;
            this.Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(95, 94);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(382, 139);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(330, 44);
            this.Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(147, 22);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Connect to server";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // WriteBox
            // 
            this.WriteBox.Location = new System.Drawing.Point(95, 253);
            this.WriteBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteBox.Name = "WriteBox";
            this.WriteBox.Size = new System.Drawing.Size(382, 23);
            this.WriteBox.TabIndex = 4;
            this.WriteBox.TextChanged += new System.EventHandler(this.WriteBox_TextChanged);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(369, 278);
            this.SendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(108, 22);
            this.SendMessage.TabIndex = 5;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // backgroundWorker2
            // 
          //  this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.WriteBox);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ChatName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label ChatName;
        private TextBox Username;
        private RichTextBox richTextBox1;
        private Button Connect;
        private TextBox WriteBox;
        private Button SendMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}