namespace WindowsApp
{
    partial class RouteManager
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
            this.lblRoutes = new System.Windows.Forms.Label();
            this.gridViewRoutes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "X Delete selected route";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "* Edit selected route";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+ Add a route";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRoutes
            // 
            this.lblRoutes.AutoSize = true;
            this.lblRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoutes.Location = new System.Drawing.Point(252, 3);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(81, 26);
            this.lblRoutes.TabIndex = 13;
            this.lblRoutes.Text = "Routes";
            // 
            // gridViewRoutes
            // 
            this.gridViewRoutes.AllowUserToAddRows = false;
            this.gridViewRoutes.AllowUserToDeleteRows = false;
            this.gridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRoutes.Location = new System.Drawing.Point(12, 32);
            this.gridViewRoutes.MultiSelect = false;
            this.gridViewRoutes.Name = "gridViewRoutes";
            this.gridViewRoutes.ReadOnly = true;
            this.gridViewRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewRoutes.Size = new System.Drawing.Size(563, 260);
            this.gridViewRoutes.TabIndex = 12;
            this.gridViewRoutes.SelectionChanged += new System.EventHandler(this.gridViewRoutes_SelectionChanged);
            // 
            // RouteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 406);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRoutes);
            this.Controls.Add(this.gridViewRoutes);
            this.Name = "RouteManager";
            this.Text = "RouteManager";
            this.Load += new System.EventHandler(this.RouteManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.DataGridView gridViewRoutes;

    }
}