namespace GeneticAlgorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.goalText = new System.Windows.Forms.Label();
            this.allGenesText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.generationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goal:";
            // 
            // goalText
            // 
            this.goalText.AutoSize = true;
            this.goalText.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalText.Location = new System.Drawing.Point(107, 31);
            this.goalText.Name = "goalText";
            this.goalText.Size = new System.Drawing.Size(129, 36);
            this.goalText.TabIndex = 1;
            this.goalText.Text = "[GOAL]";
            // 
            // allGenesText
            // 
            this.allGenesText.AutoSize = true;
            this.allGenesText.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allGenesText.Location = new System.Drawing.Point(14, 155);
            this.allGenesText.Name = "allGenesText";
            this.allGenesText.Size = new System.Drawing.Size(224, 36);
            this.allGenesText.TabIndex = 2;
            this.allGenesText.Text = "[All Genes]";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(20, 83);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(871, 56);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // generationText
            // 
            this.generationText.AutoSize = true;
            this.generationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generationText.Location = new System.Drawing.Point(13, 563);
            this.generationText.Name = "generationText";
            this.generationText.Size = new System.Drawing.Size(36, 37);
            this.generationText.TabIndex = 4;
            this.generationText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 609);
            this.Controls.Add(this.generationText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.allGenesText);
            this.Controls.Add(this.goalText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Genetic Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goalText;
        private System.Windows.Forms.Label allGenesText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label generationText;
    }
}

