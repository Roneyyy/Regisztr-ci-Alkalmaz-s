namespace RegisztracioAlkalmazas
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
            this.nevtext = new System.Windows.Forms.TextBox();
            this.hobbitext = new System.Windows.Forms.TextBox();
            this.hobbi = new System.Windows.Forms.ListBox();
            this.Ferfi = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.RadioButton();
            this.UjHobbi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nem = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.szuldate = new System.Windows.Forms.DateTimePicker();
            this.Hobbihozza = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.betolt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nevtext
            // 
            this.nevtext.Location = new System.Drawing.Point(59, 18);
            this.nevtext.Name = "nevtext";
            this.nevtext.Size = new System.Drawing.Size(100, 20);
            this.nevtext.TabIndex = 0;
            // 
            // hobbitext
            // 
            this.hobbitext.Location = new System.Drawing.Point(252, 142);
            this.hobbitext.Name = "hobbitext";
            this.hobbitext.Size = new System.Drawing.Size(120, 20);
            this.hobbitext.TabIndex = 2;
            // 
            // hobbi
            // 
            this.hobbi.FormattingEnabled = true;
            this.hobbi.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.hobbi.Location = new System.Drawing.Point(252, 34);
            this.hobbi.Name = "hobbi";
            this.hobbi.Size = new System.Drawing.Size(120, 95);
            this.hobbi.TabIndex = 3;
            this.hobbi.Tag = "";
            // 
            // Ferfi
            // 
            this.Ferfi.AutoSize = true;
            this.Ferfi.Location = new System.Drawing.Point(87, 97);
            this.Ferfi.Name = "Ferfi";
            this.Ferfi.Size = new System.Drawing.Size(31, 17);
            this.Ferfi.TabIndex = 4;
            this.Ferfi.TabStop = true;
            this.Ferfi.Text = "F";
            this.Ferfi.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(124, 97);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(33, 17);
            this.No.TabIndex = 5;
            this.No.TabStop = true;
            this.No.Text = "N";
            this.No.UseVisualStyleBackColor = true;
            // 
            // UjHobbi
            // 
            this.UjHobbi.AutoSize = true;
            this.UjHobbi.Location = new System.Drawing.Point(198, 145);
            this.UjHobbi.Name = "UjHobbi";
            this.UjHobbi.Size = new System.Drawing.Size(48, 13);
            this.UjHobbi.TabIndex = 7;
            this.UjHobbi.Text = "Új Hobbi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kedvenc Hobbi:";
            // 
            // Nem
            // 
            this.Nem.AutoSize = true;
            this.Nem.Location = new System.Drawing.Point(12, 97);
            this.Nem.Name = "Nem";
            this.Nem.Size = new System.Drawing.Size(32, 13);
            this.Nem.TabIndex = 9;
            this.Nem.Text = "Nem:";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(12, 59);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(41, 13);
            this.datum.TabIndex = 10;
            this.datum.Text = "Dátum:";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(12, 21);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 11;
            this.nev.Text = "Név:";
            // 
            // szuldate
            // 
            this.szuldate.Location = new System.Drawing.Point(59, 59);
            this.szuldate.MaxDate = new System.DateTime(2018, 10, 19, 15, 23, 27, 0);
            this.szuldate.Name = "szuldate";
            this.szuldate.Size = new System.Drawing.Size(145, 20);
            this.szuldate.TabIndex = 12;
            this.szuldate.Value = new System.DateTime(2018, 10, 19, 0, 0, 0, 0);
            // 
            // Hobbihozza
            // 
            this.Hobbihozza.Location = new System.Drawing.Point(297, 183);
            this.Hobbihozza.Name = "Hobbihozza";
            this.Hobbihozza.Size = new System.Drawing.Size(75, 23);
            this.Hobbihozza.TabIndex = 13;
            this.Hobbihozza.Text = "Hozzáad";
            this.Hobbihozza.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(201, 290);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 14;
            this.save.Text = "Mentés";
            this.save.UseVisualStyleBackColor = true;
            // 
            // betolt
            // 
            this.betolt.Location = new System.Drawing.Point(297, 290);
            this.betolt.Name = "betolt";
            this.betolt.Size = new System.Drawing.Size(75, 23);
            this.betolt.TabIndex = 15;
            this.betolt.Text = "Betöltés";
            this.betolt.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Szöveges Fálj|*.txt*|Minden Fálj|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Szöveges Fálj|*.txt*|Minden Fálj|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 325);
            this.Controls.Add(this.betolt);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Hobbihozza);
            this.Controls.Add(this.szuldate);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.Nem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UjHobbi);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Ferfi);
            this.Controls.Add(this.hobbi);
            this.Controls.Add(this.hobbitext);
            this.Controls.Add(this.nevtext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevtext;
        private System.Windows.Forms.TextBox hobbitext;
        private System.Windows.Forms.ListBox hobbi;
        private System.Windows.Forms.RadioButton Ferfi;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.Label UjHobbi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nem;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.DateTimePicker szuldate;
        private System.Windows.Forms.Button Hobbihozza;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button betolt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

