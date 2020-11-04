namespace DE_comp_pract
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bottom_menu = new System.Windows.Forms.TableLayoutPanel();
            this.side_panel = new System.Windows.Forms.TableLayoutPanel();
            this.x0_label = new System.Windows.Forms.Label();
            this.X_label = new System.Windows.Forms.Label();
            this.N_lable = new System.Windows.Forms.Label();
            this.x0_info = new System.Windows.Forms.TextBox();
            this.X_info = new System.Windows.Forms.TextBox();
            this.N_info = new System.Windows.Forms.TextBox();
            this.exact_solution_cb = new System.Windows.Forms.CheckBox();
            this.euler_solution_cb = new System.Windows.Forms.CheckBox();
            this.imp_euler_solution_cb = new System.Windows.Forms.CheckBox();
            this.runge_cutte_solution_cb = new System.Windows.Forms.CheckBox();
            this.plot_button = new System.Windows.Forms.Button();
            this.y0_label = new System.Windows.Forms.Label();
            this.y0_info = new System.Windows.Forms.TextBox();
            this.N_max_label = new System.Windows.Forms.Label();
            this.N_max_info = new System.Windows.Forms.TextBox();
            this.chart_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plot_layout = new System.Windows.Forms.TableLayoutPanel();
            this.solution_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.error_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GTE_analisis_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bottom_menu.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.chart_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.plot_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.solution_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.error_chart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.GTE_analisis_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // bottom_menu
            // 
            this.bottom_menu.ColumnCount = 2;
            this.bottom_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.bottom_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bottom_menu.Controls.Add(this.side_panel, 0, 0);
            this.bottom_menu.Controls.Add(this.chart_tab, 1, 0);
            this.bottom_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_menu.Location = new System.Drawing.Point(0, 0);
            this.bottom_menu.Name = "bottom_menu";
            this.bottom_menu.RowCount = 1;
            this.bottom_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottom_menu.Size = new System.Drawing.Size(878, 576);
            this.bottom_menu.TabIndex = 3;
            // 
            // side_panel
            // 
            this.side_panel.ColumnCount = 1;
            this.side_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.side_panel.Controls.Add(this.x0_label, 0, 0);
            this.side_panel.Controls.Add(this.X_label, 0, 2);
            this.side_panel.Controls.Add(this.N_lable, 0, 4);
            this.side_panel.Controls.Add(this.x0_info, 0, 1);
            this.side_panel.Controls.Add(this.X_info, 0, 3);
            this.side_panel.Controls.Add(this.N_info, 0, 5);
            this.side_panel.Controls.Add(this.exact_solution_cb, 0, 10);
            this.side_panel.Controls.Add(this.euler_solution_cb, 0, 11);
            this.side_panel.Controls.Add(this.imp_euler_solution_cb, 0, 12);
            this.side_panel.Controls.Add(this.runge_cutte_solution_cb, 0, 13);
            this.side_panel.Controls.Add(this.plot_button, 0, 14);
            this.side_panel.Controls.Add(this.y0_label, 0, 6);
            this.side_panel.Controls.Add(this.y0_info, 0, 7);
            this.side_panel.Controls.Add(this.N_max_label, 0, 8);
            this.side_panel.Controls.Add(this.N_max_info, 0, 9);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.side_panel.Location = new System.Drawing.Point(3, 3);
            this.side_panel.Name = "side_panel";
            this.side_panel.RowCount = 15;
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.side_panel.Size = new System.Drawing.Size(174, 570);
            this.side_panel.TabIndex = 0;
            // 
            // x0_label
            // 
            this.x0_label.AutoSize = true;
            this.x0_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.x0_label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.x0_label.Location = new System.Drawing.Point(5, 5);
            this.x0_label.Margin = new System.Windows.Forms.Padding(5);
            this.x0_label.Name = "x0_label";
            this.x0_label.Size = new System.Drawing.Size(164, 21);
            this.x0_label.TabIndex = 0;
            this.x0_label.Text = "x₀";
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.X_label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.X_label.Location = new System.Drawing.Point(5, 74);
            this.X_label.Margin = new System.Windows.Forms.Padding(5);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(164, 21);
            this.X_label.TabIndex = 0;
            this.X_label.Text = "X";
            // 
            // N_lable
            // 
            this.N_lable.AutoSize = true;
            this.N_lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.N_lable.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.N_lable.Location = new System.Drawing.Point(5, 143);
            this.N_lable.Margin = new System.Windows.Forms.Padding(5);
            this.N_lable.Name = "N_lable";
            this.N_lable.Size = new System.Drawing.Size(164, 21);
            this.N_lable.TabIndex = 0;
            this.N_lable.Text = "N";
            // 
            // x0_info
            // 
            this.x0_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.x0_info.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.x0_info.Location = new System.Drawing.Point(5, 36);
            this.x0_info.Margin = new System.Windows.Forms.Padding(5);
            this.x0_info.Name = "x0_info";
            this.x0_info.Size = new System.Drawing.Size(164, 28);
            this.x0_info.TabIndex = 1;
            this.x0_info.Text = "1";
            // 
            // X_info
            // 
            this.X_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.X_info.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.X_info.Location = new System.Drawing.Point(5, 105);
            this.X_info.Margin = new System.Windows.Forms.Padding(5);
            this.X_info.Name = "X_info";
            this.X_info.Size = new System.Drawing.Size(164, 28);
            this.X_info.TabIndex = 1;
            this.X_info.Text = "10";
            // 
            // N_info
            // 
            this.N_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.N_info.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.N_info.Location = new System.Drawing.Point(5, 174);
            this.N_info.Margin = new System.Windows.Forms.Padding(5);
            this.N_info.Name = "N_info";
            this.N_info.Size = new System.Drawing.Size(164, 28);
            this.N_info.TabIndex = 1;
            this.N_info.Text = "9";
            // 
            // exact_solution_cb
            // 
            this.exact_solution_cb.AutoSize = true;
            this.exact_solution_cb.Checked = true;
            this.exact_solution_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exact_solution_cb.Dock = System.Windows.Forms.DockStyle.Top;
            this.exact_solution_cb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.exact_solution_cb.Location = new System.Drawing.Point(5, 371);
            this.exact_solution_cb.Margin = new System.Windows.Forms.Padding(5);
            this.exact_solution_cb.Name = "exact_solution_cb";
            this.exact_solution_cb.Size = new System.Drawing.Size(164, 25);
            this.exact_solution_cb.TabIndex = 2;
            this.exact_solution_cb.Text = "exact";
            this.exact_solution_cb.UseVisualStyleBackColor = true;
            this.exact_solution_cb.CheckedChanged += new System.EventHandler(this.exact_solution_cb_CheckedChanged);
            // 
            // euler_solution_cb
            // 
            this.euler_solution_cb.AutoSize = true;
            this.euler_solution_cb.Checked = true;
            this.euler_solution_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.euler_solution_cb.Dock = System.Windows.Forms.DockStyle.Top;
            this.euler_solution_cb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.euler_solution_cb.Location = new System.Drawing.Point(5, 406);
            this.euler_solution_cb.Margin = new System.Windows.Forms.Padding(5);
            this.euler_solution_cb.Name = "euler_solution_cb";
            this.euler_solution_cb.Size = new System.Drawing.Size(164, 25);
            this.euler_solution_cb.TabIndex = 2;
            this.euler_solution_cb.Text = "euler_sol";
            this.euler_solution_cb.UseVisualStyleBackColor = true;
            this.euler_solution_cb.CheckedChanged += new System.EventHandler(this.euler_solution_cb_CheckedChanged);
            // 
            // imp_euler_solution_cb
            // 
            this.imp_euler_solution_cb.AutoSize = true;
            this.imp_euler_solution_cb.Checked = true;
            this.imp_euler_solution_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.imp_euler_solution_cb.Dock = System.Windows.Forms.DockStyle.Top;
            this.imp_euler_solution_cb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.imp_euler_solution_cb.Location = new System.Drawing.Point(5, 441);
            this.imp_euler_solution_cb.Margin = new System.Windows.Forms.Padding(5);
            this.imp_euler_solution_cb.Name = "imp_euler_solution_cb";
            this.imp_euler_solution_cb.Size = new System.Drawing.Size(164, 25);
            this.imp_euler_solution_cb.TabIndex = 2;
            this.imp_euler_solution_cb.Text = "Improve euler";
            this.imp_euler_solution_cb.UseVisualStyleBackColor = true;
            this.imp_euler_solution_cb.CheckedChanged += new System.EventHandler(this.imp_euler_solution_cb_CheckedChanged);
            // 
            // runge_cutte_solution_cb
            // 
            this.runge_cutte_solution_cb.AutoSize = true;
            this.runge_cutte_solution_cb.Checked = true;
            this.runge_cutte_solution_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.runge_cutte_solution_cb.Dock = System.Windows.Forms.DockStyle.Top;
            this.runge_cutte_solution_cb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.runge_cutte_solution_cb.Location = new System.Drawing.Point(5, 476);
            this.runge_cutte_solution_cb.Margin = new System.Windows.Forms.Padding(5);
            this.runge_cutte_solution_cb.Name = "runge_cutte_solution_cb";
            this.runge_cutte_solution_cb.Size = new System.Drawing.Size(164, 25);
            this.runge_cutte_solution_cb.TabIndex = 2;
            this.runge_cutte_solution_cb.Text = "Runge-Kutta";
            this.runge_cutte_solution_cb.UseVisualStyleBackColor = true;
            this.runge_cutte_solution_cb.CheckedChanged += new System.EventHandler(this.runge_cutte_solution_cb_CheckedChanged);
            // 
            // plot_button
            // 
            this.plot_button.AutoSize = true;
            this.plot_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.plot_button.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.plot_button.Location = new System.Drawing.Point(5, 511);
            this.plot_button.Margin = new System.Windows.Forms.Padding(5);
            this.plot_button.Name = "plot_button";
            this.plot_button.Size = new System.Drawing.Size(164, 31);
            this.plot_button.TabIndex = 3;
            this.plot_button.Text = "plot";
            this.plot_button.UseVisualStyleBackColor = true;
            this.plot_button.Click += new System.EventHandler(this.plot_button_Click);
            // 
            // y0_label
            // 
            this.y0_label.AutoSize = true;
            this.y0_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.y0_label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.y0_label.Location = new System.Drawing.Point(5, 212);
            this.y0_label.Margin = new System.Windows.Forms.Padding(5);
            this.y0_label.Name = "y0_label";
            this.y0_label.Size = new System.Drawing.Size(164, 21);
            this.y0_label.TabIndex = 0;
            this.y0_label.Text = "y₀";
            // 
            // y0_info
            // 
            this.y0_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.y0_info.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.y0_info.Location = new System.Drawing.Point(5, 243);
            this.y0_info.Margin = new System.Windows.Forms.Padding(5);
            this.y0_info.Name = "y0_info";
            this.y0_info.Size = new System.Drawing.Size(164, 28);
            this.y0_info.TabIndex = 1;
            this.y0_info.Text = "2";
            // 
            // N_max_label
            // 
            this.N_max_label.AutoSize = true;
            this.N_max_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.N_max_label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.N_max_label.Location = new System.Drawing.Point(5, 281);
            this.N_max_label.Margin = new System.Windows.Forms.Padding(5);
            this.N_max_label.Name = "N_max_label";
            this.N_max_label.Size = new System.Drawing.Size(164, 42);
            this.N_max_label.TabIndex = 0;
            this.N_max_label.Text = "N max(for GTE analisys)";
            // 
            // N_max_info
            // 
            this.N_max_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.N_max_info.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.N_max_info.Location = new System.Drawing.Point(5, 333);
            this.N_max_info.Margin = new System.Windows.Forms.Padding(5);
            this.N_max_info.Name = "N_max_info";
            this.N_max_info.Size = new System.Drawing.Size(164, 28);
            this.N_max_info.TabIndex = 1;
            this.N_max_info.Text = "100";
            // 
            // chart_tab
            // 
            this.chart_tab.Controls.Add(this.tabPage1);
            this.chart_tab.Controls.Add(this.tabPage2);
            this.chart_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_tab.Location = new System.Drawing.Point(180, 0);
            this.chart_tab.Margin = new System.Windows.Forms.Padding(0);
            this.chart_tab.Name = "chart_tab";
            this.chart_tab.SelectedIndex = 0;
            this.chart_tab.Size = new System.Drawing.Size(702, 576);
            this.chart_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.plot_layout);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Solution";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // plot_layout
            // 
            this.plot_layout.ColumnCount = 1;
            this.plot_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plot_layout.Controls.Add(this.solution_chart, 0, 0);
            this.plot_layout.Controls.Add(this.error_chart, 0, 1);
            this.plot_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot_layout.Location = new System.Drawing.Point(3, 3);
            this.plot_layout.Margin = new System.Windows.Forms.Padding(5);
            this.plot_layout.Name = "plot_layout";
            this.plot_layout.RowCount = 2;
            this.plot_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plot_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plot_layout.Size = new System.Drawing.Size(688, 541);
            this.plot_layout.TabIndex = 2;
            // 
            // solution_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.solution_chart.ChartAreas.Add(chartArea1);
            this.solution_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.solution_chart.Legends.Add(legend1);
            this.solution_chart.Location = new System.Drawing.Point(3, 3);
            this.solution_chart.Name = "solution_chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Exact";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Euler";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Improved Euler";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Runge-Kutte";
            this.solution_chart.Series.Add(series1);
            this.solution_chart.Series.Add(series2);
            this.solution_chart.Series.Add(series3);
            this.solution_chart.Series.Add(series4);
            this.solution_chart.Size = new System.Drawing.Size(682, 264);
            this.solution_chart.TabIndex = 0;
            this.solution_chart.Text = "Solution";
            title1.Name = "solution_title";
            title1.Text = "Solution";
            this.solution_chart.Titles.Add(title1);
            // 
            // error_chart
            // 
            chartArea2.Name = "ChartArea2";
            this.error_chart.ChartAreas.Add(chartArea2);
            this.error_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend2";
            this.error_chart.Legends.Add(legend2);
            this.error_chart.Location = new System.Drawing.Point(3, 273);
            this.error_chart.Name = "error_chart";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea2";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend2";
            series5.Name = "Exact";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend2";
            series6.Name = "Euler";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea2";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend2";
            series7.Name = "Improved Euler";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea2";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend2";
            series8.Name = "Runge-Kutte";
            this.error_chart.Series.Add(series5);
            this.error_chart.Series.Add(series6);
            this.error_chart.Series.Add(series7);
            this.error_chart.Series.Add(series8);
            this.error_chart.Size = new System.Drawing.Size(682, 265);
            this.error_chart.TabIndex = 0;
            this.error_chart.Text = "error";
            title2.Name = "solution_title";
            title2.Text = "Trancation error";
            this.error_chart.Titles.Add(title2);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GTE_analisis_chart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GTE Analysis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GTE_analisis_chart
            // 
            chartArea3.Name = "ChartArea3";
            this.GTE_analisis_chart.ChartAreas.Add(chartArea3);
            this.GTE_analisis_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend3";
            this.GTE_analisis_chart.Legends.Add(legend3);
            this.GTE_analisis_chart.Location = new System.Drawing.Point(3, 3);
            this.GTE_analisis_chart.Name = "GTE_analisis_chart";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea3";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend3";
            series9.Name = "Exact";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea3";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend3";
            series10.Name = "Euler";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea3";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend3";
            series11.Name = "Improved Euler";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea3";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend3";
            series12.Name = "Runge-Kutte";
            this.GTE_analisis_chart.Series.Add(series9);
            this.GTE_analisis_chart.Series.Add(series10);
            this.GTE_analisis_chart.Series.Add(series11);
            this.GTE_analisis_chart.Series.Add(series12);
            this.GTE_analisis_chart.Size = new System.Drawing.Size(688, 541);
            this.GTE_analisis_chart.TabIndex = 0;
            this.GTE_analisis_chart.Text = "error";
            title3.Name = "solution_title";
            title3.Text = "GTE Analisis";
            this.GTE_analisis_chart.Titles.Add(title3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(878, 576);
            this.Controls.Add(this.bottom_menu);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bottom_menu.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            this.chart_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.plot_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.solution_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.error_chart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.GTE_analisis_chart)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart GTE_analisis_chart;

        private System.Windows.Forms.TextBox N_max_info;
        private System.Windows.Forms.Label N_max_label;

        private System.Windows.Forms.TabControl chart_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart error_chart;
        private System.Windows.Forms.TableLayoutPanel plot_layout;
        private System.Windows.Forms.DataVisualization.Charting.Chart solution_chart;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.TableLayoutPanel bottom_menu;
        private System.Windows.Forms.CheckBox euler_solution_cb;
        private System.Windows.Forms.CheckBox exact_solution_cb;
        private System.Windows.Forms.CheckBox imp_euler_solution_cb;
        private System.Windows.Forms.TextBox N_info;
        private System.Windows.Forms.Label N_lable;
        private System.Windows.Forms.Button plot_button;
        private System.Windows.Forms.CheckBox runge_cutte_solution_cb;
        private System.Windows.Forms.TableLayoutPanel side_panel;
        private System.Windows.Forms.TextBox X_info;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.TextBox x0_info;
        private System.Windows.Forms.Label x0_label;
        private System.Windows.Forms.TextBox y0_info;
        private System.Windows.Forms.Label y0_label;

        #endregion
    }
}