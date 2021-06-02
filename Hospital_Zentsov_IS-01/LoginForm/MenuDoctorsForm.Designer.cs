
namespace LoginForm
{
    partial class MenuDoctorsForm
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
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.DiagnosisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(298, 59);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(147, 46);
            this.ScheduleButton.TabIndex = 0;
            this.ScheduleButton.Text = "Show Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // DiagnosisButton
            // 
            this.DiagnosisButton.Location = new System.Drawing.Point(298, 157);
            this.DiagnosisButton.Name = "DiagnosisButton";
            this.DiagnosisButton.Size = new System.Drawing.Size(147, 43);
            this.DiagnosisButton.TabIndex = 1;
            this.DiagnosisButton.Text = "Write a diagnosis";
            this.DiagnosisButton.UseVisualStyleBackColor = true;
            this.DiagnosisButton.Click += new System.EventHandler(this.DiagnosisButton_Click);
            // 
            // MenuDoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiagnosisButton);
            this.Controls.Add(this.ScheduleButton);
            this.Name = "MenuDoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDoctorsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button DiagnosisButton;
    }
}