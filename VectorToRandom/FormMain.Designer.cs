﻿namespace VectorToRandom {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxVectors = new System.Windows.Forms.TextBox();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.labelTickLength = new System.Windows.Forms.Label();
            this.labelTickDrawingLength = new System.Windows.Forms.Label();
            this.checkBoxEnableDrawing = new System.Windows.Forms.CheckBox();
            this.buttonClearVectors = new System.Windows.Forms.Button();
            this.labelVectorsActive = new System.Windows.Forms.Label();
            this.checkBoxCustomSize = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomW = new System.Windows.Forms.TextBox();
            this.textBoxCustomH = new System.Windows.Forms.TextBox();
            this.buttonLoadVectors = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.checkBoxStartBytesGen = new System.Windows.Forms.CheckBox();
            this.textBoxReqBytes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGeneratedBytes = new System.Windows.Forms.Label();
            this.checkBoxWriteDirectlyOnFile = new System.Windows.Forms.CheckBox();
            this.radioButtonFileBytes = new System.Windows.Forms.RadioButton();
            this.radioButtonHexFile = new System.Windows.Forms.RadioButton();
            this.buttonSetOutPathFile = new System.Windows.Forms.Button();
            this.buttonCancelProcess = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonClearBytes = new System.Windows.Forms.Button();
            this.vectorDrawer1 = new VectorToRandom.VectorDrawer();
            this.radioButtonDBG = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVectors
            // 
            this.textBoxVectors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBoxVectors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVectors.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBoxVectors.Location = new System.Drawing.Point(6, 166);
            this.textBoxVectors.Multiline = true;
            this.textBoxVectors.Name = "textBoxVectors";
            this.textBoxVectors.ReadOnly = true;
            this.textBoxVectors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxVectors.Size = new System.Drawing.Size(564, 70);
            this.textBoxVectors.TabIndex = 1;
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBoxStart.Location = new System.Drawing.Point(6, 6);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(95, 17);
            this.checkBoxStart.TabIndex = 2;
            this.checkBoxStart.Text = "Start Proccess";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckStateChanged += new System.EventHandler(this.checkBoxStart_CheckStateChanged);
            // 
            // labelTickLength
            // 
            this.labelTickLength.AutoSize = true;
            this.labelTickLength.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTickLength.Location = new System.Drawing.Point(6, 26);
            this.labelTickLength.Name = "labelTickLength";
            this.labelTickLength.Size = new System.Drawing.Size(86, 13);
            this.labelTickLength.TabIndex = 3;
            this.labelTickLength.Text = "Tick Cycle : 0Ms";
            // 
            // labelTickDrawingLength
            // 
            this.labelTickDrawingLength.AutoSize = true;
            this.labelTickDrawingLength.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTickDrawingLength.Location = new System.Drawing.Point(6, 62);
            this.labelTickDrawingLength.Name = "labelTickDrawingLength";
            this.labelTickDrawingLength.Size = new System.Drawing.Size(104, 13);
            this.labelTickDrawingLength.TabIndex = 4;
            this.labelTickDrawingLength.Text = "Drawing Cycle : 0Ms";
            // 
            // checkBoxEnableDrawing
            // 
            this.checkBoxEnableDrawing.AutoSize = true;
            this.checkBoxEnableDrawing.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBoxEnableDrawing.Location = new System.Drawing.Point(6, 42);
            this.checkBoxEnableDrawing.Name = "checkBoxEnableDrawing";
            this.checkBoxEnableDrawing.Size = new System.Drawing.Size(101, 17);
            this.checkBoxEnableDrawing.TabIndex = 5;
            this.checkBoxEnableDrawing.Text = "Enable Drawing";
            this.checkBoxEnableDrawing.UseVisualStyleBackColor = true;
            this.checkBoxEnableDrawing.CheckStateChanged += new System.EventHandler(this.checkBoxEnableDrawing_CheckStateChanged);
            // 
            // buttonClearVectors
            // 
            this.buttonClearVectors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearVectors.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonClearVectors.Location = new System.Drawing.Point(198, 64);
            this.buttonClearVectors.Name = "buttonClearVectors";
            this.buttonClearVectors.Size = new System.Drawing.Size(98, 23);
            this.buttonClearVectors.TabIndex = 6;
            this.buttonClearVectors.Text = "Clear Vectors";
            this.buttonClearVectors.UseVisualStyleBackColor = true;
            this.buttonClearVectors.Click += new System.EventHandler(this.buttonClearVectors_Click);
            // 
            // labelVectorsActive
            // 
            this.labelVectorsActive.AutoSize = true;
            this.labelVectorsActive.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelVectorsActive.Location = new System.Drawing.Point(6, 150);
            this.labelVectorsActive.Name = "labelVectorsActive";
            this.labelVectorsActive.Size = new System.Drawing.Size(91, 13);
            this.labelVectorsActive.TabIndex = 7;
            this.labelVectorsActive.Text = "0 Vectors Active :";
            // 
            // checkBoxCustomSize
            // 
            this.checkBoxCustomSize.AutoSize = true;
            this.checkBoxCustomSize.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBoxCustomSize.Location = new System.Drawing.Point(6, 78);
            this.checkBoxCustomSize.Name = "checkBoxCustomSize";
            this.checkBoxCustomSize.Size = new System.Drawing.Size(84, 17);
            this.checkBoxCustomSize.TabIndex = 8;
            this.checkBoxCustomSize.Text = "Custom Size";
            this.checkBoxCustomSize.UseVisualStyleBackColor = true;
            this.checkBoxCustomSize.CheckStateChanged += new System.EventHandler(this.checkBoxCustomSize_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "W:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "H:";
            // 
            // textBoxCustomW
            // 
            this.textBoxCustomW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBoxCustomW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustomW.Enabled = false;
            this.textBoxCustomW.Location = new System.Drawing.Point(32, 101);
            this.textBoxCustomW.Name = "textBoxCustomW";
            this.textBoxCustomW.Size = new System.Drawing.Size(71, 20);
            this.textBoxCustomW.TabIndex = 14;
            this.textBoxCustomW.TextChanged += new System.EventHandler(this.textBoxCustomW_TextChanged);
            // 
            // textBoxCustomH
            // 
            this.textBoxCustomH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBoxCustomH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustomH.Enabled = false;
            this.textBoxCustomH.Location = new System.Drawing.Point(32, 127);
            this.textBoxCustomH.Name = "textBoxCustomH";
            this.textBoxCustomH.Size = new System.Drawing.Size(71, 20);
            this.textBoxCustomH.TabIndex = 15;
            this.textBoxCustomH.TextChanged += new System.EventHandler(this.textBoxCustomH_TextChanged);
            // 
            // buttonLoadVectors
            // 
            this.buttonLoadVectors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadVectors.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonLoadVectors.Location = new System.Drawing.Point(198, 6);
            this.buttonLoadVectors.Name = "buttonLoadVectors";
            this.buttonLoadVectors.Size = new System.Drawing.Size(98, 23);
            this.buttonLoadVectors.TabIndex = 16;
            this.buttonLoadVectors.Text = "Load Vectors File";
            this.buttonLoadVectors.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveConfig.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonSaveConfig.Location = new System.Drawing.Point(198, 35);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(98, 23);
            this.buttonSaveConfig.TabIndex = 17;
            this.buttonSaveConfig.Text = "Save Vectors File";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartBytesGen
            // 
            this.checkBoxStartBytesGen.AutoSize = true;
            this.checkBoxStartBytesGen.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBoxStartBytesGen.Location = new System.Drawing.Point(323, 6);
            this.checkBoxStartBytesGen.Name = "checkBoxStartBytesGen";
            this.checkBoxStartBytesGen.Size = new System.Drawing.Size(127, 17);
            this.checkBoxStartBytesGen.TabIndex = 18;
            this.checkBoxStartBytesGen.Text = "Start Bytes Generator";
            this.checkBoxStartBytesGen.UseVisualStyleBackColor = true;
            // 
            // textBoxReqBytes
            // 
            this.textBoxReqBytes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBoxReqBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReqBytes.Location = new System.Drawing.Point(423, 29);
            this.textBoxReqBytes.Name = "textBoxReqBytes";
            this.textBoxReqBytes.Size = new System.Drawing.Size(98, 20);
            this.textBoxReqBytes.TabIndex = 19;
            this.textBoxReqBytes.TextChanged += new System.EventHandler(this.textBoxReqBytes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(320, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Requested Bytes : ";
            // 
            // labelGeneratedBytes
            // 
            this.labelGeneratedBytes.AutoSize = true;
            this.labelGeneratedBytes.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelGeneratedBytes.Location = new System.Drawing.Point(320, 52);
            this.labelGeneratedBytes.Name = "labelGeneratedBytes";
            this.labelGeneratedBytes.Size = new System.Drawing.Size(112, 13);
            this.labelGeneratedBytes.TabIndex = 21;
            this.labelGeneratedBytes.Text = "Generated Bytes : 0/0";
            // 
            // checkBoxWriteDirectlyOnFile
            // 
            this.checkBoxWriteDirectlyOnFile.AutoSize = true;
            this.checkBoxWriteDirectlyOnFile.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBoxWriteDirectlyOnFile.Location = new System.Drawing.Point(322, 68);
            this.checkBoxWriteDirectlyOnFile.Name = "checkBoxWriteDirectlyOnFile";
            this.checkBoxWriteDirectlyOnFile.Size = new System.Drawing.Size(128, 17);
            this.checkBoxWriteDirectlyOnFile.TabIndex = 22;
            this.checkBoxWriteDirectlyOnFile.Text = "Write Directly On File ";
            this.checkBoxWriteDirectlyOnFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonFileBytes
            // 
            this.radioButtonFileBytes.AutoSize = true;
            this.radioButtonFileBytes.Checked = true;
            this.radioButtonFileBytes.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButtonFileBytes.Location = new System.Drawing.Point(323, 91);
            this.radioButtonFileBytes.Name = "radioButtonFileBytes";
            this.radioButtonFileBytes.Size = new System.Drawing.Size(109, 17);
            this.radioButtonFileBytes.TabIndex = 23;
            this.radioButtonFileBytes.TabStop = true;
            this.radioButtonFileBytes.Text = "Use Bytes On File";
            this.radioButtonFileBytes.UseVisualStyleBackColor = true;
            // 
            // radioButtonHexFile
            // 
            this.radioButtonHexFile.AutoSize = true;
            this.radioButtonHexFile.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButtonHexFile.Location = new System.Drawing.Point(438, 91);
            this.radioButtonHexFile.Name = "radioButtonHexFile";
            this.radioButtonHexFile.Size = new System.Drawing.Size(118, 17);
            this.radioButtonHexFile.TabIndex = 24;
            this.radioButtonHexFile.Text = "Use Str Hex On File";
            this.radioButtonHexFile.UseVisualStyleBackColor = true;
            // 
            // buttonSetOutPathFile
            // 
            this.buttonSetOutPathFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetOutPathFile.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonSetOutPathFile.Location = new System.Drawing.Point(319, 122);
            this.buttonSetOutPathFile.Name = "buttonSetOutPathFile";
            this.buttonSetOutPathFile.Size = new System.Drawing.Size(98, 23);
            this.buttonSetOutPathFile.TabIndex = 25;
            this.buttonSetOutPathFile.Text = "Save as";
            this.buttonSetOutPathFile.UseVisualStyleBackColor = true;
            this.buttonSetOutPathFile.Click += new System.EventHandler(this.buttonSetOutPathFile_Click);
            // 
            // buttonCancelProcess
            // 
            this.buttonCancelProcess.Enabled = false;
            this.buttonCancelProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelProcess.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonCancelProcess.Location = new System.Drawing.Point(423, 122);
            this.buttonCancelProcess.Name = "buttonCancelProcess";
            this.buttonCancelProcess.Size = new System.Drawing.Size(98, 23);
            this.buttonCancelProcess.TabIndex = 26;
            this.buttonCancelProcess.Text = "Cancel Process";
            this.buttonCancelProcess.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 361);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage1.Controls.Add(this.radioButtonDBG);
            this.tabPage1.Controls.Add(this.buttonClearBytes);
            this.tabPage1.Controls.Add(this.buttonClearLog);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxLog);
            this.tabPage1.Controls.Add(this.buttonCancelProcess);
            this.tabPage1.Controls.Add(this.textBoxVectors);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.checkBoxCustomSize);
            this.tabPage1.Controls.Add(this.checkBoxStart);
            this.tabPage1.Controls.Add(this.labelVectorsActive);
            this.tabPage1.Controls.Add(this.textBoxReqBytes);
            this.tabPage1.Controls.Add(this.buttonSetOutPathFile);
            this.tabPage1.Controls.Add(this.labelGeneratedBytes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelTickLength);
            this.tabPage1.Controls.Add(this.buttonClearVectors);
            this.tabPage1.Controls.Add(this.textBoxCustomH);
            this.tabPage1.Controls.Add(this.checkBoxStartBytesGen);
            this.tabPage1.Controls.Add(this.radioButtonHexFile);
            this.tabPage1.Controls.Add(this.checkBoxWriteDirectlyOnFile);
            this.tabPage1.Controls.Add(this.buttonLoadVectors);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelTickDrawingLength);
            this.tabPage1.Controls.Add(this.checkBoxEnableDrawing);
            this.tabPage1.Controls.Add(this.textBoxCustomW);
            this.tabPage1.Controls.Add(this.buttonSaveConfig);
            this.tabPage1.Controls.Add(this.radioButtonFileBytes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config Page";
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLog.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonClearLog.Location = new System.Drawing.Point(198, 122);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(98, 23);
            this.buttonClearLog.TabIndex = 30;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(8, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Log :";
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBoxLog.Location = new System.Drawing.Point(6, 255);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(564, 70);
            this.textBoxLog.TabIndex = 28;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.vectorDrawer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vectors Page";
            // 
            // buttonClearBytes
            // 
            this.buttonClearBytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearBytes.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonClearBytes.Location = new System.Drawing.Point(198, 93);
            this.buttonClearBytes.Name = "buttonClearBytes";
            this.buttonClearBytes.Size = new System.Drawing.Size(98, 23);
            this.buttonClearBytes.TabIndex = 31;
            this.buttonClearBytes.Text = "Clear Bytes";
            this.buttonClearBytes.UseVisualStyleBackColor = true;
            this.buttonClearBytes.Click += new System.EventHandler(this.buttonClearBytes_Click);
            // 
            // vectorDrawer1
            // 
            this.vectorDrawer1.ActiveDrawing = false;
            this.vectorDrawer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.vectorDrawer1.ClearBeforeDrawing = true;
            this.vectorDrawer1.CustomHeight = 0D;
            this.vectorDrawer1.CustomWidth = 0D;
            this.vectorDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorDrawer1.Location = new System.Drawing.Point(3, 3);
            this.vectorDrawer1.Margin = new System.Windows.Forms.Padding(0);
            this.vectorDrawer1.Name = "vectorDrawer1";
            this.vectorDrawer1.Size = new System.Drawing.Size(570, 329);
            this.vectorDrawer1.StartTick = true;
            this.vectorDrawer1.TabIndex = 0;
            this.vectorDrawer1.UseCustomSize = false;
            this.vectorDrawer1.NewPointAdded += new System.EventHandler(this.vectorDrawer1_NewPointAdded);
            this.vectorDrawer1.EndTickProcess += new System.EventHandler(this.vectorDrawer1_EndTickProcess);
            // 
            // radioButtonDBG
            // 
            this.radioButtonDBG.AutoSize = true;
            this.radioButtonDBG.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButtonDBG.Location = new System.Drawing.Point(499, 67);
            this.radioButtonDBG.Name = "radioButtonDBG";
            this.radioButtonDBG.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDBG.TabIndex = 32;
            this.radioButtonDBG.TabStop = true;
            this.radioButtonDBG.Text = "Debug";
            this.radioButtonDBG.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vector To Random";
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VectorDrawer vectorDrawer1;
        private System.Windows.Forms.TextBox textBoxVectors;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.Label labelTickLength;
        private System.Windows.Forms.Label labelTickDrawingLength;
        private System.Windows.Forms.CheckBox checkBoxEnableDrawing;
        private System.Windows.Forms.Button buttonClearVectors;
        private System.Windows.Forms.Label labelVectorsActive;
        private System.Windows.Forms.CheckBox checkBoxCustomSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomW;
        private System.Windows.Forms.TextBox textBoxCustomH;
        private System.Windows.Forms.Button buttonLoadVectors;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.CheckBox checkBoxStartBytesGen;
        private System.Windows.Forms.TextBox textBoxReqBytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGeneratedBytes;
        private System.Windows.Forms.CheckBox checkBoxWriteDirectlyOnFile;
        private System.Windows.Forms.RadioButton radioButtonFileBytes;
        private System.Windows.Forms.RadioButton radioButtonHexFile;
        private System.Windows.Forms.Button buttonSetOutPathFile;
        private System.Windows.Forms.Button buttonCancelProcess;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonClearBytes;
        private System.Windows.Forms.RadioButton radioButtonDBG;
    }
}

