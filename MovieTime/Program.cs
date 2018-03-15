using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTime {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowScreenSaver();
            Application.Run();
        }

        static void ShowScreenSaver() {
            foreach (var screen in Screen.AllScreens) {
                var form = new ScreenSaverForm(screen.Bounds);
                form.Show();
            }
        }
    }
}
