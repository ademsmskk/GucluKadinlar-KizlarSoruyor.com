public static class MessageGenarator
{
    public static readonly Dictionary<ResponseCodeEnum, string> ResponseMessages
        = new Dictionary<ResponseCodeEnum, string>
    {

         { ResponseCodeEnum.Success, "Ok" },
         {ResponseCodeEnum.OperationFail,"Yapılmak istenen İşlemde Hata Oluştu"},

//Account
        { ResponseCodeEnum.GetAllAccountOperationSuccess,"Tüm Hesaplar Başarılı Bir Şekilde Getirildi" },
        {ResponseCodeEnum.GetAllAccountOperationFail,"Tüm Hesaplar Getirilirken Hata Oluştu"},
        {ResponseCodeEnum.DuplicateAccountError,"Girilen e mail sistemde kayıtlı" },
        {ResponseCodeEnum.GetAccountByEmailOperationSuccess,"Girilen maile sahip account başarılı bir şekilde bulundu."},
        {ResponseCodeEnum.GetAccountByEmailOperationFail,"Girilen maile sahip account bulunamadı"},
        {ResponseCodeEnum.UpdateAccountByEmailSuccess,"Email Başarılı Bir Şekilde Güncellendi"},
        {ResponseCodeEnum.UpdateAccountByEmailOperationFail,"Email Güncelleme Hatalı"},
        {ResponseCodeEnum.UpdateAccountPasswordSuccess,"Şifre Başarılı Bir Şekilde Güncellendi"},
        {ResponseCodeEnum.UpdateAccountPasswordOperationFail,"Şifre Güncellenemedi,Eski Şifre Hatalı."},
        {ResponseCodeEnum.AccountBlockSuccess,"Hesap Engelleme Başarılı."},
        {ResponseCodeEnum.AccountBlockOperationFail,"Hesap Engelleme Başarısız."},
        {ResponseCodeEnum.AccountCreateSuccess,"Hesap Oluşturma Başarılı."},
        {ResponseCodeEnum.AccountCreateOperationFail,"Hesap Oluşturma Başarısız."},
        {ResponseCodeEnum.ChangeVisibilityOfAccountSuccess,"Hesap Görünürlüğünü Değiştirme Başarılı."},
        {ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail,"Hesap Görünürlüğünü Değiştirme Başarısız."},


//Category

        {ResponseCodeEnum.GetAllCategoryOperationSuccess,"Tüm Kategoriler Başarılı Bir Şekilde Getirildi."},
        {ResponseCodeEnum.GetAllCategoryOperationFail,"Tüm Kategoriler Getirilirken Hata Oluştu"},
        {ResponseCodeEnum.GetAccountByNameOperationSuccess,"İsime Göre Kategori Başarılı Bir Şekilde Getirildi."},
        {ResponseCodeEnum.GetAccountByNameOperationFail,"İsime Göre Kategori Getirilirken Bir Hata İle Karşılaşıldı."},
        {ResponseCodeEnum.CategoryCreateSuccess,"Kategori Oluşturma Başarılı."},
        {ResponseCodeEnum.CategoryCreateOperationFail,"Kategori Oluşturma Hatalı."},
        {ResponseCodeEnum.CategoryDeleteSuccess,"Kategori Silme Başarılı."},
        {ResponseCodeEnum.CategoryDeleteOperationFail,"Kategori Silme Başarısız."},
        {ResponseCodeEnum.CategoryUpdateSuccess,"Kategori Güncelleme Başarılı."},
        {ResponseCodeEnum.CategoryUpdateOperationFail,"Kategori Güncelleme Başarısız."},
        {ResponseCodeEnum.DuplicateCategoryError,"Kategori Eklenme Başarısız,Eklenen Kategori Mevcut."},
//Comment
        { ResponseCodeEnum.CommentCreateOperationFail,"Yorum Oluşturma Başarısız." },
        {ResponseCodeEnum.CommentDeleteOperationFail,"Yorum Silme Başarısız."},
        {ResponseCodeEnum.GetCommentByIdOperationFail,"Yorum Getirme İşlemi Başarısız"},
        {ResponseCodeEnum.CommentUpdateSuccess,"Yorum Güncelleme Başarılı."},
        {ResponseCodeEnum.CommentUpdateOperationFail,"Yorum Güncelleme Başarısız"},
        {ResponseCodeEnum.CommentLikeUpdateOperationFail,"Yorum Beğeni Sayısı Güncelleme Başarısız."},
//Title        
        {ResponseCodeEnum.GetAllTitleOperationSuccess,"Tüm Başlıkları Getirme Başarılı."},
        {ResponseCodeEnum.GetAllTitleOperationFail,"Başlık Getirme Hatalı"},
        {ResponseCodeEnum.TitleCreateSuccess,"Başlık Oluşturma Başarılı."},
        {ResponseCodeEnum.DuplicateTitleError,"Başlık Oluşturma Başarısız Eklenmek istenen Başlık Mevcut"},
        {ResponseCodeEnum.TitleCreateOperationFail,"Başlık Oluşturma Başarısız"},
        {ResponseCodeEnum.TitleDeleteOperationFail,"Başlık Silme Başarısız"},
        {ResponseCodeEnum.TitleUpdateOperationFail,"Başlık Güncelleme Başarısız."},
        {ResponseCodeEnum.GetTitleByNameOperationFail,"İsime Göre Başlık Getirilirken Hata Oluştu."},
//Roles 
        { ResponseCodeEnum.RoleOperationFail,"Rol işlemi Hatalı"},
        {ResponseCodeEnum.DuplicateRoleError,"Rol işlemi Hatalı,Eklenmek İstenen Rol Mevcut"},
//Users 
        {ResponseCodeEnum.DuplicateUserError,"Geçersiz Kullanıcı Adı,Kullanıcı Adı Kullanılmaktadır."},
        {ResponseCodeEnum.UserUpdateOperationFail,"Kullanıcı Güncelleme Başarısız"},
        {ResponseCodeEnum.GetUserByUserNameFail,"Girilen Kullanıcı İsmine Ait Bir Kullanıcı Bulunmamaktadır."},
//Post        
        {ResponseCodeEnum.PostOperationFail,"Gönderi İşlemi Sırasında Hata Oluştu."},
        {ResponseCodeEnum.PostDeleteSuccess,"Post Silme Başarılı"},
        {ResponseCodeEnum.PostDeleteOperationFail,"Post Silme Başarısız."},

    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return ResponseMessages[ResponseCode];
    }

}