namespace Poker
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.NewGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TexasHoldemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.CardsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StatusBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PointsLbl = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.DealButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.CommunityCardsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            this.StatusBarPanel.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.OliveDrab;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuItem,
            this.EndMenuMenuItem,
            this.modeToolStripMenuItem,
            this.ExitMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(624, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // NewGameMenuItem
            // 
            this.NewGameMenuItem.Name = "NewGameMenuItem";
            this.NewGameMenuItem.Size = new System.Drawing.Size(76, 20);
            this.NewGameMenuItem.Text = "New game";
            this.NewGameMenuItem.Click += new System.EventHandler(this.NewGameMenuItem_Click);
            // 
            // EndMenuMenuItem
            // 
            this.EndMenuMenuItem.Name = "EndMenuMenuItem";
            this.EndMenuMenuItem.Size = new System.Drawing.Size(72, 20);
            this.EndMenuMenuItem.Text = "End game";
            this.EndMenuMenuItem.Click += new System.EventHandler(this.EndMenuMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandardMenuItem,
            this.TexasHoldemMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // StandardMenuItem
            // 
            this.StandardMenuItem.Name = "StandardMenuItem";
            this.StandardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StandardMenuItem.Text = "Standard";
            this.StandardMenuItem.Click += new System.EventHandler(this.StandardMenuItem_Click);
            // 
            // TexasHoldemMenuItem
            // 
            this.TexasHoldemMenuItem.Name = "TexasHoldemMenuItem";
            this.TexasHoldemMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TexasHoldemMenuItem.Text = "Texas Holdem";
            this.TexasHoldemMenuItem.Click += new System.EventHandler(this.TexasHoldemMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // PointsLabel
            // 
            this.PointsLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.PointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PointsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointsLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLabel.Location = new System.Drawing.Point(6, 6);
            this.PointsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(144, 24);
            this.PointsLabel.TabIndex = 1;
            this.PointsLabel.Text = "Points :";
            this.PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardsPanel
            // 
            this.CardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CardsPanel.BackColor = System.Drawing.Color.Transparent;
            this.CardsPanel.ColumnCount = 5;
            this.CardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsPanel.Location = new System.Drawing.Point(112, 329);
            this.CardsPanel.Name = "CardsPanel";
            this.CardsPanel.RowCount = 1;
            this.CardsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CardsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CardsPanel.Size = new System.Drawing.Size(400, 100);
            this.CardsPanel.TabIndex = 2;
            // 
            // BetNumericUpDown
            // 
            this.BetNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BetNumericUpDown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetNumericUpDown.Location = new System.Drawing.Point(471, 6);
            this.BetNumericUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.BetNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BetNumericUpDown.Size = new System.Drawing.Size(147, 23);
            this.BetNumericUpDown.TabIndex = 3;
            this.BetNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BetNumericUpDown.ValueChanged += new System.EventHandler(this.BetNumericUpDown_ValueChanged);
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBarPanel.BackColor = System.Drawing.Color.OliveDrab;
            this.StatusBarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.StatusBarPanel.ColumnCount = 4;
            this.StatusBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatusBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatusBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatusBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatusBarPanel.Controls.Add(this.PointsLbl, 1, 0);
            this.StatusBarPanel.Controls.Add(this.PointsLabel, 0, 0);
            this.StatusBarPanel.Controls.Add(this.BetNumericUpDown, 3, 0);
            this.StatusBarPanel.Controls.Add(this.BetLabel, 2, 0);
            this.StatusBarPanel.Location = new System.Drawing.Point(0, 24);
            this.StatusBarPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StatusBarPanel.Name = "StatusBarPanel";
            this.StatusBarPanel.RowCount = 1;
            this.StatusBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StatusBarPanel.Size = new System.Drawing.Size(624, 36);
            this.StatusBarPanel.TabIndex = 4;
            // 
            // PointsLbl
            // 
            this.PointsLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.PointsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PointsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointsLbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLbl.Location = new System.Drawing.Point(161, 6);
            this.PointsLbl.Margin = new System.Windows.Forms.Padding(5);
            this.PointsLbl.Name = "PointsLbl";
            this.PointsLbl.Size = new System.Drawing.Size(144, 24);
            this.PointsLbl.TabIndex = 8;
            this.PointsLbl.Text = "0";
            this.PointsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BetLabel
            // 
            this.BetLabel.BackColor = System.Drawing.Color.LightGray;
            this.BetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BetLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.Location = new System.Drawing.Point(316, 6);
            this.BetLabel.Margin = new System.Windows.Forms.Padding(5);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(144, 24);
            this.BetLabel.TabIndex = 4;
            this.BetLabel.Text = "Bet :";
            this.BetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealButton
            // 
            this.DealButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DealButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DealButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.DealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.DealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.DealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealButton.Location = new System.Drawing.Point(3, 3);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(158, 38);
            this.DealButton.TabIndex = 5;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = false;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.ChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(167, 3);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(159, 38);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Change / Done";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // CommunityCardsPanel
            // 
            this.CommunityCardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunityCardsPanel.BackColor = System.Drawing.Color.Transparent;
            this.CommunityCardsPanel.ColumnCount = 3;
            this.CommunityCardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CommunityCardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CommunityCardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CommunityCardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CommunityCardsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CommunityCardsPanel.Location = new System.Drawing.Point(112, 166);
            this.CommunityCardsPanel.Name = "CommunityCardsPanel";
            this.CommunityCardsPanel.RowCount = 1;
            this.CommunityCardsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CommunityCardsPanel.Size = new System.Drawing.Size(400, 100);
            this.CommunityCardsPanel.TabIndex = 7;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsLayout.ColumnCount = 2;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayout.Controls.Add(this.DealButton, 0, 0);
            this.ButtonsLayout.Controls.Add(this.ChangeButton, 1, 0);
            this.ButtonsLayout.Location = new System.Drawing.Point(148, 272);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsLayout.Size = new System.Drawing.Size(329, 44);
            this.ButtonsLayout.TabIndex = 9;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ButtonsLayout);
            this.Controls.Add(this.CommunityCardsPanel);
            this.Controls.Add(this.StatusBarPanel);
            this.Controls.Add(this.CardsPanel);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "PlayForm";
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            this.StatusBarPanel.ResumeLayout(false);
            this.ButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EndMenuMenuItem;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.TableLayoutPanel CardsPanel;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel StatusBarPanel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TableLayoutPanel CommunityCardsPanel;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StandardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TexasHoldemMenuItem;
        private System.Windows.Forms.Label PointsLbl;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
    }
}

