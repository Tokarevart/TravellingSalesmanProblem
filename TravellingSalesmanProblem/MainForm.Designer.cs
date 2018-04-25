namespace TravellingSalesmanProblem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clearButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.optimalPathLengthLabel = new System.Windows.Forms.Label();
            this.optimalPathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.matrixPage = new System.Windows.Forms.TabPage();
            this.matrixDataGridView = new System.Windows.Forms.DataGridView();
            this.parametersPage = new System.Windows.Forms.TabPage();
            this.antsNumTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.setDefaultsButton = new System.Windows.Forms.Button();
            this.qCoefTextBox = new System.Windows.Forms.TextBox();
            this.rhoCoefTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iterNumTextBox = new System.Windows.Forms.TextBox();
            this.betaCoefTextBox = new System.Windows.Forms.TextBox();
            this.alphaCoefTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setNodesRanButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.matrixPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).BeginInit();
            this.parametersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.matrixPage);
            this.tabControl.Controls.Add(this.parametersPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(704, 602);
            this.tabControl.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.splitContainer1);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(696, 576);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main page";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.setNodesRanButton);
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.calcButton);
            this.splitContainer1.Panel1.Controls.Add(this.optimalPathLengthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.optimalPathLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 53;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.graphPictureBox);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(690, 570);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(540, 0);
            this.clearButton.MaximumSize = new System.Drawing.Size(72, 23);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcButton.Location = new System.Drawing.Point(618, 0);
            this.calcButton.MaximumSize = new System.Drawing.Size(72, 23);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(72, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // optimalPathLengthLabel
            // 
            this.optimalPathLengthLabel.AutoSize = true;
            this.optimalPathLengthLabel.Location = new System.Drawing.Point(116, 28);
            this.optimalPathLengthLabel.Name = "optimalPathLengthLabel";
            this.optimalPathLengthLabel.Size = new System.Drawing.Size(32, 13);
            this.optimalPathLengthLabel.TabIndex = 3;
            this.optimalPathLengthLabel.Text = "None";
            // 
            // optimalPathLabel
            // 
            this.optimalPathLabel.AutoSize = true;
            this.optimalPathLabel.Location = new System.Drawing.Point(116, 7);
            this.optimalPathLabel.Name = "optimalPathLabel";
            this.optimalPathLabel.Size = new System.Drawing.Size(32, 13);
            this.optimalPathLabel.TabIndex = 2;
            this.optimalPathLabel.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Optimal path length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Optimal path:";
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPictureBox.Location = new System.Drawing.Point(0, 0);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(690, 513);
            this.graphPictureBox.TabIndex = 0;
            this.graphPictureBox.TabStop = false;
            this.graphPictureBox.Click += new System.EventHandler(this.graphPictureBox_Click);
            // 
            // matrixPage
            // 
            this.matrixPage.Controls.Add(this.matrixDataGridView);
            this.matrixPage.Location = new System.Drawing.Point(4, 22);
            this.matrixPage.Name = "matrixPage";
            this.matrixPage.Size = new System.Drawing.Size(696, 576);
            this.matrixPage.TabIndex = 2;
            this.matrixPage.Text = "Matrix page";
            this.matrixPage.UseVisualStyleBackColor = true;
            // 
            // matrixDataGridView
            // 
            this.matrixDataGridView.AllowUserToAddRows = false;
            this.matrixDataGridView.AllowUserToDeleteRows = false;
            this.matrixDataGridView.AllowUserToResizeColumns = false;
            this.matrixDataGridView.AllowUserToResizeRows = false;
            this.matrixDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrixDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.matrixDataGridView.Location = new System.Drawing.Point(0, 0);
            this.matrixDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.matrixDataGridView.MultiSelect = false;
            this.matrixDataGridView.Name = "matrixDataGridView";
            this.matrixDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrixDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.matrixDataGridView.RowHeadersWidth = 23;
            this.matrixDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixDataGridView.RowTemplate.Height = 23;
            this.matrixDataGridView.RowTemplate.ReadOnly = true;
            this.matrixDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrixDataGridView.ShowCellToolTips = false;
            this.matrixDataGridView.ShowEditingIcon = false;
            this.matrixDataGridView.Size = new System.Drawing.Size(696, 576);
            this.matrixDataGridView.TabIndex = 1;
            this.matrixDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.matrixDataGridView_CellMouseUp);
            this.matrixDataGridView.Sorted += new System.EventHandler(this.matrixDataGridView_Sorted);
            // 
            // parametersPage
            // 
            this.parametersPage.Controls.Add(this.antsNumTextBox);
            this.parametersPage.Controls.Add(this.label8);
            this.parametersPage.Controls.Add(this.setDefaultsButton);
            this.parametersPage.Controls.Add(this.qCoefTextBox);
            this.parametersPage.Controls.Add(this.rhoCoefTextBox);
            this.parametersPage.Controls.Add(this.label6);
            this.parametersPage.Controls.Add(this.label7);
            this.parametersPage.Controls.Add(this.iterNumTextBox);
            this.parametersPage.Controls.Add(this.betaCoefTextBox);
            this.parametersPage.Controls.Add(this.alphaCoefTextBox);
            this.parametersPage.Controls.Add(this.label5);
            this.parametersPage.Controls.Add(this.label4);
            this.parametersPage.Controls.Add(this.label3);
            this.parametersPage.Location = new System.Drawing.Point(4, 22);
            this.parametersPage.Name = "parametersPage";
            this.parametersPage.Padding = new System.Windows.Forms.Padding(3);
            this.parametersPage.Size = new System.Drawing.Size(696, 576);
            this.parametersPage.TabIndex = 1;
            this.parametersPage.Text = "Parameters page";
            this.parametersPage.UseVisualStyleBackColor = true;
            // 
            // antsNumTextBox
            // 
            this.antsNumTextBox.Location = new System.Drawing.Point(192, 116);
            this.antsNumTextBox.Name = "antsNumTextBox";
            this.antsNumTextBox.Size = new System.Drawing.Size(128, 21);
            this.antsNumTextBox.TabIndex = 12;
            this.antsNumTextBox.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ants number";
            // 
            // setDefaultsButton
            // 
            this.setDefaultsButton.Location = new System.Drawing.Point(10, 161);
            this.setDefaultsButton.Name = "setDefaultsButton";
            this.setDefaultsButton.Size = new System.Drawing.Size(128, 24);
            this.setDefaultsButton.TabIndex = 10;
            this.setDefaultsButton.Text = "Set defaults";
            this.setDefaultsButton.UseVisualStyleBackColor = true;
            this.setDefaultsButton.Click += new System.EventHandler(this.setDefaultsButton_Click);
            // 
            // qCoefTextBox
            // 
            this.qCoefTextBox.Location = new System.Drawing.Point(192, 71);
            this.qCoefTextBox.Name = "qCoefTextBox";
            this.qCoefTextBox.Size = new System.Drawing.Size(128, 21);
            this.qCoefTextBox.TabIndex = 9;
            this.qCoefTextBox.Text = "20";
            // 
            // rhoCoefTextBox
            // 
            this.rhoCoefTextBox.Location = new System.Drawing.Point(192, 26);
            this.rhoCoefTextBox.Name = "rhoCoefTextBox";
            this.rhoCoefTextBox.Size = new System.Drawing.Size(128, 21);
            this.rhoCoefTextBox.TabIndex = 8;
            this.rhoCoefTextBox.Text = "0,5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Q";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rho";
            // 
            // iterNumTextBox
            // 
            this.iterNumTextBox.Location = new System.Drawing.Point(10, 116);
            this.iterNumTextBox.Name = "iterNumTextBox";
            this.iterNumTextBox.Size = new System.Drawing.Size(128, 21);
            this.iterNumTextBox.TabIndex = 5;
            this.iterNumTextBox.Text = "500";
            // 
            // betaCoefTextBox
            // 
            this.betaCoefTextBox.Location = new System.Drawing.Point(10, 71);
            this.betaCoefTextBox.Name = "betaCoefTextBox";
            this.betaCoefTextBox.Size = new System.Drawing.Size(128, 21);
            this.betaCoefTextBox.TabIndex = 4;
            this.betaCoefTextBox.Text = "5";
            // 
            // alphaCoefTextBox
            // 
            this.alphaCoefTextBox.Location = new System.Drawing.Point(10, 26);
            this.alphaCoefTextBox.Name = "alphaCoefTextBox";
            this.alphaCoefTextBox.Size = new System.Drawing.Size(128, 21);
            this.alphaCoefTextBox.TabIndex = 3;
            this.alphaCoefTextBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Iterations number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Beta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alpha";
            // 
            // setNodesRanButton
            // 
            this.setNodesRanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setNodesRanButton.Location = new System.Drawing.Point(540, 27);
            this.setNodesRanButton.MaximumSize = new System.Drawing.Size(150, 23);
            this.setNodesRanButton.Name = "setNodesRanButton";
            this.setNodesRanButton.Size = new System.Drawing.Size(150, 23);
            this.setNodesRanButton.TabIndex = 6;
            this.setNodesRanButton.Text = "Set nodes randomly";
            this.setNodesRanButton.UseVisualStyleBackColor = true;
            this.setNodesRanButton.Click += new System.EventHandler(this.setNodesRandButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 602);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travelling salesman problem";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.tabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.matrixPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).EndInit();
            this.parametersPage.ResumeLayout(false);
            this.parametersPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage parametersPage;
        private System.Windows.Forms.TabPage matrixPage;
        private System.Windows.Forms.DataGridView matrixDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Label optimalPathLengthLabel;
        private System.Windows.Forms.Label optimalPathLabel;
        private System.Windows.Forms.Button setDefaultsButton;
        private System.Windows.Forms.TextBox qCoefTextBox;
        private System.Windows.Forms.TextBox rhoCoefTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iterNumTextBox;
        private System.Windows.Forms.TextBox betaCoefTextBox;
        private System.Windows.Forms.TextBox alphaCoefTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox antsNumTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button setNodesRanButton;
    }
}

