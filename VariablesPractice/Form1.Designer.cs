
namespace VariablesPractice
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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.BackColor = System.Drawing.Color.LightGray;
            this.hockeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hockeyButton.Location = new System.Drawing.Point(21, 45);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(145, 62);
            this.hockeyButton.TabIndex = 0;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = false;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.BackColor = System.Drawing.Color.LightGray;
            this.areaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.areaButton.Location = new System.Drawing.Point(21, 143);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(145, 62);
            this.areaButton.TabIndex = 1;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = false;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.BackColor = System.Drawing.Color.LightGray;
            this.carpetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carpetButton.Location = new System.Drawing.Point(21, 241);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(145, 62);
            this.carpetButton.TabIndex = 2;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = false;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.LightGray;
            this.billButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billButton.Location = new System.Drawing.Point(21, 345);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(145, 62);
            this.billButton.TabIndex = 3;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(192, 45);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(438, 362);
            this.outputText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.hockeyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Label outputText;
    }
}

