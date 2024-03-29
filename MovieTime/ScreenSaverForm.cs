﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace MovieTime {
    public partial class ScreenSaverForm : Form {
        #region WIN32 API

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        const int GWL_STYLE = -16;

        const int WS_CHILD = 0x40000000;

        #endregion

        private bool IsPreviewMode = false;

        private ScreenSaverForm() {
            InitializeComponent();
        }

        public ScreenSaverForm(Rectangle bounds) : this() {
            Bounds = bounds;
            Cursor.Hide();
            TopMost = true;
        }

        public ScreenSaverForm(IntPtr previewHandle) : this() {
            SetParent(Handle, previewHandle);
            SetWindowLong(Handle, GWL_STYLE, new IntPtr(GetWindowLong(Handle, GWL_STYLE) | WS_CHILD));
            GetClientRect(previewHandle, out var parentRect);
            Size = parentRect.Size;
            Location = new Point(0, 0);
            IsPreviewMode = true;
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e) {
            Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e) {
            Exit();
        }

        private void Exit() {
            if (IsPreviewMode) return;
            Environment.Exit(0);
        }

        private void VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e) {
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath),
                "libvlc",
                IntPtr.Size == 4 ? "x86" : "x64"
                ));
        }

        private void VlcControl_Click(object sender, EventArgs e) {
            Exit();
        }

        private void VlcControl_KeyPress(object sender, KeyPressEventArgs e) {
            Exit();
        }

        private void ScreenSaverForm_Shown(object sender, EventArgs e) {
            PlayNext();
        }

        private void VlcControl_Stopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e) {
            PlayNext();
        }

        private void PlayNext() {
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => {
                VlcControl.Play(new FileInfo(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "movie.mp4")));
            });
        }
    }
}
