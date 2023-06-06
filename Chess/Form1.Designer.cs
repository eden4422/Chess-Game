namespace Chess
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
            menuPanel = new Panel();
            textBox1 = new TextBox();
            multiplayerButton = new Button();
            SinglePlayerButton = new Button();
            chessBoard = new DataGridView();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chessBoard).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(textBox1);
            menuPanel.Controls.Add(multiplayerButton);
            menuPanel.Controls.Add(SinglePlayerButton);
            menuPanel.Dock = DockStyle.Fill;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(800, 450);
            menuPanel.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Menu";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // multiplayerButton
            // 
            multiplayerButton.Location = new Point(318, 243);
            multiplayerButton.Name = "multiplayerButton";
            multiplayerButton.Size = new Size(165, 44);
            multiplayerButton.TabIndex = 4;
            multiplayerButton.Text = "Multiplayer";
            multiplayerButton.UseVisualStyleBackColor = true;
            // 
            // SinglePlayerButton
            // 
            SinglePlayerButton.AutoSize = true;
            SinglePlayerButton.Location = new Point(318, 193);
            SinglePlayerButton.Name = "SinglePlayerButton";
            SinglePlayerButton.Size = new Size(165, 44);
            SinglePlayerButton.TabIndex = 3;
            SinglePlayerButton.Text = "Single Player";
            SinglePlayerButton.UseVisualStyleBackColor = true;
            SinglePlayerButton.Click += SinglePlayerButton_Click;
            // 
            // chessBoard
            // 
            chessBoard.AllowUserToAddRows = false;
            chessBoard.AllowUserToDeleteRows = false;
            chessBoard.AllowUserToResizeColumns = false;
            chessBoard.AllowUserToResizeRows = false;
            chessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chessBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chessBoard.Location = new Point(175, 0);
            chessBoard.Name = "chessBoard";
            chessBoard.ReadOnly = true;
            chessBoard.RowTemplate.Height = 25;
            chessBoard.ScrollBars = ScrollBars.None;
            chessBoard.Size = new Size(450, 450);
            chessBoard.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chessBoard);
            Controls.Add(menuPanel);
            Name = "Form1";
            Text = "Chess";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chessBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private TextBox textBox1;
        private Button multiplayerButton;
        private Button SinglePlayerButton;
        private DataGridView chessBoard;
    }
}