 Proje Özellikleri
 Kullanıcı Girişi ve Yetkilendirme
 
 Rol bazlı giriş sistemi uygulanmıştır.
Sistemde üç farklı kullanıcı rolü bulunmaktadır:

Admin

Çağrı Personeli

Destek Personeli

Kullanıcının rolüne göre erişebileceği ekranlar ve işlemler sınırlandırılmıştır.

Kullanıcı adı ve şifre kontrolü ile güvenli giriş sağlanmaktadır.

 Müşteri Yönetimi

Müşteri ekleme, güncelleme ve silme işlemleri yapılabilmektedir.

Telefon, e-posta gibi iletişim bilgileri sistem üzerinden takip edilmektedir.

Müşteriye ait talep ve hizmet geçmişi görüntülenebilmektedir.

Kayıtlar DataGridView üzerinden listelenmekte ve seçilebilmektedir.

 Personel Yönetimi

Personel ekleme, güncelleme ve silme işlemleri yapılmaktadır.

Personellere rol ve uzmanlık alanı tanımlanabilmektedir.

Taleplere sorumlu personel atanabilmektedir.

Personel bazlı yapılan işlemler raporlamaya uygun şekilde takip edilmektedir.

Hizmet Yönetimi

Hizmet ekleme, güncelleme ve silme işlemleri yapılabilmektedir.

Hizmetlere ait açıklama ve fiyat bilgileri tanımlanmıştır.

Hizmetler, talep oluşturma sürecine entegre şekilde kullanılmaktadır.

 Talep Yönetimi (İş Emri Süreci)

Müşteri ve hizmet seçilerek talep oluşturma işlemi yapılmaktadır.

Talepler için durum takibi yapılmaktadır:

Yeni

İşlemde

Tamamlandı

Taleplere personel atanabilmektedir.

Talepler tarih bazlı olarak kayıt altına alınmaktadır.

Tarih bazlı kayıt (oluşturma tarihi, güncelleme vb.)



Raporlama ve Dashboard

Tarih aralığına göre filtreleme yapılabilmektedir.

Durum bazlı (Yeni / İşlemde / Tamamlandı) raporlar alınabilmektedir.

Hizmet bazlı raporlama yapılabilmektedir.

Raporlar DataGridView üzerinden listelenmektedir.

İşletme performansını analiz etmeye yönelik özet ekranlar bulunmaktadır.

 Mimari Yapı (N-Tier Architecture)

Proje katmanlı mimari kullanılarak geliştirilmiştir:

UI (User Interface)
Windows Forms arayüzleri (Form ekranları, DataGridView, ComboBox, Chart vb.)

BLL / Service (Business Logic Layer)
İş kuralları, doğrulamalar, durum kontrolleri, ekranların çağırdığı metotlar

DAL / DAO (Data Access Layer)
MySQL veritabanı işlemleri (CRUD), sorgular, bağlantı yönetimi

Domain / Entities
Veri modelleri (Customer, Staff, Service, Request/Talep vb.)

Bu yapı sayesinde UI tarafı doğrudan SQL yazmaz; tüm süreç Service ve DAL üzerinden ilerler.

 Kullanılan Teknolojiler

Programlama Dili: C# (.NET Framework)

Arayüz: Windows Forms

Veritabanı: MySQL (phpMyAdmin)

Mimari: N-Katmanlı Mimari (UI / BLL / DAL / Domain)

Veri İşleme: DataTable

Versiyon Kontrol: Git & GitHub

 Kurulum ve Çalıştırma
1) Projeyi Klonlayın
git clone https://github.com/Dilektmbl/CRM-Projesi

2) Visual Studio ile Açın

CRMProjesi.sln dosyasını açın

3) Veritabanı Bağlantı Ayarları

App.config içindeki MySQL bağlantı bilgilerini düzenleyin

4) Veritabanı Tabloları

MySQL üzerinde aşağıdaki tablolar oluşturuldu

kullanici

musteri

personel

hizmet

talep

 Projenin Amaçları

1) Müşteri ve hizmet süreçlerini dijitalleştirmek

2) İşletme içi iş akışını düzenlemek

 3) Manuel hataları azaltmak

4) Gerçek hayata uygun kurumsal bir CRM/Talep sistemi geliştirmek

5) N-Katmanlı mimariyi uygulamalı öğrenmek

Geliştirici

Ad Soyad: Dilek Tombul 
Üniversite: Bursa Uludağ Üniversitesi

Bölüm: Yönetim Bilişim Sistemleri

 Video

https://youtu.be/ddcExJbLC-A

Not

Bu proje eğitim ve akademik amaçlarla geliştirilmiştir.
