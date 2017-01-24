namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttNumber0 = new System.Windows.Forms.Button();
            this.bttDecmal = new System.Windows.Forms.Button();
            this.bttPlus = new System.Windows.Forms.Button();
            this.bttEquals = new System.Windows.Forms.Button();
            this.bttScore = new System.Windows.Forms.Button();
            this.bttFive = new System.Windows.Forms.Button();
            this.bttSix = new System.Windows.Forms.Button();
            this.bttTimes = new System.Windows.Forms.Button();
            this.bttInverse = new System.Windows.Forms.Button();
            this.bttOne = new System.Windows.Forms.Button();
            this.bttThree = new System.Windows.Forms.Button();
            this.bttTwo = new System.Windows.Forms.Button();
            this.bttC = new System.Windows.Forms.Button();
            this.bttPluseMinus = new System.Windows.Forms.Button();
            this.bttMMinus = new System.Windows.Forms.Button();
            this.bttSlash = new System.Windows.Forms.Button();
            this.bttDivde = new System.Windows.Forms.Button();
            this.bttCe = new System.Windows.Forms.Button();
            this.bttMc = new System.Windows.Forms.Button();
            this.bttNine = new System.Windows.Forms.Button();
            this.BttEight = new System.Windows.Forms.Button();
            this.bttSeven = new System.Windows.Forms.Button();
            this.bttPercent = new System.Windows.Forms.Button();
            this.btt4 = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.bttArrow = new System.Windows.Forms.Button();
            this.bttMs = new System.Windows.Forms.Button();
            this.bttMPlus = new System.Windows.Forms.Button();
            this.bttMr = new System.Windows.Forms.Button();
            this.labCurrentOperation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(473, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bttNumber0
            // 
            this.bttNumber0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.bttNumber0.Location = new System.Drawing.Point(20, 434);
            this.bttNumber0.Margin = new System.Windows.Forms.Padding(5);
            this.bttNumber0.Name = "bttNumber0";
            this.bttNumber0.Size = new System.Drawing.Size(164, 55);
            this.bttNumber0.TabIndex = 2;
            this.bttNumber0.Text = "0";
            this.bttNumber0.UseVisualStyleBackColor = true;
            this.bttNumber0.Click += new System.EventHandler(this.buttClick);
            // 
            // bttDecmal
            // 
            this.bttDecmal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDecmal.Location = new System.Drawing.Point(194, 434);
            this.bttDecmal.Margin = new System.Windows.Forms.Padding(5);
            this.bttDecmal.Name = "bttDecmal";
            this.bttDecmal.Size = new System.Drawing.Size(77, 55);
            this.bttDecmal.TabIndex = 3;
            this.bttDecmal.Text = ".";
            this.bttDecmal.UseVisualStyleBackColor = true;
            this.bttDecmal.Click += new System.EventHandler(this.buttClick);
            // 
            // bttPlus
            // 
            this.bttPlus.ForeColor = System.Drawing.Color.Black;
            this.bttPlus.Location = new System.Drawing.Point(281, 434);
            this.bttPlus.Margin = new System.Windows.Forms.Padding(5);
            this.bttPlus.Name = "bttPlus";
            this.bttPlus.Size = new System.Drawing.Size(77, 55);
            this.bttPlus.TabIndex = 4;
            this.bttPlus.Text = "+";
            this.bttPlus.UseVisualStyleBackColor = true;
            this.bttPlus.Click += new System.EventHandler(this.operatorClick);
            // 
            // bttEquals
            // 
            this.bttEquals.BackColor = System.Drawing.Color.Transparent;
            this.bttEquals.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.bttEquals.ForeColor = System.Drawing.Color.Black;
            this.bttEquals.Location = new System.Drawing.Point(368, 369);
            this.bttEquals.Margin = new System.Windows.Forms.Padding(5);
            this.bttEquals.Name = "bttEquals";
            this.bttEquals.Size = new System.Drawing.Size(77, 120);
            this.bttEquals.TabIndex = 5;
            this.bttEquals.Text = "=";
            this.bttEquals.UseVisualStyleBackColor = false;
            this.bttEquals.Click += new System.EventHandler(this.bttEquals_Click);
            // 
            // bttScore
            // 
            this.bttScore.ForeColor = System.Drawing.Color.Black;
            this.bttScore.Location = new System.Drawing.Point(281, 369);
            this.bttScore.Margin = new System.Windows.Forms.Padding(5);
            this.bttScore.Name = "bttScore";
            this.bttScore.Size = new System.Drawing.Size(77, 55);
            this.bttScore.TabIndex = 6;
            this.bttScore.Text = "-";
            this.bttScore.UseVisualStyleBackColor = true;
            this.bttScore.Click += new System.EventHandler(this.operatorClick);
            // 
            // bttFive
            // 
            this.bttFive.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFive.Location = new System.Drawing.Point(107, 304);
            this.bttFive.Margin = new System.Windows.Forms.Padding(5);
            this.bttFive.Name = "bttFive";
            this.bttFive.Size = new System.Drawing.Size(77, 55);
            this.bttFive.TabIndex = 7;
            this.bttFive.Text = "5";
            this.bttFive.UseVisualStyleBackColor = true;
            this.bttFive.Click += new System.EventHandler(this.buttClick);
            // 
            // bttSix
            // 
            this.bttSix.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSix.Location = new System.Drawing.Point(194, 304);
            this.bttSix.Margin = new System.Windows.Forms.Padding(5);
            this.bttSix.Name = "bttSix";
            this.bttSix.Size = new System.Drawing.Size(77, 55);
            this.bttSix.TabIndex = 8;
            this.bttSix.Text = "6";
            this.bttSix.UseVisualStyleBackColor = true;
            this.bttSix.Click += new System.EventHandler(this.buttClick);
            // 
            // bttTimes
            // 
            this.bttTimes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTimes.ForeColor = System.Drawing.Color.Black;
            this.bttTimes.Location = new System.Drawing.Point(281, 304);
            this.bttTimes.Margin = new System.Windows.Forms.Padding(5);
            this.bttTimes.Name = "bttTimes";
            this.bttTimes.Size = new System.Drawing.Size(77, 55);
            this.bttTimes.TabIndex = 9;
            this.bttTimes.Text = "*";
            this.bttTimes.UseVisualStyleBackColor = true;
            this.bttTimes.Click += new System.EventHandler(this.operatorClick);
            // 
            // bttInverse
            // 
            this.bttInverse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttInverse.ForeColor = System.Drawing.Color.Black;
            this.bttInverse.Location = new System.Drawing.Point(368, 304);
            this.bttInverse.Margin = new System.Windows.Forms.Padding(5);
            this.bttInverse.Name = "bttInverse";
            this.bttInverse.Size = new System.Drawing.Size(77, 55);
            this.bttInverse.TabIndex = 10;
            this.bttInverse.Text = "1/X";
            this.bttInverse.UseVisualStyleBackColor = true;
            // 
            // bttOne
            // 
            this.bttOne.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOne.Location = new System.Drawing.Point(20, 369);
            this.bttOne.Margin = new System.Windows.Forms.Padding(5);
            this.bttOne.Name = "bttOne";
            this.bttOne.Size = new System.Drawing.Size(77, 55);
            this.bttOne.TabIndex = 11;
            this.bttOne.Text = "1";
            this.bttOne.UseVisualStyleBackColor = true;
            this.bttOne.Click += new System.EventHandler(this.buttClick);
            // 
            // bttThree
            // 
            this.bttThree.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThree.Location = new System.Drawing.Point(194, 369);
            this.bttThree.Margin = new System.Windows.Forms.Padding(5);
            this.bttThree.Name = "bttThree";
            this.bttThree.Size = new System.Drawing.Size(77, 55);
            this.bttThree.TabIndex = 12;
            this.bttThree.Text = "3";
            this.bttThree.UseVisualStyleBackColor = true;
            this.bttThree.Click += new System.EventHandler(this.buttClick);
            // 
            // bttTwo
            // 
            this.bttTwo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTwo.Location = new System.Drawing.Point(107, 369);
            this.bttTwo.Margin = new System.Windows.Forms.Padding(5);
            this.bttTwo.Name = "bttTwo";
            this.bttTwo.Size = new System.Drawing.Size(77, 55);
            this.bttTwo.TabIndex = 13;
            this.bttTwo.Text = "2";
            this.bttTwo.UseVisualStyleBackColor = true;
            this.bttTwo.Click += new System.EventHandler(this.buttClick);
            // 
            // bttC
            // 
            this.bttC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttC.Location = new System.Drawing.Point(194, 174);
            this.bttC.Margin = new System.Windows.Forms.Padding(5);
            this.bttC.Name = "bttC";
            this.bttC.Size = new System.Drawing.Size(77, 55);
            this.bttC.TabIndex = 14;
            this.bttC.Text = "C";
            this.bttC.UseVisualStyleBackColor = true;
            this.bttC.Click += new System.EventHandler(this.bttC_Click);
            // 
            // bttPluseMinus
            // 
            this.bttPluseMinus.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.bttPluseMinus.Location = new System.Drawing.Point(281, 174);
            this.bttPluseMinus.Margin = new System.Windows.Forms.Padding(5);
            this.bttPluseMinus.Name = "bttPluseMinus";
            this.bttPluseMinus.Size = new System.Drawing.Size(77, 55);
            this.bttPluseMinus.TabIndex = 15;
            this.bttPluseMinus.Text = "±";
            this.bttPluseMinus.UseVisualStyleBackColor = true;
            // 
            // bttMMinus
            // 
            this.bttMMinus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMMinus.Location = new System.Drawing.Point(368, 109);
            this.bttMMinus.Margin = new System.Windows.Forms.Padding(5);
            this.bttMMinus.Name = "bttMMinus";
            this.bttMMinus.Size = new System.Drawing.Size(77, 55);
            this.bttMMinus.TabIndex = 16;
            this.bttMMinus.Text = "M-";
            this.bttMMinus.UseVisualStyleBackColor = true;
            // 
            // bttSlash
            // 
            this.bttSlash.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSlash.Location = new System.Drawing.Point(281, 237);
            this.bttSlash.Margin = new System.Windows.Forms.Padding(5);
            this.bttSlash.Name = "bttSlash";
            this.bttSlash.Size = new System.Drawing.Size(77, 55);
            this.bttSlash.TabIndex = 17;
            this.bttSlash.Text = "/";
            this.bttSlash.UseVisualStyleBackColor = true;
            this.bttSlash.Click += new System.EventHandler(this.operatorClick);
            // 
            // bttDivde
            // 
            this.bttDivde.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDivde.Location = new System.Drawing.Point(368, 174);
            this.bttDivde.Margin = new System.Windows.Forms.Padding(5);
            this.bttDivde.Name = "bttDivde";
            this.bttDivde.Size = new System.Drawing.Size(77, 55);
            this.bttDivde.TabIndex = 18;
            this.bttDivde.Text = "√";
            this.bttDivde.UseVisualStyleBackColor = true;
            // 
            // bttCe
            // 
            this.bttCe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCe.Location = new System.Drawing.Point(107, 174);
            this.bttCe.Margin = new System.Windows.Forms.Padding(5);
            this.bttCe.Name = "bttCe";
            this.bttCe.Size = new System.Drawing.Size(77, 55);
            this.bttCe.TabIndex = 19;
            this.bttCe.Text = "CE";
            this.bttCe.UseVisualStyleBackColor = true;
            this.bttCe.Click += new System.EventHandler(this.bttCe_Click);
            // 
            // bttMc
            // 
            this.bttMc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMc.Location = new System.Drawing.Point(20, 109);
            this.bttMc.Margin = new System.Windows.Forms.Padding(5);
            this.bttMc.Name = "bttMc";
            this.bttMc.Size = new System.Drawing.Size(77, 55);
            this.bttMc.TabIndex = 20;
            this.bttMc.Text = "MC";
            this.bttMc.UseVisualStyleBackColor = true;
            // 
            // bttNine
            // 
            this.bttNine.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNine.Location = new System.Drawing.Point(194, 239);
            this.bttNine.Margin = new System.Windows.Forms.Padding(5);
            this.bttNine.Name = "bttNine";
            this.bttNine.Size = new System.Drawing.Size(77, 55);
            this.bttNine.TabIndex = 21;
            this.bttNine.Text = "9";
            this.bttNine.UseVisualStyleBackColor = true;
            this.bttNine.Click += new System.EventHandler(this.buttClick);
            // 
            // BttEight
            // 
            this.BttEight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttEight.Location = new System.Drawing.Point(107, 239);
            this.BttEight.Margin = new System.Windows.Forms.Padding(5);
            this.BttEight.Name = "BttEight";
            this.BttEight.Size = new System.Drawing.Size(77, 55);
            this.BttEight.TabIndex = 22;
            this.BttEight.Text = "8";
            this.BttEight.UseVisualStyleBackColor = true;
            this.BttEight.Click += new System.EventHandler(this.buttClick);
            // 
            // bttSeven
            // 
            this.bttSeven.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSeven.Location = new System.Drawing.Point(20, 239);
            this.bttSeven.Margin = new System.Windows.Forms.Padding(5);
            this.bttSeven.Name = "bttSeven";
            this.bttSeven.Size = new System.Drawing.Size(77, 55);
            this.bttSeven.TabIndex = 23;
            this.bttSeven.Text = "7";
            this.bttSeven.UseVisualStyleBackColor = true;
            this.bttSeven.Click += new System.EventHandler(this.buttClick);
            // 
            // bttPercent
            // 
            this.bttPercent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPercent.Location = new System.Drawing.Point(368, 237);
            this.bttPercent.Margin = new System.Windows.Forms.Padding(5);
            this.bttPercent.Name = "bttPercent";
            this.bttPercent.Size = new System.Drawing.Size(77, 55);
            this.bttPercent.TabIndex = 24;
            this.bttPercent.Text = "%";
            this.bttPercent.UseVisualStyleBackColor = true;
            // 
            // btt4
            // 
            this.btt4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt4.Location = new System.Drawing.Point(20, 304);
            this.btt4.Margin = new System.Windows.Forms.Padding(5);
            this.btt4.Name = "btt4";
            this.btt4.Size = new System.Drawing.Size(77, 55);
            this.btt4.TabIndex = 25;
            this.btt4.Text = "4";
            this.btt4.UseVisualStyleBackColor = true;
            this.btt4.Click += new System.EventHandler(this.buttClick);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResult.Location = new System.Drawing.Point(20, 57);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(425, 30);
            this.txtBoxResult.TabIndex = 26;
            // 
            // bttArrow
            // 
            this.bttArrow.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.bttArrow.Location = new System.Drawing.Point(20, 174);
            this.bttArrow.Margin = new System.Windows.Forms.Padding(5);
            this.bttArrow.Name = "bttArrow";
            this.bttArrow.Size = new System.Drawing.Size(77, 55);
            this.bttArrow.TabIndex = 27;
            this.bttArrow.Text = "←";
            this.bttArrow.UseVisualStyleBackColor = true;
            // 
            // bttMs
            // 
            this.bttMs.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMs.Location = new System.Drawing.Point(194, 109);
            this.bttMs.Margin = new System.Windows.Forms.Padding(5);
            this.bttMs.Name = "bttMs";
            this.bttMs.Size = new System.Drawing.Size(77, 55);
            this.bttMs.TabIndex = 30;
            this.bttMs.Text = "MS";
            this.bttMs.UseVisualStyleBackColor = true;
            // 
            // bttMPlus
            // 
            this.bttMPlus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMPlus.Location = new System.Drawing.Point(281, 109);
            this.bttMPlus.Margin = new System.Windows.Forms.Padding(5);
            this.bttMPlus.Name = "bttMPlus";
            this.bttMPlus.Size = new System.Drawing.Size(77, 55);
            this.bttMPlus.TabIndex = 31;
            this.bttMPlus.Text = "M+";
            this.bttMPlus.UseVisualStyleBackColor = true;
            // 
            // bttMr
            // 
            this.bttMr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMr.Location = new System.Drawing.Point(107, 109);
            this.bttMr.Margin = new System.Windows.Forms.Padding(5);
            this.bttMr.Name = "bttMr";
            this.bttMr.Size = new System.Drawing.Size(77, 55);
            this.bttMr.TabIndex = 32;
            this.bttMr.Text = "MR";
            this.bttMr.UseVisualStyleBackColor = true;
            // 
            // labCurrentOperation
            // 
            this.labCurrentOperation.AutoSize = true;
            this.labCurrentOperation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentOperation.Location = new System.Drawing.Point(16, 31);
            this.labCurrentOperation.Name = "labCurrentOperation";
            this.labCurrentOperation.Size = new System.Drawing.Size(0, 23);
            this.labCurrentOperation.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 560);
            this.Controls.Add(this.labCurrentOperation);
            this.Controls.Add(this.bttMr);
            this.Controls.Add(this.bttMPlus);
            this.Controls.Add(this.bttMs);
            this.Controls.Add(this.bttArrow);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.btt4);
            this.Controls.Add(this.bttPercent);
            this.Controls.Add(this.bttSeven);
            this.Controls.Add(this.BttEight);
            this.Controls.Add(this.bttNine);
            this.Controls.Add(this.bttMc);
            this.Controls.Add(this.bttCe);
            this.Controls.Add(this.bttDivde);
            this.Controls.Add(this.bttSlash);
            this.Controls.Add(this.bttMMinus);
            this.Controls.Add(this.bttPluseMinus);
            this.Controls.Add(this.bttC);
            this.Controls.Add(this.bttTwo);
            this.Controls.Add(this.bttThree);
            this.Controls.Add(this.bttOne);
            this.Controls.Add(this.bttInverse);
            this.Controls.Add(this.bttTimes);
            this.Controls.Add(this.bttSix);
            this.Controls.Add(this.bttFive);
            this.Controls.Add(this.bttScore);
            this.Controls.Add(this.bttEquals);
            this.Controls.Add(this.bttPlus);
            this.Controls.Add(this.bttDecmal);
            this.Controls.Add(this.bttNumber0);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button bttNumber0;
        private System.Windows.Forms.Button bttDecmal;
        private System.Windows.Forms.Button bttPlus;
        private System.Windows.Forms.Button bttEquals;
        private System.Windows.Forms.Button bttScore;
        private System.Windows.Forms.Button bttFive;
        private System.Windows.Forms.Button bttSix;
        private System.Windows.Forms.Button bttTimes;
        private System.Windows.Forms.Button bttInverse;
        private System.Windows.Forms.Button bttOne;
        private System.Windows.Forms.Button bttThree;
        private System.Windows.Forms.Button bttTwo;
        private System.Windows.Forms.Button bttC;
        private System.Windows.Forms.Button bttPluseMinus;
        private System.Windows.Forms.Button bttMMinus;
        private System.Windows.Forms.Button bttSlash;
        private System.Windows.Forms.Button bttDivde;
        private System.Windows.Forms.Button bttCe;
        private System.Windows.Forms.Button bttMc;
        private System.Windows.Forms.Button bttNine;
        private System.Windows.Forms.Button BttEight;
        private System.Windows.Forms.Button bttSeven;
        private System.Windows.Forms.Button bttPercent;
        private System.Windows.Forms.Button btt4;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button bttArrow;
        private System.Windows.Forms.Button bttMs;
        private System.Windows.Forms.Button bttMPlus;
        private System.Windows.Forms.Button bttMr;
        private System.Windows.Forms.Label labCurrentOperation;
    }
}

