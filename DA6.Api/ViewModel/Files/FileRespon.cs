namespace DA6.Api.ViewModel.Files
{
    public class FileRespon
    {
        public string fileName { get; set; }
        public string filePath { get; set; }
        public string size { get; set; }
        public int status { get; set; }
        public FileRespon()
        {
            status = 400;
        }
        public FileRespon(string FileName,string FilePath,string Size, int Status)
        {
            fileName = FileName;
            filePath = FilePath;
            size = Size;
            status = Status;
        }
    }
}
