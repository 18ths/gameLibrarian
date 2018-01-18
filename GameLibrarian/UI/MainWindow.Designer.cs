namespace GameLibrarian
{
    partial class MainWindow
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
            this.FgtLabel = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FgtLabel
            // 
            this.FgtLabel.AutoSize = true;
            this.FgtLabel.Location = new System.Drawing.Point(90, 75);
            this.FgtLabel.Name = "FgtLabel";
            this.FgtLabel.Size = new System.Drawing.Size(98, 13);
            this.FgtLabel.TabIndex = 0;
            this.FgtLabel.Text = "Vito is a huge faget";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(734, 12);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(77, 37);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "Add new game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 413);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.FgtLabel);
            this.Name = "MainWindow";
            this.Text = "OKNO NA ŚWIAT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FgtLabel;
        private System.Windows.Forms.Button NewGameButton;
    }
}

