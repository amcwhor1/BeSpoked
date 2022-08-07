
namespace BeSpoked_Bikes_1
{
    partial class HomePage
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
            this.SalesPersonnelButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SalesTrackerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalesPersonnelButton
            // 
            this.SalesPersonnelButton.Location = new System.Drawing.Point(203, 134);
            this.SalesPersonnelButton.Name = "SalesPersonnelButton";
            this.SalesPersonnelButton.Size = new System.Drawing.Size(175, 82);
            this.SalesPersonnelButton.TabIndex = 0;
            this.SalesPersonnelButton.Text = "Sales Personnel";
            this.SalesPersonnelButton.UseVisualStyleBackColor = true;
            this.SalesPersonnelButton.Click += new System.EventHandler(this.SalesPersonnelButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(384, 134);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(175, 82);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(203, 222);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(175, 82);
            this.CustomersButton.TabIndex = 2;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(384, 222);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(175, 82);
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SalesTrackerLabel
            // 
            this.SalesTrackerLabel.AutoSize = true;
            this.SalesTrackerLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.SalesTrackerLabel.Location = new System.Drawing.Point(270, 49);
            this.SalesTrackerLabel.Name = "SalesTrackerLabel";
            this.SalesTrackerLabel.Size = new System.Drawing.Size(239, 32);
            this.SalesTrackerLabel.TabIndex = 4;
            this.SalesTrackerLabel.Text = "BeSpoked Tracker";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesTrackerLabel);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.SalesPersonnelButton);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SalesPersonnelButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Label SalesTrackerLabel;
    }
}