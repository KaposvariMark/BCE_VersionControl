namespace ToyFactory
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Car = new System.Windows.Forms.Button();
            this.btn_Ball = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btn_BallColor = new System.Windows.Forms.Button();
            this.btn_Present = new System.Windows.Forms.Button();
            this.btn_ColorBox = new System.Windows.Forms.Button();
            this.btn_ColorRibbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.Location = new System.Drawing.Point(12, 219);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_Car
            // 
            this.btn_Car.Location = new System.Drawing.Point(104, 24);
            this.btn_Car.Name = "btn_Car";
            this.btn_Car.Size = new System.Drawing.Size(75, 75);
            this.btn_Car.TabIndex = 1;
            this.btn_Car.Text = "CAR";
            this.btn_Car.UseVisualStyleBackColor = true;
            this.btn_Car.Click += new System.EventHandler(this.btn_Car_Click);
            // 
            // btn_Ball
            // 
            this.btn_Ball.Location = new System.Drawing.Point(204, 24);
            this.btn_Ball.Name = "btn_Ball";
            this.btn_Ball.Size = new System.Drawing.Size(75, 75);
            this.btn_Ball.TabIndex = 2;
            this.btn_Ball.Text = "BALL";
            this.btn_Ball.UseVisualStyleBackColor = true;
            this.btn_Ball.Click += new System.EventHandler(this.btn_Ball_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(302, 24);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming next:";
            // 
            // btn_BallColor
            // 
            this.btn_BallColor.BackColor = System.Drawing.Color.Red;
            this.btn_BallColor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_BallColor.Location = new System.Drawing.Point(204, 105);
            this.btn_BallColor.Name = "btn_BallColor";
            this.btn_BallColor.Size = new System.Drawing.Size(75, 23);
            this.btn_BallColor.TabIndex = 4;
            this.btn_BallColor.UseVisualStyleBackColor = false;
            this.btn_BallColor.Click += new System.EventHandler(this.btn_BallColor_Click);
            // 
            // btn_Present
            // 
            this.btn_Present.Location = new System.Drawing.Point(12, 24);
            this.btn_Present.Name = "btn_Present";
            this.btn_Present.Size = new System.Drawing.Size(75, 75);
            this.btn_Present.TabIndex = 5;
            this.btn_Present.Text = "PRESENT";
            this.btn_Present.UseVisualStyleBackColor = true;
            // 
            // btn_ColorBox
            // 
            this.btn_ColorBox.BackColor = System.Drawing.Color.Red;
            this.btn_ColorBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ColorBox.Location = new System.Drawing.Point(12, 134);
            this.btn_ColorBox.Name = "btn_ColorBox";
            this.btn_ColorBox.Size = new System.Drawing.Size(75, 23);
            this.btn_ColorBox.TabIndex = 6;
            this.btn_ColorBox.UseVisualStyleBackColor = false;
            this.btn_ColorBox.Click += new System.EventHandler(this.btn_BallColor_Click);
            // 
            // btn_ColorRibbon
            // 
            this.btn_ColorRibbon.BackColor = System.Drawing.Color.Red;
            this.btn_ColorRibbon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ColorRibbon.Location = new System.Drawing.Point(12, 105);
            this.btn_ColorRibbon.Name = "btn_ColorRibbon";
            this.btn_ColorRibbon.Size = new System.Drawing.Size(75, 23);
            this.btn_ColorRibbon.TabIndex = 7;
            this.btn_ColorRibbon.UseVisualStyleBackColor = false;
            this.btn_ColorRibbon.Click += new System.EventHandler(this.btn_BallColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ColorRibbon);
            this.Controls.Add(this.btn_ColorBox);
            this.Controls.Add(this.btn_Present);
            this.Controls.Add(this.btn_BallColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btn_Ball);
            this.Controls.Add(this.btn_Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btn_Car;
        private System.Windows.Forms.Button btn_Ball;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btn_BallColor;
        private System.Windows.Forms.Button btn_Present;
        private System.Windows.Forms.Button btn_ColorBox;
        private System.Windows.Forms.Button btn_ColorRibbon;
    }
}

