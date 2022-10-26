namespace IcarusDroneRepairManagement
{
    partial class frmMain
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
            this.nudServiceTag = new System.Windows.Forms.NumericUpDown();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.tbxDroneModel = new System.Windows.Forms.TextBox();
            this.tbxServiceProblem = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExpress = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvExpress = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDroneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmServiceTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRegular = new System.Windows.Forms.ListView();
            this.clmClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDroneProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmServiceCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTagService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbFinished = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateExpress = new System.Windows.Forms.Button();
            this.btnUpdateRegular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceTag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudServiceTag
            // 
            this.nudServiceTag.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudServiceTag.Location = new System.Drawing.Point(11, 262);
            this.nudServiceTag.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nudServiceTag.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudServiceTag.Name = "nudServiceTag";
            this.nudServiceTag.ReadOnly = true;
            this.nudServiceTag.Size = new System.Drawing.Size(144, 20);
            this.nudServiceTag.TabIndex = 0;
            this.nudServiceTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tbxClientName
            // 
            this.tbxClientName.Location = new System.Drawing.Point(11, 25);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(144, 20);
            this.tbxClientName.TabIndex = 1;
            // 
            // tbxDroneModel
            // 
            this.tbxDroneModel.Location = new System.Drawing.Point(11, 64);
            this.tbxDroneModel.Name = "tbxDroneModel";
            this.tbxDroneModel.Size = new System.Drawing.Size(144, 20);
            this.tbxDroneModel.TabIndex = 2;
            // 
            // tbxServiceProblem
            // 
            this.tbxServiceProblem.Location = new System.Drawing.Point(11, 103);
            this.tbxServiceProblem.Multiline = true;
            this.tbxServiceProblem.Name = "tbxServiceProblem";
            this.tbxServiceProblem.Size = new System.Drawing.Size(144, 101);
            this.tbxServiceProblem.TabIndex = 3;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(11, 223);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(144, 20);
            this.tbxCost.TabIndex = 4;
            this.tbxCost.TextChanged += new System.EventHandler(this.tbxCost_TextChanged);
            this.tbxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCost_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExpress);
            this.groupBox1.Controls.Add(this.rbRegular);
            this.groupBox1.Location = new System.Drawing.Point(11, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Priority";
            // 
            // rbExpress
            // 
            this.rbExpress.AutoSize = true;
            this.rbExpress.Location = new System.Drawing.Point(6, 42);
            this.rbExpress.Name = "rbExpress";
            this.rbExpress.Size = new System.Drawing.Size(62, 17);
            this.rbExpress.TabIndex = 1;
            this.rbExpress.TabStop = true;
            this.rbExpress.Text = "Express";
            this.rbExpress.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(6, 19);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 0;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(11, 362);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(144, 44);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Drone";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Drone Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Service Problem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Service Tag";
            // 
            // lvExpress
            // 
            this.lvExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmDroneModel,
            this.clmProblem,
            this.clmCost,
            this.clmServiceTag});
            this.lvExpress.HideSelection = false;
            this.lvExpress.Location = new System.Drawing.Point(161, 253);
            this.lvExpress.Name = "lvExpress";
            this.lvExpress.Size = new System.Drawing.Size(501, 179);
            this.lvExpress.TabIndex = 12;
            this.lvExpress.UseCompatibleStateImageBehavior = false;
            this.lvExpress.View = System.Windows.Forms.View.Details;
            this.lvExpress.SelectedIndexChanged += new System.EventHandler(this.lvExpress_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Client Name";
            this.clmName.Width = 110;
            // 
            // clmDroneModel
            // 
            this.clmDroneModel.Text = "Drone Model";
            this.clmDroneModel.Width = 110;
            // 
            // clmProblem
            // 
            this.clmProblem.Text = "Service Problem";
            this.clmProblem.Width = 117;
            // 
            // clmCost
            // 
            this.clmCost.Text = "Service Cost";
            this.clmCost.Width = 85;
            // 
            // clmServiceTag
            // 
            this.clmServiceTag.Text = "Service Tag";
            this.clmServiceTag.Width = 75;
            // 
            // lvRegular
            // 
            this.lvRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmClientName,
            this.clmModel,
            this.clmDroneProblem,
            this.clmServiceCost,
            this.clmTagService});
            this.lvRegular.HideSelection = false;
            this.lvRegular.Location = new System.Drawing.Point(161, 25);
            this.lvRegular.Name = "lvRegular";
            this.lvRegular.Size = new System.Drawing.Size(501, 179);
            this.lvRegular.TabIndex = 13;
            this.lvRegular.UseCompatibleStateImageBehavior = false;
            this.lvRegular.View = System.Windows.Forms.View.Details;
            this.lvRegular.SelectedIndexChanged += new System.EventHandler(this.lvRegular_SelectedIndexChanged);
            // 
            // clmClientName
            // 
            this.clmClientName.Text = "Client Name";
            this.clmClientName.Width = 110;
            // 
            // clmModel
            // 
            this.clmModel.Text = "Drone Model";
            this.clmModel.Width = 110;
            // 
            // clmDroneProblem
            // 
            this.clmDroneProblem.Text = "Service Problem";
            this.clmDroneProblem.Width = 117;
            // 
            // clmServiceCost
            // 
            this.clmServiceCost.Text = "Service Cost";
            this.clmServiceCost.Width = 85;
            // 
            // clmTagService
            // 
            this.clmTagService.Text = "Service Tag";
            this.clmTagService.Width = 75;
            // 
            // lbFinished
            // 
            this.lbFinished.FormattingEnabled = true;
            this.lbFinished.Location = new System.Drawing.Point(668, 25);
            this.lbFinished.Name = "lbFinished";
            this.lbFinished.Size = new System.Drawing.Size(210, 407);
            this.lbFinished.TabIndex = 14;
            this.lbFinished.DoubleClick += new System.EventHandler(this.lbFinished_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Express Queue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Regular Queue";
            // 
            // btnUpdateExpress
            // 
            this.btnUpdateExpress.Location = new System.Drawing.Point(161, 438);
            this.btnUpdateExpress.Name = "btnUpdateExpress";
            this.btnUpdateExpress.Size = new System.Drawing.Size(101, 22);
            this.btnUpdateExpress.TabIndex = 17;
            this.btnUpdateExpress.Text = "Update Express";
            this.btnUpdateExpress.UseVisualStyleBackColor = true;
            this.btnUpdateExpress.Click += new System.EventHandler(this.btnUpdateExpress_Click);
            // 
            // btnUpdateRegular
            // 
            this.btnUpdateRegular.Location = new System.Drawing.Point(161, 210);
            this.btnUpdateRegular.Name = "btnUpdateRegular";
            this.btnUpdateRegular.Size = new System.Drawing.Size(101, 22);
            this.btnUpdateRegular.TabIndex = 18;
            this.btnUpdateRegular.Text = "Update Regular";
            this.btnUpdateRegular.UseVisualStyleBackColor = true;
            this.btnUpdateRegular.Click += new System.EventHandler(this.btnUpdateRegular_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 473);
            this.Controls.Add(this.btnUpdateRegular);
            this.Controls.Add(this.btnUpdateExpress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFinished);
            this.Controls.Add(this.lvRegular);
            this.Controls.Add(this.lvExpress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxServiceProblem);
            this.Controls.Add(this.tbxDroneModel);
            this.Controls.Add(this.tbxClientName);
            this.Controls.Add(this.nudServiceTag);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceTag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudServiceTag;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.TextBox tbxDroneModel;
        private System.Windows.Forms.TextBox tbxServiceProblem;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbExpress;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvExpress;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmDroneModel;
        private System.Windows.Forms.ColumnHeader clmProblem;
        private System.Windows.Forms.ColumnHeader clmCost;
        private System.Windows.Forms.ColumnHeader clmServiceTag;
        private System.Windows.Forms.ListView lvRegular;
        private System.Windows.Forms.ListBox lbFinished;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader clmClientName;
        private System.Windows.Forms.ColumnHeader clmModel;
        private System.Windows.Forms.ColumnHeader clmDroneProblem;
        private System.Windows.Forms.ColumnHeader clmServiceCost;
        private System.Windows.Forms.ColumnHeader clmTagService;
        private System.Windows.Forms.Button btnUpdateExpress;
        private System.Windows.Forms.Button btnUpdateRegular;
    }
}

