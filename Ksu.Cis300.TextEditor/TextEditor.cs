/*TextEditor.cs
 * Author: Payton Jellison
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// Allows a user to open and save basic text files.
    /// </summary>
    public partial class TextEditor : Form
    {
        /// <summary>
        /// Creates the text editor.
        /// </summary>
        public TextEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a dialog box to allow the user to open a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(uxOpenDialog.FileName + " can't be opened");
            }
        }

        /// <summary>
        /// Opens a dialog box to allow the user to save a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(uxOpenDialog.FileName + " can't be saved");
            }
        }
    }
}
