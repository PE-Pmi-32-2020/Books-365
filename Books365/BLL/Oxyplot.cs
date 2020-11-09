namespace Books365.PL
{
    using System.Collections.Generic;
    using System.Linq;
    using OxyPlot;
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Title = "Pages Read Graphic";
            this.Points = new List<DataPoint> { };
            using (AppContext db = new AppContext())
            {
                var booksRead = db.ReadingStatuses.Where(u => u.BookStatus == "read" || u.BookStatus == "is reading");
                int i = 1;
                int totalpages = 0;
                foreach (var item in booksRead)
                {
                    totalpages += item.PagesWritten;
                    Points.Add(new DataPoint(item.BookISBN, item.PagesWritten));
                    i++;
                }
            }

        }
        public string Title { get; private set; }
        public IList<DataPoint> Points { get; private set; }
    }




}
