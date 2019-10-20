namespace TAD
{
    partial class Index
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
            this.PnlBar = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BttnClose = new System.Windows.Forms.Button();
            this.BttnList = new System.Windows.Forms.Button();
            this.BttnTrees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBar
            // 
            this.PnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.PnlBar.Controls.Add(this.LblTitle);
            this.PnlBar.Controls.Add(this.BttnClose);
            this.PnlBar.Location = new System.Drawing.Point(-3, -1);
            this.PnlBar.Name = "PnlBar";
            this.PnlBar.Size = new System.Drawing.Size(456, 48);
            this.PnlBar.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.LblTitle.Location = new System.Drawing.Point(15, 17);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(83, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "TAD POROJECT";
            // 
            // BttnClose
            // 
            this.BttnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Location = new System.Drawing.Point(394, 0);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(61, 47);
            this.BttnClose.TabIndex = 1;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = false;
            this.BttnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttnList
            // 
            this.BttnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnList.FlatAppearance.BorderSize = 0;
            this.BttnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnList.Location = new System.Drawing.Point(141, 127);
            this.BttnList.Name = "BttnList";
            this.BttnList.Size = new System.Drawing.Size(157, 35);
            this.BttnList.TabIndex = 2;
            this.BttnList.Text = "LISTAS";
            this.BttnList.UseVisualStyleBackColor = false;
            this.BttnList.Click += new System.EventHandler(this.BttnList_Click);
            // 
            // BttnTrees
            // 
            this.BttnTrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnTrees.FlatAppearance.BorderSize = 0;
            this.BttnTrees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnTrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnTrees.Location = new System.Drawing.Point(141, 178);
            this.BttnTrees.Name = "BttnTrees";
            this.BttnTrees.Size = new System.Drawing.Size(157, 35);
            this.BttnTrees.TabIndex = 3;
            this.BttnTrees.Text = "ÁRBOLES";
            this.BttnTrees.UseVisualStyleBackColor = false;
            this.BttnTrees.Click += new System.EventHandler(this.BttnTrees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(80, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿CON QUE TAD DESEA TRABAJAR?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(451, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnTrees);
            this.Controls.Add(this.BttnList);
            this.Controls.Add(this.PnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Index_Load);
            this.PnlBar.ResumeLayout(false);
            this.PnlBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlBar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Button BttnList;
        private System.Windows.Forms.Button BttnTrees;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

