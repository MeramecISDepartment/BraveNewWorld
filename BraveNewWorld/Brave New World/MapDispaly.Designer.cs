using System.Windows.Forms;

namespace ClassProject
{
    partial class MapDisplay
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
            this.picboxDrawing = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxDrawing
            // 
            this.picboxDrawing.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picboxDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxDrawing.Location = new System.Drawing.Point(1, 0);
            this.picboxDrawing.Name = "picboxDrawing";
            this.picboxDrawing.Size = new System.Drawing.Size(966, 482);
            this.picboxDrawing.TabIndex = 0;
            this.picboxDrawing.TabStop = false;
            this.picboxDrawing.Click += new System.EventHandler(this.picboxDrawing_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDraw.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDraw.Location = new System.Drawing.Point(402, 488);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(134, 49);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Display";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar2.Location = new System.Drawing.Point(271, 543);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(408, 23);
            this.progressBar2.TabIndex = 10;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(818, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(31, 532);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MapDisplay
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 570);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.picboxDrawing);
            this.Name = "MapDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.picboxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.PictureBox picboxDrawing;
        private System.Windows.Forms.Button btnDraw;
        private ProgressBar progressBar2;
        private Button btnExit;
        private Button btnSave;



    }
}

