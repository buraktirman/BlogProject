namespace Blog.Web.ResultMessages
{
    public class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklendi.";
            }
            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellendi.";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silindi.";
            }
        }

        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla eklendi.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla güncellendi.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla silindi.";
            }
        }

        public static class User
        {
            public static string Add(string userEmail)
            {
                return $"{userEmail} email adresli kullanıcı başarıyla eklendi.";
            }
            public static string Update(string userEmail)
            {
                return $"{userEmail} email adresli kullanıcı başarıyla güncellendi.";
            }
            public static string Delete(string userEmail)
            {
                return $"{userEmail} email adresli kullanıcı başarıyla silindi.";
            }
        }
    }
}
