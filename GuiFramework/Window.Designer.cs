namespace GuiFramework
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skiaView = new SkiaSharp.Views.Desktop.SKControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // skiaView
            // 
            this.skiaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skiaView.Location = new System.Drawing.Point(0, 0);
            this.skiaView.Name = "skiaView";
            this.skiaView.Size = new System.Drawing.Size(800, 450);
            this.skiaView.TabIndex = 0;
            this.skiaView.Text = "skControl1";
            this.skiaView.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs>(this.skiaView_PaintSurface);
            this.skiaView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skiaView_MouseDown);
            this.skiaView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.skiaView_MouseMove);
            this.skiaView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skiaView_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skiaView);
            this.Name = "Window";
            this.ShowIcon = false;
            this.Text = "Window";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SkiaSharp.Views.Desktop.SKControl skiaView;
        private System.Windows.Forms.Timer timer1;
    }
}

