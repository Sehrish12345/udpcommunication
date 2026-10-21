namespace udpClientApp
{
    partial class ClientForm
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
            richTextBox1 = new RichTextBox();
            btnStart = new Button();
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(162, 153);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(300, 100);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SteelBlue;
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(162, 306);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(114, 39);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.SeaGreen;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(348, 306);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(114, 39);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Location = new Point(162, 104);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter your message:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(160, 364);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Status: Not Started";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(btnStart);
            Controls.Add(richTextBox1);
            ForeColor = Color.Teal;
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDP Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnStart;
        private Button btnSend;
        private Label label1;
        private Label label2;
    }
}
