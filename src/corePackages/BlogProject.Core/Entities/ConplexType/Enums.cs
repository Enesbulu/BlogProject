namespace BlogProject.Core.Entities.ConplexType
{
    public class Enums
    {
        public enum RecordStatu
        {
            None = 0,
            Active = 1,
            Passive = 2,
        }

        public enum FileType
        {
            None,
            Xls,
            Xlsx,
            Doc,
            Pps,
            Pdf,
            Img,
            Mp4
        }
        public enum CorrectionRequestStatus
        {
            None = 0,
            Pending,  //(Beklemede): Düzeltme isteği henüz incelenmemiş veya işlenmemiş durumda.
            Accepted, //(Kabul Edildi): Düzeltme isteği kabul edilmiş ve işlem yapılmış durumda.
            Rejected, //(Reddedildi): Düzeltme isteği reddedilmiş ve işlem yapılmamış durumda.
            Completed, //(Tamamlandı): Düzeltme isteği üzerinde gerekli işlemler tamamlanmış durumda.
            Cancelled, //(İptal Edildi): Düzeltme isteği kullanıcı veya sistem tarafından iptal edilmiş durumda.
            InProgress,//(Devam Ediyor): Düzeltme isteği üzerinde işlemler devam ediyor durumda.
        }
    }
}
