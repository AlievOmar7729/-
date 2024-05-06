using System.Text.RegularExpressions;

namespace Strategy
{
    public class DownloadImage
    {
        private ILoadType _loadType;
        private static string regex = @"^https://";

        private void SetStrategy(ILoadType loadType)
        {
            _loadType = loadType;
        }
        public void LoadIMG(string href)
        {
            SetStrategy(Regex.IsMatch(href, regex) ? new FileNetwork() : new FileSystem());
            _loadType.LoadIMG(href);

        }
    }
}
