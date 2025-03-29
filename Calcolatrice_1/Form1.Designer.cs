namespace Calcolatrice_1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            risultato = new Button();
            addizione = new Button();
            divisione = new Button();
            moltiplicazione = new Button();
            sottrazione = new Button();
            num = new Label();
            ac = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(252, 140);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 140);
            button2.Name = "button2";
            button2.Size = new Size(46, 40);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(356, 140);
            button3.Name = "button3";
            button3.Size = new Size(46, 40);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(252, 186);
            button4.Name = "button4";
            button4.Size = new Size(46, 40);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(304, 186);
            button5.Name = "button5";
            button5.Size = new Size(46, 40);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(356, 186);
            button6.Name = "button6";
            button6.Size = new Size(46, 40);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(252, 232);
            button7.Name = "button7";
            button7.Size = new Size(46, 40);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(304, 232);
            button8.Name = "button8";
            button8.Size = new Size(46, 40);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(356, 232);
            button9.Name = "button9";
            button9.Size = new Size(46, 40);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(356, 278);
            button10.Name = "button10";
            button10.Size = new Size(46, 40);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // risultato
            // 
            risultato.Location = new Point(252, 278);
            risultato.Name = "risultato";
            risultato.Size = new Size(98, 40);
            risultato.TabIndex = 10;
            risultato.Text = "=";
            risultato.UseVisualStyleBackColor = true;
            risultato.Click += risultato_Click;
            // 
            // addizione
            // 
            addizione.Location = new Point(408, 140);
            addizione.Name = "addizione";
            addizione.Size = new Size(27, 40);
            addizione.TabIndex = 11;
            addizione.Text = "+";
            addizione.UseVisualStyleBackColor = true;
            addizione.Click += addizione_Click;
            // 
            // divisione
            // 
            divisione.Location = new Point(408, 278);
            divisione.Name = "divisione";
            divisione.Size = new Size(27, 40);
            divisione.TabIndex = 12;
            divisione.Text = "/";
            divisione.UseVisualStyleBackColor = true;
            divisione.Click += divisione_Click;
            // 
            // moltiplicazione
            // 
            moltiplicazione.Location = new Point(408, 232);
            moltiplicazione.Name = "moltiplicazione";
            moltiplicazione.Size = new Size(27, 40);
            moltiplicazione.TabIndex = 13;
            moltiplicazione.Text = "*";
            moltiplicazione.UseVisualStyleBackColor = true;
            moltiplicazione.Click += button14_Click;
            // 
            // sottrazione
            // 
            sottrazione.Location = new Point(408, 186);
            sottrazione.Name = "sottrazione";
            sottrazione.Size = new Size(27, 40);
            sottrazione.TabIndex = 14;
            sottrazione.Text = "-";
            sottrazione.UseVisualStyleBackColor = true;
            sottrazione.Click += sottrazione_Click;
            // 
            // num
            // 
            num.AutoSize = true;
            num.Location = new Point(255, 100);
            num.MinimumSize = new Size(180, 20);
            num.Name = "num";
            num.Size = new Size(180, 20);
            num.TabIndex = 15;
            // 
            // ac
            // 
            ac.Location = new Point(252, 324);
            ac.Name = "ac";
            ac.Size = new Size(183, 23);
            ac.TabIndex = 16;
            ac.Text = "AC";
            ac.UseVisualStyleBackColor = true;
            ac.Click += ac_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ac);
            Controls.Add(num);
            Controls.Add(sottrazione);
            Controls.Add(moltiplicazione);
            Controls.Add(divisione);
            Controls.Add(addizione);
            Controls.Add(risultato);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button risultato;
        private Button addizione;
        private Button divisione;
        private Button moltiplicazione;
        private Button sottrazione;
        private Label num;
        private Button ac;
    }
}
