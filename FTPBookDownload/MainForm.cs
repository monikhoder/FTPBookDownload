using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimTools.WinForms;

namespace FTPBookDownload
{
    public partial class MainForm : KtWindow
    {
        private List<Book> bookList = new List<Book>();
        private void AddBookList()
        {
            bookList.Add(new Book { Id = "01", Title = "Pride and Prejudice", url = "ftp://gutenberg.pglaf.org/1/3/4/1342/1342-0.txt", img_url = "https://www.gutenberg.org/cache/epub/1342/pg1342.cover.medium.jpg" });
            bookList.Add(new Book { Id = "02", Title = "The Adventures of Sherlock Holmes", url = "ftp://gutenberg.pglaf.org/1/6/6/1661/1661-0.txt", img_url = "https://www.gutenberg.org/cache/epub/1661/pg1661.cover.medium.jpg" });
            bookList.Add(new Book { Id = "03", Title = "Moby Dick", url = "ftp://gutenberg.pglaf.org/2/7/0/2701/2701-0.txt", img_url = "https://www.gutenberg.org/cache/epub/2701/pg2701.cover.medium.jpg" });
            bookList.Add(new Book { Id = "04", Title = "War and Peace", url = "ftp://gutenberg.pglaf.org/2/6/0/2600/2600-0.txt", img_url = "https://www.gutenberg.org/cache/epub/2600/pg2600.cover.medium.jpg" });
            bookList.Add(new Book { Id = "05", Title = "The Great Gatsby", url = "ftp://gutenberg.pglaf.org/6/4/3/64317/64317-0.txt", img_url = "https://www.gutenberg.org/cache/epub/64317/pg64317.cover.medium.jpg" });
            bookList.Add(new Book { Id = "06", Title = "Frankenstein", url = "ftp://gutenberg.pglaf.org/8/4/84/84-0.txt", img_url = "https://www.gutenberg.org/cache/epub/84/pg84.cover.medium.jpg" });
            bookList.Add(new Book { Id = "07", Title = "Dracula", url = "ftp://gutenberg.pglaf.org/3/4/345/345-0.txt", img_url = "https://www.gutenberg.org/cache/epub/345/pg345.cover.medium.jpg" });
            bookList.Add(new Book { Id = "08", Title = "The Odyssey", url = "ftp://gutenberg.pglaf.org/1/7/2/1727/1727-0.txt", img_url = "https://www.gutenberg.org/cache/epub/1727/pg1727.cover.medium.jpg" });
            bookList.Add(new Book { Id = "09", Title = "Ulysses", url = "ftp://gutenberg.pglaf.org/4/3/0/4300/4300-0.txt", img_url = "https://www.gutenberg.org/cache/epub/4300/pg4300.cover.medium.jpg" });
            bookList.Add(new Book { Id = "10", Title = "A Tale of Two Cities", url = "ftp://gutenberg.pglaf.org/9/8/98/98-0.txt", img_url = "https://www.gutenberg.org/cache/epub/98/pg98.cover.medium.jpg" });
            bookList.Add(new Book { Id = "11", Title = "Jane Eyre", url = "ftp://gutenberg.pglaf.org/1/2/6/1260/1260-0.txt", img_url = "https://www.gutenberg.org/cache/epub/1260/pg1260.cover.medium.jpg" });
            bookList.Add(new Book { Id = "12", Title = "Les Misérables", url = "ftp://gutenberg.pglaf.org/1/3/5/135/135-0.txt", img_url = "https://www.gutenberg.org/cache/epub/135/pg135.cover.medium.jpg" });
            bookList.Add(new Book { Id = "13", Title = "The Picture of Dorian Gray", url = "ftp://gutenberg.pglaf.org/1/7/4/174/174-0.txt", img_url = "https://www.gutenberg.org/cache/epub/174/pg174.cover.medium.jpg" });
            bookList.Add(new Book { Id = "14", Title = "The Count of Monte Cristo", url = "ftp://gutenberg.pglaf.org/1/1/8/1184/1184-0.txt", img_url = "https://www.gutenberg.org/cache/epub/1184/pg1184.cover.medium.jpg" });
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadBooks()
        {
            tblBook.Rows.Clear();
            foreach (var book in bookList)
            {
                var books = tblBook.NewRow();
                books["tblname"] = book.Title;
            }


        }
        public class Book
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string url { get; set; }
            public string img_url { get; set; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddBookList();
            LoadBooks();
            
        }

        private async void tblBook_CellClick(KtTable table, KtTableRow row, KtTableColumn column)
        {
            int rowindex = row.Index;
            string imagUrl = bookList[rowindex].img_url;
            lblTitle.Text = bookList[rowindex].Title;
            ChangeBookCover(imagUrl);
            bookTextBox.Clear();
            ReadBookAsync(rowindex);

        }
        private async Task ChangeBookCover(string url)
        {
            try
            {
                lblLoadingCover.Visible = true;

                // Download the image asynchronously
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = await webClient.DownloadDataTaskAsync(new Uri(url));
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // Set the downloaded image to the picture box
                        BookCover.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., network issues)
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lblLoadingCover.Visible = false;
            }
        }
        private async Task ReadBookAsync(int index)
        {
            string url = bookList[index].url;
            string result = string.Empty;

            TexbookLoading.Visible = true;

            try
            {
                // Create FTP web request
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // Get FTP response
                using (FtpWebResponse response = (FtpWebResponse)await Task.Factory.FromAsync(
                    request.BeginGetResponse, request.EndGetResponse, null))
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    // Read data from file
                    result = await reader.ReadToEndAsync();

                    // Save to a local file
                    File.WriteAllText("book.txt", result);

                    // Set the text to the bookTextBox
                    bookTextBox.Text = result;
                }
            }
            catch (WebException webEx)
            {
                // Handle web exceptions (e.g., network issues, file not found)
                MessageBox.Show($"Error accessing the FTP server: {webEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                // Handle IO exceptions (e.g., file access issues)
                MessageBox.Show($"Error reading or writing the file: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TexbookLoading.Visible = false;
            }

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            string url = bookList[rowIndex].url;
            string localFilePath = SelectSaveFilePath($"{lblTitle.Text}.txt");
            if (localFilePath != null)
            {
                lblDownloadLoading.Visible = true;
                await DownloadFileFromFTP(url, localFilePath);
                lblDownloadLoading.Visible = false;
            }

        }
        private string SelectSaveFilePath(string defaultFileName)
        {
          
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = defaultFileName;
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save the FTP File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
            }
            return null;
        }
        private async Task DownloadFileFromFTP(string ftpUrl, string localFilePath)
        {
            try
            {
                // Create an FtpWebRequest for the given FTP URL
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("anonymous", "anonymous");

                // Get the FTP response
                using (FtpWebResponse response = (FtpWebResponse)await Task.Factory.FromAsync(
                    request.BeginGetResponse, request.EndGetResponse, null))
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
                {
                    // Copy the FTP file to the local file system
                    await responseStream.CopyToAsync(fileStream);
                }

                MessageBox.Show("Download completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Error during FTP download: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"File system error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
