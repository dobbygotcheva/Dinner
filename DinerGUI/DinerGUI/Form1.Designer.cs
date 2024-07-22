namespace DinerGUI
{
    partial class OrderGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlaceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditEntree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDrink = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lstBxEntree = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCoffee = new System.Windows.Forms.RadioButton();
            this.radTea = new System.Windows.Forms.RadioButton();
            this.radLemon = new System.Windows.Forms.RadioButton();
            this.radSoda = new System.Windows.Forms.RadioButton();
            this.radJuice = new System.Windows.Forms.RadioButton();
            this.radMilk = new System.Windows.Forms.RadioButton();
            this.cmboSpecial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckBxWater = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.editTool,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlaceOrder,
            this.menuClearOrder,
            this.menuDisplayOrder,
            this.menuExit});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(44, 24);
            this.fileToolStrip.Text = "File";
            // 
            // menuPlaceOrder
            // 
            this.menuPlaceOrder.Name = "menuPlaceOrder";
            this.menuPlaceOrder.Size = new System.Drawing.Size(175, 26);
            this.menuPlaceOrder.Text = "Place Order";
            // 
            // menuClearOrder
            // 
            this.menuClearOrder.Name = "menuClearOrder";
            this.menuClearOrder.Size = new System.Drawing.Size(175, 26);
            this.menuClearOrder.Text = "Clear Order";
            // 
            // menuDisplayOrder
            // 
            this.menuDisplayOrder.Name = "menuDisplayOrder";
            this.menuDisplayOrder.Size = new System.Drawing.Size(175, 26);
            this.menuDisplayOrder.Text = "Display Order";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(175, 26);
            this.menuExit.Text = "Exit";
            // 
            // editTool
            // 
            this.editTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditEntree,
            this.menuEditDrink,
            this.menuEditSpecial});
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(47, 24);
            this.editTool.Text = "Edit";
            // 
            // menuEditEntree
            // 
            this.menuEditEntree.Name = "menuEditEntree";
            this.menuEditEntree.Size = new System.Drawing.Size(195, 26);
            this.menuEditEntree.Text = "Entree";
            // 
            // menuEditDrink
            // 
            this.menuEditDrink.Name = "menuEditDrink";
            this.menuEditDrink.Size = new System.Drawing.Size(195, 26);
            this.menuEditDrink.Text = "Drink";
            // 
            // menuEditSpecial
            // 
            this.menuEditSpecial.Name = "menuEditSpecial";
            this.menuEditSpecial.Size = new System.Drawing.Size(195, 26);
            this.menuEditSpecial.Text = "Special Requests";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(125, 26);
            this.menuAbout.Text = "About";
            // 
            // lstBxEntree
            // 
            this.lstBxEntree.BackColor = System.Drawing.Color.Khaki;
            this.lstBxEntree.FormattingEnabled = true;
            this.lstBxEntree.ItemHeight = 18;
            this.lstBxEntree.Location = new System.Drawing.Point(16, 59);
            this.lstBxEntree.Name = "lstBxEntree";
            this.lstBxEntree.Size = new System.Drawing.Size(168, 76);
            this.lstBxEntree.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entree Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCoffee);
            this.groupBox2.Controls.Add(this.radTea);
            this.groupBox2.Controls.Add(this.radLemon);
            this.groupBox2.Controls.Add(this.radSoda);
            this.groupBox2.Controls.Add(this.radJuice);
            this.groupBox2.Controls.Add(this.radMilk);
            this.groupBox2.Location = new System.Drawing.Point(203, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drink Selection";
            // 
            // radCoffee
            // 
            this.radCoffee.AutoSize = true;
            this.radCoffee.Location = new System.Drawing.Point(7, 167);
            this.radCoffee.Name = "radCoffee";
            this.radCoffee.Size = new System.Drawing.Size(79, 23);
            this.radCoffee.TabIndex = 5;
            this.radCoffee.TabStop = true;
            this.radCoffee.Text = "Coffee";
            this.radCoffee.UseVisualStyleBackColor = true;
            // 
            // radTea
            // 
            this.radTea.AutoSize = true;
            this.radTea.Location = new System.Drawing.Point(6, 138);
            this.radTea.Name = "radTea";
            this.radTea.Size = new System.Drawing.Size(55, 23);
            this.radTea.TabIndex = 4;
            this.radTea.TabStop = true;
            this.radTea.Text = "Tea";
            this.radTea.UseVisualStyleBackColor = true;
            // 
            // radLemon
            // 
            this.radLemon.AutoSize = true;
            this.radLemon.Location = new System.Drawing.Point(6, 114);
            this.radLemon.Name = "radLemon";
            this.radLemon.Size = new System.Drawing.Size(79, 23);
            this.radLemon.TabIndex = 3;
            this.radLemon.TabStop = true;
            this.radLemon.Text = "Lemon";
            this.radLemon.UseVisualStyleBackColor = true;
            // 
            // radSoda
            // 
            this.radSoda.AutoSize = true;
            this.radSoda.Location = new System.Drawing.Point(6, 84);
            this.radSoda.Name = "radSoda";
            this.radSoda.Size = new System.Drawing.Size(68, 23);
            this.radSoda.TabIndex = 2;
            this.radSoda.TabStop = true;
            this.radSoda.Text = "Soda";
            this.radSoda.UseVisualStyleBackColor = true;
            // 
            // radJuice
            // 
            this.radJuice.AutoSize = true;
            this.radJuice.Location = new System.Drawing.Point(6, 55);
            this.radJuice.Name = "radJuice";
            this.radJuice.Size = new System.Drawing.Size(70, 23);
            this.radJuice.TabIndex = 1;
            this.radJuice.TabStop = true;
            this.radJuice.Text = "Juice";
            this.radJuice.UseVisualStyleBackColor = true;
            // 
            // radMilk
            // 
            this.radMilk.AutoSize = true;
            this.radMilk.Location = new System.Drawing.Point(6, 25);
            this.radMilk.Name = "radMilk";
            this.radMilk.Size = new System.Drawing.Size(58, 23);
            this.radMilk.TabIndex = 0;
            this.radMilk.TabStop = true;
            this.radMilk.Text = "Milk";
            this.radMilk.UseVisualStyleBackColor = true;
            // 
            // cmboSpecial
            // 
            this.cmboSpecial.BackColor = System.Drawing.Color.Khaki;
            this.cmboSpecial.FormattingEnabled = true;
            this.cmboSpecial.Items.AddRange(new object[] {
            "Whole Wheat",
            "Pumpernickel",
            "Seedless Rye",
            "Pita",
            "Sour Dough"});
            this.cmboSpecial.Location = new System.Drawing.Point(16, 170);
            this.cmboSpecial.Name = "cmboSpecial";
            this.cmboSpecial.Size = new System.Drawing.Size(168, 26);
            this.cmboSpecial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Special Requests";
            // 
            // ckBxWater
            // 
            this.ckBxWater.AutoSize = true;
            this.ckBxWater.Location = new System.Drawing.Point(16, 219);
            this.ckBxWater.Name = "ckBxWater";
            this.ckBxWater.Size = new System.Drawing.Size(75, 23);
            this.ckBxWater.TabIndex = 6;
            this.ckBxWater.Text = "Water";
            this.ckBxWater.UseVisualStyleBackColor = true;
            // 
            // OrderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(403, 324);
            this.Controls.Add(this.ckBxWater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboSpecial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxEntree);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderGUI";
            this.Text = "Student Union - Diner by the Valley";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuPlaceOrder;
        private System.Windows.Forms.ToolStripMenuItem menuClearOrder;
        private System.Windows.Forms.ToolStripMenuItem menuDisplayOrder;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem editTool;
        private System.Windows.Forms.ToolStripMenuItem menuEditEntree;
        private System.Windows.Forms.ToolStripMenuItem menuEditDrink;
        private System.Windows.Forms.ToolStripMenuItem menuEditSpecial;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ListBox lstBxEntree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radCoffee;
        private System.Windows.Forms.RadioButton radTea;
        private System.Windows.Forms.RadioButton radLemon;
        private System.Windows.Forms.RadioButton radSoda;
        private System.Windows.Forms.RadioButton radJuice;
        private System.Windows.Forms.RadioButton radMilk;
        private System.Windows.Forms.ComboBox cmboSpecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckBxWater;
    }
}

