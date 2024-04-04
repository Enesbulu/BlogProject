namespace BlogProject.DataAccess.EntityFramework.Constants
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
        public const string AUTHOR_ID = "AuthorId";
        public const string EDITOR_ID = "EditorId";


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

        //TAG TABLE
        public const string TAG_NAME = "TagName ";
        public const string ARTICLE_TAGS = "ArticleTags ";

        //AUTHOR TABLE
        public const string AUTHOR_FIRST_NAME = "FirstName"; 
        public const string AUTHOR_LAST_NAME = "LastName";


        //EDITOR TABLE
        public const string EDITOR_FIRST_NAME = "FirstName";
        public const string EDITOR_LAST_NAME = "LastName";



    }
}
