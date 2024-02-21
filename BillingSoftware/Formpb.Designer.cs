
namespace BillingSoftware
{
    partial class Formpb
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
            this.cpbar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // cpbar
            // 
            this.cpbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbar.AnimationSpeed = 500;
            this.cpbar.BackColor = System.Drawing.Color.Transparent;
            this.cpbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cpbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cpbar.InnerMargin = 2;
            this.cpbar.InnerWidth = -1;
            this.cpbar.Location = new System.Drawing.Point(88, 60);
            this.cpbar.MarqueeAnimationSpeed = 2000;
            this.cpbar.Name = "cpbar";
            this.cpbar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cpbar.OuterMargin = -25;
            this.cpbar.OuterWidth = 26;
            this.cpbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cpbar.ProgressWidth = 18;
            this.cpbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbar.Size = new System.Drawing.Size(256, 263);
            this.cpbar.StartAngle = 270;
            this.cpbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbar.SubscriptText = ".23";
            this.cpbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbar.SuperscriptText = "";
            this.cpbar.TabIndex = 92;
            this.cpbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbar.Value = 68;
            this.cpbar.Click += new System.EventHandler(this.cpbar_Click);
            // 
            // Formpb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 391);
            this.Controls.Add(this.cpbar);
            this.Name = "Formpb";
            this.Text = "Formpb";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpbar;
    }
}