namespace TAD
{
    partial class FrmList
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
            this.BttnList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CmbItem = new Bunifu.Framework.UI.BunifuDropdown();
            this.button2 = new System.Windows.Forms.Button();
            this.LblList = new System.Windows.Forms.Label();
            this.LblMode = new System.Windows.Forms.Label();
            this.LblErrorAdd = new System.Windows.Forms.Label();
            this.LblErrorCreateList = new System.Windows.Forms.Label();
            this.LblErrorDelete = new System.Windows.Forms.Label();
            this.LblItems = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.LblTitle.Size = new System.Drawing.Size(41, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "LISTAS";
            // 
            // BttnClose
            // 
            this.BttnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Location = new System.Drawing.Point(500, 0);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(61, 47);
            this.BttnClose.TabIndex = 1;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = false;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click_1);
            // 
            // PnlBar
            // 
            this.PnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.PnlBar.Controls.Add(this.LblTitle);
            this.PnlBar.Controls.Add(this.BttnClose);
            this.PnlBar.Location = new System.Drawing.Point(0, 0);
            this.PnlBar.Name = "PnlBar";
            this.PnlBar.Size = new System.Drawing.Size(561, 48);
            this.PnlBar.TabIndex = 1;
            // 
            // BttnList
            // 
            this.BttnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.BttnList.FlatAppearance.BorderSize = 0;
            this.BttnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnList.Location = new System.Drawing.Point(28, 196);
            this.BttnList.Name = "BttnList";
            this.BttnList.Size = new System.Drawing.Size(157, 35);
            this.BttnList.TabIndex = 3;
            this.BttnList.Text = "CREAR LISTA";
            this.BttnList.UseVisualStyleBackColor = false;
            this.BttnList.Click += new System.EventHandler(this.BttnList_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "AGREGAR ELEMENTO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtItem
            // 
            this.TxtItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItem.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtItem.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.TxtItem.HintText = "Dato";
            this.TxtItem.isPassword = false;
            this.TxtItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.TxtItem.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtItem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.TxtItem.LineThickness = 2;
            this.TxtItem.Location = new System.Drawing.Point(201, 144);
            this.TxtItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(157, 36);
            this.TxtItem.TabIndex = 6;
            this.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtItem.OnValueChanged += new System.EventHandler(this.TxtItem_OnValueChanged);
            this.TxtItem.Enter += new System.EventHandler(this.TxtItem_Enter);
            this.TxtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItem_KeyDown);
            // 
            // CmbItem
            // 
            this.CmbItem.BackColor = System.Drawing.Color.Transparent;
            this.CmbItem.BorderRadius = 3;
            this.CmbItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbItem.ForeColor = System.Drawing.Color.White;
            this.CmbItem.Items = new string[0];
            this.CmbItem.Location = new System.Drawing.Point(371, 154);
            this.CmbItem.Name = "CmbItem";
            this.CmbItem.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.CmbItem.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.CmbItem.selectedIndex = -1;
            this.CmbItem.Size = new System.Drawing.Size(157, 26);
            this.CmbItem.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(371, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "ELIMINAR ELEMENTO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblList
            // 
            this.LblList.AutoSize = true;
            this.LblList.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.LblList.Location = new System.Drawing.Point(25, 285);
            this.LblList.MaximumSize = new System.Drawing.Size(500, 160);
            this.LblList.Name = "LblList";
            this.LblList.Size = new System.Drawing.Size(0, 18);
            this.LblList.TabIndex = 9;
            // 
            // LblMode
            // 
            this.LblMode.AutoSize = true;
            this.LblMode.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblMode.Location = new System.Drawing.Point(16, 66);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(124, 12);
            this.LblMode.TabIndex = 10;
            this.LblMode.Text = "ESTADO: SIN LISTA";
            // 
            // LblErrorAdd
            // 
            this.LblErrorAdd.AutoSize = true;
            this.LblErrorAdd.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblErrorAdd.Location = new System.Drawing.Point(199, 247);
            this.LblErrorAdd.Name = "LblErrorAdd";
            this.LblErrorAdd.Size = new System.Drawing.Size(47, 12);
            this.LblErrorAdd.TabIndex = 11;
            this.LblErrorAdd.Text = "*ERROR";
            this.LblErrorAdd.Visible = false;
            // 
            // LblErrorCreateList
            // 
            this.LblErrorCreateList.AutoSize = true;
            this.LblErrorCreateList.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCreateList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblErrorCreateList.Location = new System.Drawing.Point(26, 247);
            this.LblErrorCreateList.Name = "LblErrorCreateList";
            this.LblErrorCreateList.Size = new System.Drawing.Size(47, 12);
            this.LblErrorCreateList.TabIndex = 12;
            this.LblErrorCreateList.Text = "*ERROR";
            this.LblErrorCreateList.Visible = false;
            // 
            // LblErrorDelete
            // 
            this.LblErrorDelete.AutoSize = true;
            this.LblErrorDelete.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblErrorDelete.Location = new System.Drawing.Point(369, 247);
            this.LblErrorDelete.Name = "LblErrorDelete";
            this.LblErrorDelete.Size = new System.Drawing.Size(47, 12);
            this.LblErrorDelete.TabIndex = 13;
            this.LblErrorDelete.Text = "*ERROR";
            this.LblErrorDelete.Visible = false;
            // 
            // LblItems
            // 
            this.LblItems.AutoSize = true;
            this.LblItems.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.LblItems.Location = new System.Drawing.Point(16, 89);
            this.LblItems.Name = "LblItems";
            this.LblItems.Size = new System.Drawing.Size(145, 12);
            this.LblItems.TabIndex = 14;
            this.LblItems.Text = "CANTIDAD DE ITEMS: 0";
            this.LblItems.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.LblItems);
            this.Controls.Add(this.LblErrorDelete);
            this.Controls.Add(this.LblErrorCreateList);
            this.Controls.Add(this.LblErrorAdd);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.LblList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CmbItem);
            this.Controls.Add(this.TxtItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BttnList);
            this.Controls.Add(this.PnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmList";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.PnlBar.ResumeLayout(false);
            this.PnlBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Panel PnlBar;
        private System.Windows.Forms.Button BttnList;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtItem;
        private Bunifu.Framework.UI.BunifuDropdown CmbItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblList;
        private System.Windows.Forms.Label LblMode;
        private System.Windows.Forms.Label LblErrorAdd;
        private System.Windows.Forms.Label LblErrorCreateList;
        private System.Windows.Forms.Label LblErrorDelete;
        private System.Windows.Forms.Label LblItems;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}