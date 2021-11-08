namespace ChuckFormRetry
{
    partial class ChuckForm
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
            this.btnGenerateJoke = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lbJokeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateJoke
            // 
            this.btnGenerateJoke.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateJoke.Name = "btnGenerateJoke";
            this.btnGenerateJoke.Size = new System.Drawing.Size(266, 35);
            this.btnGenerateJoke.TabIndex = 0;
            this.btnGenerateJoke.Text = "Generate Awesomness!";
            this.btnGenerateJoke.UseVisualStyleBackColor = true;
            this.btnGenerateJoke.Click += new System.EventHandler(this.btnGenerateJoke_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(12, 53);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(266, 23);
            this.cbCategories.TabIndex = 1;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // lbJokeOutput
            // 
            this.lbJokeOutput.AutoSize = true;
            this.lbJokeOutput.Location = new System.Drawing.Point(12, 98);
            this.lbJokeOutput.Name = "lbJokeOutput";
            this.lbJokeOutput.Size = new System.Drawing.Size(161, 15);
            this.lbJokeOutput.TabIndex = 2;
            this.lbJokeOutput.Text = "Get ready to blow your mind!";
            // 
            // ChuckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 368);
            this.Controls.Add(this.lbJokeOutput);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.btnGenerateJoke);
            this.Name = "ChuckForm";
            this.Text = "Chuck It!";
            this.Load += new System.EventHandler(this.ChuckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerateJoke;
        private ComboBox cbCategories;
        private Label lbJokeOutput;
    }
}