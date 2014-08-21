namespace ClassProject
{
    partial class frmPersonalization
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
            this.lblLevels = new System.Windows.Forms.Label();
            this.lblCenterPoints = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLevels = new System.Windows.Forms.TextBox();
            this.cmbMeshLevel = new System.Windows.Forms.ComboBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevels.Location = new System.Drawing.Point(12, 7);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(58, 19);
            this.lblLevels.TabIndex = 0;
            this.lblLevels.Text = "Levels:";
            this.toolTip1.SetToolTip(this.lblLevels, "Number of contour  on the map");
            // 
            // lblCenterPoints
            // 
            this.lblCenterPoints.AutoSize = true;
            this.lblCenterPoints.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterPoints.Location = new System.Drawing.Point(12, 74);
            this.lblCenterPoints.Name = "lblCenterPoints";
            this.lblCenterPoints.Size = new System.Drawing.Size(66, 19);
            this.lblCenterPoints.TabIndex = 4;
            this.lblCenterPoints.Text = "Meshes:";
            this.toolTip1.SetToolTip(this.lblCenterPoints, "Number of land masses generated ");
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(16, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 22);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save changes");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(208, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 22);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Cancel changes");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLevels
            // 
            this.txtLevels.Location = new System.Drawing.Point(92, 9);
            this.txtLevels.MaxLength = 3;
            this.txtLevels.Name = "txtLevels";
            this.txtLevels.Size = new System.Drawing.Size(42, 20);
            this.txtLevels.TabIndex = 1;
            this.txtLevels.TextChanged += new System.EventHandler(this.txtLevels_TextChanged);
            // 
            // cmbMeshLevel
            // 
            this.cmbMeshLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeshLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMeshLevel.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbMeshLevel.Location = new System.Drawing.Point(92, 76);
            this.cmbMeshLevel.Name = "cmbMeshLevel";
            this.cmbMeshLevel.Size = new System.Drawing.Size(85, 21);
            this.cmbMeshLevel.TabIndex = 5;
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.SystemColors.Control;
            this.btnDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDefault.Location = new System.Drawing.Point(112, 150);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(90, 22);
            this.btnDefault.TabIndex = 9;
            this.btnDefault.Text = "Default";
            this.toolTip1.SetToolTip(this.btnDefault, "Default Settings");
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(92, 116);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(85, 20);
            this.txtSeed.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed:";
            this.toolTip1.SetToolTip(this.label1, "Unique identifier of the map");
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 400;
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Threads:";
            this.toolTip1.SetToolTip(this.label2, "Unique identifier of the map");
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(92, 43);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(42, 20);
            this.txtThreads.TabIndex = 3;
            this.txtThreads.TextChanged += new System.EventHandler(this.txtThreads_TextChanged);
            // 
            // frmPersonalization
            // 
            this.AcceptButton = this.btnSave;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(314, 184);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.cmbMeshLevel);
            this.Controls.Add(this.txtLevels);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCenterPoints);
            this.Controls.Add(this.lblLevels);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPersonalization";
            this.Text = "Personalization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonalization_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonalization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Label lblCenterPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLevels;
        private System.Windows.Forms.ComboBox cmbMeshLevel;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Label label2;
    }
}