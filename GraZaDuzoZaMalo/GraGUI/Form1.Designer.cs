namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.labelDo = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.labelOd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gBLosowanie = new System.Windows.Forms.GroupBox();
            this.czas = new System.Windows.Forms.Label();
            this.odpowiedz = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.wpisanaLiczba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gBPrzerwij = new System.Windows.Forms.GroupBox();
            this.wylosowana = new System.Windows.Forms.Label();
            this.liczbaRuchow = new System.Windows.Forms.Label();
            this.czasGry = new System.Windows.Forms.Label();
            this.czas2 = new System.Windows.Forms.Label();
            this.liczbaRuchow2 = new System.Windows.Forms.Label();
            this.wylosowana2 = new System.Windows.Forms.Label();
            this.groupBoxLosuj.SuspendLayout();
            this.gBLosowanie.SuspendLayout();
            this.gBPrzerwij.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.labelDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.labelOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(12, 63);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(290, 100);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(190, 35);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(72, 56);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(7, 63);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(58, 13);
            this.labelDo.TabIndex = 2;
            this.labelDo.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(72, 12);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 1;
            this.textBoxOd.TextChanged += new System.EventHandler(this.TextBoxOd_TextChanged);
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(7, 20);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(58, 13);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Zakres od:";
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(202, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Przerwij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Historia gry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // gBLosowanie
            // 
            this.gBLosowanie.Controls.Add(this.czas);
            this.gBLosowanie.Controls.Add(this.odpowiedz);
            this.gBLosowanie.Controls.Add(this.button4);
            this.gBLosowanie.Controls.Add(this.wpisanaLiczba);
            this.gBLosowanie.Controls.Add(this.label1);
            this.gBLosowanie.Location = new System.Drawing.Point(12, 186);
            this.gBLosowanie.Name = "gBLosowanie";
            this.gBLosowanie.Size = new System.Drawing.Size(290, 100);
            this.gBLosowanie.TabIndex = 5;
            this.gBLosowanie.TabStop = false;
            this.gBLosowanie.Visible = false;
            this.gBLosowanie.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(212, 20);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(35, 13);
            this.czas.TabIndex = 4;
            this.czas.Text = "label2";
            // 
            // odpowiedz
            // 
            this.odpowiedz.AutoSize = true;
            this.odpowiedz.Location = new System.Drawing.Point(13, 81);
            this.odpowiedz.Name = "odpowiedz";
            this.odpowiedz.Size = new System.Drawing.Size(60, 13);
            this.odpowiedz.TabIndex = 3;
            this.odpowiedz.Text = "Odpowiedź";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Sprawdź";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // wpisanaLiczba
            // 
            this.wpisanaLiczba.Location = new System.Drawing.Point(13, 46);
            this.wpisanaLiczba.Name = "wpisanaLiczba";
            this.wpisanaLiczba.Size = new System.Drawing.Size(100, 20);
            this.wpisanaLiczba.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba wylosowana. Odgadnij ją!";
            // 
            // gBPrzerwij
            // 
            this.gBPrzerwij.Controls.Add(this.wylosowana2);
            this.gBPrzerwij.Controls.Add(this.liczbaRuchow2);
            this.gBPrzerwij.Controls.Add(this.czas2);
            this.gBPrzerwij.Controls.Add(this.wylosowana);
            this.gBPrzerwij.Controls.Add(this.liczbaRuchow);
            this.gBPrzerwij.Controls.Add(this.czasGry);
            this.gBPrzerwij.Location = new System.Drawing.Point(13, 305);
            this.gBPrzerwij.Name = "gBPrzerwij";
            this.gBPrzerwij.Size = new System.Drawing.Size(289, 81);
            this.gBPrzerwij.TabIndex = 6;
            this.gBPrzerwij.TabStop = false;
            this.gBPrzerwij.Visible = false;
            // 
            // wylosowana
            // 
            this.wylosowana.AutoSize = true;
            this.wylosowana.Location = new System.Drawing.Point(15, 65);
            this.wylosowana.Name = "wylosowana";
            this.wylosowana.Size = new System.Drawing.Size(71, 13);
            this.wylosowana.TabIndex = 2;
            this.wylosowana.Text = "Wylosowana:";
            // 
            // liczbaRuchow
            // 
            this.liczbaRuchow.AutoSize = true;
            this.liczbaRuchow.Location = new System.Drawing.Point(15, 42);
            this.liczbaRuchow.Name = "liczbaRuchow";
            this.liczbaRuchow.Size = new System.Drawing.Size(79, 13);
            this.liczbaRuchow.TabIndex = 1;
            this.liczbaRuchow.Text = "Liczba ruchów:";
            // 
            // czasGry
            // 
            this.czasGry.AutoSize = true;
            this.czasGry.Location = new System.Drawing.Point(15, 20);
            this.czasGry.Name = "czasGry";
            this.czasGry.Size = new System.Drawing.Size(99, 13);
            this.czasGry.TabIndex = 0;
            this.czasGry.Text = "Całkowity czas gry:";
            // 
            // czas2
            // 
            this.czas2.AutoSize = true;
            this.czas2.Location = new System.Drawing.Point(155, 20);
            this.czas2.Name = "czas2";
            this.czas2.Size = new System.Drawing.Size(35, 13);
            this.czas2.TabIndex = 3;
            this.czas2.Text = "label2";
            // 
            // liczbaRuchow2
            // 
            this.liczbaRuchow2.AutoSize = true;
            this.liczbaRuchow2.Location = new System.Drawing.Point(155, 42);
            this.liczbaRuchow2.Name = "liczbaRuchow2";
            this.liczbaRuchow2.Size = new System.Drawing.Size(35, 13);
            this.liczbaRuchow2.TabIndex = 4;
            this.liczbaRuchow2.Text = "label2";
            // 
            // wylosowana2
            // 
            this.wylosowana2.AutoSize = true;
            this.wylosowana2.Location = new System.Drawing.Point(155, 62);
            this.wylosowana2.Name = "wylosowana2";
            this.wylosowana2.Size = new System.Drawing.Size(35, 13);
            this.wylosowana2.TabIndex = 5;
            this.wylosowana2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 445);
            this.Controls.Add(this.gBPrzerwij);
            this.Controls.Add(this.gBLosowanie);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Gra: Za dużo za mało";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.gBLosowanie.ResumeLayout(false);
            this.gBLosowanie.PerformLayout();
            this.gBPrzerwij.ResumeLayout(false);
            this.gBPrzerwij.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        internal System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gBLosowanie;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Label odpowiedz;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox wpisanaLiczba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gBPrzerwij;
        private System.Windows.Forms.Label wylosowana;
        private System.Windows.Forms.Label liczbaRuchow;
        private System.Windows.Forms.Label czasGry;
        private System.Windows.Forms.Label wylosowana2;
        private System.Windows.Forms.Label liczbaRuchow2;
        private System.Windows.Forms.Label czas2;
    }
}

