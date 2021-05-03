
namespace MusicApp
{
    partial class AddArtist
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
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.lstArtists = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(55, 40);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(120, 20);
            this.txtArtistName.TabIndex = 0;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(52, 24);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(61, 13);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(55, 67);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 2;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // lstArtists
            // 
            this.lstArtists.HideSelection = false;
            this.lstArtists.Location = new System.Drawing.Point(490, 85);
            this.lstArtists.Name = "lstArtists";
            this.lstArtists.Size = new System.Drawing.Size(121, 97);
            this.lstArtists.TabIndex = 3;
            this.lstArtists.UseCompatibleStateImageBehavior = false;
            // 
            // AddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstArtists);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.txtArtistName);
            this.Name = "AddArtist";
            this.Text = "AddArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.ListView lstArtists;
    }
}