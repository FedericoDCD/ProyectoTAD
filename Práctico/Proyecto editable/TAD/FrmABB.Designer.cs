namespace TAD
{
    partial class FrmABB
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BttnClose = new System.Windows.Forms.Button();
            this.PnlBar = new System.Windows.Forms.Panel();
            this.TxtItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.BttnList = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblEnOrden = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LblPreOrden = new System.Windows.Forms.Label();
            this.LblPosOrden = new System.Windows.Forms.Label();
            this.LblItems = new System.Windows.Forms.Label();
            this.LblMode = new System.Windows.Forms.Label();
            this.lblItemError = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.PnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.LblTitle.Location = new System.Drawing.Point(15, 17);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(26, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "ABB";
            // 
            // BttnClose
            // 
            this.BttnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Location = new System.Drawing.Point(935, 0);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(61, 47);
            this.BttnClose.TabIndex = 1;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = false;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // PnlBar
            // 
            this.PnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.PnlBar.Controls.Add(this.LblTitle);
            this.PnlBar.Controls.Add(this.BttnClose);
            this.PnlBar.Location = new System.Drawing.Point(0, 0);
            this.PnlBar.Name = "PnlBar";
            this.PnlBar.Size = new System.Drawing.Size(1029, 50);
            this.PnlBar.TabIndex = 1;
            // 
            // TxtItem
            // 
            this.TxtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtItem.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.TxtItem.HintText = "Dato";
            this.TxtItem.isPassword = false;
            this.TxtItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.TxtItem.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtItem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.TxtItem.LineThickness = 2;
            this.TxtItem.Location = new System.Drawing.Point(35, 222);
            this.TxtItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(157, 36);
            this.TxtItem.TabIndex = 9;
            this.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtItem.Enter += new System.EventHandler(this.TxtItem_Enter);
            this.TxtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItem_KeyDown);
            this.TxtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "AGREGAR ELEMENTO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttnList
            // 
            this.BttnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnList.FlatAppearance.BorderSize = 0;
            this.BttnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnList.Location = new System.Drawing.Point(35, 168);
            this.BttnList.Name = "BttnList";
            this.BttnList.Size = new System.Drawing.Size(157, 35);
            this.BttnList.TabIndex = 7;
            this.BttnList.Text = "CREAR ABB";
            this.BttnList.UseVisualStyleBackColor = false;
            this.BttnList.Click += new System.EventHandler(this.BttnList_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(329, 85);
            this.label1.MaximumSize = new System.Drawing.Size(500, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ENORDEN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(575, 84);
            this.label2.MaximumSize = new System.Drawing.Size(500, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "PREORDEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(824, 81);
            this.label3.MaximumSize = new System.Drawing.Size(500, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "POSORDEN:";
            // 
            // LblEnOrden
            // 
            this.LblEnOrden.AutoSize = true;
            this.LblEnOrden.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(211)))), ((int)(((byte)(217)))));
            this.LblEnOrden.Location = new System.Drawing.Point(254, 121);
            this.LblEnOrden.MaximumSize = new System.Drawing.Size(230, 300);
            this.LblEnOrden.Name = "LblEnOrden";
            this.LblEnOrden.Size = new System.Drawing.Size(0, 18);
            this.LblEnOrden.TabIndex = 14;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(238, 67);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 359);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // LblPreOrden
            // 
            this.LblPreOrden.AutoSize = true;
            this.LblPreOrden.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(211)))), ((int)(((byte)(217)))));
            this.LblPreOrden.Location = new System.Drawing.Point(503, 121);
            this.LblPreOrden.MaximumSize = new System.Drawing.Size(230, 300);
            this.LblPreOrden.Name = "LblPreOrden";
            this.LblPreOrden.Size = new System.Drawing.Size(0, 18);
            this.LblPreOrden.TabIndex = 16;
            // 
            // LblPosOrden
            // 
            this.LblPosOrden.AutoSize = true;
            this.LblPosOrden.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPosOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(211)))), ((int)(((byte)(217)))));
            this.LblPosOrden.Location = new System.Drawing.Point(755, 121);
            this.LblPosOrden.MaximumSize = new System.Drawing.Size(230, 300);
            this.LblPosOrden.Name = "LblPosOrden";
            this.LblPosOrden.Size = new System.Drawing.Size(0, 18);
            this.LblPosOrden.TabIndex = 17;
            // 
            // LblItems
            // 
            this.LblItems.AutoSize = true;
            this.LblItems.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblItems.Location = new System.Drawing.Point(17, 90);
            this.LblItems.Name = "LblItems";
            this.LblItems.Size = new System.Drawing.Size(145, 12);
            this.LblItems.TabIndex = 19;
            this.LblItems.Text = "CANTIDAD DE ITEMS: 0";
            this.LblItems.Visible = false;
            // 
            // LblMode
            // 
            this.LblMode.AutoSize = true;
            this.LblMode.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblMode.Location = new System.Drawing.Point(17, 67);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(124, 12);
            this.LblMode.TabIndex = 18;
            this.LblMode.Text = "ESTADO: SIN ÁRBOL";
            // 
            // lblItemError
            // 
            this.lblItemError.AutoSize = true;
            this.lblItemError.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lblItemError.Location = new System.Drawing.Point(33, 318);
            this.lblItemError.Name = "lblItemError";
            this.lblItemError.Size = new System.Drawing.Size(47, 12);
            this.lblItemError.TabIndex = 20;
            this.lblItemError.Text = "*ERROR";
            this.lblItemError.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(487, 67);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 359);
            this.bunifuSeparator2.TabIndex = 21;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(739, 67);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 359);
            this.bunifuSeparator3.TabIndex = 22;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // FrmABB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.lblItemError);
            this.Controls.Add(this.LblItems);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.LblPosOrden);
            this.Controls.Add(this.LblPreOrden);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.LblEnOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BttnList);
            this.Controls.Add(this.PnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmABB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "y";
            this.Load += new System.EventHandler(this.FrmABB_Load);
            this.PnlBar.ResumeLayout(false);
            this.PnlBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Panel PnlBar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BttnList;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblEnOrden;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label LblPreOrden;
        private System.Windows.Forms.Label LblPosOrden;
        private System.Windows.Forms.Label LblItems;
        private System.Windows.Forms.Label LblMode;
        private System.Windows.Forms.Label lblItemError;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
    }
}