namespace CuckForms
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
            this.btnGenerateJoke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJokeOutput = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerateJoke
            // 
            this.btnGenerateJoke.Location = new System.Drawing.Point(273, 51);
            this.btnGenerateJoke.Name = "btnGenerateJoke";
            this.btnGenerateJoke.Size = new System.Drawing.Size(153, 23);
            this.btnGenerateJoke.TabIndex = 0;
            this.btnGenerateJoke.Text = "Generate Awesomness!";
            this.btnGenerateJoke.UseVisualStyleBackColor = true;
            this.btnGenerateJoke.Click += new System.EventHandler(this.btnGenerateJoke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a Category";
            // 
            // lbJokeOutput
            // 
            this.lbJokeOutput.AutoSize = true;
            this.lbJokeOutput.Location = new System.Drawing.Point(13, 106);
            this.lbJokeOutput.Name = "lbJokeOutput";
            this.lbJokeOutput.Size = new System.Drawing.Size(141, 13);
            this.lbJokeOutput.TabIndex = 3;
            this.lbJokeOutput.Text = "Get ready to blow your mind!";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(16, 52);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(240, 21);
            this.cbCategories.TabIndex = 4;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lbJokeOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateJoke);
            this.Name = "Form1";
            this.Text = "Chuck Jokes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateJoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbJokeOutput;
        private System.Windows.Forms.ComboBox cbCategories;
    }
}

