﻿var IslemSonucTurleri =
{
    Basarili: "BAŞARILI",
    Hata: "HATA",
    Uyari: "UYARI",
    Bilgi: "BİLGİ"
};

var IslemSonucKodlari =
{
    Basarili: 1,
    Hata: 2,
    Uyari: 3,
    Bilgi: 4
};

function ModalBilgilendirme(baslik, aciklama) {
    $("#MdlBaslik").text(baslik);
    $("#MdlAciklama").text(aciklama);
    ModalGoster("MdlBilgilendirme");
}

function ModalGoster(modalId) {
    $("#" + modalId).modal("show");
}

function ModalKapat(modalId) {
    $("#" + modalId).modal("hide");
}

function KullaniciGiris() {

    try {


        var kkodu = $("#KullaniciKodu").val();
        var psw = $("#Parola").val();

        if (kkodu === "") {
            ModalBilgilendirme("UYARI", "Kullanıcı Kodu Boş Geçilemez.");
            return false;
        }
        if (psw === "") {
            ModalBilgilendirme("UYARI", "Parola Boş Geçilemez.");
            return false;
        }

        $.ajax({
            type: "POST",
            url: "/Kullanici/KullaniciGiris",
            content: "application/json;",
            dataType: 'json',
            data: $('#FrmKullaniciGiris').serialize(),
            async: true,
            success: function (data) {

                console.log(data);

                if (data.IslemKodu === 1) {
                    window.location.href = "../Anasayfa/Index"

                }
                else if (data.IslemKodu === 2) {
                    ModalBilgilendirme(IslemSonucTurleri.Hata, data.Aciklama);
                }
            },
            error: function (ex) {
                ModalBilgilendirme(IslemSonucTurleri.Hata, data.Aciklama);
            }
        });
    } catch (e) {
        console.log("Hata : " + e);
    }
}
