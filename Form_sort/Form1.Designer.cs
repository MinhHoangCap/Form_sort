
namespace Form_sort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Bubble_button = new System.Windows.Forms.Button();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Bubble_panel = new System.Windows.Forms.Panel();
            this.Insert_panel = new System.Windows.Forms.Panel();
            
            this.SuspendLayout();
            // 
            // Bubble_button
            // 
            this.Bubble_button.Location = new System.Drawing.Point(117, 56);
            this.Bubble_button.Name = "Bubble_button";
            this.Bubble_button.Size = new System.Drawing.Size(145, 29);
            this.Bubble_button.TabIndex = 0;
            this.Bubble_button.Text = "Bubble Sort";
            this.Bubble_button.UseVisualStyleBackColor = true;
            this.Bubble_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(544, 55);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(94, 29);
            this.Insert_button.TabIndex = 1;
            this.Insert_button.Text = "Insert Sort";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Bubble_panel
            // 
            this.Bubble_panel.Location = new System.Drawing.Point(30, 91);
            this.Bubble_panel.Name = "Bubble_panel";
            this.Bubble_panel.Size = new System.Drawing.Size(662, 125);
            this.Bubble_panel.TabIndex = 2;
            // 
            // Insert_panel
            // 
            this.Insert_panel.Location = new System.Drawing.Point(30, 248);
            this.Insert_panel.Name = "Insert_panel";
            this.Insert_panel.Size = new System.Drawing.Size(662, 125);
            this.Insert_panel.TabIndex = 3;
            // 
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Insert_panel);
            this.Controls.Add(this.Bubble_panel);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Bubble_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bubble_button;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Panel Bubble_panel;
        private System.Windows.Forms.Panel Insert_panel;
       
    }
}

