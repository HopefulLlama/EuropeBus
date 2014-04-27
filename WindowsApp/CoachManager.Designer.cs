namespace WindowsApp
{
    partial class CoachManager
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCoach = new System.Windows.Forms.Label();
            this.gridViewCoaches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "X Delete selected coach";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 349);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "* Edit selected coach";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "+ Add a coach";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoach.Location = new System.Drawing.Point(252, 9);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(98, 26);
            this.lblCoach.TabIndex = 19;
            this.lblCoach.Text = "Coaches";
            // 
            // gridViewCoaches
            // 
            this.gridViewCoaches.AllowUserToAddRows = false;
            this.gridViewCoaches.AllowUserToDeleteRows = false;
            this.gridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCoaches.Location = new System.Drawing.Point(12, 38);
            this.gridViewCoaches.MultiSelect = false;
            this.gridViewCoaches.Name = "gridViewCoaches";
            this.gridViewCoaches.ReadOnly = true;
            this.gridViewCoaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCoaches.Size = new System.Drawing.Size(563, 260);
            this.gridViewCoaches.TabIndex = 18;
            this.gridViewCoaches.SelectionChanged += new System.EventHandler(this.gridViewCoaches_SelectionChanged);
            // 
            // CoachManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 417);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.gridViewCoaches);
            this.Name = "CoachManager";
            this.Text = "CoachManager";
            this.Load += new System.EventHandler(this.CoachManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoaches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.DataGridView gridViewCoaches;

    }
}