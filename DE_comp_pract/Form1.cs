using System;
using System.Linq;
using System.Windows.Forms;
using solutions;

namespace DE_comp_pract
{
    public partial class Form1 : Form
    {
        
        private GraphBuilder exactGraph = new GraphBuilder(new ExactSolution());
        private GraphBuilder eulerGraph = new GraphBuilder(new EulerSolution());
        private GraphBuilder impEulerGraph = new GraphBuilder(new ImpEulerSolution());
        private GraphBuilder RungeKutteGraph = new GraphBuilder(new RungeKutte());
        
        public Form1()
        {
            InitializeComponent();
        }

        private void plot_button_Click(object sender, EventArgs e)
        {
            try
            {
                double initX = Double.Parse(x0_info.Text);
                double finaleX = Double.Parse(X_info.Text);
                double initY = Double.Parse(y0_info.Text);
                int stepAmount = Int32.Parse(N_info.Text);
                int finaleStepAmount = Int32.Parse(N_max_info.Text);

                exactGraph.Rebuild(initX, finaleX, initY, stepAmount);
                eulerGraph.Rebuild(initX, finaleX, initY, stepAmount);
                impEulerGraph.Rebuild(initX, finaleX, initY, stepAmount);
                RungeKutteGraph.Rebuild(initX, finaleX, initY, stepAmount);

                solution_chart.Series[0].Points.DataBindXY(exactGraph.XArray, exactGraph.YArray);
                solution_chart.Series[1].Points.DataBindXY(eulerGraph.XArray, eulerGraph.YArray);
                solution_chart.Series[2].Points.DataBindXY(impEulerGraph.XArray, impEulerGraph.YArray);
                solution_chart.Series[3].Points.DataBindXY(RungeKutteGraph.XArray, RungeKutteGraph.YArray);

                solution_chart.ChartAreas[0].AxisX.Minimum = initX;
                solution_chart.ChartAreas[0].AxisX.Maximum = finaleX;

                GraphBuilder exactErrGraph = new GraphBuilder(initX, finaleX, initY, stepAmount, 
                    new ErrorSearch(exactGraph.YArray, exactGraph.YArray));
                GraphBuilder eulerErrGraph = new GraphBuilder(initX, finaleX, initY, stepAmount, 
                    new ErrorSearch(exactGraph.YArray, eulerGraph.YArray));
                GraphBuilder impEulerErrGraph = new GraphBuilder(initX, finaleX, initY, stepAmount, 
                    new ErrorSearch(exactGraph.YArray, impEulerGraph.YArray));
                GraphBuilder RungeKutteErrGraph = new GraphBuilder(initX, finaleX, initY, stepAmount, 
                    new ErrorSearch(exactGraph.YArray, RungeKutteGraph.YArray));

                
                error_chart.Series[0].Points.DataBindXY(exactErrGraph.XArray, exactErrGraph.YArray);
                error_chart.Series[1].Points.DataBindXY(eulerErrGraph.XArray, eulerErrGraph.YArray);
                error_chart.Series[2].Points.DataBindXY(impEulerErrGraph.XArray, impEulerErrGraph.YArray);
                error_chart.Series[3].Points.DataBindXY(RungeKutteErrGraph.XArray, RungeKutteErrGraph.YArray);
                
                error_chart.ChartAreas[0].AxisX.Minimum = initX;
                error_chart.ChartAreas[0].AxisX.Maximum = finaleX;

                double[] GTEXArray = new double[finaleStepAmount - stepAmount + 1];
                double[] GTEYExactArray = new double[finaleStepAmount - stepAmount + 1];
                double[] GTEYEulerArray = new double[finaleStepAmount - stepAmount + 1];
                double[] GTEYImpEulerArray = new double[finaleStepAmount - stepAmount + 1];
                double[] GTEYRungeKutteArray = new double[finaleStepAmount - stepAmount + 1];
                
                for (int i = stepAmount; i <= finaleStepAmount; i++)
                {
                    GTEXArray[i - stepAmount] = i;
                    exactGraph.Rebuild(initX, finaleX, initY, i);
                    eulerGraph.Rebuild(initX, finaleX, initY, i);
                    impEulerGraph.Rebuild(initX, finaleX, initY, i);
                    RungeKutteGraph.Rebuild(initX, finaleX, initY, i);
                    GraphBuilder exactGTEGraph = new GraphBuilder(initX, finaleX, initY, i, 
                        new ErrorSearch(exactGraph.YArray, exactGraph.YArray));
                    GraphBuilder eulerGTEGraph = new GraphBuilder(initX, finaleX, initY, i, 
                        new ErrorSearch(exactGraph.YArray, eulerGraph.YArray));
                    GraphBuilder impEulerGTEGraph = new GraphBuilder(initX, finaleX, initY, i, 
                        new ErrorSearch(exactGraph.YArray, impEulerGraph.YArray));
                    GraphBuilder RungeKutteGTEGraph = new GraphBuilder(initX, finaleX, initY, i, 
                        new ErrorSearch(exactGraph.YArray, RungeKutteGraph.YArray));
                    GTEYExactArray[i - stepAmount] = exactGTEGraph.YArray.Max();
                    GTEYEulerArray[i - stepAmount] = eulerGTEGraph.YArray.Max();
                    GTEYImpEulerArray[i - stepAmount] = impEulerGTEGraph.YArray.Max();
                    GTEYRungeKutteArray[i - stepAmount] = RungeKutteGTEGraph.YArray.Max();
                }
                
                GTE_analisis_chart.Series[0].Points.DataBindXY(GTEXArray, GTEYExactArray);
                GTE_analisis_chart.Series[1].Points.DataBindXY(GTEXArray, GTEYEulerArray);
                GTE_analisis_chart.Series[2].Points.DataBindXY(GTEXArray, GTEYImpEulerArray);
                GTE_analisis_chart.Series[3].Points.DataBindXY(GTEXArray, GTEYRungeKutteArray);
                
                GTE_analisis_chart.ChartAreas[0].AxisX.Minimum = stepAmount;
                GTE_analisis_chart.ChartAreas[0].AxisX.Maximum = finaleStepAmount;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public Solution Solution { get; set; }

        private void exact_solution_cb_CheckedChanged(object sender, EventArgs e)
        {
            solution_chart.Series[0].Enabled = exact_solution_cb.Checked;
            error_chart.Series[0].Enabled = exact_solution_cb.Checked;
            GTE_analisis_chart.Series[0].Enabled = exact_solution_cb.Checked;
        }

        private void euler_solution_cb_CheckedChanged(object sender, EventArgs e)
        {
            solution_chart.Series[1].Enabled = euler_solution_cb.Checked;
            error_chart.Series[1].Enabled = euler_solution_cb.Checked;
            GTE_analisis_chart.Series[1].Enabled = euler_solution_cb.Checked;
        }

        private void imp_euler_solution_cb_CheckedChanged(object sender, EventArgs e)
        {
            solution_chart.Series[2].Enabled = imp_euler_solution_cb.Checked;
            error_chart.Series[2].Enabled = imp_euler_solution_cb.Checked;
            GTE_analisis_chart.Series[2].Enabled = imp_euler_solution_cb.Checked;
        }

        private void runge_cutte_solution_cb_CheckedChanged(object sender, EventArgs e)
        {
            solution_chart.Series[3].Enabled = runge_cutte_solution_cb.Checked;
            error_chart.Series[3].Enabled = runge_cutte_solution_cb.Checked;
            GTE_analisis_chart.Series[3].Enabled = runge_cutte_solution_cb.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plot_button_Click(sender, e);
        }
    }
}