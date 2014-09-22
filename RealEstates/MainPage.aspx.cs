using RealEstates.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Moti
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateRssFeed();
            MatchesBL mbl = new MatchesBL();
            mbl.autoMatch();
            
        }
        private void PopulateRssFeed()
        {
            string RssFeedUrl = "http://www.calcalist.co.il/integration/StoryRss7.xml";
            List<Feeds> feeds = new List<Feeds>();
            try
            {
                XDocument xDoc = new XDocument();
                xDoc = XDocument.Load(RssFeedUrl);
                var items = (from x in xDoc.Descendants("item")
                             select new
                             {
                                 title = x.Element("title").Value,
                                 link = x.Element("link").Value,
                                 pubDate = x.Element("pubDate").Value,
                                 description = x.Element("description").Value,
                                 
                             });
                if (items != null)
                {
                    foreach (var i in items)
                    {
                        Feeds f = new Feeds
                        {
                            Title = i.title,
                            Link = i.link,
                            PublishDate = i.pubDate,
                            Description = i.description,
                            
                        };
                        f.RemoveHRefFromPic();
                        f.PictureFromDescription = f.removePiture();
                        feeds.Add(f);
                    }
                }

                NewsRSS.DataSource = feeds;
                NewsRSS.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}