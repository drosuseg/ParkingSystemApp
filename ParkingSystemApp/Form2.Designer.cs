namespace ParkingSystemApp
{
    partial class Form2
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Button customize_btn;
            System.Windows.Forms.Button parkinghis_btn;
            System.Windows.Forms.Button parkingSpacs_btn;
            System.Windows.Forms.Button dashboard_btn;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label plannerlabel2;
            System.Windows.Forms.Label parklabel1;
            System.Windows.Forms.BindingSource bindingSource1;
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl11 = new ParkingSystemApp.userControl1();
            this.userControl41 = new ParkingSystemApp.UserControl4();
            this.userControl31 = new ParkingSystemApp.UserControl3();
            this.userControl21 = new ParkingSystemApp.UserControl2();
            panel1 = new System.Windows.Forms.Panel();
            customize_btn = new System.Windows.Forms.Button();
            parkinghis_btn = new System.Windows.Forms.Button();
            parkingSpacs_btn = new System.Windows.Forms.Button();
            dashboard_btn = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            plannerlabel2 = new System.Windows.Forms.Label();
            parklabel1 = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.GhostWhite;
            panel1.Controls.Add(customize_btn);
            panel1.Controls.Add(parkinghis_btn);
            panel1.Controls.Add(parkingSpacs_btn);
            panel1.Controls.Add(dashboard_btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(plannerlabel2);
            panel1.Controls.Add(parklabel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(252, 1043);
            panel1.TabIndex = 0;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customize_btn
            // 
            customize_btn.AccessibleName = "customize_btn";
            customize_btn.BackColor = System.Drawing.Color.GhostWhite;
            customize_btn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            customize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            customize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            customize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customize_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customize_btn.ForeColor = System.Drawing.Color.Indigo;
            customize_btn.Location = new System.Drawing.Point(0, 447);
            customize_btn.Name = "customize_btn";
            customize_btn.Size = new System.Drawing.Size(252, 79);
            customize_btn.TabIndex = 6;
            customize_btn.Text = "Customize";
            customize_btn.UseVisualStyleBackColor = false;
            customize_btn.Click += new System.EventHandler(this.customize_btn_Click_1);
            // 
            // parkinghis_btn
            // 
            parkinghis_btn.AccessibleName = "parkinghis_btn";
            parkinghis_btn.BackColor = System.Drawing.Color.GhostWhite;
            parkinghis_btn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            parkinghis_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            parkinghis_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            parkinghis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            parkinghis_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parkinghis_btn.ForeColor = System.Drawing.Color.Indigo;
            parkinghis_btn.Location = new System.Drawing.Point(3, 273);
            parkinghis_btn.Name = "parkinghis_btn";
            parkinghis_btn.Size = new System.Drawing.Size(249, 84);
            parkinghis_btn.TabIndex = 5;
            parkinghis_btn.Text = "Parking History";
            parkinghis_btn.UseVisualStyleBackColor = false;
            parkinghis_btn.Click += new System.EventHandler(this.parkingHis_btn_Click);
            // 
            // parkingSpacs_btn
            // 
            parkingSpacs_btn.AccessibleName = "parkingSpacs_btn";
            parkingSpacs_btn.BackColor = System.Drawing.Color.GhostWhite;
            parkingSpacs_btn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            parkingSpacs_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            parkingSpacs_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            parkingSpacs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            parkingSpacs_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parkingSpacs_btn.ForeColor = System.Drawing.Color.Indigo;
            parkingSpacs_btn.Location = new System.Drawing.Point(0, 363);
            parkingSpacs_btn.Name = "parkingSpacs_btn";
            parkingSpacs_btn.Size = new System.Drawing.Size(252, 78);
            parkingSpacs_btn.TabIndex = 4;
            parkingSpacs_btn.Text = "Parking Spaces";
            parkingSpacs_btn.UseVisualStyleBackColor = false;
            parkingSpacs_btn.Click += new System.EventHandler(this.parkingSpacs_btn_Click);
            // 
            // dashboard_btn
            // 
            dashboard_btn.AccessibleName = "Dashboard_button";
            dashboard_btn.BackColor = System.Drawing.Color.GhostWhite;
            dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dashboard_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dashboard_btn.ForeColor = System.Drawing.Color.Indigo;
            dashboard_btn.Location = new System.Drawing.Point(0, 196);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new System.Drawing.Size(252, 71);
            dashboard_btn.TabIndex = 3;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // panel2
            // 
            panel2.Location = new System.Drawing.Point(0, 961);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(237, 70);
            panel2.TabIndex = 2;
            panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // plannerlabel2
            // 
            plannerlabel2.AccessibleName = "plannerlabel";
            plannerlabel2.AutoSize = true;
            plannerlabel2.BackColor = System.Drawing.Color.Lavender;
            plannerlabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            plannerlabel2.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            plannerlabel2.ForeColor = System.Drawing.Color.Black;
            plannerlabel2.Location = new System.Drawing.Point(51, 73);
            plannerlabel2.Name = "plannerlabel2";
            plannerlabel2.Size = new System.Drawing.Size(144, 41);
            plannerlabel2.TabIndex = 1;
            plannerlabel2.Text = "Planner";
            plannerlabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // parklabel1
            // 
            parklabel1.AccessibleName = "parklabel";
            parklabel1.AutoSize = true;
            parklabel1.BackColor = System.Drawing.Color.GhostWhite;
            parklabel1.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            parklabel1.ForeColor = System.Drawing.Color.SlateBlue;
            parklabel1.Location = new System.Drawing.Point(78, 38);
            parklabel1.Name = "parklabel1";
            parklabel1.Size = new System.Drawing.Size(85, 38);
            parklabel1.TabIndex = 0;
            parklabel1.Text = "Park";
            parklabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userControl11);
            this.panel3.Controls.Add(this.userControl41);
            this.panel3.Controls.Add(this.userControl31);
            this.panel3.Controls.Add(this.userControl21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(252, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1656, 1043);
            this.panel3.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1656, 1043);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.Color.White;
            this.userControl41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl41.Location = new System.Drawing.Point(0, 0);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(1656, 1043);
            this.userControl41.TabIndex = 3;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.White;
            this.userControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1656, 1043);
            this.userControl31.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1656, 1043);
            this.userControl21.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1908, 1043);
            this.Controls.Add(this.panel3);
            this.Controls.Add(panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel3;
        private userControl1 userControl11;
        private UserControl4 userControl41;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
    }
    #endregion
}