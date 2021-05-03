
namespace MusicApp
{
    partial class AddPlaylist
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
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lstPlaylistSongs = new System.Windows.Forms.ListBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Location = new System.Drawing.Point(13, 13);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(35, 13);
            this.lblPlaylistName.TabIndex = 0;
            this.lblPlaylistName.Text = "Name";
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(13, 30);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(114, 20);
            this.txtPlaylistName.TabIndex = 1;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(13, 303);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlaylist.TabIndex = 2;
            this.btnAddPlaylist.Text = "Add Playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(12, 91);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(120, 95);
            this.lstSongs.TabIndex = 3;
            // 
            // lstPlaylistSongs
            // 
            this.lstPlaylistSongs.FormattingEnabled = true;
            this.lstPlaylistSongs.Location = new System.Drawing.Point(220, 91);
            this.lstPlaylistSongs.Name = "lstPlaylistSongs";
            this.lstPlaylistSongs.Size = new System.Drawing.Size(120, 95);
            this.lstPlaylistSongs.TabIndex = 4;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(138, 122);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 5;
            this.btnAddSong.Text = ">>";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(240, 192);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSong.TabIndex = 6;
            this.btnRemoveSong.Text = "Remove";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            // 
            // AddPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 369);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.lstPlaylistSongs);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.lblPlaylistName);
            this.Name = "AddPlaylist";
            this.Text = "AddPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.ListBox lstPlaylistSongs;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnRemoveSong;
    }
}