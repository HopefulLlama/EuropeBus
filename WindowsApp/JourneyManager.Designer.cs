namespace WindowsApp
{
    partial class JourneyManager
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
            this.gridViewRoutes = new System.Windows.Forms.DataGridView();
            this.lblRoutes = new System.Windows.Forms.Label();
            this.lblRouteText = new System.Windows.Forms.Label();
            this.gridViewTimes = new System.Windows.Forms.DataGridView();
            this.lblArrow1 = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblCoaches = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridViewCoaches = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewRoutes
            // 
            this.gridViewRoutes.AllowUserToAddRows = false;
            this.gridViewRoutes.AllowUserToDeleteRows = false;
            this.gridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRoutes.Location = new System.Drawing.Point(12, 51);
            this.gridViewRoutes.MultiSelect = false;
            this.gridViewRoutes.Name = "gridViewRoutes";
            this.gridViewRoutes.ReadOnly = true;
            this.gridViewRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewRoutes.Size = new System.Drawing.Size(563, 260);
            this.gridViewRoutes.TabIndex = 0;
            this.gridViewRoutes.SelectionChanged += new System.EventHandler(this.gridViewRoutes_SelectionChanged);
            // 
            // lblRoutes
            // 
            this.lblRoutes.AutoSize = true;
            this.lblRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoutes.Location = new System.Drawing.Point(252, 22);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(81, 26);
            this.lblRoutes.TabIndex = 1;
            this.lblRoutes.Text = "Routes";
            // 
            // lblRouteText
            // 
            this.lblRouteText.AutoSize = true;
            this.lblRouteText.Location = new System.Drawing.Point(339, 9);
            this.lblRouteText.Name = "lblRouteText";
            this.lblRouteText.Size = new System.Drawing.Size(475, 13);
            this.lblRouteText.TabIndex = 2;
            this.lblRouteText.Text = "Select an item to view sub-items (i.e. : Routes have operation times which have a" +
    "ssigned coaches).";
            // 
            // gridViewTimes
            // 
            this.gridViewTimes.AllowUserToAddRows = false;
            this.gridViewTimes.AllowUserToDeleteRows = false;
            this.gridViewTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTimes.Location = new System.Drawing.Point(619, 51);
            this.gridViewTimes.MultiSelect = false;
            this.gridViewTimes.Name = "gridViewTimes";
            this.gridViewTimes.ReadOnly = true;
            this.gridViewTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTimes.Size = new System.Drawing.Size(293, 260);
            this.gridViewTimes.TabIndex = 3;
            this.gridViewTimes.SelectionChanged += new System.EventHandler(this.gridViewTimes_SelectionChanged);
            // 
            // lblArrow1
            // 
            this.lblArrow1.AutoSize = true;
            this.lblArrow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow1.Location = new System.Drawing.Point(581, 153);
            this.lblArrow1.Name = "lblArrow1";
            this.lblArrow1.Size = new System.Drawing.Size(32, 26);
            this.lblArrow1.TabIndex = 4;
            this.lblArrow1.Text = "->";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(718, 22);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(71, 26);
            this.lblTimes.TabIndex = 5;
            this.lblTimes.Text = "Times";
            // 
            // lblCoaches
            // 
            this.lblCoaches.AutoSize = true;
            this.lblCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoaches.Location = new System.Drawing.Point(1066, 22);
            this.lblCoaches.Name = "lblCoaches";
            this.lblCoaches.Size = new System.Drawing.Size(98, 26);
            this.lblCoaches.TabIndex = 8;
            this.lblCoaches.Text = "Coaches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(918, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "->";
            // 
            // gridViewCoaches
            // 
            this.gridViewCoaches.AllowUserToAddRows = false;
            this.gridViewCoaches.AllowUserToDeleteRows = false;
            this.gridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCoaches.Location = new System.Drawing.Point(956, 51);
            this.gridViewCoaches.MultiSelect = false;
            this.gridViewCoaches.Name = "gridViewCoaches";
            this.gridViewCoaches.ReadOnly = true;
            this.gridViewCoaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCoaches.Size = new System.Drawing.Size(316, 260);
            this.gridViewCoaches.TabIndex = 6;
            this.gridViewCoaches.SelectionChanged += new System.EventHandler(this.gridViewCoaches_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+ Add a journey";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 362);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "* Edit selected journey";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "X Delete selected journey";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // JourneyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 427);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCoaches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewCoaches);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblArrow1);
            this.Controls.Add(this.gridViewTimes);
            this.Controls.Add(this.lblRouteText);
            this.Controls.Add(this.lblRoutes);
            this.Controls.Add(this.gridViewRoutes);
            this.Name = "JourneyManager";
            this.Text = "Journey Manager";
            this.Load += new System.EventHandler(this.RoutesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoaches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewRoutes;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.Label lblRouteText;
        private System.Windows.Forms.DataGridView gridViewTimes;
        private System.Windows.Forms.Label lblArrow1;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblCoaches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridViewCoaches;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}