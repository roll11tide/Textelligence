using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textelligence
{
    public partial class Form1 : Form
    {
        #region Variable Declarations
        SplashScreen splash = new SplashScreen();
        string position = "enctodec";
        #endregion

        #region Form1
        public Form1()
        {
            InitializeComponent();

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;

            splash.Show();
            SplashTimer.Start();
        }
        #endregion

        #region Functional Methods and Routines
        private bool returnPositionValidity()
        {
            if ((position == "enctodec" & fieldlabel1.Text == "Encrypted") | (position == "dectoenc" & fieldlabel1.Text == "Decrypted"))
            {
                return true;
            } else
            {
                if (MessageBox.Show("Fields mismatched! This can cause functional failure! Restart the program to fix this. Close program now?", "Field Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                
                return false;
            }
        }

        private void switchLabelFields()
        {
            if (returnPositionValidity())
            {
                if (position == "enctodec")
                {
                    fieldlabel1.Text = "Decrypted";
                    fieldlabel2.Text = "Encrypted";
                    position = "dectoenc";
                } else if (position == "dectoenc")
                {
                    fieldlabel1.Text = "Encrypted";
                    fieldlabel2.Text = "Decrypted";
                    position = "enctodec";
                } else
                {
                    if (MessageBox.Show("Position unknown. This can cause functional failure! Restart the program to fix this. Close program now?", "Field Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }
        #endregion

        #region Event Handlers
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splash.Close();
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void switchFieldsButton_Click(object sender, EventArgs e)
        {
            switchLabelFields();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (field2.Text != "")
                {
                    field2.Text = "";
                }

                if (returnPositionValidity())
                {
                    if (position == "enctodec")
                    {
                        // Converting from encrytped text to decrypted text
                        if (field1.Text != "" & keyField.Text != "")
                        {
                            field2.Text = AES.Decrypt(field1.Text, keyField.Text);
                        } else
                        {
                            MessageBox.Show("Missing input in either text or key field.", "Cannot Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else if (position == "dectoenc")
                    {
                        // Converting from decrypted text to encrypted text
                        if (field1.Text != "" & keyField.Text != "")
                        {
                            field2.Text = AES.Encrypt(field1.Text, keyField.Text);
                        }
                        else
                        {
                            MessageBox.Show("Missing input in either text or key field.", "Cannot Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } else
                    {
                        if (MessageBox.Show("Position unknown. This can cause functional failure! Restart the program to fix this. Close program now?", "Field Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                }
            } catch
            {
                MessageBox.Show("There was a problem with the ciphering operation. Either the key is invalid or the text was not properly encrypted.", "Problem Ciphering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            keyField.PasswordChar = '\0';
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            keyField.PasswordChar = '*';
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            field1.Text = "";
            field2.Text = "";
        }

        private void copyOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(field2.Text);
        }

        private void legendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Legend l = new Legend();
            l.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}