namespace SmartCVFormValidator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblCV = new System.Windows.Forms.Label();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();

           

            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.Text = "Full Name:";

           

            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;

            

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.Text = "Email:";

           

            this.txtEmail.Location = new System.Drawing.Point(120, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 1;

            

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.Text = "Phone:";

            

            this.txtPhone.Location = new System.Drawing.Point(120, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 2;

            

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.Text = "Password:";

            

            this.txtPassword.Location = new System.Drawing.Point(120, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 3;

            

            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 140);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.Text = "Address:";

            

            this.txtAddress.Location = new System.Drawing.Point(120, 140);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 4;

           

            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(20, 170);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(63, 13);
            this.lblPostalCode.Text = "Postal Code:";

          

            this.txtPostalCode.Location = new System.Drawing.Point(120, 170);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(200, 20);
            this.txtPostalCode.TabIndex = 5;

         

            this.lblCV.AutoSize = true;
            this.lblCV.Location = new System.Drawing.Point(20, 200);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(65, 13);
            this.lblCV.Text = "Paste CV Text:";

          

            this.txtCV.Location = new System.Drawing.Point(120, 200);
            this.txtCV.Multiline = true;
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(400, 100);
            this.txtCV.TabIndex = 6;

            

            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 310);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 13);
            this.lblResult.Text = "Results:";

            

            this.txtResult.Location = new System.Drawing.Point(120, 310);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(400, 100);
            this.txtResult.TabIndex = 7;

         

            this.btnValidate.Location = new System.Drawing.Point(120, 430);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(100, 23);
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            

            this.btnExport.Location = new System.Drawing.Point(230, 430);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.Text = "Export to .rtf"; // Updated to reflect RTF export
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

        

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.lblCV);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Smart CV & Form Validator";
        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnExport;
    }
}