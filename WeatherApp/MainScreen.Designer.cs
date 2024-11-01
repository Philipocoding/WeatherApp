namespace WeatherApp
{
    partial class MainScreen
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
            txtbLocation = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            pcbIcon = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblDetails = new Label();
            lblWind = new Label();
            lblSunrise = new Label();
            lvlSunset = new Label();
            lblPressure = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbIcon).BeginInit();
            SuspendLayout();
            // 
            // txtbLocation
            // 
            txtbLocation.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbLocation.Location = new Point(216, 34);
            txtbLocation.Name = "txtbLocation";
            txtbLocation.Size = new Size(348, 57);
            txtbLocation.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(588, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 41);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(84, 298);
            label1.Name = "label1";
            label1.Size = new Size(138, 45);
            label1.TabIndex = 2;
            label1.Text = "Sunrise:";
            // 
            // pcbIcon
            // 
            pcbIcon.Location = new Point(588, 145);
            pcbIcon.Name = "pcbIcon";
            pcbIcon.Size = new Size(169, 85);
            pcbIcon.TabIndex = 3;
            pcbIcon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(84, 365);
            label2.Name = "label2";
            label2.Size = new Size(128, 45);
            label2.TabIndex = 4;
            label2.Text = "Sunset:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.Location = new Point(84, 218);
            label3.Name = "label3";
            label3.Size = new Size(206, 45);
            label3.TabIndex = 5;
            label3.Text = "Wind speed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label4.Location = new Point(84, 145);
            label4.Name = "label4";
            label4.Size = new Size(122, 45);
            label4.TabIndex = 6;
            label4.Text = "Detais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.Location = new Point(84, 422);
            label5.Name = "label5";
            label5.Size = new Size(156, 45);
            label5.TabIndex = 7;
            label5.Text = "Pressure:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblDetails.Location = new Point(295, 150);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(29, 45);
            lblDetails.TabIndex = 8;
            lblDetails.Text = ".";
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWind.Location = new Point(295, 218);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(29, 45);
            lblWind.TabIndex = 9;
            lblWind.Text = ".";
            // 
            // lblSunrise
            // 
            lblSunrise.AutoSize = true;
            lblSunrise.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblSunrise.Location = new Point(295, 289);
            lblSunrise.Name = "lblSunrise";
            lblSunrise.Size = new Size(29, 45);
            lblSunrise.TabIndex = 10;
            lblSunrise.Text = ".";
            // 
            // lvlSunset
            // 
            lvlSunset.AutoSize = true;
            lvlSunset.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lvlSunset.Location = new Point(295, 356);
            lvlSunset.Name = "lvlSunset";
            lvlSunset.Size = new Size(29, 45);
            lvlSunset.TabIndex = 11;
            lvlSunset.Text = ".";
            // 
            // lblPressure
            // 
            lblPressure.AutoSize = true;
            lblPressure.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPressure.Location = new Point(295, 422);
            lblPressure.Name = "lblPressure";
            lblPressure.Size = new Size(29, 45);
            lblPressure.TabIndex = 12;
            lblPressure.Text = ".";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 517);
            Controls.Add(lblPressure);
            Controls.Add(lvlSunset);
            Controls.Add(lblSunrise);
            Controls.Add(lblWind);
            Controls.Add(lblDetails);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pcbIcon);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtbLocation);
            Name = "MainScreen";
            Text = "Form2";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pcbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbLocation;
        private Button btnSearch;
        private Label label1;
        private PictureBox pcbIcon;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblDetails;
        private Label lblWind;
        private Label lblSunrise;
        private Label lvlSunset;
        private Label lblPressure;
    }
}