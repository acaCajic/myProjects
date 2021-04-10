namespace Poker.Scripts.View.Forms
{
    partial class Setup
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
            this.StartPointsLabel = new System.Windows.Forms.Label();
            this.PointsTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartPointsLabel
            // 
            this.StartPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartPointsLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPointsLabel.ForeColor = System.Drawing.Color.Black;
            this.StartPointsLabel.Location = new System.Drawing.Point(19, 16);
            this.StartPointsLabel.Margin = new System.Windows.Forms.Padding(10);
            this.StartPointsLabel.Name = "StartPointsLabel";
            this.StartPointsLabel.Size = new System.Drawing.Size(137, 35);
            this.StartPointsLabel.TabIndex = 0;
            this.StartPointsLabel.Text = "Start points: ";
            this.StartPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PointsTextBox
            // 
            this.PointsTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsTextBox.Location = new System.Drawing.Point(169, 24);
            this.PointsTextBox.Name = "PointsTextBox";
            this.PointsTextBox.Size = new System.Drawing.Size(103, 23);
            this.PointsTextBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(12, 64);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(260, 40);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PointsTextBox);
            this.Controls.Add(this.StartPointsLabel);
            this.Name = "Setup";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartPointsLabel;
        private System.Windows.Forms.TextBox PointsTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}