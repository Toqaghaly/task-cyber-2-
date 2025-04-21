using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartCVFormValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
           
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string address = txtAddress.Text;
            string postalCode = txtPostalCode.Text;
            string cvText = txtCV.Text;

            
            bool isNameValid = Regex.IsMatch(name, @"^[\p{L}\s]+$", RegexOptions.IgnoreCase); 
            bool isEmailValid = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            bool isPhoneValid = Regex.IsMatch(phone, @"^\+?\d{10,15}$");
            bool isPasswordValid = Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"); 
            bool isAddressValid = Regex.IsMatch(address, @"^[\p{L}\d\s,.-]+$", RegexOptions.IgnoreCase); 
            bool isPostalCodeValid = Regex.IsMatch(postalCode, @"^\d{5}(-\d{4})?$"); 

            
            txtName.BackColor = isNameValid ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;
            txtEmail.BackColor = isEmailValid ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;
            txtPhone.BackColor = isPhoneValid ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;
            txtPassword.BackColor = isPasswordValid ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;
            txtAddress.BackColor = isAddressValid ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;
            txtPostalCode.BackColor = isPostalCodeValid ? System.Drawing.Color.White : System.Drawing.Color.LightCoral;

            
            string result = "Manual Form Entry Validation Results:\n";
            result += $"Name: {(isNameValid ? "Valid" : "Invalid")}\n";
            result += $"Email: {(isEmailValid ? "Valid" : "Invalid")}\n";
            result += $"Phone: {(isPhoneValid ? "Valid" : "Invalid")}\n";
            result += $"Password: {(isPasswordValid ? "Valid" : "Invalid")}\n";
            result += $"Address: {(isAddressValid ? "Valid" : "Invalid")}\n";
            result += $"Postal Code: {(isPostalCodeValid ? "Valid" : "Invalid")}\n";

           
            validationResults = new bool[]
            {
                isNameValid,
                isEmailValid,
                isPhoneValid,
                isPasswordValid,
                isAddressValid,
                isPostalCodeValid
            };

           
            if (!string.IsNullOrEmpty(cvText))
            {
                result += "\nCV Parsing Results:\n";
                string cvName = ExtractField(cvText, @"Name:\s*([^\n]+)", "Name not found");
                string cvEmail = ExtractField(cvText, @"Email:\s*([\w-\.]+@([\w-]+\.)+[\w-]{2,4})", "Email not found");
                string cvPhone = ExtractField(cvText, @"Phone:\s*(\+?\d{10,15})", "Phone not found");
                string cvSkills = ExtractField(cvText, @"Skills:\s*([^\n]+)", "Skills not found");
                string cvExperience = ExtractField(cvText, @"Experience:\s*(\d+)\s*years?", "Experience not found");

                result += $"Name: {cvName}\nEmail: {cvEmail}\nPhone: {cvPhone}\nSkills: {cvSkills}\nExperience: {cvExperience}\n";
            }

            txtResult.Text = result;
        }

        private bool[] validationResults; 

        private void btnExport_Click(object sender, EventArgs e)
        {
            string result = txtResult.Text;
            if (!string.IsNullOrEmpty(result))
            {
                
                string[] lines = result.Split(new[] { "\n" }, StringSplitOptions.None);

               
                string rtfHeader = @"{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red255\green0\blue0;}{\highlight0}";
                string rtfContent = rtfHeader + "\n";

                int manualEntryLineIndex = 0;
                foreach (string line in lines)
                {
                    if (line.Contains("CV Parsing Results:") || manualEntryLineIndex >= 6)
                    {
                        
                        rtfContent += $@"\highlight0 \cf1 {line}\par" + "\n";
                    }
                    else if (line.Contains("Manual Form Entry Validation Results:"))
                    {
                        
                        rtfContent += $@"\highlight0 \cf1 {line}\par" + "\n";
                    }
                    else if (manualEntryLineIndex < 6)
                    {
                       
                        bool isValid = validationResults[manualEntryLineIndex];
                        string highlightCode = isValid ? @"\highlight0" : @"\highlight2"; 
                        rtfContent += $@"{highlightCode} \cf1 {line}\par" + "\n";
                        manualEntryLineIndex++;
                    }
                }

                rtfContent += "}"; 
                File.WriteAllText("ValidatedData.rtf", rtfContent);
                MessageBox.Show("Data exported to ValidatedData.rtf successfully! Open it in a word processor to see the highlighting.");
            }
            else
            {
                MessageBox.Show("No data to export!");
            }
        }

        private string ExtractField(string text, string pattern, string defaultMessage)
        {
            Match match = Regex.Match(text, pattern);
            return match.Success ? match.Groups[1].Value : defaultMessage;
        }

       
    }
}