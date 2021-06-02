
namespace LoginForm
{
    partial class MenuForm
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
            this.ShowPersonalCard = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(296, 68);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(152, 43);
            this.ScheduleButton.TabIndex = 0;
            this.ScheduleButton.Text = "ShowSchedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // ShowPersonalCard
            // 
            this.ShowPersonalCard.Location = new System.Drawing.Point(295, 173);
            this.ShowPersonalCard.Name = "ShowPersonalCard";
            this.ShowPersonalCard.Size = new System.Drawing.Size(152, 45);
            this.ShowPersonalCard.TabIndex = 1;
            this.ShowPersonalCard.Text = "Show Personal Card";
            this.ShowPersonalCard.UseVisualStyleBackColor = true;
            this.ShowPersonalCard.Click += new System.EventHandler(this.ShoePersonalCard_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(294, 269);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(153, 47);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete account";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ShowPersonalCard);
            this.Controls.Add(this.ScheduleButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button ShowPersonalCard;
        private System.Windows.Forms.Button DeleteButton;
    }
}