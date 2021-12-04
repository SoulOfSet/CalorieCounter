
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
            this.components = new System.ComponentModel.Container();
            this.buttonMealEntry = new System.Windows.Forms.Button();
            this.buttonRunReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHomePageHeader = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMealEntry
            // 
            this.buttonMealEntry.Location = new System.Drawing.Point(283, 109);
            this.buttonMealEntry.Name = "buttonMealEntry";
            this.buttonMealEntry.Size = new System.Drawing.Size(186, 49);
            this.buttonMealEntry.TabIndex = 0;
            this.buttonMealEntry.Text = "New Meal";
            this.buttonMealEntry.UseVisualStyleBackColor = true;
            this.buttonMealEntry.Click += new System.EventHandler(this.buttonMealEntry_Click);
            // 
            // buttonRunReport
            // 
            this.buttonRunReport.Location = new System.Drawing.Point(292, 272);
            this.buttonRunReport.Name = "buttonRunReport";
            this.buttonRunReport.Size = new System.Drawing.Size(161, 43);
            this.buttonRunReport.TabIndex = 1;
            this.buttonRunReport.Text = "Run Report";
            this.buttonRunReport.UseVisualStyleBackColor = true;
            this.buttonRunReport.Click += new System.EventHandler(this.buttonRunReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This weeks food report (i think we shoudl show a list of all the food for the wee" +
    "k)";
            // 
            // labelHomePageHeader
            // 
            this.labelHomePageHeader.AutoSize = true;
            this.labelHomePageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomePageHeader.Location = new System.Drawing.Point(244, 28);
            this.labelHomePageHeader.Name = "labelHomePageHeader";
            this.labelHomePageHeader.Size = new System.Drawing.Size(259, 39);
            this.labelHomePageHeader.TabIndex = 3;
            this.labelHomePageHeader.Text = "Calorie Counter";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelHomePageHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRunReport);
            this.Controls.Add(this.buttonMealEntry);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMealEntry;
        private System.Windows.Forms.Button buttonRunReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHomePageHeader;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

