namespace Khanq.View
{
    partial class UCMain
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
            this.khang = new Khang.WinForms.Khang(this.components);
            this.SuspendLayout();
            // 
            // khang
            // 
            this.khang.AnimateWindow = true;
            this.khang.BorderRadius = 15;
            this.khang.ContainerControl = this;
            this.khang.DockForm = false;
            this.khang.DockIndicatorTransparencyValue = 0.6D;
            this.khang.DragForm = false;
            this.khang.ResizeForm = false;
            this.khang.TransparentWhileDrag = true;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCMAAin";
            this.Load += new System.EventHandler(this.UCMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Khang.WinForms.Khang khang;
    }
}