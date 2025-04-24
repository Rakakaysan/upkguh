using Microsoft.Data.SqlClient; // For database access
using System;
using System.Data;
using System.Text.RegularExpressions; // For Regex-based URL parsing as an alternative
using System.Windows.Forms;

namespace upkguh
{
    public partial class Materi : UserControl
    {
        // Use the connection string from your Konesksi class
        private string connectionString = Konesksi.conn;

        public Materi()
        {
            InitializeComponent();
            ConfigureDataGridView();
            MateriKontenText.Text = "Silakan pilih materi dari tabel di atas.";
            YouTubeVideoPlayer.Navigate("about:blank"); // Start with a blank page
            ShowData();
            // Load data when the control loads
            this.Load += Materi_Load;
        }

        private void Materi_Load(object sender, EventArgs e)
        {
            // Initial setup
            MateriKontenText.Text = "Silakan pilih materi dari tabel di atas.";
            YouTubeVideoPlayer.Navigate("about:blank"); // Start with a blank page
            ShowData();
        }


        private void ConfigureDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust columns to fill width
            dataGridView1.RowHeadersVisible = false; // Hide the default row header column

            // Handle cell click event
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // --- READ Data into Grid ---
        public void ShowData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT id_materi, nama_materi, konten_materi, url_youtube FROM materi_pembelajaran ORDER BY nama_materi", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tabel;

                    // --- Configure Columns (AFTER setting DataSource) ---
                    if (dataGridView1.Columns.Count > 0)
                    {
                        // Hide columns we don't need directly in the grid view
                        dataGridView1.Columns["id_materi"].Visible = false;
                        dataGridView1.Columns["konten_materi"].Visible = false; // Content is too long for grid
                        dataGridView1.Columns["url_youtube"].Visible = false; // URL is shown in browser

                        // Set user-friendly header text for the visible column
                        dataGridView1.Columns["nama_materi"].HeaderText = "Nama Materi";

                        // Adjust the fill weight if needed (optional)
                        dataGridView1.Columns["nama_materi"].FillWeight = 100; // Make it take up available space
                    }

                    // Clear initial selection and details view
                    dataGridView1.ClearSelection();
                    MateriKontenText.Text = "Silakan pilih materi dari tabel di atas.";
                    YouTubeVideoPlayer.Navigate("about:blank");

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error saat menampilkan daftar materi: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menampilkan daftar materi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Handle Row Click ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row (not the header) is clicked
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                try
                {
                    // Safely get data from the clicked row (handle potential DBNull)
                    string konten = selectedRow.Cells["konten_materi"].Value?.ToString() ?? "Konten tidak tersedia.";
                    string youtubeUrl = selectedRow.Cells["url_youtube"].Value?.ToString(); // Can be null

                    // Display the text content
                    MateriKontenText.Text = konten;

                    // Display the YouTube video if URL exists
                    if (!string.IsNullOrWhiteSpace(youtubeUrl))
                    {
                        string embedUrl = GetYouTubeEmbedUrl(youtubeUrl);
                        if (embedUrl != null)
                        {

                            var embed = "<html><head>" +
                                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                                "</head></body> " +
                                "<iframe width\"600\" src=\"{0}\"" +
                                "frameborder= \"0\" allow=\"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                                "</body></html>";
                            //YouTubeVideoPlayer.Navigate(embedUrl);
                            YouTubeVideoPlayer.DocumentText = string.Format(embed, embedUrl);
                        }
                        else
                        {
                            // Handle invalid or non-YouTube URL if necessary
                            YouTubeVideoPlayer.Navigate("about:blank"); // Show blank page
                            MateriKontenText.AppendText("\n\n(URL YouTube tidak valid atau tidak dapat di-embed)");
                        }
                    }
                    else
                    {
                        // No YouTube URL provided for this entry
                        YouTubeVideoPlayer.Navigate("about:blank"); // Show blank page
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menampilkan detail materi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Clear details on error
                    MateriKontenText.Text = "Terjadi kesalahan saat memuat detail.";
                    YouTubeVideoPlayer.Navigate("about:blank");
                }
            }
        }


        /// <summary>
        /// Converts a standard YouTube URL (watch?v= or youtu.be/) into an embeddable URL.
        /// Returns null if the URL is invalid or not a recognized YouTube format.
        /// </summary>
        private string GetYouTubeEmbedUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return null;

            string videoId = null;

            try
            {
                // Try parsing using Uri and HttpUtility (preferred if System.Web is available)
                /* // Uncomment this block if you have System.Web reference
                Uri uri = new Uri(url);
                if (uri.Host.EndsWith("youtube.com", StringComparison.OrdinalIgnoreCase))
                {
                     var query = HttpUtility.ParseQueryString(uri.Query);
                     videoId = query["v"];
                }
                else if (uri.Host.EndsWith("youtu.be", StringComparison.OrdinalIgnoreCase))
                {
                     videoId = uri.Segments.Length > 1 ? uri.Segments[1] : null;
                }
                */

                // --- Alternative using Regex (doesn't require System.Web) ---
                // Pattern for standard youtube.com/watch?v=VIDEOID
                var regexWatch = new Regex(@"youtube\.com/watch\?v=([^&]+)");
                Match matchWatch = regexWatch.Match(url);
                if (matchWatch.Success)
                {
                    videoId = matchWatch.Groups[1].Value;
                }
                else
                {
                    // Pattern for short youtu.be/VIDEOID
                    var regexShort = new Regex(@"youtu\.be/([^?&]+)");
                    Match matchShort = regexShort.Match(url);
                    if (matchShort.Success)
                    {
                        videoId = matchShort.Groups[1].Value;
                    }
                    else
                    {
                        // Pattern for youtube.com/embed/VIDEOID (already embedded)
                        var regexEmbed = new Regex(@"youtube\.com/embed/([^?&]+)");
                        Match matchEmbed = regexEmbed.Match(url);
                        if (matchEmbed.Success)
                        {
                            videoId = matchEmbed.Groups[1].Value; // Already has the ID
                                                                  // Return the original URL if it's already an embed URL
                                                                  // Or construct it again for consistency, depending on desired behavior
                                                                  // return url; // Option 1: return original if already embed
                        }
                    }
                }
                // --- End of Regex Alternative ---


                if (!string.IsNullOrWhiteSpace(videoId))
                {
                    // Remove any extra query parameters that might interfere
                    videoId = videoId.Split('&')[0];
                    return $"https://www.youtube.com/embed/{videoId}";
                }
            }
            catch (UriFormatException)
            {
                // Invalid URL format
                return null;
            }
            catch (Exception)
            {
                // Catch other potential errors during parsing
                return null;
            }

            return null; // Return null if no valid ID was extracted
        }

    }
}