using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TravellingSalesmanProblem.Resources;

namespace TravellingSalesmanProblem
{
    enum BorderType
    {
        Normal,
        Optimal
    }

    public partial class MainForm : Form
    {
        BitmapCanvas bmpCanvas;

        SolidBrush nodeBrush = new SolidBrush(Color.Aqua);
        Pen nodePen = new Pen(Color.Black, 2);
        Pen normalBorderPen = new Pen(Color.Black, 4);
        Pen optimalBorderPen = new Pen(Color.DarkViolet, 6);
        Size nodeSize = new Size(30, 30);
        Font nodeTextFont = new Font(FontFamily.GenericSansSerif, 16f);
        Font lengthTextFont = new Font(FontFamily.GenericSansSerif, 20f, FontStyle.Bold);

        Random rand = new Random();

        List<List<int>> lengthMatr = new List<List<int>>();

        List<Point> nodesLocs = new List<Point>();

        float alpha;
        float beta;
        int iterNum;
        int antsNum;
        float rho;
        float q;

        AntColonyOptimizationForTSP tsp;

        public MainForm()
        {
            InitializeComponent();

            bmpCanvas = new BitmapCanvas(graphPictureBox, graphPictureBox.Width, graphPictureBox.Height);
        }

        Point CalculateNodeLocation(Point point)
        {
            return new Point(point.X - nodeSize.Width / 2, point.Y - nodeSize.Height / 2);
        }

        Point CalculateNodeTextLocation(Point point, string s)
        {
            if (s.Length == 1)
                return new Point(point.X - 10, point.Y - 12);
            else if (s.Length == 2)
                return new Point(point.X - 16, point.Y - 12);
            else
                return new Point(point.X - 5 * s.Length, point.Y - 12);
        }

        void DrawNode(Point point, int index)
        {
            bmpCanvas.DrawEllipse(
                new Rectangle(
                    CalculateNodeLocation(new Point(point.X, point.Y)),
                    nodeSize),
                nodePen,
                nodeBrush);

            string bufs = index.ToString();
            bmpCanvas.DrawString(
                bufs,
                nodeTextFont,
                Brushes.Black,
                CalculateNodeTextLocation(
                    new Point(point.X, point.Y),
                    bufs));
        }

        void DrawNodes()
        {
            for (int i = 0; i < nodesLocs.Count; i++)
                DrawNode(nodesLocs[i], i);
        }

        void DrawBorder(Point p0, Point p1, BorderType bt)
        {
            if (bt == BorderType.Normal)
                bmpCanvas.DrawLine(normalBorderPen, p0, p1);
            else
                bmpCanvas.DrawLine(optimalBorderPen, p0, p1);
        }

        void DrawOptimalBorders(List<int> optimalBorders)
        {
            for (int i = 0; i < optimalBorders.Count - 1; i++)
                DrawBorder(nodesLocs[optimalBorders[i]], nodesLocs[optimalBorders[i + 1]], BorderType.Optimal);
            DrawBorder(nodesLocs[optimalBorders[0]], nodesLocs[optimalBorders[optimalBorders.Count - 1]], BorderType.Optimal);
        }

        void DrawBorders()
        {
            for (int i = 0; i < nodesLocs.Count; i++)
                for (int j = i + 1; j < nodesLocs.Count; j++)
                    DrawBorder(nodesLocs[i], nodesLocs[j], BorderType.Normal);

            if (tsp != null &&
                nodesLocs.Count == tsp.GetBestTrail().Count)
                DrawOptimalBorders(tsp.GetBestTrail());
        }
        
        void AddNodeToLengthMatrix()
        {
            for (int i = 0; i < lengthMatr.Count; i++)
                lengthMatr[i].Add(rand.Next(1, 50));
            lengthMatr.Add(new List<int>());
            for (int i = 0; i < lengthMatr.Count - 1; i++)
                lengthMatr[lengthMatr.Count - 1].Add(lengthMatr[i][lengthMatr.Count - 1]);
            lengthMatr[lengthMatr.Count - 1].Add(0);

            for (int i = 0; i < lengthMatr.Count; i++)
                lengthMatr[i][i] = 0;
        }

