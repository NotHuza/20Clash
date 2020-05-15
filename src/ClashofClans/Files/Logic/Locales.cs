using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
    public class Locales : Data
    {
        public Locales(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }

        public string FileName { get; set; }

        public string LocalizedName { get; set; }

        public bool HasEvenSpaceCharacters { get; set; }

        public bool isRTL { get; set; }

        public string UsedSystemFont { get; set; }

        public string HelpshiftSDKLanguage { get; set; }

        public string HelpshiftSDKLanguageAndroid { get; set; }

        public int SortOrder { get; set; }

        public bool TestLanguage { get; set; }

        public string TestExcludes { get; set; }

        public bool BoomboxEnabled { get; set; }

        public string BoomboxUrl { get; set; }

        public string BoomboxStagingUrl { get; set; }

        public string HelpshiftLanguageTagOverride { get; set; }

        public string ForcedFontName { get; set; }
    }
}