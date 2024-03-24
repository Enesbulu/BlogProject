﻿namespace BlogProject.DataAccess.EntityFramework.Constants
{
    public class ColumNameConstants
    {
        //ARTICLE CONFIGURATIONS TABLE
        public const string TITLE = "Title";
        public const string CONTENT = "Content";
        public const string THUMBNAIL = "Thumbnail";
        public const string DATE = "Date";
        public const string VIEW_COUNT = "ViewCount";
        public const string COMMENT_COUNT = "CommnetCount";
        public const string CATEGORY_ID = "CategoryId";


        //CORRECTION REQUEST TABLE
        public const string ARTICLE_ID = "ArticleID";
        public const string USER_ID = "UserID";
        public const string REQUEST_CONTENT = "RequestContents";
        public const string STATUS = "Status";


        //COMMENTS TABLE
        public const string COMMENT_CONTENT = "CommentContents ";
        public const string APPROVED_USER_ID = "ApprovedUserId ";
        public const string IS_PUBLISHED = "IsPublished ";
        public const string IS_APPROVED = "IsApproved ";



    }
}
