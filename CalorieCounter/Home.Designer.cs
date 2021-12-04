
namespace CalorieCounter
{
    partial class Home
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
            this.foodentry = new System.Windows.Forms.Button();
            this.runreport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodentry
            // 
            this.foodentry.Location = new System.Drawing.Point(236, 80);
            this.foodentry.Name = "foodentry";
            this.foodentry.Size = new System.Drawing.Size(75, 23);
            this.foodentry.TabIndex = 0;
            this.foodentry.Text = "Food Entry";
            this.foodentry.UseVisualStyleBackColor = true;
            this.foodentry.Click += new System.EventHandler(this.button1_Click);
            // 
            // runreport
            // 
            this.runreport.Location = new System.Drawing.Point(394, 80);
            this.runreport.Name = "runreport";
            this.runreport.Size = new System.Drawing.Size(75, 23);
            this.runreport.TabIndex = 1;
            this.runreport.Text = "Run Report";
            this.runreport.UseVisualStyleBackColor = true;
            this.runreport.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This weeks food report (i think we shoudl show a list of all the food for the wee" +
    "k)";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runreport);
            this.Controls.Add(this.foodentry);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button foodentry;
        private System.Windows.Forms.Button runreport;
        private System.Windows.Forms.Label label1;
    }
}

