namespace GameLibrarian.UI
{
    partial class NewGameWindow
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.propertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.propertiesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(347, 195);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // propertiesLayout
            // 
            this.propertiesLayout.ColumnCount = 2;
            this.propertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.propertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesLayout.Controls.Add(this.NameLabel, 0, 0);
            this.propertiesLayout.Controls.Add(this.NameTextBox, 1, 0);
            this.propertiesLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertiesLayout.Location = new System.Drawing.Point(15, 191);
            this.propertiesLayout.MaximumSize = new System.Drawing.Size(-1, 30);
            this.propertiesLayout.MinimumSize = new System.Drawing.Size(408, 30);
            this.propertiesLayout.Name = "propertiesLayout";
            this.propertiesLayout.RowCount = 1;
            this.propertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesLayout.Size = new System.Drawing.Size(408, 30);
            this.propertiesLayout.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Location = new System.Drawing.Point(100, 5);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(308, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NewGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 236);
            this.Controls.Add(this.propertiesLayout);
            this.Controls.Add(this.SubmitButton);
            this.MaximumSize = new System.Drawing.Size(1024, 274);
            this.MinimumSize = new System.Drawing.Size(456, 274);
            this.Name = "NewGameWindow";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Add new game";
            this.propertiesLayout.ResumeLayout(false);
            this.propertiesLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TableLayoutPanel propertiesLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}