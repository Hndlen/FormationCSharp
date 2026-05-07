
namespace FormTest
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
            this.textBoxJoueur1 = new System.Windows.Forms.TextBox();
            this.textBoxJoueur2 = new System.Windows.Forms.TextBox();
            this.buttonJouer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxJoueur1
            // 
            this.textBoxJoueur1.Location = new System.Drawing.Point(148, 69);
            this.textBoxJoueur1.Name = "textBoxJoueur1";
            this.textBoxJoueur1.Size = new System.Drawing.Size(100, 23);
            this.textBoxJoueur1.TabIndex = 0;
            this.textBoxJoueur1.Text = "Jouer1";
            // 
            // textBoxJoueur2
            // 
            this.textBoxJoueur2.Location = new System.Drawing.Point(317, 69);
            this.textBoxJoueur2.Name = "textBoxJoueur2";
            this.textBoxJoueur2.Size = new System.Drawing.Size(100, 23);
            this.textBoxJoueur2.TabIndex = 1;
            this.textBoxJoueur2.Text = "Jouer2";
            this.textBoxJoueur2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonJouer
            // 
            this.buttonJouer.Location = new System.Drawing.Point(551, 69);
            this.buttonJouer.Name = "buttonJouer";
            this.buttonJouer.Size = new System.Drawing.Size(75, 23);
            this.buttonJouer.TabIndex = 2;
            this.buttonJouer.Text = "Jouer";
            this.buttonJouer.UseVisualStyleBackColor = true;
            this.buttonJouer.Click += new System.EventHandler(this.buttonJouer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.buttonC3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonC2);
            this.panel1.Controls.Add(this.buttonC1);
            this.panel1.Controls.Add(this.buttonB3);
            this.panel1.Controls.Add(this.buttonB2);
            this.panel1.Controls.Add(this.buttonB1);
            this.panel1.Controls.Add(this.buttonA3);
            this.panel1.Controls.Add(this.buttonA2);
            this.panel1.Controls.Add(this.buttonA1);
            this.panel1.Location = new System.Drawing.Point(148, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 289);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonC3
            // 
            this.buttonC3.Location = new System.Drawing.Point(200, 192);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(80, 80);
            this.buttonC3.TabIndex = 9;
            this.buttonC3.Text = "_";
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonC2
            // 
            this.buttonC2.Location = new System.Drawing.Point(110, 192);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(80, 80);
            this.buttonC2.TabIndex = 7;
            this.buttonC2.Text = "_";
            this.buttonC2.UseVisualStyleBackColor = true;
            // 
            // buttonC1
            // 
            this.buttonC1.Location = new System.Drawing.Point(20, 192);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(80, 80);
            this.buttonC1.TabIndex = 6;
            this.buttonC1.Text = "_";
            this.buttonC1.UseVisualStyleBackColor = true;
            // 
            // buttonB3
            // 
            this.buttonB3.Location = new System.Drawing.Point(200, 106);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(80, 80);
            this.buttonB3.TabIndex = 5;
            this.buttonB3.Text = "_";
            this.buttonB3.UseVisualStyleBackColor = true;
            // 
            // buttonB2
            // 
            this.buttonB2.Location = new System.Drawing.Point(110, 106);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(80, 80);
            this.buttonB2.TabIndex = 4;
            this.buttonB2.Text = "_";
            this.buttonB2.UseVisualStyleBackColor = true;
            // 
            // buttonB1
            // 
            this.buttonB1.Location = new System.Drawing.Point(20, 106);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(80, 80);
            this.buttonB1.TabIndex = 3;
            this.buttonB1.Text = "_";
            this.buttonB1.UseVisualStyleBackColor = true;
            // 
            // buttonA3
            // 
            this.buttonA3.Location = new System.Drawing.Point(200, 20);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(80, 80);
            this.buttonA3.TabIndex = 2;
            this.buttonA3.Text = "_";
            this.buttonA3.UseVisualStyleBackColor = true;
            // 
            // buttonA2
            // 
            this.buttonA2.Location = new System.Drawing.Point(110, 20);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(80, 80);
            this.buttonA2.TabIndex = 1;
            this.buttonA2.Text = "_";
            this.buttonA2.UseVisualStyleBackColor = true;
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(20, 20);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(80, 80);
            this.buttonA1.TabIndex = 0;
            this.buttonA1.Text = "_";
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.Location = new System.Drawing.Point(520, 129);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.ReadOnly = true;
            this.richTextBoxConsole.Size = new System.Drawing.Size(193, 289);
            this.richTextBoxConsole.TabIndex = 4;
            this.richTextBoxConsole.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxConsole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonJouer);
            this.Controls.Add(this.textBoxJoueur2);
            this.Controls.Add(this.textBoxJoueur1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJoueur1;
        private System.Windows.Forms.TextBox textBoxJoueur2;
        private System.Windows.Forms.Button buttonJouer;
        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonC2;
        private System.Windows.Forms.Button buttonC1;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Button buttonB2;
        private System.Windows.Forms.Button buttonB1;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
    }
}

