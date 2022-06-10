
namespace RSA
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
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fresh = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.saveToDatabase = new System.Windows.Forms.Button();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseFromDatabase = new System.Windows.Forms.Button();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_fi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(36, 105);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(60, 27);
            this.textBox_p.TabIndex = 0;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(125, 105);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(60, 27);
            this.textBox_q.TabIndex = 1;
            this.textBox_q.TextChanged += new System.EventHandler(this.textBox_q_TextChanged);
            // 
            // encryptionButton
            // 
            this.encryptionButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.encryptionButton.Location = new System.Drawing.Point(36, 326);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(195, 44);
            this.encryptionButton.TabIndex = 2;
            this.encryptionButton.Text = "Šifruoti";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(121, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "q:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_fresh
            // 
            this.textBox_fresh.Location = new System.Drawing.Point(36, 138);
            this.textBox_fresh.Multiline = true;
            this.textBox_fresh.Name = "textBox_fresh";
            this.textBox_fresh.Size = new System.Drawing.Size(400, 182);
            this.textBox_fresh.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // decryptionButton
            // 
            this.decryptionButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.decryptionButton.Location = new System.Drawing.Point(241, 326);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(195, 44);
            this.decryptionButton.TabIndex = 7;
            this.decryptionButton.Text = "Dešifruoti";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(557, 137);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(400, 182);
            this.textBox_result.TabIndex = 8;
            // 
            // saveToDatabase
            // 
            this.saveToDatabase.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.saveToDatabase.Location = new System.Drawing.Point(557, 325);
            this.saveToDatabase.Name = "saveToDatabase";
            this.saveToDatabase.Size = new System.Drawing.Size(195, 44);
            this.saveToDatabase.TabIndex = 9;
            this.saveToDatabase.Text = "Išsaugoti į Duomenų bazę";
            this.saveToDatabase.UseVisualStyleBackColor = true;
            this.saveToDatabase.Click += new System.EventHandler(this.saveToDatabase_Click);
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(761, 104);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.ReadOnly = true;
            this.textBox_e.Size = new System.Drawing.Size(95, 27);
            this.textBox_e.TabIndex = 10;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(862, 104);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.ReadOnly = true;
            this.textBox_d.Size = new System.Drawing.Size(95, 27);
            this.textBox_d.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(757, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "e:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(858, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "d:";
            // 
            // chooseFromDatabase
            // 
            this.chooseFromDatabase.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.chooseFromDatabase.Location = new System.Drawing.Point(215, 39);
            this.chooseFromDatabase.Name = "chooseFromDatabase";
            this.chooseFromDatabase.Size = new System.Drawing.Size(84, 29);
            this.chooseFromDatabase.TabIndex = 14;
            this.chooseFromDatabase.Text = "Pasirinkti";
            this.chooseFromDatabase.UseVisualStyleBackColor = true;
            this.chooseFromDatabase.Click += new System.EventHandler(this.chooseFromDatabase_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(658, 104);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.Size = new System.Drawing.Size(95, 27);
            this.textBox_n.TabIndex = 15;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(654, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "n:";
            // 
            // textBox_fi
            // 
            this.textBox_fi.Location = new System.Drawing.Point(557, 104);
            this.textBox_fi.Name = "textBox_fi";
            this.textBox_fi.ReadOnly = true;
            this.textBox_fi.Size = new System.Drawing.Size(95, 27);
            this.textBox_fi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(553, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "φ(n)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Esami duomenys išsaugoti duomenų bazėje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(606, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(357, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "RSA šifravimo/dešifravimo aplikacija";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 397);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_fi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.chooseFromDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.saveToDatabase);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_fresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button saveToDatabase;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chooseFromDatabase;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_fi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

