using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AceNews.Old_Code.DAL;

namespace AceNews.Old_Code.BOL.Likes
{
    public class BOLLikes
    {
        internal bool InsertLike(int HCSectionCode, int ItemCode)
        {
            try
            {
                AceNews.Old_Code.DAL.Likes NewLike = new DAL.Likes();
                LikesDataContext dc = new LikesDataContext();
                dc.Likes.InsertOnSubmit(NewLike);
                NewLike.HCSectionCode = HCSectionCode;
                NewLike.ItemCode = ItemCode;
                NewLike.SendDate = DateTime.Now;

                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal int GetCount(int HCSectionCode, int NewsCode)
        {
            LikesDataContext dc = new LikesDataContext();
            return dc.Likes.Where(p => p.HCSectionCode.Equals(HCSectionCode) && p.ItemCode.Equals(NewsCode)).Count();
        }
    }
}