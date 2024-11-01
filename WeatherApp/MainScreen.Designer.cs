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
            btnSearch = new Button();
            label1 = new Label();
            lblSunset = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblDetails = new Label();
            lblWind = new Label();
            lblSunrise = new Label();
            lvlSunset = new Label();
            lblPressure = new Label();
            txbLocationData = new TextBox();
            lblSunsetTime = new Label();
            btnLondon = new Button();
            btnParis = new Button();
            btnWashington = new Button();
            btnMadrid = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.GradientActiveCaption;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(649, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 41);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(94, 273);
            label1.Name = "label1";
            label1.Size = new Size(138, 45);
            label1.TabIndex = 2;
            label1.Text = "Sunrise:";
            // 
            // lblSunset
            // 
            lblSunset.AutoSize = true;
            lblSunset.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblSunset.Location = new Point(94, 340);
            lblSunset.Name = "lblSunset";
            lblSunset.Size = new Size(128, 45);
            lblSunset.TabIndex = 4;
            lblSunset.Text = "Sunset:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.Location = new Point(94, 193);
            label3.Name = "label3";
            label3.Size = new Size(206, 45);
            label3.TabIndex = 5;
            label3.Text = "Wind speed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label4.Location = new Point(94, 120);
            label4.Name = "label4";
            label4.Size = new Size(122, 45);
            label4.TabIndex = 6;
            label4.Text = "Detais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.Location = new Point(94, 397);
            label5.Name = "label5";
            label5.Size = new Size(156, 45);
            label5.TabIndex = 7;
            label5.Text = "Pressure:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 20.25F);
            lblDetails.Location = new Point(401, 134);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(0, 37);
            lblDetails.TabIndex = 8;
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Font = new Font("Segoe UI", 20.25F);
            lblWind.Location = new Point(401, 202);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(0, 37);
            lblWind.TabIndex = 9;
            // 
            // lblSunrise
            // 
            lblSunrise.AutoSize = true;
            lblSunrise.Font = new Font("Segoe UI", 20.25F);
            lblSunrise.Location = new Point(401, 273);
            lblSunrise.Name = "lblSunrise";
            lblSunrise.Size = new Size(0, 37);
            lblSunrise.TabIndex = 10;
            // 
            // lvlSunset
            // 
            lvlSunset.AutoSize = true;
            lvlSunset.Font = new Font("Segoe UI", 20.25F);
            lvlSunset.Location = new Point(401, 340);
            lvlSunset.Name = "lvlSunset";
            lvlSunset.Size = new Size(0, 37);
            lvlSunset.TabIndex = 11;
            // 
            // lblPressure
            // 
            lblPressure.AutoSize = true;
            lblPressure.Font = new Font("Segoe UI", 20.25F);
            lblPressure.Location = new Point(401, 406);
            lblPressure.Name = "lblPressure";
            lblPressure.Size = new Size(0, 37);
            lblPressure.TabIndex = 12;
            // 
            // txbLocationData
            // 
            txbLocationData.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbLocationData.Location = new Point(285, 21);
            txbLocationData.Name = "txbLocationData";
            txbLocationData.Size = new Size(348, 57);
            txbLocationData.TabIndex = 13;
            // 
            // lblSunsetTime
            // 
            lblSunsetTime.AutoSize = true;
            lblSunsetTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSunsetTime.Location = new Point(401, 348);
            lblSunsetTime.Name = "lblSunsetTime";
            lblSunsetTime.Size = new Size(0, 37);
            lblSunsetTime.TabIndex = 14;
            // 
            // btnLondon
            // 
            btnLondon.BackColor = SystemColors.MenuHighlight;
            btnLondon.FlatStyle = FlatStyle.Flat;
            btnLondon.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLondon.Location = new Point(805, 100);
            btnLondon.Margin = new Padding(0);
            btnLondon.Name = "btnLondon";
            btnLondon.Size = new Size(174, 67);
            btnLondon.TabIndex = 16;
            btnLondon.Text = "London";
            btnLondon.UseVisualStyleBackColor = false;
            btnLondon.Click += btnLondon_Click;
            // 
            // btnParis
            // 
            btnParis.BackColor = SystemColors.MenuHighlight;
            btnParis.FlatStyle = FlatStyle.Flat;
            btnParis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParis.Location = new Point(805, 315);
            btnParis.Margin = new Padding(0);
            btnParis.Name = "btnParis";
            btnParis.Size = new Size(174, 67);
            btnParis.TabIndex = 17;
            btnParis.Text = "Paris";
            btnParis.UseVisualStyleBackColor = false;
            btnParis.Click += btnParis_Click;
            // 
            // btnWashington
            // 
            btnWashington.BackColor = SystemColors.MenuHighlight;
            btnWashington.FlatStyle = FlatStyle.Flat;
            btnWashington.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWashington.Location = new Point(805, 243);
            btnWashington.Margin = new Padding(0);
            btnWashington.Name = "btnWashington";
            btnWashington.Size = new Size(174, 67);
            btnWashington.TabIndex = 18;
            btnWashington.Text = "Washington DC";
            btnWashington.UseVisualStyleBackColor = false;
            btnWashington.Click += btnWashington_Click;
            // 
            // btnMadrid
            // 
            btnMadrid.BackColor = SystemColors.MenuHighlight;
            btnMadrid.FlatStyle = FlatStyle.Flat;
            btnMadrid.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMadrid.Location = new Point(805, 172);
            btnMadrid.Margin = new Padding(0);
            btnMadrid.Name = "btnMadrid";
            btnMadrid.Size = new Size(174, 67);
            btnMadrid.TabIndex = 19;
            btnMadrid.Text = "Madrid";
            btnMadrid.UseVisualStyleBackColor = false;
            btnMadrid.Click += btnMadrid_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1013, 517);
            Controls.Add(btnMadrid);
            Controls.Add(btnWashington);
            Controls.Add(btnParis);
            Controls.Add(btnLondon);
            Controls.Add(lblSunsetTime);
            Controls.Add(txbLocationData);
            Controls.Add(lblPressure);
            Controls.Add(lvlSunset);
            Controls.Add(lblSunrise);
            Controls.Add(lblWind);
            Controls.Add(lblDetails);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSunset);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "MainScreen";
            Text = "Form2";
            Load += MainScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Label label1;
        private Label lblSunset;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblDetails;
        private Label lblWind;
        private Label lblSunrise;
        private Label lvlSunset;
        private Label lblPressure;
        private TextBox txbLocationData;
        private Label lblSunsetTime;
        private Button btnLondon;
        private Button btnParis;
        private Button btnWashington;
        private Button btnMadrid;
    }
}