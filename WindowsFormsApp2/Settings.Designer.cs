namespace Corona
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.muteunmute = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.Silver;
            this.savebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("News701 BT", 12.25F, System.Drawing.FontStyle.Bold);
            this.savebutton.Location = new System.Drawing.Point(584, 393);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(104, 30);
            this.savebutton.TabIndex = 0;
            this.savebutton.Text = "Uložiť";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.Silver;
            this.cancelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("News701 BT", 12.25F, System.Drawing.FontStyle.Bold);
            this.cancelbutton.Location = new System.Drawing.Point(694, 393);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(94, 30);
            this.cancelbutton.TabIndex = 1;
            this.cancelbutton.Text = "Zrušiť";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // muteunmute
            // 
            this.muteunmute.Location = new System.Drawing.Point(12, 12);
            this.muteunmute.Name = "muteunmute";
            this.muteunmute.Size = new System.Drawing.Size(70, 70);
            this.muteunmute.TabIndex = 2;
            this.muteunmute.UseVisualStyleBackColor = true;
            this.muteunmute.Click += new System.EventHandler(this.muteunmute_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("News701 BT", 12.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Vyber si zvuk";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Corona.Properties.Resources.Koronavirus_Covid_19_sars_cov_2_988x553;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.muteunmute);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.RightToLeftLayout = true;
            this.Text = "Corona";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button muteunmute;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}