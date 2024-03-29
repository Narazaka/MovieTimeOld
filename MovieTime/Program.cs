﻿using System;
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
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RunMain(args);
        }

        static void RunMain(string[] args) {
            if (args.Length > 0) {
                switch (args[0].ToLower().Trim().Substring(0, 2)) {
                    case "/s":
                        ShowScreenSaver();
                        return;
                    case "/p":
                        PreviewScreenSaver(new IntPtr(long.Parse(args[1])));
                        return;
                }
            }
            ConfigScreenSaver();
        }

        static void ShowScreenSaver() {
            foreach (var screen in Screen.AllScreens) {
                var form = new ScreenSaverForm(screen.Bounds);
                form.Show();
            }
            Application.Run();
        }

        static void PreviewScreenSaver(IntPtr previewHandle) {
            Application.Run(new ScreenSaverForm(previewHandle));
        }

        static void ConfigScreenSaver() {
            Application.Run(new ConfigForm());
        }
    }
}
