namespace BlogProject.DataAccess.EntityFramework.Constants
{
    public static class LengthContraints
    {
        public const int TITLE_MAX_LENGTH = 100;
        public const int TITLE_MIN_LENGTH = 5;
        public const int CONTENT_MAX_LENGTH = 5000;
        public const int CONTENT_MIN_LENGTH = 10;
        public const int THUMBNAIL_MAX_LENGTH = 250;
        public const int THUMBNAIL_MIN_LENGTH = 10;
        public const int NAME_MAX_LENGTH = 50;
        public const int LAST_NAME_MAX_LENGTH = 70;
        public const int NAME_MIN_LENGTH = 5;
        public const int DESCRIPTION_MAX_LENGTH = 500;
        public const int DESCRIPTION_MIN_LENGTH = 10;
        public const string MAX = "nvarchar(MAX)";
        public const byte CORRECTION_REQUEST_ARTICLEID_MAXLENGTH = 40;
        public const byte CORRECTION_REQUEST_USERID_MAXLENGTH = 40;
        public const short CORRECTION_REQUEST_MAXLENGTH = 500;
        public const short COMMENT_CONTENT_MAXLENGTH = 200;
        public const short TAG_NAME_MAX_LENGTH = 20;
        //public const short TAG_NAME_MİN_LENGTH = 2;



    }
}
