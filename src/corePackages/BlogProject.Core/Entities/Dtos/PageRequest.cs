namespace BlogProject.Core.Entities.Dtos
{
    public class PageRequest
    {
        public int Index { get; set; } = 0;
        public int Size { get; set; } = 10;
    }
}
