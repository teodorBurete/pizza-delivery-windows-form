
namespace PizzaDeliveryProject2.Forms
{
    partial class ConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbStreetNo = new System.Windows.Forms.Label();
            this.lbAddressDetails = new System.Windows.Forms.Label();
            this.rbGroup = new System.Windows.Forms.GroupBox();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvConfirmation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.rbGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please confirm the following:";
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.Location = new System.Drawing.Point(3, 183);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(136, 29);
            this.btnChangeAddress.TabIndex = 2;
            this.btnChangeAddress.Text = "Change Address";
            this.btnChangeAddress.UseVisualStyleBackColor = true;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(6, 31);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(61, 21);
            this.rbCash.TabIndex = 3;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(8, 46);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(50, 17);
            this.lbStreet.TabIndex = 4;
            this.lbStreet.Text = "Street:";
            // 
            // lbStreetNo
            // 
            this.lbStreetNo.AutoSize = true;
            this.lbStreetNo.Location = new System.Drawing.Point(6, 71);
            this.lbStreetNo.Name = "lbStreetNo";
            this.lbStreetNo.Size = new System.Drawing.Size(76, 17);
            this.lbStreetNo.TabIndex = 5;
            this.lbStreetNo.Text = "Street No.:";
            // 
            // lbAddressDetails
            // 
            this.lbAddressDetails.AutoSize = true;
            this.lbAddressDetails.Location = new System.Drawing.Point(6, 102);
            this.lbAddressDetails.Name = "lbAddressDetails";
            this.lbAddressDetails.Size = new System.Drawing.Size(82, 34);
            this.lbAddressDetails.TabIndex = 7;
            this.lbAddressDetails.Text = "Additional \r\nInformation:";
            // 
            // rbGroup
            // 
            this.rbGroup.Controls.Add(this.rbCash);
            this.rbGroup.Controls.Add(this.rbCard);
            this.rbGroup.Location = new System.Drawing.Point(15, 295);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(196, 107);
            this.rbGroup.TabIndex = 8;
            this.rbGroup.TabStop = false;
            this.rbGroup.Text = "Payment Method:";
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(6, 58);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(175, 21);
            this.rbCard.TabIndex = 4;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card (POS, at delivery)";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStreetNo);
            this.groupBox2.Controls.Add(this.lbStreet);
            this.groupBox2.Controls.Add(this.lbAddressDetails);
            this.groupBox2.Controls.Add(this.btnChangeAddress);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 227);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address:";
            // 
            // lvConfirmation
            // 
            this.lvConfirmation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvConfirmation.HideSelection = false;
            this.lvConfirmation.Location = new System.Drawing.Point(294, 43);
            this.lvConfirmation.Name = "lvConfirmation";
            this.lvConfirmation.Size = new System.Drawing.Size(480, 359);
            this.lvConfirmation.TabIndex = 10;
            this.lvConfirmation.UseCompatibleStateImageBehavior = false;
            this.lvConfirmation.View = System.Windows.Forms.View.Details;
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(777, 295);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 52);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm Order!";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveAs,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(955, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(135, 24);
            this.btnSaveAs.Text = "Save Order as Text";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 24);
            this.btnPrint.Text = "Print Order";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(777, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 49);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(291, 405);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(79, 17);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Total price:";
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 477);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lvConfirmation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbGroup);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.rbGroup.ResumeLayout(false);
            this.rbGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeAddress;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbStreetNo;
        private System.Windows.Forms.Label lbAddressDetails;
        private System.Windows.Forms.GroupBox rbGroup;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvConfirmation;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}