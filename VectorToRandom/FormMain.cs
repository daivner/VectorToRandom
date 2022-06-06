using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorToRandom {
    public partial class FormMain : Form {

        double customSizeW, customSizeH;
        int requestedBytes;
        List<byte> generatedBytes;
        string fileNameOut, filePathOut;

        public FormMain() {
            InitializeComponent();
            textBoxCustomH.Text = Height.ToString();
            textBoxCustomW.Text = Width.ToString();
            requestedBytes = 0;
            generatedBytes = new List<byte>();
        }

        private void vectorDrawer1_NewPointAdded(object sender, EventArgs e) {
            textBoxVectors.AppendText(((EventArgsVector)e).Vector.ToString() + (char)13 + (char)10 + (char)13 + (char)10);
            labelVectorsActive.Text = vectorDrawer1.Vectors.Count.ToString() + " Vectors Active ";
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> New Vector Added" + (char)13 + (char)10);
        }

        private void FormMain_SizeChanged(object sender, EventArgs e) {

            textBoxVectors.Width = Width - 36;
            textBoxVectors.Height = (Height - 260) / 2;

            //Label Log 
            label5.Location = new Point(8, textBoxVectors.Location.Y + textBoxVectors.Height + 3);

            textBoxLog.Width = Width - 36;
            textBoxLog.Height = (Height - 260) / 2;
            textBoxLog.Location = new Point(6, label5.Location.Y + label5.Height + 3);


            if (!checkBoxCustomSize.Checked) {
                textBoxCustomH.Text = Height.ToString();
                textBoxCustomW.Text = Width.ToString();
            } else {
                if (textBoxCustomH.ForeColor == Color.Red) {
                    textBoxCustomH.Text = Height.ToString();
                } else if (double.TryParse(textBoxCustomH.Text, out customSizeH)) {
                    if (double.Parse(textBoxCustomH.Text) < Height) {
                        textBoxCustomH.Text = Height.ToString();
                    }
                }

                if (textBoxCustomW.ForeColor == Color.Red) {
                    textBoxCustomW.Text = Width.ToString();
                } else if (double.TryParse(textBoxCustomW.Text, out customSizeW)) {
                    if (double.Parse(textBoxCustomW.Text) < Width) {
                        textBoxCustomW.Text = Width.ToString();
                    }
                }
            }
            
        }

        private void vectorDrawer1_EndTickProcess(object sender, EventArgs e) {
            labelTickLength.Text = "Tick Cycle : " + vectorDrawer1.LastTickProcessMS.ToString("G4") + "Ms";
            labelTickDrawingLength.Text = "Drawing Cycle : " + vectorDrawer1.LastTickDrawingProcessMS.ToString("G4") + "Ms";

            if (checkBoxStartBytesGen.Checked && vectorDrawer1.Vectors.Count > 0) {
                generatedBytes.Add(genNewByte());
                updateGeneratedBytesLabel();
            }
        }

        private void checkBoxStart_CheckStateChanged(object sender, EventArgs e) {
            vectorDrawer1.StartTick = checkBoxStart.Checked;
            if (checkBoxStart.Checked) {
                textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Tick Started" + (char)13 + (char)10);
            } else {
                textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Tick Stoped" + (char)13 + (char)10);
            }
        }

        private void checkBoxEnableDrawing_CheckStateChanged(object sender, EventArgs e) {
            vectorDrawer1.ActiveDrawing = checkBoxEnableDrawing.Checked;
            if (checkBoxEnableDrawing.Checked) {
                textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Drawing Enabled" + (char)13 + (char)10);
            } else {
                textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Drawing Disabled" + (char)13 + (char)10);
            }
        }

        private void buttonClearVectors_Click(object sender, EventArgs e) {
            vectorDrawer1.ClearVectors();
            labelVectorsActive.Text = vectorDrawer1.Vectors.Count.ToString() + " Vectors Active ";
            textBoxVectors.ResetText();
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Vectors Cleared" + (char)13 + (char)10);
        }

        private void checkBoxCustomSize_CheckStateChanged(object sender, EventArgs e) {
            textBoxCustomH.Enabled = checkBoxCustomSize.Checked;
            textBoxCustomW.Enabled = checkBoxCustomSize.Checked;
            vectorDrawer1.UseCustomSize = checkBoxCustomSize.Checked;

            if (!checkBoxCustomSize.Checked) {
                textBoxCustomH.Text = Height.ToString();
                textBoxCustomW.Text = Width.ToString();
            }
        }

        private void textBoxCustomW_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(textBoxCustomW.Text, out customSizeW)) {
                textBoxCustomW.ForeColor = Color.Green;
                vectorDrawer1.CustomWidth = customSizeW;
            } else {
                textBoxCustomW.ForeColor = Color.Red;
            }
            
        }

        private void buttonClearLog_Click(object sender, EventArgs e) {
            textBoxLog.Clear();
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Log Cleared" + (char)13 + (char)10);
        }

        private void textBoxReqBytes_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(textBoxReqBytes.Text, out requestedBytes)) {
                textBoxReqBytes.ForeColor = Color.Green;
                updateGeneratedBytesLabel();
            } else {
                textBoxReqBytes.ForeColor = Color.Red;
            }
        }

        private void updateGeneratedBytesLabel() {
            labelGeneratedBytes.Text = "Generated Bytes: " + generatedBytes.Count + " / " + requestedBytes;
            if (generatedBytes.Count > requestedBytes) {
                labelGeneratedBytes.ForeColor = Color.Green;
            } else {
                labelGeneratedBytes.ForeColor = Color.Yellow;
            }
        }

        private byte genNewByte() {
            byte ret = 5;

            return ret;
        }

        private void buttonClearBytes_Click(object sender, EventArgs e) {
            generatedBytes.Clear();
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Generated Bytes Cleared" + (char)13 + (char)10);
        }

        private void buttonSetOutPathFile_Click(object sender, EventArgs e) {



        }

        private void textBoxCustomH_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(textBoxCustomH.Text, out customSizeH)) {
                textBoxCustomH.ForeColor =  Color.Green;
                vectorDrawer1.CustomHeight = customSizeH;
            } else {
                textBoxCustomH.ForeColor =  Color.Red;
            }
        }
    }
}
