namespace WindowsApp
{
    partial class MainMenu
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnDataLink = new System.Windows.Forms.Button();
            this.btnSeatAllocator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(77, 9);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(208, 44);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDataLink
            // 
            this.btnDataLink.Location = new System.Drawing.Point(22, 66);
            this.btnDataLink.Name = "btnDataLink";
            this.btnDataLink.Size = new System.Drawing.Size(150, 50);
            this.btnDataLink.TabIndex = 1;
            this.btnDataLink.Text = "Data Manager";
            this.btnDataLink.UseVisualStyleBackColor = true;
            this.btnDataLink.Click += new System.EventHandler(this.btnDataLink_Click);
            // 
            // btnSeatAllocator
            // 
            this.btnSeatAllocator.Location = new System.Drawing.Point(178, 66);
            this.btnSeatAllocator.Name = "btnSeatAllocator";
            this.btnSeatAllocator.Size = new System.Drawing.Size(150, 50);
            this.btnSeatAllocator.TabIndex = 2;
            this.btnSeatAllocator.Text = "Seating Allocator";
            this.btnSeatAllocator.UseVisualStyleBackColor = true;
            this.btnSeatAllocator.Click += new System.EventHandler(this.btnSeatAllocator_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 135);
            this.Controls.Add(this.btnSeatAllocator);
            this.Controls.Add(this.btnDataLink);
            this.Controls.Add(this.lblMainMenu);
            this.Name = "MainMenu";
            this.Text = "Europe Bus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnDataLink;
        private System.Windows.Forms.Button btnSeatAllocator;
    }
}

