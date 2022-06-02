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
            this.SuspendLayout();
            // 
            // vectorDrawer1
            // 
            this.vectorDrawer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vectorDrawer1.Location = new System.Drawing.Point(9, 9);
            this.vectorDrawer1.Margin = new System.Windows.Forms.Padding(0);
            this.vectorDrawer1.Name = "vectorDrawer1";
            this.vectorDrawer1.Size = new System.Drawing.Size(1383, 746);
            this.vectorDrawer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 764);
            this.Controls.Add(this.vectorDrawer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private VectorDrawer vectorDrawer1;
    }
}

