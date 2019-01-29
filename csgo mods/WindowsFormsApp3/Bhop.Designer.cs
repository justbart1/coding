namespace WindowsFormsApp3
{
    partial class Bhop
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
            this.bhopCheckBox = new System.Windows.Forms.CheckBox();
            this.bhopDelay = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.bhopDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // bhopCheckBox
            // 
            this.bhopCheckBox.AutoSize = true;
            this.bhopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhopCheckBox.Location = new System.Drawing.Point(21, 24);
            this.bhopCheckBox.Name = "bhopCheckBox";
            this.bhopCheckBox.Size = new System.Drawing.Size(100, 35);
            this.bhopCheckBox.TabIndex = 0;
            this.bhopCheckBox.Text = "Bhop";
            this.bhopCheckBox.UseVisualStyleBackColor = true;
            this.bhopCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bhopDelay
            // 
            this.bhopDelay.Location = new System.Drawing.Point(127, 24);
            this.bhopDelay.Maximum = 20;
            this.bhopDelay.Name = "bhopDelay";
            this.bhopDelay.Size = new System.Drawing.Size(137, 45);
            this.bhopDelay.TabIndex = 3;
            this.bhopDelay.Scroll += new System.EventHandler(this.bhopDelay_Scroll);
            // 
            // Bhop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bhopDelay);
            this.Controls.Add(this.bhopCheckBox);
            this.Name = "Bhop";
            this.Size = new System.Drawing.Size(641, 373);
            this.Load += new System.EventHandler(this.Bhop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bhopDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bhopCheckBox;
        private System.Windows.Forms.TrackBar bhopDelay;
    }
}
