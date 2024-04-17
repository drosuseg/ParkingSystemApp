namespace ParkingSystemApp
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label parklabel1;
            parklabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parklabel1
            // 
            parklabel1.AccessibleName = "parklabel";
            parklabel1.AutoSize = true;
            parklabel1.BackColor = System.Drawing.Color.White;
            parklabel1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parklabel1.ForeColor = System.Drawing.Color.SlateBlue;
            parklabel1.Location = new System.Drawing.Point(13, 12);
            parklabel1.Name = "parklabel1";
            parklabel1.Size = new System.Drawing.Size(124, 28);
            parklabel1.TabIndex = 2;
            parklabel1.Text = "Customize";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(parklabel1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(641, 524);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
