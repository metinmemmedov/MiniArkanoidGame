namespace MiniArkanoidGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ball = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // ball
            // 
            ball.Image = (Image)resources.GetObject("ball.Image");
            ball.Location = new Point(293, 12);
            ball.Name = "ball";
            ball.Size = new Size(70, 70);
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.TabIndex = 0;
            ball.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(222, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 20);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 661);
            Controls.Add(panel1);
            Controls.Add(ball);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Arkanoid Game";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
    }
}
