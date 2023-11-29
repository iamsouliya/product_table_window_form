namespace productTable
{
    partial class Form1
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(106, 93);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(110, 22);
            this.txtProduct.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(240, 93);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(110, 22);
            this.txtQty.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(373, 93);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.Color.White;
            this.totalPrice.Location = new System.Drawing.Point(533, 54);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(178, 61);
            this.totalPrice.TabIndex = 7;
            this.totalPrice.Text = "0";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(106, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 45);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 263);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(931, 310);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product\'s name";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total price";
            this.columnHeader4.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 585);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

