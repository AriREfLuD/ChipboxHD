Chipbox HD Uydu Alýcýsý Yedekleme ve Kontrol Yazýlýmlarý
========================================================

Bu proje, Hiremco Chipbox HD model ARM Linux tabanlý uydu alýcýsýna FTP ve Telnet arabirimi üzerinden baðlanarak cihazdaki bilgileri yedeklemeyi ve cihazý kumanda etmeyi saðlar. Programlar Visual Studio 2012 tümleþik geliþtirme ortamý kullanýlarak C# 4.0 programlama dili ile yazýlmýþtýr.

Proje de iki temel yazýlým mevcuttur. Bunlar, yedekleme ve kumanda yazýlýmlarýdýr. Aþaðýda her bir programýn detaylý açýklamasý verilmiþtir.

Chipbox HD Normal ve IPTV Kanal Listesi Yedekleme/Geri Yükleme Yazýlýmý
-----------------------------------------------------------------------
Program arayüzünde Chipbox baðlantý bilgileri ekranýna cihazýn IP adresi ve Telnet/FTP kullanýcý adý ve þifre bilgisi girildikten sonra IPTV ve normal kanal listesi için ayrý ayrý yedekleme butonlarý kullanýlarak yedekleme yapýlabilir. Yedeklemeler, programýn .exe dosyasýnýn olduðu klasörde .exe dosyasý ile ayný isimde bir klasör oluþturularak, klasörün içine yapýlmaktadýr. IPTV ve normal kanal listeleri ayrý klasörlere ve dosya isimleri de tarih damgalý olarak yedeklenmektedir. Yedekleme iþlemi tamamlanýnca oluþturulan dosyanýn tam yolu mesaj kutusu aracýlýðýyla gösterilmektedir.

* Program arayüzü aþaðýda görülebilir.
![Program Arayüzü](ChipboxKanalYedek1.png)

* Programýn içindeki yardým ekraný kullaným ile ilgili temel bilgileri içermektedir.
![Yardým Ekraný](ChipboxKanalYedek2.png)

Program her kapanýþta son kayýtlý ayarlarý bir sonraki açýlýþta hatýrlamak üzere kaydeder.

Program, FTP eriþimi için [System.Net.FtpClient](http://netftp.codeplex.com/) harici kütüphanesini kullanmaktadýr. Bunun amacý .NET BCL de bulunan FTP eriþim kütüphanesinden daha hýzlý ve kararlý çalýþmasýdýr.

Program ile ilgili olarak, uydu alýcýlarý ve teknolojileri konsunda Türkiye'deki en büyük forum olan TurkeyForum'daki baþlýða [bu baðlantý](http://www.turkeyforum.com/satforum/showthread.php?t=694992)dan ulaþýlabilir.

Chipbox HD Mini Kumanda
-----------------------
Mini kumandanýn temel amacý, Chipbox HD uydu alýcýsýna temel uzaktan kumanda kontrollerini göndermektir. Bunu yaparken de arayüz tasarýmýnda en küçük alan ile en etkili kullanýmý amaçlamaktadýr. Programýn, açýldýðýnda herhangi bir görsel arayüzü bulunmamaktadýr. Sadece görev çubuðunda ki simge aktif olur ve baðlantý durumunu belirten bir bilgi balonu görünür.

Program cihaza baðlanmak için uydu alýcýya Telnet (TCP) baðlantýsý yapar. Ayrýca olasý baðlantý kopmasý durumunda otomatik olarak tekrar baðlanacak þekilde programlanmýþtýr.

Program simgesine sol týklayarak program arayüzüne, sað týklayarak ise ayar menüsüne eriþilmektedir. Program arayüzünün kapanmasý için arayüze týklandýktan sonra ekranda herhangi baþka bir noktaya týklamak yeterlidir. Programýn arayüzünde uydu alýcýnýn temel kontrol tuþlarý vardýr, bunlar: Aþaðý, yukarý, sola, saða, kapat, sessiz, menü ve çýkýþ tuþlarýdýr. Ayar menüsünde ise IP adresi giriþ kutusu, baðlantý ve otomatik açýlýþ seçenekleri vardýr. Baðlantý ve otomatik açýlýþ butonlarýnýn yanýnda durumlarýna göre (baðlý ise ya da otomatik açýlýþ devrede ise) onay iþareti görünmektedir. IP adresi ve diðer seçimler program kapanýrken kaydedilerek bir sonraki açýlýþta tekrar yüklenir.

Ayrýca, kullaným kolaylýðý için programýn arayüzüne ulaþmadan, herhangi bir anda klavye kýsayollarýný kullanarak cihaza komutlar göndermek mümkündür. Klavyeden Alt + [Yön tuþlarý] kullanýlarak cihaza kumandadaki yön tuþlarý komutlarý (sol-sað: ses kontrolü, aþaðý-yukarý: kanal deðiþtirme) olduðu gibi hýzlýca gönderilebilir. Bu özelliði saðlamak için Win32 API'sini kullanan harici [System Hotkey Component](http://www.codeproject.com/Articles/3055/System-Hotkey-Component) kütüphanesi kullanýlmýþtýr.

Aþaðýda programýn örnek arayüzü mevcuttur.

* Program arayüzü ve hakkýnda ekraný birlikte görünmekte.

![Program Arayüzü ve Yardým Ekraný](ChipboxKumanda1.png)

* Simgeye sað týk yapýnca açýlan ayar ekraný:

![Program Ayar Menüsü](ChipboxKumanda2.png)

Program ile ilgili olarak, uydu alýcýlarý ve teknolojileri konsunda Türkiye'deki en büyük forum olan TurkeyForum'daki baþlýða [bu baðlantý](http://www.turkeyforum.com/satforum/showthread.php?t=694928)dan ulaþýlabilir.

