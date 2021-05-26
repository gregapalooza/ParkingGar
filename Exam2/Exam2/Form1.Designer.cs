namespace Exam2
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
            this.tixList = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.lblAvail = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.tixView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tixList
            // 
            this.tixList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tixList.FormattingEnabled = true;
            this.tixList.ItemHeight = 18;
            this.tixList.Location = new System.Drawing.Point(20, 22);
            this.tixList.Name = "tixList";
            this.tixList.Size = new System.Drawing.Size(769, 274);
            this.tixList.TabIndex = 1;
            this.tixList.SelectedIndexChanged += new System.EventHandler(this.tixList_SelectedIndexChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(20, 553);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(131, 35);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(157, 553);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(131, 35);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Location = new System.Drawing.Point(309, 564);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(89, 13);
            this.lblAvail.TabIndex = 4;
            this.lblAvail.Text = "Spaces Available";
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Location = new System.Drawing.Point(405, 564);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(19, 13);
            this.lblRemain.TabIndex = 5;
            this.lblRemain.Text = "25";
            // 
            // tixView
            // 
            this.tixView.FormattingEnabled = true;
            this.tixView.Location = new System.Drawing.Point(20, 311);
            this.tixView.Name = "tixView";
            this.tixView.Size = new System.Drawing.Size(769, 186);
            this.tixView.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(808, 628);
            this.Controls.Add(this.tixView);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tixList);
            this.Name = "Form1";
            this.Text = "Park It App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox tixList;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.ListBox tixView;
    }
}

