namespace CzytnikKart_Kinastowski_Picheta
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
            this.BConnect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BSendCommand = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BConnect
            // 
            this.BConnect.Location = new System.Drawing.Point(39, 12);
            this.BConnect.Name = "BConnect";
            this.BConnect.Size = new System.Drawing.Size(245, 132);
            this.BConnect.TabIndex = 0;
            this.BConnect.Text = "Connect";
            this.BConnect.UseVisualStyleBackColor = true;
            this.BConnect.Click += new System.EventHandler(this.BConnect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 132);
            this.button2.TabIndex = 1;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BSendCommand
            // 
            this.BSendCommand.Location = new System.Drawing.Point(606, 255);
            this.BSendCommand.Name = "BSendCommand";
            this.BSendCommand.Size = new System.Drawing.Size(245, 132);
            this.BSendCommand.TabIndex = 2;
            this.BSendCommand.Text = "Send Command";
            this.BSendCommand.UseVisualStyleBackColor = true;
            this.BSendCommand.Click += new System.EventHandler(this.BSendCommand_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(123, 308);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 39);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 415);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(919, 257);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "not connected";
            // 
            // BDisconnect
            // 
            this.BDisconnect.Location = new System.Drawing.Point(311, 12);
            this.BDisconnect.Name = "BDisconnect";
            this.BDisconnect.Size = new System.Drawing.Size(245, 132);
            this.BDisconnect.TabIndex = 6;
            this.BDisconnect.Text = "Disconnect";
            this.BDisconnect.UseVisualStyleBackColor = true;
            this.BDisconnect.Click += new System.EventHandler(this.BDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 684);
            this.Controls.Add(this.BDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BSendCommand);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BConnect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BSendCommand;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDisconnect;
    }
}

