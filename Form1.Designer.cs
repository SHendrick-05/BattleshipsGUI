namespace BattleshipsGUI
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleText = new System.Windows.Forms.Label();
            this.CPUBoard = new System.Windows.Forms.TableLayoutPanel();
            this.winText = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.columnLabelsCPU = new System.Windows.Forms.Panel();
            this.colBLabelCPU = new System.Windows.Forms.Label();
            this.colDLabelCPU = new System.Windows.Forms.Label();
            this.colELabelCPU = new System.Windows.Forms.Label();
            this.colCLabelCPU = new System.Windows.Forms.Label();
            this.colALabelCPU = new System.Windows.Forms.Label();
            this.rowLabelsCPU = new System.Windows.Forms.Panel();
            this.row1LabelCPU = new System.Windows.Forms.Label();
            this.row4LabelCPU = new System.Windows.Forms.Label();
            this.row5LabelCPU = new System.Windows.Forms.Label();
            this.row3LabelCPU = new System.Windows.Forms.Label();
            this.row2LabelCPU = new System.Windows.Forms.Label();
            this.CPUBoardPanel = new System.Windows.Forms.Panel();
            this.playerBoardPanel = new System.Windows.Forms.Panel();
            this.playerBoard = new System.Windows.Forms.TableLayoutPanel();
            this.rowLabelsPlayer = new System.Windows.Forms.Panel();
            this.row1LabelPlayer = new System.Windows.Forms.Label();
            this.row4LabelPlayer = new System.Windows.Forms.Label();
            this.row5LabelPlayer = new System.Windows.Forms.Label();
            this.row3LabelPlayer = new System.Windows.Forms.Label();
            this.row2LabelPlayer = new System.Windows.Forms.Label();
            this.columnLabelsPlayer = new System.Windows.Forms.Panel();
            this.colBLabelPlayer = new System.Windows.Forms.Label();
            this.colDLabelPlayer = new System.Windows.Forms.Label();
            this.colELabelPlayer = new System.Windows.Forms.Label();
            this.colCLabelPlayer = new System.Windows.Forms.Label();
            this.colALabelPlayer = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.gameState = new System.Windows.Forms.TextBox();
            this.gameStateLabel = new System.Windows.Forms.Label();
            this.loseText = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.columnLabelsCPU.SuspendLayout();
            this.rowLabelsCPU.SuspendLayout();
            this.CPUBoardPanel.SuspendLayout();
            this.playerBoardPanel.SuspendLayout();
            this.rowLabelsPlayer.SuspendLayout();
            this.columnLabelsPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.menuPanel.Controls.Add(this.gameStateLabel);
            this.menuPanel.Controls.Add(this.gameState);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.titlePanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 550);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(0, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 80);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Navy;
            this.titlePanel.Controls.Add(this.titleText);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(200, 80);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.BackColor = System.Drawing.Color.Transparent;
            this.titleText.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.Silver;
            this.titleText.Location = new System.Drawing.Point(31, 25);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(138, 30);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Battleships";
            this.titleText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // CPUBoard
            // 
            this.CPUBoard.ColumnCount = 5;
            this.CPUBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.Location = new System.Drawing.Point(20, 20);
            this.CPUBoard.Name = "CPUBoard";
            this.CPUBoard.RowCount = 5;
            this.CPUBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CPUBoard.Size = new System.Drawing.Size(350, 350);
            this.CPUBoard.TabIndex = 1;
            this.CPUBoard.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.CPUBoard_CellPaint);
            this.CPUBoard.Click += new System.EventHandler(this.CPUBoard_Click);
            // 
            // winText
            // 
            this.winText.AutoSize = true;
            this.winText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winText.ForeColor = System.Drawing.Color.White;
            this.winText.Location = new System.Drawing.Point(266, 17);
            this.winText.Name = "winText";
            this.winText.Size = new System.Drawing.Size(95, 24);
            this.winText.TabIndex = 2;
            this.winText.Text = "You win!";
            this.winText.Visible = false;
            // 
            // replayButton
            // 
            this.replayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replayButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.ForeColor = System.Drawing.Color.White;
            this.replayButton.Location = new System.Drawing.Point(441, 9);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(159, 41);
            this.replayButton.TabIndex = 3;
            this.replayButton.Text = "Play again?";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // columnLabelsCPU
            // 
            this.columnLabelsCPU.Controls.Add(this.colBLabelCPU);
            this.columnLabelsCPU.Controls.Add(this.colDLabelCPU);
            this.columnLabelsCPU.Controls.Add(this.colELabelCPU);
            this.columnLabelsCPU.Controls.Add(this.colCLabelCPU);
            this.columnLabelsCPU.Controls.Add(this.colALabelCPU);
            this.columnLabelsCPU.Location = new System.Drawing.Point(20, 0);
            this.columnLabelsCPU.Name = "columnLabelsCPU";
            this.columnLabelsCPU.Size = new System.Drawing.Size(350, 20);
            this.columnLabelsCPU.TabIndex = 4;
            // 
            // colBLabelCPU
            // 
            this.colBLabelCPU.AutoSize = true;
            this.colBLabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBLabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.colBLabelCPU.Location = new System.Drawing.Point(95, 0);
            this.colBLabelCPU.Name = "colBLabelCPU";
            this.colBLabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colBLabelCPU.Size = new System.Drawing.Size(18, 20);
            this.colBLabelCPU.TabIndex = 5;
            this.colBLabelCPU.Text = "B";
            // 
            // colDLabelCPU
            // 
            this.colDLabelCPU.AutoSize = true;
            this.colDLabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDLabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.colDLabelCPU.Location = new System.Drawing.Point(235, 0);
            this.colDLabelCPU.Name = "colDLabelCPU";
            this.colDLabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colDLabelCPU.Size = new System.Drawing.Size(20, 20);
            this.colDLabelCPU.TabIndex = 3;
            this.colDLabelCPU.Text = "D";
            // 
            // colELabelCPU
            // 
            this.colELabelCPU.AutoSize = true;
            this.colELabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colELabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.colELabelCPU.Location = new System.Drawing.Point(305, 0);
            this.colELabelCPU.Name = "colELabelCPU";
            this.colELabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colELabelCPU.Size = new System.Drawing.Size(17, 20);
            this.colELabelCPU.TabIndex = 2;
            this.colELabelCPU.Text = "E";
            // 
            // colCLabelCPU
            // 
            this.colCLabelCPU.AutoSize = true;
            this.colCLabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCLabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.colCLabelCPU.Location = new System.Drawing.Point(165, 0);
            this.colCLabelCPU.Name = "colCLabelCPU";
            this.colCLabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colCLabelCPU.Size = new System.Drawing.Size(21, 20);
            this.colCLabelCPU.TabIndex = 1;
            this.colCLabelCPU.Text = "C";
            // 
            // colALabelCPU
            // 
            this.colALabelCPU.AutoSize = true;
            this.colALabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colALabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.colALabelCPU.Location = new System.Drawing.Point(25, 0);
            this.colALabelCPU.Name = "colALabelCPU";
            this.colALabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colALabelCPU.Size = new System.Drawing.Size(20, 20);
            this.colALabelCPU.TabIndex = 0;
            this.colALabelCPU.Text = "A";
            // 
            // rowLabelsCPU
            // 
            this.rowLabelsCPU.Controls.Add(this.row1LabelCPU);
            this.rowLabelsCPU.Controls.Add(this.row4LabelCPU);
            this.rowLabelsCPU.Controls.Add(this.row5LabelCPU);
            this.rowLabelsCPU.Controls.Add(this.row3LabelCPU);
            this.rowLabelsCPU.Controls.Add(this.row2LabelCPU);
            this.rowLabelsCPU.Location = new System.Drawing.Point(0, 20);
            this.rowLabelsCPU.Name = "rowLabelsCPU";
            this.rowLabelsCPU.Size = new System.Drawing.Size(20, 350);
            this.rowLabelsCPU.TabIndex = 5;
            // 
            // row1LabelCPU
            // 
            this.row1LabelCPU.AutoSize = true;
            this.row1LabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1LabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.row1LabelCPU.Location = new System.Drawing.Point(0, 25);
            this.row1LabelCPU.Name = "row1LabelCPU";
            this.row1LabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row1LabelCPU.Size = new System.Drawing.Size(17, 20);
            this.row1LabelCPU.TabIndex = 1;
            this.row1LabelCPU.Text = "1";
            // 
            // row4LabelCPU
            // 
            this.row4LabelCPU.AutoSize = true;
            this.row4LabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row4LabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.row4LabelCPU.Location = new System.Drawing.Point(0, 235);
            this.row4LabelCPU.Name = "row4LabelCPU";
            this.row4LabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row4LabelCPU.Size = new System.Drawing.Size(17, 20);
            this.row4LabelCPU.TabIndex = 4;
            this.row4LabelCPU.Text = "4";
            // 
            // row5LabelCPU
            // 
            this.row5LabelCPU.AutoSize = true;
            this.row5LabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row5LabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.row5LabelCPU.Location = new System.Drawing.Point(0, 305);
            this.row5LabelCPU.Name = "row5LabelCPU";
            this.row5LabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row5LabelCPU.Size = new System.Drawing.Size(17, 20);
            this.row5LabelCPU.TabIndex = 5;
            this.row5LabelCPU.Text = "5";
            // 
            // row3LabelCPU
            // 
            this.row3LabelCPU.AutoSize = true;
            this.row3LabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3LabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.row3LabelCPU.Location = new System.Drawing.Point(0, 165);
            this.row3LabelCPU.Name = "row3LabelCPU";
            this.row3LabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row3LabelCPU.Size = new System.Drawing.Size(17, 20);
            this.row3LabelCPU.TabIndex = 3;
            this.row3LabelCPU.Text = "3";
            // 
            // row2LabelCPU
            // 
            this.row2LabelCPU.AutoSize = true;
            this.row2LabelCPU.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2LabelCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.row2LabelCPU.Location = new System.Drawing.Point(0, 95);
            this.row2LabelCPU.Name = "row2LabelCPU";
            this.row2LabelCPU.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row2LabelCPU.Size = new System.Drawing.Size(17, 20);
            this.row2LabelCPU.TabIndex = 2;
            this.row2LabelCPU.Text = "2";
            // 
            // CPUBoardPanel
            // 
            this.CPUBoardPanel.Controls.Add(this.CPUBoard);
            this.CPUBoardPanel.Controls.Add(this.rowLabelsCPU);
            this.CPUBoardPanel.Controls.Add(this.columnLabelsCPU);
            this.CPUBoardPanel.Location = new System.Drawing.Point(250, 111);
            this.CPUBoardPanel.Name = "CPUBoardPanel";
            this.CPUBoardPanel.Size = new System.Drawing.Size(370, 370);
            this.CPUBoardPanel.TabIndex = 6;
            // 
            // playerBoardPanel
            // 
            this.playerBoardPanel.Controls.Add(this.playerBoard);
            this.playerBoardPanel.Controls.Add(this.rowLabelsPlayer);
            this.playerBoardPanel.Controls.Add(this.columnLabelsPlayer);
            this.playerBoardPanel.Location = new System.Drawing.Point(674, 111);
            this.playerBoardPanel.Name = "playerBoardPanel";
            this.playerBoardPanel.Size = new System.Drawing.Size(370, 370);
            this.playerBoardPanel.TabIndex = 7;
            // 
            // playerBoard
            // 
            this.playerBoard.ColumnCount = 5;
            this.playerBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.Location = new System.Drawing.Point(20, 20);
            this.playerBoard.Name = "playerBoard";
            this.playerBoard.RowCount = 5;
            this.playerBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.playerBoard.Size = new System.Drawing.Size(350, 350);
            this.playerBoard.TabIndex = 1;
            this.playerBoard.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.playerBoard_CellPaint);
            this.playerBoard.Click += new System.EventHandler(this.playerBoard_Click);
            // 
            // rowLabelsPlayer
            // 
            this.rowLabelsPlayer.Controls.Add(this.row1LabelPlayer);
            this.rowLabelsPlayer.Controls.Add(this.row4LabelPlayer);
            this.rowLabelsPlayer.Controls.Add(this.row5LabelPlayer);
            this.rowLabelsPlayer.Controls.Add(this.row3LabelPlayer);
            this.rowLabelsPlayer.Controls.Add(this.row2LabelPlayer);
            this.rowLabelsPlayer.Location = new System.Drawing.Point(0, 20);
            this.rowLabelsPlayer.Name = "rowLabelsPlayer";
            this.rowLabelsPlayer.Size = new System.Drawing.Size(20, 350);
            this.rowLabelsPlayer.TabIndex = 5;
            // 
            // row1LabelPlayer
            // 
            this.row1LabelPlayer.AutoSize = true;
            this.row1LabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1LabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.row1LabelPlayer.Location = new System.Drawing.Point(0, 25);
            this.row1LabelPlayer.Name = "row1LabelPlayer";
            this.row1LabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row1LabelPlayer.Size = new System.Drawing.Size(17, 20);
            this.row1LabelPlayer.TabIndex = 1;
            this.row1LabelPlayer.Text = "1";
            // 
            // row4LabelPlayer
            // 
            this.row4LabelPlayer.AutoSize = true;
            this.row4LabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row4LabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.row4LabelPlayer.Location = new System.Drawing.Point(0, 235);
            this.row4LabelPlayer.Name = "row4LabelPlayer";
            this.row4LabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row4LabelPlayer.Size = new System.Drawing.Size(17, 20);
            this.row4LabelPlayer.TabIndex = 4;
            this.row4LabelPlayer.Text = "4";
            // 
            // row5LabelPlayer
            // 
            this.row5LabelPlayer.AutoSize = true;
            this.row5LabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row5LabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.row5LabelPlayer.Location = new System.Drawing.Point(0, 305);
            this.row5LabelPlayer.Name = "row5LabelPlayer";
            this.row5LabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row5LabelPlayer.Size = new System.Drawing.Size(17, 20);
            this.row5LabelPlayer.TabIndex = 5;
            this.row5LabelPlayer.Text = "5";
            // 
            // row3LabelPlayer
            // 
            this.row3LabelPlayer.AutoSize = true;
            this.row3LabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3LabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.row3LabelPlayer.Location = new System.Drawing.Point(0, 165);
            this.row3LabelPlayer.Name = "row3LabelPlayer";
            this.row3LabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row3LabelPlayer.Size = new System.Drawing.Size(17, 20);
            this.row3LabelPlayer.TabIndex = 3;
            this.row3LabelPlayer.Text = "3";
            // 
            // row2LabelPlayer
            // 
            this.row2LabelPlayer.AutoSize = true;
            this.row2LabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2LabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.row2LabelPlayer.Location = new System.Drawing.Point(0, 95);
            this.row2LabelPlayer.Name = "row2LabelPlayer";
            this.row2LabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.row2LabelPlayer.Size = new System.Drawing.Size(17, 20);
            this.row2LabelPlayer.TabIndex = 2;
            this.row2LabelPlayer.Text = "2";
            // 
            // columnLabelsPlayer
            // 
            this.columnLabelsPlayer.Controls.Add(this.colBLabelPlayer);
            this.columnLabelsPlayer.Controls.Add(this.colDLabelPlayer);
            this.columnLabelsPlayer.Controls.Add(this.colELabelPlayer);
            this.columnLabelsPlayer.Controls.Add(this.colCLabelPlayer);
            this.columnLabelsPlayer.Controls.Add(this.colALabelPlayer);
            this.columnLabelsPlayer.Location = new System.Drawing.Point(20, 0);
            this.columnLabelsPlayer.Name = "columnLabelsPlayer";
            this.columnLabelsPlayer.Size = new System.Drawing.Size(350, 20);
            this.columnLabelsPlayer.TabIndex = 4;
            // 
            // colBLabelPlayer
            // 
            this.colBLabelPlayer.AutoSize = true;
            this.colBLabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBLabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.colBLabelPlayer.Location = new System.Drawing.Point(95, 0);
            this.colBLabelPlayer.Name = "colBLabelPlayer";
            this.colBLabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colBLabelPlayer.Size = new System.Drawing.Size(18, 20);
            this.colBLabelPlayer.TabIndex = 5;
            this.colBLabelPlayer.Text = "B";
            // 
            // colDLabelPlayer
            // 
            this.colDLabelPlayer.AutoSize = true;
            this.colDLabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDLabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.colDLabelPlayer.Location = new System.Drawing.Point(235, 0);
            this.colDLabelPlayer.Name = "colDLabelPlayer";
            this.colDLabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colDLabelPlayer.Size = new System.Drawing.Size(20, 20);
            this.colDLabelPlayer.TabIndex = 3;
            this.colDLabelPlayer.Text = "D";
            // 
            // colELabelPlayer
            // 
            this.colELabelPlayer.AutoSize = true;
            this.colELabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colELabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.colELabelPlayer.Location = new System.Drawing.Point(305, 0);
            this.colELabelPlayer.Name = "colELabelPlayer";
            this.colELabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colELabelPlayer.Size = new System.Drawing.Size(17, 20);
            this.colELabelPlayer.TabIndex = 2;
            this.colELabelPlayer.Text = "E";
            // 
            // colCLabelPlayer
            // 
            this.colCLabelPlayer.AutoSize = true;
            this.colCLabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCLabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.colCLabelPlayer.Location = new System.Drawing.Point(165, 0);
            this.colCLabelPlayer.Name = "colCLabelPlayer";
            this.colCLabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colCLabelPlayer.Size = new System.Drawing.Size(21, 20);
            this.colCLabelPlayer.TabIndex = 1;
            this.colCLabelPlayer.Text = "C";
            // 
            // colALabelPlayer
            // 
            this.colALabelPlayer.AutoSize = true;
            this.colALabelPlayer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colALabelPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.colALabelPlayer.Location = new System.Drawing.Point(25, 0);
            this.colALabelPlayer.Name = "colALabelPlayer";
            this.colALabelPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colALabelPlayer.Size = new System.Drawing.Size(20, 20);
            this.colALabelPlayer.TabIndex = 0;
            this.colALabelPlayer.Text = "A";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CPULabel.Location = new System.Drawing.Point(395, 70);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(116, 24);
            this.CPULabel.TabIndex = 8;
            this.CPULabel.Text = "Computer";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.playerLabel.Location = new System.Drawing.Point(829, 70);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(72, 24);
            this.playerLabel.TabIndex = 9;
            this.playerLabel.Text = "Player";
            // 
            // gameState
            // 
            this.gameState.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameState.Location = new System.Drawing.Point(10, 130);
            this.gameState.Multiline = true;
            this.gameState.Name = "gameState";
            this.gameState.ReadOnly = true;
            this.gameState.Size = new System.Drawing.Size(180, 300);
            this.gameState.TabIndex = 2;
            // 
            // gameStateLabel
            // 
            this.gameStateLabel.AutoSize = true;
            this.gameStateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gameStateLabel.Location = new System.Drawing.Point(30, 100);
            this.gameStateLabel.Name = "gameStateLabel";
            this.gameStateLabel.Size = new System.Drawing.Size(140, 22);
            this.gameStateLabel.TabIndex = 3;
            this.gameStateLabel.Text = "Game tracker";
            // 
            // loseText
            // 
            this.loseText.AutoSize = true;
            this.loseText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseText.ForeColor = System.Drawing.Color.White;
            this.loseText.Location = new System.Drawing.Point(726, 17);
            this.loseText.Name = "loseText";
            this.loseText.Size = new System.Drawing.Size(102, 24);
            this.loseText.TabIndex = 10;
            this.loseText.Text = "You lose.";
            this.loseText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.loseText);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.playerBoardPanel);
            this.Controls.Add(this.CPUBoardPanel);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.winText);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.columnLabelsCPU.ResumeLayout(false);
            this.columnLabelsCPU.PerformLayout();
            this.rowLabelsCPU.ResumeLayout(false);
            this.rowLabelsCPU.PerformLayout();
            this.CPUBoardPanel.ResumeLayout(false);
            this.playerBoardPanel.ResumeLayout(false);
            this.rowLabelsPlayer.ResumeLayout(false);
            this.rowLabelsPlayer.PerformLayout();
            this.columnLabelsPlayer.ResumeLayout(false);
            this.columnLabelsPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel CPUBoard;
        private System.Windows.Forms.Label winText;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Panel columnLabelsCPU;
        private System.Windows.Forms.Label colBLabelCPU;
        private System.Windows.Forms.Label colDLabelCPU;
        private System.Windows.Forms.Label colELabelCPU;
        private System.Windows.Forms.Label colCLabelCPU;
        private System.Windows.Forms.Label colALabelCPU;
        private System.Windows.Forms.Panel rowLabelsCPU;
        private System.Windows.Forms.Label row1LabelCPU;
        private System.Windows.Forms.Label row4LabelCPU;
        private System.Windows.Forms.Label row5LabelCPU;
        private System.Windows.Forms.Label row3LabelCPU;
        private System.Windows.Forms.Label row2LabelCPU;
        private System.Windows.Forms.Panel CPUBoardPanel;
        private System.Windows.Forms.Panel playerBoardPanel;
        private System.Windows.Forms.TableLayoutPanel playerBoard;
        private System.Windows.Forms.Panel rowLabelsPlayer;
        private System.Windows.Forms.Label row1LabelPlayer;
        private System.Windows.Forms.Label row4LabelPlayer;
        private System.Windows.Forms.Label row5LabelPlayer;
        private System.Windows.Forms.Label row3LabelPlayer;
        private System.Windows.Forms.Label row2LabelPlayer;
        private System.Windows.Forms.Panel columnLabelsPlayer;
        private System.Windows.Forms.Label colBLabelPlayer;
        private System.Windows.Forms.Label colDLabelPlayer;
        private System.Windows.Forms.Label colELabelPlayer;
        private System.Windows.Forms.Label colCLabelPlayer;
        private System.Windows.Forms.Label colALabelPlayer;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox gameState;
        private System.Windows.Forms.Label gameStateLabel;
        private System.Windows.Forms.Label loseText;
    }
}

