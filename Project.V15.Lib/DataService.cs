namespace Project.V15.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string fd = File.ReadAllText(path);
            fd = fd.Replace('\n', '\r');
            string[] lines = fd.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;


            string[,] arr = new string[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');

                for (int c = 0; c < cols; c++) { arr[r, c] = line_r[c]; }
            }
            return arr;
        }

    }
}
