namespace KeyMouseAccessibilityTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainControl = new System.Windows.Forms.Label();
            this.cursorX = new System.Windows.Forms.Label();
            this.cursorY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pressedDebug = new System.Windows.Forms.Label();
            this.xydirLabel = new System.Windows.Forms.Label();
            this.xymovLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.AutoSize = true;
            this.mainControl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainControl.Location = new System.Drawing.Point(645, 9);
            this.mainControl.Name = "mainControl";
            this.mainControl.Size = new System.Drawing.Size(161, 64);
            this.mainControl.TabIndex = 0;
            this.mainControl.Text = "TEMPORARY\r\nPROTOTYPE";
            this.mainControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cursorX
            // 
            this.cursorX.AutoSize = true;
            this.cursorX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cursorX.Location = new System.Drawing.Point(552, 278);
            this.cursorX.Name = "cursorX";
            this.cursorX.Size = new System.Drawing.Size(110, 32);
            this.cursorX.TabIndex = 2;
            this.cursorX.Text = "cursor X";
            this.cursorX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cursorY
            // 
            this.cursorY.AutoSize = true;
            this.cursorY.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cursorY.Location = new System.Drawing.Point(802, 278);
            this.cursorY.Name = "cursorY";
            this.cursorY.Size = new System.Drawing.Size(109, 32);
            this.cursorY.TabIndex = 3;
            this.cursorY.Text = "cursor Y";
            this.cursorY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pressedDebug
            // 
            this.pressedDebug.AutoSize = true;
            this.pressedDebug.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pressedDebug.Location = new System.Drawing.Point(680, 403);
            this.pressedDebug.Name = "pressedDebug";
            this.pressedDebug.Size = new System.Drawing.Size(102, 32);
            this.pressedDebug.TabIndex = 4;
            this.pressedDebug.Text = "Pressed";
            this.pressedDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xydirLabel
            // 
            this.xydirLabel.AutoSize = true;
            this.xydirLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xydirLabel.Location = new System.Drawing.Point(680, 510);
            this.xydirLabel.Name = "xydirLabel";
            this.xydirLabel.Size = new System.Drawing.Size(46, 32);
            this.xydirLabel.TabIndex = 5;
            this.xydirLabel.Text = "dir";
            this.xydirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xymovLabel
            // 
            this.xymovLabel.AutoSize = true;
            this.xymovLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xymovLabel.Location = new System.Drawing.Point(680, 574);
            this.xymovLabel.Name = "xymovLabel";
            this.xymovLabel.Size = new System.Drawing.Size(64, 32);
            this.xymovLabel.TabIndex = 6;
            this.xymovLabel.Text = "mov";
            this.xymovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(437, 680);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 826);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xymovLabel);
            this.Controls.Add(this.xydirLabel);
            this.Controls.Add(this.pressedDebug);
            this.Controls.Add(this.cursorY);
            this.Controls.Add(this.cursorX);
            this.Controls.Add(this.mainControl);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainControl;
        private Label cursorX;
        private Label cursorY;
        private System.Windows.Forms.Timer timer1;
        private Label pressedDebug;
        private Label xydirLabel;
        private Label xymovLabel;
        private TextBox textBox1;
    }
}