namespace Summative_Adventure_Game
{
    partial class adventureSummative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adventureSummative));
            this.startButton = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.Label();
            this.descriptorLabel = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.LightGray;
            this.startButton.Location = new System.Drawing.Point(467, 372);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 60);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.BackColor = System.Drawing.Color.Transparent;
            this.titleLable.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.Black;
            this.titleLable.Location = new System.Drawing.Point(235, 53);
            this.titleLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(649, 80);
            this.titleLable.TabIndex = 1;
            this.titleLable.Text = "THE ESCAPE GAME";
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.Transparent;
            this.textOutput.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.ForeColor = System.Drawing.Color.LightGray;
            this.textOutput.Location = new System.Drawing.Point(416, 242);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(187, 59);
            this.textOutput.TabIndex = 2;
            // 
            // descriptorLabel
            // 
            this.descriptorLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptorLabel.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptorLabel.ForeColor = System.Drawing.Color.White;
            this.descriptorLabel.Location = new System.Drawing.Point(16, 74);
            this.descriptorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptorLabel.Name = "descriptorLabel";
            this.descriptorLabel.Size = new System.Drawing.Size(197, 609);
            this.descriptorLabel.TabIndex = 3;
            this.descriptorLabel.Text = resources.GetString("descriptorLabel.Text");
            this.descriptorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.descriptorLabel.Visible = false;
           
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.White;
            this.option1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.Black;
            this.option1.Location = new System.Drawing.Point(279, 602);
            this.option1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(197, 49);
            this.option1.TabIndex = 4;
            this.option1.Text = "Observe your surroundings";
            this.option1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.option1.Visible = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.White;
            this.option2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.Black;
            this.option2.Location = new System.Drawing.Point(484, 602);
            this.option2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(197, 49);
            this.option2.TabIndex = 5;
            this.option2.Text = "Call out for help";
            this.option2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.option2.Visible = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.White;
            this.option3.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.ForeColor = System.Drawing.Color.Black;
            this.option3.Location = new System.Drawing.Point(689, 602);
            this.option3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(197, 49);
            this.option3.TabIndex = 6;
            this.option3.Text = "Attempt to open the cell";
            this.option3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.option3.Visible = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.White;
            this.menuLabel.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.Location = new System.Drawing.Point(484, 537);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(197, 49);
            this.menuLabel.TabIndex = 7;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuLabel.Visible = false;
            this.menuLabel.Click += new System.EventHandler(this.menuLabel_Click);
            // 
            // adventureSummative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summative_Adventure_Game.Properties.Resources.Space_Station;
            this.ClientSize = new System.Drawing.Size(996, 694);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.descriptorLabel);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adventureSummative";
            this.Text = "Adventure Word Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startButton;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Label descriptorLabel;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.Label menuLabel;
    }
}

