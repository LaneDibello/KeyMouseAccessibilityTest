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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lUpLeft = new TextBox();
            lUp = new TextBox();
            lUpRight = new TextBox();
            lRight = new TextBox();
            lDownRight = new TextBox();
            lDown = new TextBox();
            lDownLeft = new TextBox();
            lLeft = new TextBox();
            lMouseDir = new Label();
            lLeftClick = new TextBox();
            lRightClick = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // lUpLeft
            // 
            lUpLeft.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lUpLeft.Location = new Point(16, 16);
            lUpLeft.Name = "lUpLeft";
            lUpLeft.ReadOnly = true;
            lUpLeft.Size = new Size(80, 26);
            lUpLeft.TabIndex = 0;
            lUpLeft.Text = "KEY";
            lUpLeft.TextAlign = HorizontalAlignment.Center;
            lUpLeft.Enter += keybindEnter;
            lUpLeft.KeyDown += kebindPress;
            lUpLeft.Leave += keybindLeave;
            // 
            // lUp
            // 
            lUp.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lUp.Location = new Point(120, 16);
            lUp.Name = "lUp";
            lUp.ReadOnly = true;
            lUp.Size = new Size(80, 26);
            lUp.TabIndex = 1;
            lUp.Text = "KEY";
            lUp.TextAlign = HorizontalAlignment.Center;
            lUp.Enter += keybindEnter;
            lUp.KeyDown += kebindPress;
            lUp.Leave += keybindLeave;
            // 
            // lUpRight
            // 
            lUpRight.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lUpRight.Location = new Point(224, 16);
            lUpRight.Name = "lUpRight";
            lUpRight.ReadOnly = true;
            lUpRight.Size = new Size(80, 26);
            lUpRight.TabIndex = 2;
            lUpRight.Text = "KEY";
            lUpRight.TextAlign = HorizontalAlignment.Center;
            lUpRight.Enter += keybindEnter;
            lUpRight.KeyDown += kebindPress;
            lUpRight.Leave += keybindLeave;
            // 
            // lRight
            // 
            lRight.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lRight.Location = new Point(224, 64);
            lRight.Name = "lRight";
            lRight.ReadOnly = true;
            lRight.Size = new Size(80, 26);
            lRight.TabIndex = 4;
            lRight.Text = "KEY";
            lRight.TextAlign = HorizontalAlignment.Center;
            lRight.Enter += keybindEnter;
            lRight.KeyDown += kebindPress;
            lRight.Leave += keybindLeave;
            // 
            // lDownRight
            // 
            lDownRight.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lDownRight.Location = new Point(224, 112);
            lDownRight.Name = "lDownRight";
            lDownRight.ReadOnly = true;
            lDownRight.Size = new Size(80, 26);
            lDownRight.TabIndex = 7;
            lDownRight.Text = "KEY";
            lDownRight.TextAlign = HorizontalAlignment.Center;
            lDownRight.Enter += keybindEnter;
            lDownRight.KeyDown += kebindPress;
            lDownRight.Leave += keybindLeave;
            // 
            // lDown
            // 
            lDown.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lDown.Location = new Point(120, 112);
            lDown.Name = "lDown";
            lDown.ReadOnly = true;
            lDown.Size = new Size(80, 26);
            lDown.TabIndex = 6;
            lDown.Text = "KEY";
            lDown.TextAlign = HorizontalAlignment.Center;
            lDown.Enter += keybindEnter;
            lDown.KeyDown += kebindPress;
            lDown.Leave += keybindLeave;
            // 
            // lDownLeft
            // 
            lDownLeft.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lDownLeft.Location = new Point(16, 112);
            lDownLeft.Name = "lDownLeft";
            lDownLeft.ReadOnly = true;
            lDownLeft.Size = new Size(80, 26);
            lDownLeft.TabIndex = 5;
            lDownLeft.Text = "KEY";
            lDownLeft.TextAlign = HorizontalAlignment.Center;
            lDownLeft.Enter += keybindEnter;
            lDownLeft.KeyDown += kebindPress;
            lDownLeft.Leave += keybindLeave;
            // 
            // lLeft
            // 
            lLeft.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lLeft.Location = new Point(16, 64);
            lLeft.Name = "lLeft";
            lLeft.ReadOnly = true;
            lLeft.Size = new Size(80, 26);
            lLeft.TabIndex = 3;
            lLeft.Text = "KEY";
            lLeft.TextAlign = HorizontalAlignment.Center;
            lLeft.Enter += keybindEnter;
            lLeft.KeyDown += kebindPress;
            lLeft.Leave += keybindLeave;
            // 
            // lMouseDir
            // 
            lMouseDir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lMouseDir.Location = new Point(120, 56);
            lMouseDir.Name = "lMouseDir";
            lMouseDir.Size = new Size(80, 40);
            lMouseDir.TabIndex = 8;
            lMouseDir.Text = "Mouse\r\nDirections";
            lMouseDir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lLeftClick
            // 
            lLeftClick.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lLeftClick.Location = new Point(16, 168);
            lLeftClick.Name = "lLeftClick";
            lLeftClick.ReadOnly = true;
            lLeftClick.Size = new Size(80, 26);
            lLeftClick.TabIndex = 9;
            lLeftClick.Text = "KEY";
            lLeftClick.TextAlign = HorizontalAlignment.Center;
            lLeftClick.Enter += keybindEnter;
            lLeftClick.KeyDown += kebindPress;
            lLeftClick.Leave += keybindLeave;
            // 
            // lRightClick
            // 
            lRightClick.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lRightClick.Location = new Point(16, 208);
            lRightClick.Name = "lRightClick";
            lRightClick.ReadOnly = true;
            lRightClick.Size = new Size(80, 26);
            lRightClick.TabIndex = 10;
            lRightClick.Text = "KEY";
            lRightClick.TextAlign = HorizontalAlignment.Center;
            lRightClick.Enter += keybindEnter;
            lRightClick.KeyDown += kebindPress;
            lRightClick.Leave += keybindLeave;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 168);
            label2.Name = "label2";
            label2.Size = new Size(184, 24);
            label2.TabIndex = 12;
            label2.Text = "Left Click";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 208);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 13;
            label1.Text = "Right Click";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Location = new Point(8, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 40);
            panel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 557);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lRightClick);
            Controls.Add(lLeftClick);
            Controls.Add(lMouseDir);
            Controls.Add(lLeft);
            Controls.Add(lDownLeft);
            Controls.Add(lDown);
            Controls.Add(lDownRight);
            Controls.Add(lRight);
            Controls.Add(lUpRight);
            Controls.Add(lUp);
            Controls.Add(lUpLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Keyboard Mouse Movement";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TextBox lUpLeft;
        private TextBox lUp;
        private TextBox lUpRight;
        private TextBox lRight;
        private TextBox lDownRight;
        private TextBox lDown;
        private TextBox lDownLeft;
        private TextBox lLeft;
        private Label lMouseDir;
        private TextBox lLeftClick;
        private TextBox lRightClick;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}