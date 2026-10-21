namespace udpClientApp
{
    partial class ServerForm
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
            richTextBox1 = new RichTextBox();
            btnServerStart = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(163, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(356, 144);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnServerStart
            // 
            btnServerStart.BackColor = Color.SteelBlue;
            btnServerStart.ForeColor = Color.White;
            btnServerStart.Location = new Point(159, 275);
            btnServerStart.Name = "btnServerStart";
            btnServerStart.Size = new Size(360, 36);
            btnServerStart.TabIndex = 1;
            btnServerStart.Text = "Start Server";
            btnServerStart.UseVisualStyleBackColor = false;
            btnServerStart.Click += btnStartServer_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnServerStart);
            Controls.Add(richTextBox1);
            Name = "ServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDP Server";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnServerStart;
    }
}