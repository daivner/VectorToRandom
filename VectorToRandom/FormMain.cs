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
        int requestedBytes, generatedBytesRealTime;
        //List<byte> generatedBytes;
        //string fileNameOut, filePathOut;
        long bytesWriten = 0;

        DialogResult dialogResultCube;
        System.IO.FileStream fileStreamCube;

        //General
        public FormMain() {
            InitializeComponent();
            textBoxCustomH.Text = Height.ToString();
            textBoxCustomW.Text = Width.ToString();
            requestedBytes = 0;

        }

        private void vectorDrawer1_NewVectorAdded(object sender, EventArgs e) {
            textBoxVectors.AppendText("[" + (vectorDrawer1.Vectors.Count - 1) + "]" + ((EventArgsVector)e).Vector.ToString() + (char)13 + (char)10);
            labelVectorsActive.Text = vectorDrawer1.Vectors.Count.ToString() + " Vectors Active ";
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> New Vector Added" + (char)13 + (char)10);
            buttonClearVectors.Enabled = true;
            buttonClearVectors.ForeColor = Color.SteelBlue;
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

            if (vectorDrawer1.Vectors.Count > 0) {
                if (fileStreamCube != null && dialogResultCube == DialogResult.OK) {

                    if (generatedBytesRealTime < requestedBytes) {
                        generatedBytesRealTime++;

                        if (saveFileDialogCube.FilterIndex == 1) {
                            fileStreamCube.WriteByte(genNewByte());
                            bytesWriten++;
                        } else if (saveFileDialogCube.FilterIndex == 2) {
                            fileStreamCube.WriteByte((byte)genNewByte().ToString("X2")[0]);
                            fileStreamCube.WriteByte((byte)genNewByte().ToString("X2")[1]);
                            bytesWriten += 2;
                        } else /*if (saveFileDialogCube.FilterIndex == 3)*/ {
                            byte b = genNewByte();
                            string s = b.ToString();
                            if (b > 99) {
                                fileStreamCube.WriteByte((byte)s[0]);
                                fileStreamCube.WriteByte((byte)s[1]);
                                fileStreamCube.WriteByte((byte)s[2]);
                                fileStreamCube.WriteByte((byte)'\n');
                                bytesWriten += 4;
                            } else if (b > 9) {
                                fileStreamCube.WriteByte((byte)s[0]);
                                fileStreamCube.WriteByte((byte)s[1]);
                                fileStreamCube.WriteByte((byte)'\n');
                                bytesWriten += 3;
                            } else {
                                fileStreamCube.WriteByte((byte)s[0]);
                                fileStreamCube.WriteByte((byte)'\n');
                                bytesWriten += 2;
                            }
                        }

                        updateGeneratedBytesLabel(generatedBytesRealTime);
                    }

                    if (generatedBytesRealTime == requestedBytes) {

                        if (fileStreamCube.Length == bytesWriten) {
                            dialogResultCube = DialogResult.None;

                            MessageBox.Show("The cube has been created successfully.", "Vector To Random",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        } else {
                            dialogResultCube = DialogResult.None;

                            MessageBox.Show("Failed to create the cube, only " + fileStreamCube.Length + "/" + requestedBytes + " Bytes has been writen", "Vector To Random",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }

                        generatedBytesRealTime = 0;
                        fileStreamCube.Close();
                        fileStreamCube.Dispose();
                        fileStreamCube = null;

                        textBoxReqBytes.Enabled = true;

                        buttonCancelProcess.Enabled = false;
                        buttonCancelProcess.ForeColor = Color.DarkGray;
                        buttonSetOutPathFile.Enabled = true;
                        buttonSetOutPathFile.ForeColor = Color.SteelBlue;
                    }
                }
            }

            
            
        }

        private void updateGeneratedBytesLabel(int generatedBytes) {
            labelGeneratedBytes.Text = "Generated Bytes: " + generatedBytes + " / " + requestedBytes;
            if (generatedBytes >= requestedBytes) {
                labelGeneratedBytes.ForeColor = Color.Green;
            } else {
                labelGeneratedBytes.ForeColor = Color.Yellow;
            }
        }


        //Textbox Validation
        private void textBoxCustomW_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(textBoxCustomW.Text, out customSizeW)) {
                textBoxCustomW.ForeColor = Color.Green;
                vectorDrawer1.CustomWidth = customSizeW;
            } else {
                textBoxCustomW.ForeColor = Color.Red;
            }
        }

        private void textBoxCustomH_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(textBoxCustomH.Text, out customSizeH)) {
                textBoxCustomH.ForeColor = Color.Green;
                vectorDrawer1.CustomHeight = customSizeH;
            } else {
                textBoxCustomH.ForeColor = Color.Red;
            }
        }

        private void textBoxReqBytes_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(textBoxReqBytes.Text, out requestedBytes)) {
                if(requestedBytes > 0) {
                    textBoxReqBytes.ForeColor = Color.Green;
                    updateGeneratedBytesLabel(0);
                } else {
                    textBoxReqBytes.ForeColor = Color.Red;
                }
            } else {
                textBoxReqBytes.ForeColor = Color.Red;
            }
        }


        //CheckBox Options
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

        private void checkBoxCustomSize_CheckStateChanged(object sender, EventArgs e) {
            textBoxCustomH.Enabled = checkBoxCustomSize.Checked;
            textBoxCustomW.Enabled = checkBoxCustomSize.Checked;
            vectorDrawer1.UseCustomSize = checkBoxCustomSize.Checked;

            if (!checkBoxCustomSize.Checked) {
                textBoxCustomH.Text = Height.ToString();
                textBoxCustomW.Text = Width.ToString();
            }
        }


        //Buttons
        private void buttonClearLog_Click(object sender, EventArgs e) {
            textBoxLog.Clear();
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Log Cleared" + (char)13 + (char)10);
        }

        private void buttonClearVectors_Click(object sender, EventArgs e) {
            vectorDrawer1.ClearVectors();
            labelVectorsActive.Text = vectorDrawer1.Vectors.Count.ToString() + " Vectors Active ";
            textBoxVectors.ResetText();
            textBoxLog.AppendText(DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "> Vectors Cleared" + (char)13 + (char)10);
            buttonClearVectors.Enabled = false;
            buttonClearVectors.ForeColor = Color.DarkGray;
        }

        //TODO - directly write is missing
        private void buttonSetOutPathFile_Click(object sender, EventArgs e) {

            dialogResultCube = saveFileDialogCube.ShowDialog();

            if (dialogResultCube == DialogResult.OK) {

                if (saveFileDialogCube.FilterIndex == 1) {
                    fileStreamCube = System.IO.File.Create(saveFileDialogCube.FileName + ".ByteCube");
                } else if (saveFileDialogCube.FilterIndex == 2) {
                    fileStreamCube = System.IO.File.Create(saveFileDialogCube.FileName + ".HexCube");
                } else {
                    fileStreamCube = System.IO.File.Create(saveFileDialogCube.FileName + ".DecimalCube");
                }

                textBoxReqBytes.Enabled = false;

                buttonSetOutPathFile.Enabled = false;
                buttonSetOutPathFile.ForeColor = Color.DarkGray;

                buttonCancelProcess.Enabled = true;
                buttonCancelProcess.ForeColor = Color.SteelBlue;

                bytesWriten = 0;

            }
        }

        private void buttonCancelProcess_Click(object sender, EventArgs e) {
            if(requestedBytes > generatedBytesRealTime) {

                fileStreamCube.Close();
                fileStreamCube.Dispose();
                System.IO.File.Delete(fileStreamCube.Name);
                fileStreamCube = null;

                textBoxReqBytes.Enabled = true;

                generatedBytesRealTime = 0;
                updateGeneratedBytesLabel(generatedBytesRealTime);
                labelGeneratedBytes.ForeColor = Color.SteelBlue;

                buttonSetOutPathFile.Enabled = true;
                buttonSetOutPathFile.ForeColor = Color.SteelBlue;

                buttonCancelProcess.Enabled = false;
                buttonCancelProcess.ForeColor = Color.DarkGray;
            }
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e) {
            DialogResult dialogResult = saveFileDialogVectors.ShowDialog();
            if (dialogResult == DialogResult.OK) {

                System.IO.FileStream fileStream = System.IO.File.Create(saveFileDialogVectors.FileName + ".vectors");

                for (int i = 0; i < vectorDrawer1.Vectors.Count; i++) {
                    fileStream.WriteAsync(toByteArray((vectorDrawer1.Vectors[i].ToString() + "\n").ToCharArray(), vectorDrawer1.Vectors[i].ToString().Length + 1), 0, vectorDrawer1.Vectors[i].ToString().Length + 1);
                }

                fileStream.Close();

            }
        }

        


        //Extras
        private byte genNewByte() {
            double ret = 0;

            for (int i = 0; i < vectorDrawer1.Vectors.Count; i++) {
                ret += (double)1 / (vectorDrawer1.Vectors[i].height) * vectorDrawer1.Vectors[i].ActualPoint.Y;

                if (ret >= 1)
                    ret -= 1;

                ret += (double)1 / (vectorDrawer1.Vectors[i].width) * vectorDrawer1.Vectors[i].ActualPoint.X;

                if (ret >= 1)
                    ret -= 1;
            }

            return (byte)((int)(ret * 255));
        }

        private byte[] toByteArray(char[] chars, int requested) {
            byte[] bytes = new byte[requested];
            for (int i = 0; i < requested; i++) {
                bytes[i] = (byte)chars[i];
            }
            return bytes;
        }

    }
}

/*
 * To Do
 * 
 */