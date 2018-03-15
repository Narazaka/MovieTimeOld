namespace MovieTime {
    partial class ScreenSaverForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.VlcControl = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.VlcControl)).BeginInit();
            this.SuspendLayout();
            // 
            // VlcControl
            // 
            this.VlcControl.BackColor = System.Drawing.Color.Black;
            this.VlcControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VlcControl.Location = new System.Drawing.Point(0, 0);
            this.VlcControl.Name = "VlcControl";
            this.VlcControl.Size = new System.Drawing.Size(284, 261);
            this.VlcControl.Spu = -1;
            this.VlcControl.TabIndex = 0;
            this.VlcControl.Text = "vlcControl1";
            this.VlcControl.VlcLibDirectory = null;
            this.VlcControl.VlcMediaplayerOptions = null;
            this.VlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VlcLibDirectoryNeeded);
            this.VlcControl.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.VlcControl_Stopped);
            this.VlcControl.Click += new System.EventHandler(this.VlcControl_Click);
            this.VlcControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VlcControl_KeyPress);
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.VlcControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Shown += new System.EventHandler(this.ScreenSaverForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.VlcControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl VlcControl;
    }
}

