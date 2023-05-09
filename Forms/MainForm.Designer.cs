
namespace PizzaDeliveryProject2
{
    partial class MainForm
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
            this.gbPizzaSelection = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIngredients = new System.Windows.Forms.Label();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.lvPizza = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPizza = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnGoToOrderConfirmation = new System.Windows.Forms.Button();
            this.gbPizzaSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.cmsPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPizzaSelection
            // 
            this.gbPizzaSelection.Controls.Add(this.label4);
            this.gbPizzaSelection.Controls.Add(this.label3);
            this.gbPizzaSelection.Controls.Add(this.lbIngredients);
            this.gbPizzaSelection.Controls.Add(this.btnAddPizza);
            this.gbPizzaSelection.Controls.Add(this.numQty);
            this.gbPizzaSelection.Controls.Add(this.cbPizza);
            this.gbPizzaSelection.Location = new System.Drawing.Point(0, 12);
            this.gbPizzaSelection.Name = "gbPizzaSelection";
            this.gbPizzaSelection.Size = new System.Drawing.Size(200, 414);
            this.gbPizzaSelection.TabIndex = 0;
            this.gbPizzaSelection.TabStop = false;
            this.gbPizzaSelection.Text = "Pizza Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select your pizza!";
            // 
            // lbIngredients
            // 
            this.lbIngredients.AutoSize = true;
            this.lbIngredients.Location = new System.Drawing.Point(3, 80);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(0, 17);
            this.lbIngredients.TabIndex = 3;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Location = new System.Drawing.Point(9, 337);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(120, 23);
            this.btnAddPizza.TabIndex = 2;
            this.btnAddPizza.Text = "Add To Order";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // numQty
            // 
            this.numQty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numQty.Location = new System.Drawing.Point(9, 309);
            this.numQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 22);
            this.numQty.TabIndex = 1;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Location = new System.Drawing.Point(9, 53);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(121, 24);
            this.cbPizza.TabIndex = 0;
            this.cbPizza.SelectedIndexChanged += new System.EventHandler(this.cbPizza_SelectedIndexChanged);
            // 
            // lvPizza
            // 
            this.lvPizza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPizza.ContextMenuStrip = this.cmsPizza;
            this.lvPizza.FullRowSelect = true;
            this.lvPizza.HideSelection = false;
            this.lvPizza.Location = new System.Drawing.Point(224, 37);
            this.lvPizza.Name = "lvPizza";
            this.lvPizza.Size = new System.Drawing.Size(551, 330);
            this.lvPizza.TabIndex = 55;
            this.lvPizza.UseCompatibleStateImageBehavior = false;
            this.lvPizza.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pizza";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty.";
            this.columnHeader2.Width = 42;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 78;
            // 
            // cmsPizza
            // 
            this.cmsPizza.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPizza.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsPizza.Name = "contextMenuStrip1";
            this.cmsPizza.Size = new System.Drawing.Size(213, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.deleteToolStripMenuItem.Text = "Remove From Order";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Order:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(221, 373);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total:";
            // 
            // btnGoToOrderConfirmation
            // 
            this.btnGoToOrderConfirmation.Location = new System.Drawing.Point(615, 373);
            this.btnGoToOrderConfirmation.Name = "btnGoToOrderConfirmation";
            this.btnGoToOrderConfirmation.Size = new System.Drawing.Size(160, 53);
            this.btnGoToOrderConfirmation.TabIndex = 56;
            this.btnGoToOrderConfirmation.Text = "Go to Order Confirmation!";
            this.btnGoToOrderConfirmation.UseVisualStyleBackColor = true;
            this.btnGoToOrderConfirmation.Click += new System.EventHandler(this.btnGoToOrderConfirmation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 486);
            this.Controls.Add(this.btnGoToOrderConfirmation);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPizza);
            this.Controls.Add(this.gbPizzaSelection);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbPizzaSelection.ResumeLayout(false);
            this.gbPizzaSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.cmsPizza.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPizzaSelection;
        private System.Windows.Forms.Label lbIngredients;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.ListView lvPizza;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGoToOrderConfirmation;
        private System.Windows.Forms.ContextMenuStrip cmsPizza;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

