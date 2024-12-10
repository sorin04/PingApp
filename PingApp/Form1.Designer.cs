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
            label2 = new Label();
            textNombrePings = new TextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPing
            // 
            buttonPing.Location = new Point(267, 51);
            buttonPing.Margin = new Padding(3, 2, 3, 2);
            buttonPing.Name = "buttonPing";
            buttonPing.Size = new Size(94, 20);
            buttonPing.TabIndex = 0;
            buttonPing.Text = "Ping";
            buttonPing.UseVisualStyleBackColor = true;
            buttonPing.Click += buttonPing_Click;
            // 
            // textAdresse
            // 
            textAdresse.Location = new Point(92, 51);
            textAdresse.Margin = new Padding(3, 2, 3, 2);
            textAdresse.Name = "textAdresse";
            textAdresse.Size = new Size(144, 23);
            textAdresse.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Adresse";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { infoLabel });
            statusStrip1.Location = new Point(0, 315);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 13, 0);
            statusStrip1.Size = new Size(869, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // infoLabel
            // 
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 17);
            // 
            // listView1
            // 
            listView1.Location = new Point(475, 51);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(353, 242);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // textNombrePings
            // 
            textNombrePings.Location = new Point(92, 97);
            textNombrePings.Margin = new Padding(2, 2, 2, 2);
            textNombrePings.Name = "textNombrePings";
            textNombrePings.Size = new Size(144, 23);
            textNombrePings.TabIndex = 6;
            // 
            // Form1
            // 
            AcceptButton = buttonPing;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 337);
            Controls.Add(textNombrePings);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(textAdresse);
            Controls.Add(buttonPing);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label2;
        private TextBox textNombrePings;
    }
}
