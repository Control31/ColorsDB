namespace ColorsDB
{
    partial class Form1
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
            this.Colors = new System.Windows.Forms.Label();
            this.listColors = new System.Windows.Forms.ListBox();
            this.Shades = new System.Windows.Forms.Label();
            this.listShades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.AutoSize = true;
            this.Colors.Location = new System.Drawing.Point(81, 71);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(36, 13);
            this.Colors.TabIndex = 0;
            this.Colors.Text = "Colors";
            // 
            // listColors
            // 
            this.listColors.FormattingEnabled = true;
            this.listColors.Location = new System.Drawing.Point(84, 135);
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(120, 95);
            this.listColors.TabIndex = 1;
            this.listColors.SelectedIndexChanged += new System.EventHandler(this.listColors_SelectedIndexChanged);
            // 
            // Shades
            // 
            this.Shades.AutoSize = true;
            this.Shades.Location = new System.Drawing.Point(266, 71);
            this.Shades.Name = "Shades";
            this.Shades.Size = new System.Drawing.Size(43, 13);
            this.Shades.TabIndex = 2;
            this.Shades.Text = "Shades";
            // 
            // listShades
            // 
            this.listShades.FormattingEnabled = true;
            this.listShades.Location = new System.Drawing.Point(269, 135);
            this.listShades.Name = "listShades";
            this.listShades.Size = new System.Drawing.Size(120, 95);
            this.listShades.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShades);
            this.Controls.Add(this.Shades);
            this.Controls.Add(this.listColors);
            this.Controls.Add(this.Colors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Colors;
        private System.Windows.Forms.ListBox listColors;
        private System.Windows.Forms.Label Shades;
        private System.Windows.Forms.ListBox listShades;
    }
}

