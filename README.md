📌 Proje Özellikleri
🔐 Kullanıcı Girişi ve Yetkilendirme

Rol bazlı giriş sistemi

Admin

Çağri Personeli

Destek Personel

Kullanıcının rolüne göre erişilebilir ekranlar / işlemler kısıtlanır

Kullanıcı adı & şifre kontrolü ile güvenli giriş

👥 Müşteri Yönetimi

Müşteri ekleme / güncelleme / silme

İletişim bilgileri takibi (telefon, e-posta vb.)

Müşteri ile ilişkilendirilen talep ve hizmet geçmişi

DataGridView üzerinden listeleme ve seçim yapabilme

🧑‍💼 Personel Yönetimi

Personel ekleme / güncelleme / silme

Personel rolü / uzmanlık alanı tanımlama

Taleplere personel atama (işin sorumlusu)

Personel bazlı işlem takibi 

🛎️ Hizmet Yönetimi

Hizmet ekleme / güncelleme / silme

Hizmet açıklaması ve fiyat bilgileri

Taleplerle entegre çalışma (talep oluştururken hizmet seçimi)

📄 Talep Yönetimi (İş Emri Süreci)

Müşteri ve hizmet seçimi ile talep oluşturma

Talep türü ve durum takibi

Örn: Yeni / İşlemde / Tamamlandı

Personel atama

Tarih bazlı kayıt (oluşturma tarihi, güncelleme vb.)

(Varsa) talep üzerinden satış/hizmet işlem kaydı mantığı

📊 Raporlama ve Dashboard

Tarih aralığına göre filtreleme

Durum bazlı (Yeni/İşlemde/Tamamlandı) raporlama

Hizmet bazlı raporlama

DataGridView ile rapor listeleme

İşletme performansını analiz etmeye yönelik özet ekranlar

📐 Mimari Yapı (N-Tier Architecture)

Proje katmanlı mimari kullanılarak geliştirilmiştir:

UI (User Interface)
Windows Forms arayüzleri (Form ekranları, DataGridView, ComboBox, Chart vb.)

BLL / Service (Business Logic Layer)
İş kuralları, doğrulamalar, durum kontrolleri, ekranların çağırdığı metotlar

DAL / DAO (Data Access Layer)
MySQL veritabanı işlemleri (CRUD), sorgular, bağlantı yönetimi

Domain / Entities
Veri modelleri (Customer, Staff, Service, Request/Talep vb.)

Bu yapı sayesinde UI tarafı doğrudan SQL yazmaz; tüm süreç Service ve DAO üzerinden ilerler.

📂 Proje Yapısı
CRMProjesi
│
├── CRMProjesi.UI         → Windows Forms arayüzleri
├── CRMProjesi.BLL        → İş mantığı (Service katmanı)
├── CRMProjesi.DAL        → Veritabanı işlemleri (DAO katmanı)
├── CRMProjesi.Domain     → Veri modelleri (Entities)
│
├── App.config            → MySQL bağlantı ayarları
├── Program.cs            → Uygulama başlangıç noktası
└── CRMProjesi.sln

🛠️ Kullanılan Teknolojiler

Programlama Dili: C# (.NET Framework)

Arayüz: Windows Forms

Veritabanı: MySQL (phpMyAdmin)

Mimari: N-Katmanlı Mimari (UI / BLL / DAL / Domain)

Veri İşleme: DataTable 

Versiyon Kontrol: Git & GitHub

🚀 Kurulum ve Çalıştırma
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

🎯 Projenin Amaçları

✅ Müşteri ve hizmet süreçlerini dijitalleştirmek

✅ İşletme içi iş akışını düzenlemek

✅ Manuel hataları azaltmak

✅ Gerçek hayata uygun kurumsal bir CRM/Talep sistemi geliştirmek

✅ N-Katmanlı mimariyi uygulamalı öğrenmek

👤 Geliştirici

Ad Soyad: Dilek Tombul 
Üniversite: Bursa Uludağ Üniversitesi

Bölüm: Yönetim Bilişim Sistemleri

🎥 Video

https://youtu.be/ddcExJbLC-A

📌 Not

Bu proje eğitim ve akademik amaçlarla geliştirilmiştir.
