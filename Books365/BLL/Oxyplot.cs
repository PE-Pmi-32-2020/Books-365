namespace Books365.PL
{
    using System.Collections.Generic;
    using OxyPlot.Series;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Title = "Pages Read Graphic";
            this.Columns = new List<ColumnItem> { };
            using (AppContext db = new AppContext())
            {
                var booksRead = db.ReadingStatuses;
                foreach (var item in booksRead)
                {
                    this.Columns.Add(new ColumnItem { Value = item.PagesWritten });
                }
            }
        }

        public string Title { get; private set; }

        public IList<ColumnItem> Columns { get; private set; }
    }
}
