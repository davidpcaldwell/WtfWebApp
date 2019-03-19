//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System;
using global::System.ComponentModel;
using global::System.Data;
using global::System.Data.SqlClient;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Threading.Tasks;
using global::System.Xml.Linq;
using global::Inedo.Data;

#pragma warning disable 1591
namespace TheDailyWtf.Data
{
    public static partial class Tables
    {
        public partial class AdImpressions
        {
            public string Banner_Name { get; set; }
            public DateTime Impression_Date { get; set; }
            public int Impression_Count { get; set; }
        }
        public partial class AdRedirectUrls
        {
            public Guid Ad_Guid { get; set; }
            public string Redirect_Url { get; set; }
            public int Click_Count { get; set; }
        }
        public partial class Ads
        {
            public int Ad_Id { get; set; }
            public string Ad_Html { get; set; }
        }
        public partial class ArticlePostMappings
        {
            public int Post_Id { get; set; }
            public int Article_Id { get; set; }
        }
        [Obsolete("Articles is obsolete. Use Articles_Extended instead.", true)]
        public partial class Articles
        {
            public int Article_Id { get; set; }
            public string Article_Slug { get; set; }
            public DateTime? Published_Date { get; set; }
            public string PublishedStatus_Name { get; set; }
            public string Author_Slug { get; set; }
            public string Title_Text { get; set; }
            public string Series_Slug { get; set; }
            public string Body_Html { get; set; }
            public int? Discourse_Topic_Id { get; set; }
            public string Discourse_Topic_Opened { get; set; }
            public int? Ad_Id { get; set; }
        }
        public partial class Articles_Extended
        {
            public int Article_Id { get; set; }
            public string Article_Slug { get; set; }
            public DateTime? Published_Date { get; set; }
            public string PublishedStatus_Name { get; set; }
            public string Author_Slug { get; set; }
            public string Title_Text { get; set; }
            public string Series_Slug { get; set; }
            public string Body_Html { get; set; }
            public string BodyAndAd_Html { get; set; }
            public int? Discourse_Topic_Id { get; set; }
            public string Discourse_Topic_Opened { get; set; }
            public int? Previous_Article_Id { get; set; }
            public string Previous_Article_Slug { get; set; }
            public string Previous_Title_Text { get; set; }
            public int? Next_Article_Id { get; set; }
            public string Next_Article_Slug { get; set; }
            public string Next_Title_Text { get; set; }
            public string Author_Display_Name { get; set; }
            public YNIndicator Author_Admin_Indicator { get; set; }
            public string Author_Bio_Html { get; set; }
            public string Author_ShortBio_Text { get; set; }
            public string Author_Image_Url { get; set; }
            public YNIndicator Author_Active_Indicator { get; set; }
            public string Series_Title_Text { get; set; }
            public string Series_Description_Text { get; set; }
            public int? Cached_Comment_Count { get; set; }
            public DateTime? Last_Comment_Date { get; set; }
            public string Ad_Html { get; set; }
        }
        public partial class Authors
        {
            public string Author_Slug { get; set; }
            public string Display_Name { get; set; }
            public byte[] Password_Bytes { get; set; }
            public byte[] Salt_Bytes { get; set; }
            public YNIndicator Admin_Indicator { get; set; }
            public string Bio_Html { get; set; }
            public string ShortBio_Text { get; set; }
            public string Image_Url { get; set; }
            public YNIndicator Active_Indicator { get; set; }
        }
        [Obsolete("Comments is obsolete. Use Comments_Extended instead.", true)]
        public partial class Comments
        {
            public int Comment_Id { get; set; }
            public int Article_Id { get; set; }
            public string Body_Html { get; set; }
            public string User_Name { get; set; }
            public DateTime Posted_Date { get; set; }
            public int? Discourse_Post_Id { get; set; }
            public YNIndicator Featured_Indicator { get; set; }
            public string User_IP { get; set; }
            public string User_Token { get; set; }
            public int? Parent_Comment_Id { get; set; }
            public YNIndicator Hidden_Indicator { get; set; }
        }
        public partial class Comments_Extended
        {
            public int Comment_Id { get; set; }
            public int Article_Id { get; set; }
            public string Article_Title { get; set; }
            public string Body_Html { get; set; }
            public string User_Name { get; set; }
            public DateTime Posted_Date { get; set; }
            public int? Discourse_Post_Id { get; set; }
            public YNIndicator Featured_Indicator { get; set; }
            public YNIndicator Hidden_Indicator { get; set; }
            public string User_IP { get; set; }
            public string User_Token { get; set; }
            public int? Parent_Comment_Id { get; set; }
            public string Parent_Comment_User_Name { get; set; }
        }
        public partial class FeaturedComments
        {
            public int Article_Id { get; set; }
            public int Discourse_Post_Id { get; set; }
        }
        public partial class Series
        {
            public string Series_Slug { get; set; }
            public string Title_Text { get; set; }
            public string Description_Text { get; set; }
        }
    }
}
#pragma warning restore 1591
