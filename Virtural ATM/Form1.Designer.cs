namespace Virtural_ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.balance = new System.Windows.Forms.Label();
            this.deposit_dollars = new System.Windows.Forms.TextBox();
            this.transaction_dollars = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transaction_complete = new System.Windows.Forms.Button();
            this.deposit_complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balance.Location = new System.Drawing.Point(70, 34);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(165, 32);
            this.balance.TabIndex = 1;
            this.balance.Text = "Balance: $0.00";
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // deposit_dollars
            // 
            this.deposit_dollars.Location = new System.Drawing.Point(123, 123);
            this.deposit_dollars.Name = "deposit_dollars";
            this.deposit_dollars.Size = new System.Drawing.Size(100, 23);
            this.deposit_dollars.TabIndex = 2;
            // 
            // transaction_dollars
            // 
            this.transaction_dollars.Location = new System.Drawing.Point(123, 171);
            this.transaction_dollars.Name = "transaction_dollars";
            this.transaction_dollars.Size = new System.Drawing.Size(100, 23);
            this.transaction_dollars.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deposit: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Transaction: ";
            // 
            // transaction_complete
            // 
            this.transaction_complete.Location = new System.Drawing.Point(96, 240);
            this.transaction_complete.Name = "transaction_complete";
            this.transaction_complete.Size = new System.Drawing.Size(153, 23);
            this.transaction_complete.TabIndex = 10;
            this.transaction_complete.Text = "Complete Transaction";
            this.transaction_complete.UseVisualStyleBackColor = true;
            this.transaction_complete.Click += new System.EventHandler(this.transaction_complete_Click);
            // 
            // deposit_complete
            // 
            this.deposit_complete.Location = new System.Drawing.Point(96, 211);
            this.deposit_complete.Name = "deposit_complete";
            this.deposit_complete.Size = new System.Drawing.Size(153, 23);
            this.deposit_complete.TabIndex = 11;
            this.deposit_complete.Text = "Complete Deposit";
            this.deposit_complete.UseVisualStyleBackColor = true;
            this.deposit_complete.Click += new System.EventHandler(this.deposit_complete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 289);
            this.Controls.Add(this.deposit_complete);
            this.Controls.Add(this.transaction_complete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transaction_dollars);
            this.Controls.Add(this.deposit_dollars);
            this.Controls.Add(this.balance);
            this.Name = "Form1";
            this.Text = "Cade\'s Basic ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label balance;
        private TextBox deposit_dollars;
        private TextBox transaction_dollars;
        private Label label3;
        private Label label4;
        private Button transaction_complete;
        private Button deposit_complete;
    }
}