        void UpdateDataGridView()
        {
            matrixDataGridView.Rows.Clear();
            matrixDataGridView.Columns.Clear();

            if (lengthMatr.Count == 0)
                return;

            for (int i = 0; i < lengthMatr.Count; i++)
            {
                matrixDataGridView.Columns.Add("colName" + i.ToString(), i.ToString());
                matrixDataGridView.Columns[i].Width = 23;
            }
            
            matrixDataGridView.Rows.Add(lengthMatr.Count);
            for (int i = 0; i < lengthMatr.Count; i++)
                matrixDataGridView.Rows[i].HeaderCell.Value = i.ToString();

            for (int i = 0; i < lengthMatr.Count - 1; i++)
                for (int j = i + 1; j < lengthMatr.Count; j++)
                {
                    matrixDataGridView[j, i].Value = lengthMatr[i][j];
                    matrixDataGridView[i, j].Value = lengthMatr[j][i];
                }

            for (int i = 0; i < lengthMatr.Count; i++)
                matrixDataGridView[i, i].Value = 0;
        }

        void UpdateGraph()
        {
            bmpCanvas.Clear();

            DrawBorders();
            DrawNodes();
        }

        void ClearNodesData()
        {
            lengthMatr = new List<List<int>>();
            nodesLocs = new List<Point>();
        }

        private void graphPictureBox_Click(object sender, EventArgs e)
        {
            if (tsp != null)
            {
                ClearButtonClick();
            }

            nodesLocs.Add(graphPictureBox.PointToClient(Cursor.Position));

            UpdateGraph();
            AddNodeToLengthMatrix();
            UpdateDataGridView();
        }

        private void matrixDataGridView_Sorted(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        
        private void matrixDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            matrixDataGridView.ClearSelection();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            bmpCanvas = new BitmapCanvas(graphPictureBox, graphPictureBox.Width, graphPictureBox.Height);

            UpdateGraph();
        }

        private void setDefaultsButton_Click(object sender, EventArgs e)
        {
            alphaCoefTextBox.Text = "1";
            betaCoefTextBox.Text = "5";
            iterNumTextBox.Text = "500";
            antsNumTextBox.Text = "4";
            rhoCoefTextBox.Text = "0,5";
            qCoefTextBox.Text = "20";
        }

        private void ClearButtonClick()
        {
            tsp = null;

            ClearNodesData();
            UpdateGraph();
            UpdateDataGridView();

            optimalPathLabel.Text = "None";
            optimalPathLengthLabel.Text = "None";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearButtonClick();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (lengthMatr.Count == 0)
            {
                ClearButtonClick();
                return;
            }

            alpha = (float)Convert.ToDouble(alphaCoefTextBox.Text);
            beta = (float)Convert.ToDouble(betaCoefTextBox.Text);
            rho = (float)Convert.ToDouble(rhoCoefTextBox.Text);
            q = (float)Convert.ToDouble(qCoefTextBox.Text);
            iterNum = (int)Convert.ToDouble(iterNumTextBox.Text);
            antsNum = (int)Convert.ToDouble(antsNumTextBox.Text);

            tsp = new AntColonyOptimizationForTSP();
            tsp.Calculate(lengthMatr, nodesLocs.Count, antsNum, iterNum, alpha, beta, rho, q);

            optimalPathLabel.Text = "";
            var bestTrl = tsp.GetBestTrail();
            for (int i = 0; i < bestTrl.Count - 1; i++)
            {
                optimalPathLabel.Text += bestTrl[i].ToString() + " - ";
            }
            optimalPathLabel.Text += bestTrl[bestTrl.Count - 1].ToString();

            optimalPathLengthLabel.Text = tsp.GetBestTrailLength().ToString();

            UpdateGraph();
        }

        private void setNodesRandButton_Click(object sender, EventArgs e)
        {
            if (tsp != null || nodesLocs.Count != 0)
            {
                ClearButtonClick();
            }

            for (int i = 0, max = rand.Next(4, 9); i < max; i++)
            {
                nodesLocs.Add(
                    new Point(
                        rand.Next(nodeSize.Width, graphPictureBox.Width - nodeSize.Width),
                        rand.Next(nodeSize.Height, graphPictureBox.Height - nodeSize.Height)));

                AddNodeToLengthMatrix();
            }

            UpdateGraph();
            UpdateDataGridView();
        }
    }
}
