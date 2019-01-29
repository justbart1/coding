namespace WindowsFormsApp3
{
    partial class VISUALS
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
            this.Glow_checkBox = new System.Windows.Forms.CheckBox();
            this.Radar_checkBox = new System.Windows.Forms.CheckBox();
            this.Glowenemy_checkBox = new System.Windows.Forms.CheckBox();
            this.Glowteam_checkBox = new System.Windows.Forms.CheckBox();
            this.Flash_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Glow_checkBox
            // 
            this.Glow_checkBox.AutoSize = true;
            this.Glow_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Glow_checkBox.Location = new System.Drawing.Point(15, 16);
            this.Glow_checkBox.Name = "Glow_checkBox";
            this.Glow_checkBox.Size = new System.Drawing.Size(127, 37);
            this.Glow_checkBox.TabIndex = 0;
            this.Glow_checkBox.Text = "GLOW";
            this.Glow_checkBox.UseVisualStyleBackColor = true;
            this.Glow_checkBox.CheckedChanged += new System.EventHandler(this.Glow_checkBox_CheckedChanged);
            // 
            // Radar_checkBox
            // 
            this.Radar_checkBox.AutoSize = true;
            this.Radar_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radar_checkBox.Location = new System.Drawing.Point(308, 16);
            this.Radar_checkBox.Name = "Radar_checkBox";
            this.Radar_checkBox.Size = new System.Drawing.Size(140, 37);
            this.Radar_checkBox.TabIndex = 1;
            this.Radar_checkBox.Text = "RADAR";
            this.Radar_checkBox.UseVisualStyleBackColor = true;
            this.Radar_checkBox.CheckedChanged += new System.EventHandler(this.Radar_checkBox_CheckedChanged);
            // 
            // Glowenemy_checkBox
            // 
            this.Glowenemy_checkBox.AutoSize = true;
            this.Glowenemy_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Glowenemy_checkBox.Location = new System.Drawing.Point(15, 102);
            this.Glowenemy_checkBox.Name = "Glowenemy_checkBox";
            this.Glowenemy_checkBox.Size = new System.Drawing.Size(215, 37);
            this.Glowenemy_checkBox.TabIndex = 2;
            this.Glowenemy_checkBox.Text = "Glow_enemy";
            this.Glowenemy_checkBox.UseVisualStyleBackColor = true;
            this.Glowenemy_checkBox.CheckedChanged += new System.EventHandler(this.Glowenemy_checkBox_CheckedChanged);
            // 
            // Glowteam_checkBox
            // 
            this.Glowteam_checkBox.AutoSize = true;
            this.Glowteam_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Glowteam_checkBox.Location = new System.Drawing.Point(15, 59);
            this.Glowteam_checkBox.Name = "Glowteam_checkBox";
            this.Glowteam_checkBox.Size = new System.Drawing.Size(191, 37);
            this.Glowteam_checkBox.TabIndex = 3;
            this.Glowteam_checkBox.Text = "Glow_team";
            this.Glowteam_checkBox.UseVisualStyleBackColor = true;
            this.Glowteam_checkBox.CheckedChanged += new System.EventHandler(this.Glowteam_checkBox_CheckedChanged);
            // 
            // Flash_checkBox
            // 
            this.Flash_checkBox.AutoSize = true;
            this.Flash_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flash_checkBox.Location = new System.Drawing.Point(308, 59);
            this.Flash_checkBox.Name = "Flash_checkBox";
            this.Flash_checkBox.Size = new System.Drawing.Size(132, 37);
            this.Flash_checkBox.TabIndex = 4;
            this.Flash_checkBox.Text = "FLASH";
            this.Flash_checkBox.UseVisualStyleBackColor = true;
            this.Flash_checkBox.CheckedChanged += new System.EventHandler(this.Flash_checkBox_CheckedChanged);
            // 
            // VISUALS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Flash_checkBox);
            this.Controls.Add(this.Glowteam_checkBox);
            this.Controls.Add(this.Glowenemy_checkBox);
            this.Controls.Add(this.Radar_checkBox);
            this.Controls.Add(this.Glow_checkBox);
            this.Name = "VISUALS";
            this.Size = new System.Drawing.Size(641, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Glow_checkBox;
        private System.Windows.Forms.CheckBox Radar_checkBox;
        private System.Windows.Forms.CheckBox Glowenemy_checkBox;
        private System.Windows.Forms.CheckBox Glowteam_checkBox;
        private System.Windows.Forms.CheckBox Flash_checkBox;
    }
}
