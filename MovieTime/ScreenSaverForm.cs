using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTime {
    public partial class ScreenSaverForm : Form {
        public ScreenSaverForm(Rectangle bounds) {
            InitializeComponent();
            Bounds = bounds;
            Cursor.Hide();
            TopMost = true;
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e) {
            Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e) {
            Exit();
        }

        private void Exit() {
            Environment.Exit(0);
        }
    }
}
