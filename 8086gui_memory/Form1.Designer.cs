namespace _8086gui_memory
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
            this.commitOperationButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.opSelector = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dlInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dhInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bhInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ahInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regSelector1 = new System.Windows.Forms.TextBox();
            this.regSelector2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.memoryInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.memoryOutput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.memoryOutput1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.memoryInput1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commitOperationButton
            // 
            this.commitOperationButton.Location = new System.Drawing.Point(6, 299);
            this.commitOperationButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.commitOperationButton.Name = "commitOperationButton";
            this.commitOperationButton.Size = new System.Drawing.Size(247, 70);
            this.commitOperationButton.TabIndex = 49;
            this.commitOperationButton.Text = "Wykonaj operację";
            this.commitOperationButton.UseVisualStyleBackColor = true;
            this.commitOperationButton.Click += new System.EventHandler(this.commitOperationButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 250);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.MinimumSize = new System.Drawing.Size(59, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "Arg 2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 250);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.MinimumSize = new System.Drawing.Size(59, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Arg 1";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 250);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.MinimumSize = new System.Drawing.Size(86, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Operacja";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opSelector
            // 
            this.opSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opSelector.FormattingEnabled = true;
            this.opSelector.Location = new System.Drawing.Point(6, 267);
            this.opSelector.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.opSelector.Name = "opSelector";
            this.opSelector.Size = new System.Drawing.Size(88, 23);
            this.opSelector.TabIndex = 45;
            this.opSelector.SelectedIndexChanged += new System.EventHandler(this.opSelector_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 221);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Parametry operacji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.MinimumSize = new System.Drawing.Size(108, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "DL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlInput
            // 
            this.dlInput.Location = new System.Drawing.Point(146, 191);
            this.dlInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dlInput.MaxLength = 2;
            this.dlInput.Name = "dlInput";
            this.dlInput.Size = new System.Drawing.Size(110, 23);
            this.dlInput.TabIndex = 40;
            this.dlInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MinimumSize = new System.Drawing.Size(108, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "DH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dhInput
            // 
            this.dhInput.Location = new System.Drawing.Point(6, 191);
            this.dhInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dhInput.MaxLength = 2;
            this.dhInput.Name = "dhInput";
            this.dhInput.Size = new System.Drawing.Size(110, 23);
            this.dhInput.TabIndex = 38;
            this.dhInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MinimumSize = new System.Drawing.Size(108, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "CL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clInput
            // 
            this.clInput.Location = new System.Drawing.Point(146, 144);
            this.clInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clInput.MaxLength = 2;
            this.clInput.Name = "clInput";
            this.clInput.Size = new System.Drawing.Size(110, 23);
            this.clInput.TabIndex = 36;
            this.clInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.MinimumSize = new System.Drawing.Size(108, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "CH";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chInput
            // 
            this.chInput.Location = new System.Drawing.Point(6, 144);
            this.chInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chInput.MaxLength = 2;
            this.chInput.Name = "chInput";
            this.chInput.Size = new System.Drawing.Size(110, 23);
            this.chInput.TabIndex = 34;
            this.chInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MinimumSize = new System.Drawing.Size(108, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "BL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blInput
            // 
            this.blInput.Location = new System.Drawing.Point(146, 97);
            this.blInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.blInput.MaxLength = 2;
            this.blInput.Name = "blInput";
            this.blInput.Size = new System.Drawing.Size(110, 23);
            this.blInput.TabIndex = 32;
            this.blInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MinimumSize = new System.Drawing.Size(108, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "BH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bhInput
            // 
            this.bhInput.Location = new System.Drawing.Point(6, 97);
            this.bhInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bhInput.MaxLength = 2;
            this.bhInput.Name = "bhInput";
            this.bhInput.Size = new System.Drawing.Size(110, 23);
            this.bhInput.TabIndex = 30;
            this.bhInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MinimumSize = new System.Drawing.Size(108, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "AL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alInput
            // 
            this.alInput.Location = new System.Drawing.Point(146, 50);
            this.alInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.alInput.MaxLength = 2;
            this.alInput.Name = "alInput";
            this.alInput.Size = new System.Drawing.Size(110, 23);
            this.alInput.TabIndex = 28;
            this.alInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MinimumSize = new System.Drawing.Size(108, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "AH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ahInput
            // 
            this.ahInput.Location = new System.Drawing.Point(6, 50);
            this.ahInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ahInput.MaxLength = 2;
            this.ahInput.Name = "ahInput";
            this.ahInput.Size = new System.Drawing.Size(110, 23);
            this.ahInput.TabIndex = 26;
            this.ahInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dane wejściowe";
            // 
            // regSelector1
            // 
            this.regSelector1.Location = new System.Drawing.Point(117, 267);
            this.regSelector1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.regSelector1.MaxLength = 4;
            this.regSelector1.Name = "regSelector1";
            this.regSelector1.Size = new System.Drawing.Size(59, 23);
            this.regSelector1.TabIndex = 67;
            this.regSelector1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regSelector2
            // 
            this.regSelector2.Location = new System.Drawing.Point(194, 267);
            this.regSelector2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.regSelector2.MaxLength = 4;
            this.regSelector2.Name = "regSelector2";
            this.regSelector2.Size = new System.Drawing.Size(59, 23);
            this.regSelector2.TabIndex = 68;
            this.regSelector2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(274, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 69;
            this.label14.Text = "Wypisz z pamięci";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // memoryInput
            // 
            this.memoryInput.Location = new System.Drawing.Point(274, 50);
            this.memoryInput.MaxLength = 4;
            this.memoryInput.Name = "memoryInput";
            this.memoryInput.Size = new System.Drawing.Size(108, 23);
            this.memoryInput.TabIndex = 70;
            this.memoryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.MinimumSize = new System.Drawing.Size(108, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 18);
            this.label15.TabIndex = 71;
            this.label15.Text = "Adres";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(274, 116);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.MinimumSize = new System.Drawing.Size(108, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 18);
            this.label16.TabIndex = 73;
            this.label16.Text = "Wynik";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoryOutput
            // 
            this.memoryOutput.BackColor = System.Drawing.Color.White;
            this.memoryOutput.Enabled = false;
            this.memoryOutput.ForeColor = System.Drawing.Color.Black;
            this.memoryOutput.Location = new System.Drawing.Point(274, 144);
            this.memoryOutput.Name = "memoryOutput";
            this.memoryOutput.ReadOnly = true;
            this.memoryOutput.Size = new System.Drawing.Size(108, 23);
            this.memoryOutput.TabIndex = 74;
            this.memoryOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(274, 190);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 20);
            this.label17.TabIndex = 75;
            this.label17.Text = "Wpisz do pamięci";
            // 
            // memoryOutput1
            // 
            this.memoryOutput1.BackColor = System.Drawing.Color.White;
            this.memoryOutput1.ForeColor = System.Drawing.Color.Black;
            this.memoryOutput1.Location = new System.Drawing.Point(274, 299);
            this.memoryOutput1.Name = "memoryOutput1";
            this.memoryOutput1.Size = new System.Drawing.Size(108, 23);
            this.memoryOutput1.TabIndex = 79;
            this.memoryOutput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(274, 272);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.MinimumSize = new System.Drawing.Size(108, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 18);
            this.label18.TabIndex = 78;
            this.label18.Text = "Dane";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(274, 221);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.MinimumSize = new System.Drawing.Size(108, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 18);
            this.label19.TabIndex = 77;
            this.label19.Text = "Adres";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoryInput1
            // 
            this.memoryInput1.Location = new System.Drawing.Point(274, 240);
            this.memoryInput1.MaxLength = 4;
            this.memoryInput1.Name = "memoryInput1";
            this.memoryInput1.Size = new System.Drawing.Size(108, 23);
            this.memoryInput1.TabIndex = 76;
            this.memoryInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 80;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.memoryOutput1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.memoryInput1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.memoryOutput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.memoryInput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.regSelector2);
            this.Controls.Add(this.regSelector1);
            this.Controls.Add(this.commitOperationButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.opSelector);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dlInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dhInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bhInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ahInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "8086 simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button commitOperationButton;
        private Label label13;
        private Label label12;
        private Label label11;
        private ComboBox opSelector;
        private Label label10;
        private Label label6;
        private TextBox dlInput;
        private Label label7;
        private TextBox dhInput;
        private Label label8;
        private TextBox clInput;
        private Label label9;
        private TextBox chInput;
        private Label label4;
        private TextBox blInput;
        private Label label5;
        private TextBox bhInput;
        private Label label3;
        private TextBox alInput;
        private Label label2;
        private TextBox ahInput;
        private Label label1;
        private TextBox regSelector1;
        private TextBox regSelector2;
        private Label label14;
        private TextBox memoryInput;
        private Label label15;
        private Button button1;
        private Label label16;
        private TextBox memoryOutput;
        private Label label17;
        private TextBox memoryOutput1;
        private Label label18;
        private Label label19;
        private TextBox memoryInput1;
        private Button button2;
    }
}