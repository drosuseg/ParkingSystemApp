namespace ParkingSystemApp
{
    partial class UserControl3
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
            parklabel1.Location = new System.Drawing.Point(13, 19);
            parklabel1.Name = "parklabel1";
            parklabel1.Size = new System.Drawing.Size(173, 28);
            parklabel1.TabIndex = 2;
            parklabel1.Text = "Parking History";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(parklabel1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(664, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
