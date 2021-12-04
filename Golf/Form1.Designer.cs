
namespace Golf
{
    partial class Golf
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Golf));
            this.pField = new System.Windows.Forms.Panel();
            this.pSampleEnemy = new System.Windows.Forms.PictureBox();
            this.lStartCount = new System.Windows.Forms.Label();
            this.pTarget = new System.Windows.Forms.PictureBox();
            this.pSample = new System.Windows.Forms.PictureBox();
            this.lStats = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTools = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSampleEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSample)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.pTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pField
            // 
            this.pField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pField.Controls.Add(this.pSampleEnemy);
            this.pField.Controls.Add(this.lStartCount);
            this.pField.Controls.Add(this.pTarget);
            this.pField.Controls.Add(this.pSample);
            this.pField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pField.Location = new System.Drawing.Point(3, 47);
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(909, 503);
            this.pField.TabIndex = 0;
            this.pField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pField_MouseMove);
            // 
            // pSampleEnemy
            // 
            this.pSampleEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pSampleEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pSampleEnemy.Image")));
            this.pSampleEnemy.Location = new System.Drawing.Point(813, 284);
            this.pSampleEnemy.Name = "pSampleEnemy";
            this.pSampleEnemy.Size = new System.Drawing.Size(40, 40);
            this.pSampleEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSampleEnemy.TabIndex = 4;
            this.pSampleEnemy.TabStop = false;
            this.pSampleEnemy.Visible = false;
            // 
            // lStartCount
            // 
            this.lStartCount.AutoSize = true;
            this.lStartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStartCount.Location = new System.Drawing.Point(439, 14);
            this.lStartCount.Name = "lStartCount";
            this.lStartCount.Size = new System.Drawing.Size(24, 25);
            this.lStartCount.TabIndex = 2;
            this.lStartCount.Text = "3";
            this.lStartCount.Visible = false;
            // 
            // pTarget
            // 
            this.pTarget.Image = ((System.Drawing.Image)(resources.GetObject("pTarget.Image")));
            this.pTarget.Location = new System.Drawing.Point(795, 177);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(86, 101);
            this.pTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTarget.TabIndex = 1;
            this.pTarget.TabStop = false;
            this.pTarget.Visible = false;
            // 
            // pSample
            // 
            this.pSample.Image = ((System.Drawing.Image)(resources.GetObject("pSample.Image")));
            this.pSample.Location = new System.Drawing.Point(845, 430);
            this.pSample.Name = "pSample";
            this.pSample.Size = new System.Drawing.Size(55, 64);
            this.pSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSample.TabIndex = 0;
            this.pSample.TabStop = false;
            this.pSample.Visible = false;
            // 
            // lStats
            // 
            this.lStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lStats.Location = new System.Drawing.Point(271, 2);
            this.lStats.Name = "lStats";
            this.lStats.Size = new System.Drawing.Size(341, 33);
            this.lStats.TabIndex = 3;
            this.lStats.Text = "You win!";
            this.lStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lStats.Visible = false;
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(809, 2);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(80, 24);
            this.lCount.TabIndex = 1;
            this.lCount.Text = "Count: 0";
            this.lCount.Visible = false;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(3, 5);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.pField, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTools, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.131868F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.86813F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(915, 553);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.bStart);
            this.pTools.Controls.Add(this.lStats);
            this.pTools.Controls.Add(this.lCount);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTools.Location = new System.Drawing.Point(3, 3);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(909, 38);
            this.pTools.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Golf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 553);
            this.Controls.Add(this.tableLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Golf";
            this.ShowIcon = false;
            this.Text = "Golf";
            this.pField.ResumeLayout(false);
            this.pField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSampleEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSample)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pField;
        private System.Windows.Forms.PictureBox pTarget;
        private System.Windows.Forms.PictureBox pSample;
        private System.Windows.Forms.Label lStartCount;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lStats;
        private System.Windows.Forms.PictureBox pSampleEnemy;
    }
}

