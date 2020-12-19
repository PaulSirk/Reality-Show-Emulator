
namespace Reality_Game_Show_Emulator
{
    partial class frmEmulatorScreen
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
            this.lblContestants = new System.Windows.Forms.Label();
            this.lblPlacement = new System.Windows.Forms.Label();
            this.lsbxContestants = new System.Windows.Forms.ListBox();
            this.lsbxProgress = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContestants
            // 
            this.lblContestants.AutoSize = true;
            this.lblContestants.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContestants.Location = new System.Drawing.Point(51, 24);
            this.lblContestants.Name = "lblContestants";
            this.lblContestants.Size = new System.Drawing.Size(123, 21);
            this.lblContestants.TabIndex = 0;
            this.lblContestants.Text = "Contestants";
            // 
            // lblPlacement
            // 
            this.lblPlacement.AutoSize = true;
            this.lblPlacement.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacement.Location = new System.Drawing.Point(256, 24);
            this.lblPlacement.Name = "lblPlacement";
            this.lblPlacement.Size = new System.Drawing.Size(107, 21);
            this.lblPlacement.TabIndex = 1;
            this.lblPlacement.Text = "Placement";
            // 
            // lsbxContestants
            // 
            this.lsbxContestants.FormattingEnabled = true;
            this.lsbxContestants.Location = new System.Drawing.Point(39, 65);
            this.lsbxContestants.Name = "lsbxContestants";
            this.lsbxContestants.Size = new System.Drawing.Size(148, 186);
            this.lsbxContestants.TabIndex = 2;
            // 
            // lsbxProgress
            // 
            this.lsbxProgress.FormattingEnabled = true;
            this.lsbxProgress.Location = new System.Drawing.Point(229, 65);
            this.lsbxProgress.Name = "lsbxProgress";
            this.lsbxProgress.Size = new System.Drawing.Size(148, 186);
            this.lsbxProgress.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(39, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Contestant(s)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminate
            // 
            this.btnEliminate.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminate.Location = new System.Drawing.Point(39, 303);
            this.btnEliminate.Name = "btnEliminate";
            this.btnEliminate.Size = new System.Drawing.Size(135, 40);
            this.btnEliminate.TabIndex = 5;
            this.btnEliminate.Text = "Eliminate Contestant";
            this.btnEliminate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(242, 257);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmulatorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 363);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEliminate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbxProgress);
            this.Controls.Add(this.lsbxContestants);
            this.Controls.Add(this.lblPlacement);
            this.Controls.Add(this.lblContestants);
            this.Name = "frmEmulatorScreen";
            this.Text = "Reality Emulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContestants;
        private System.Windows.Forms.Label lblPlacement;
        private System.Windows.Forms.ListBox lsbxContestants;
        private System.Windows.Forms.ListBox lsbxProgress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminate;
        private System.Windows.Forms.Button btnExit;
    }
}

