Flappy Bird Clone
Bu depo, popüler mobil oyun Flappy Bird'ün bir kopyası olan 2D bir oyunun kaynak kodunu içerir. Oyun, bir kuşu kontrol ederek engelleri aştığınız ve olabildiğince yükseğe uçmaya çalıştığınız basit ama bağımlılık yapan bir oyundur.

Özellikler:

Kuş hareket kontrolü (fare tıklaması, boşluk tuşu veya dokunmatik ekran dokunuşu)
Engelleri aşma
Puanlama sistemi (dahil değildir, ancak kolayca uygulanabilir)
Çarpışma algılama ve oyun sonu durumu
Ses efektleri (çırpma kanatları, çarpışma sesi)
Basit animasyon (dahil değildir, ancak kolayca uygulanabilir)
Gereklilikler:

Unity game engine (herhangi bir sürüm)
Kurulum:

Unity'yi bilgisayarınıza indirin ve yükleyin.
Bu deponun kaynak kodlarını bilgisayarınıza indirin.
Unity'yi açın ve yeni bir 2D proje oluşturun.
Proje klasörünüze gidin ve "Assets" klasörünü bulun.
İndirdiğiniz kaynak kodlarını "Assets" klasörüne kopyalayın.
Unity editöründe, oyun hiyerarşisinde "BirdController" scriptini bulun ve onu kuş oyun objenize ekleyin.
Oynanış:

Oyunu çalıştırdığınızda, kuşu fare tıklaması, boşluk tuşu veya dokunmatik ekran dokunuşuyla kontrol edebilirsiniz.
Kuş yukarı doğru hareket edecek ve engelleri aşmaya çalışmanız gerekiyor.
Engellere çarpmak oyunu bitirir.
Kod Açıklaması:

BirdController script'i kuşun hareketini, çarpışma algılamayı, ses efektlerini ve basit rotasyonu kontrol eder.
Script içerisinde kuşun yukarı doğru itme kuvveti, dönüş değerleri, sınırlamalar ve animatör gibi değişkenler tanımlanmıştır.
Update fonksiyonu kuşun konumunu ve rotasyonunu her frame günceller.
PushUp fonksiyonu kuşa yukarı doğru itme kuvveti uygular ve rotasyonunu ayarlar.
OnCollisionEnter2D fonksiyonu çarpışma algılama işlemini gerçekleştirir ve oyunu sonlandırır.
StayOnBorders fonksiyonu kuşu oyun sınırları içerisinde tutar.
Lisans:

Bu kod [Lisans seçin ve ekleyin] lisansı ile lisanslanmıştır.

Not:

Bu kod eğitim amaçlıdır ve ticari amaçlarla kullanılamaz. Kod yorumları İngilizce değildir, ancak script anlaşılması için yeterli düzeydedir. Oyun tamamlanmamıştır, ancak temel mekanikler çalışmaktadır. Puanlama sistemi ve animasyon gibi özellikleri kendiniz ekleyebilirsiniz.
