namespace VectorToRandom {
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
            this.vectorDrawer1 = new VectorToRandom.VectorDrawer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vectorDrawer1
            // 
            this.vectorDrawer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vectorDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vectorDrawer1.Location = new System.Drawing.Point(0, 0);
            this.vectorDrawer1.Margin = new System.Windows.Forms.Padding(0);
            this.vectorDrawer1.Name = "vectorDrawer1";
            this.vectorDrawer1.Size = new System.Drawing.Size(1264, 581);
            this.vectorDrawer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vectorDrawer1);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VectorDrawer vectorDrawer1;
        private System.Windows.Forms.Label label1;
    }
}

