
namespace MusicApp
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
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblPlaylists = new System.Windows.Forms.Label();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.lvwSongs = new System.Windows.Forms.ListView();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(502, 13);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 0;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(583, 13);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlbum.TabIndex = 1;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(664, 13);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 2;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblPlaylists
            // 
            this.lblPlaylists.AutoSize = true;
            this.lblPlaylists.Location = new System.Drawing.Point(13, 13);
            this.lblPlaylists.Name = "lblPlaylists";
            this.lblPlaylists.Size = new System.Drawing.Size(69, 13);
            this.lblPlaylists.TabIndex = 3;
            this.lblPlaylists.Text = "Your Playlists";
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(88, 8);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlaylist.TabIndex = 4;
            this.btnAddPlaylist.Text = "Add Playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.Location = new System.Drawing.Point(16, 51);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(147, 381);
            this.lstPlaylists.TabIndex = 5;
            this.lstPlaylists.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
            // 
            // lvwSongs
            // 
            this.lvwSongs.HideSelection = false;
            this.lvwSongs.Location = new System.Drawing.Point(170, 51);
            this.lvwSongs.Name = "lvwSongs";
            this.lvwSongs.Size = new System.Drawing.Size(488, 381);
            this.lvwSongs.TabIndex = 6;
            this.lvwSongs.UseCompatibleStateImageBehavior = false;
            this.lvwSongs.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwSongs_ItemChecked);
            this.lvwSongs.SelectedIndexChanged += new System.EventHandler(this.lvwSongs_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(668, 171);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(97, 83);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lvwSongs);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.lblPlaylists);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.btnAddArtist);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label lblPlaylists;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.ListView lvwSongs;
        private System.Windows.Forms.Button btnPlay;
    }
}