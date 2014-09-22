using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstates.ServerSide
{
    public class Feeds
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string PublishDate { get; set; }
        public string Description { get; set; }
        public string PictureFromDescription { get; set; }
        public void RemoveHRefFromPic()
        {
            Description=Description.Remove(5, 57);
            int startCut=0;
            for (int i = 0; i < Description.Length; i++)
            {
                if(Description[i].Equals('<'))
                    if (Description[i + 1].Equals('/') && Description[i + 2].Equals('a') && Description[i + 3].Equals('>'))
                         startCut = i;
            }

            Description = Description.Remove(startCut, 4);

            System.Diagnostics.Debug.WriteLine(Description);
        }
        public string removePiture()
        {
            int endOfImg=0;
            for (int i = 5; i < Description.Length; i++)
            {
                if (Description[i].Equals('>'))
                { 
                    endOfImg = i;
                    break;
                }
            }
            string toReturn = Description.Substring(5, endOfImg - 4 );
            Description = Description.Remove(5, endOfImg - 4);
            System.Diagnostics.Debug.WriteLine(Description);
            System.Diagnostics.Debug.WriteLine(toReturn);
            return toReturn;
        }


    }

}