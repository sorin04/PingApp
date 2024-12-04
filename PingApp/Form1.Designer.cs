namespace PingApp2
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
            buttonPing = new Button();
            textAdresse = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            infoLabel = new ToolStripStatusLabel();
            listView1 = new ListView();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPing
            // 
            buttonPing.Location = new Point(381, 85);
            buttonPing.Margin = new Padding(4);
            buttonPing.Name = "buttonPing";
            buttonPing.Size = new Size(135, 34);
            buttonPing.TabIndex = 0;
            buttonPing.Text = "Ping";
            buttonPing.UseVisualStyleBackColor = true;
            buttonPing.Click += buttonPing_Click;
            // 
            // textAdresse
            // 
            textAdresse.Location = new Point(131, 85);
            textAdresse.Margin = new Padding(4);
            textAdresse.Name = "textAdresse";
            textAdresse.Size = new Size(204, 31);
            textAdresse.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 2;
            label1.Text = "Adresse";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { infoLabel });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1242, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // infoLabel
            // 
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 15);
            // 
            // listView1
            // 
            listView1.Location = new Point(678, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(503, 400);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AcceptButton = buttonPing;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 561);
            Controls.Add(listView1);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(textAdresse);
            Controls.Add(buttonPing);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ping Me";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPing;
        private TextBox textAdresse;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel infoLabel;
        private ListView listView1;
    }
}
