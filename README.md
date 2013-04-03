Chipbox HD Uydu Al�c�s� Yedekleme ve Kontrol Yaz�l�mlar�
========================================================

Bu proje, Hiremco Chipbox HD model ARM Linux tabanl� uydu al�c�s�na FTP ve Telnet arabirimi �zerinden ba�lanarak cihazdaki bilgileri yedeklemeyi ve cihaz� kumanda etmeyi sa�lar. Programlar Visual Studio 2012 t�mle�ik geli�tirme ortam� kullan�larak C# 4.0 programlama dili ile yaz�lm��t�r.

Proje de iki temel yaz�l�m mevcuttur. Bunlar, yedekleme ve kumanda yaz�l�mlar�d�r. A�a��da her bir program�n detayl� a��klamas� verilmi�tir.

Chipbox HD Normal ve IPTV Kanal Listesi Yedekleme/Geri Y�kleme Yaz�l�m�
-----------------------------------------------------------------------
Program aray�z�nde Chipbox ba�lant� bilgileri ekran�na cihaz�n IP adresi ve Telnet/FTP kullan�c� ad� ve �ifre bilgisi girildikten sonra IPTV ve normal kanal listesi i�in ayr� ayr� yedekleme butonlar� kullan�larak yedekleme yap�labilir. Yedeklemeler, program�n .exe dosyas�n�n oldu�u klas�rde .exe dosyas� ile ayn� isimde bir klas�r olu�turularak, klas�r�n i�ine yap�lmaktad�r. IPTV ve normal kanal listeleri ayr� klas�rlere ve dosya isimleri de tarih damgal� olarak yedeklenmektedir. Yedekleme i�lemi tamamlan�nca olu�turulan dosyan�n tam yolu mesaj kutusu arac�l���yla g�sterilmektedir.

* Program aray�z� a�a��da g�r�lebilir.
![Program Aray�z�](ChipboxKanalYedek1.png)

* Program�n i�indeki yard�m ekran� kullan�m ile ilgili temel bilgileri i�ermektedir.
![Yard�m Ekran�](ChipboxKanalYedek2.png)

Program her kapan��ta son kay�tl� ayarlar� bir sonraki a��l��ta hat�rlamak �zere kaydeder.

Program, FTP eri�imi i�in [System.Net.FtpClient](http://netftp.codeplex.com/) harici k�t�phanesini kullanmaktad�r. Bunun amac� .NET BCL de bulunan FTP eri�im k�t�phanesinden daha h�zl� ve kararl� �al��mas�d�r.

Program ile ilgili olarak, uydu al�c�lar� ve teknolojileri konsunda T�rkiye'deki en b�y�k forum olan TurkeyForum'daki ba�l��a [bu ba�lant�](http://www.turkeyforum.com/satforum/showthread.php?t=694992)dan ula��labilir.

Chipbox HD Mini Kumanda
-----------------------
Mini kumandan�n temel amac�, Chipbox HD uydu al�c�s�na temel uzaktan kumanda kontrollerini g�ndermektir. Bunu yaparken de aray�z tasar�m�nda en k���k alan ile en etkili kullan�m� ama�lamaktad�r. Program�n, a��ld���nda herhangi bir g�rsel aray�z� bulunmamaktad�r. Sadece g�rev �ubu�unda ki simge aktif olur ve ba�lant� durumunu belirten bir bilgi balonu g�r�n�r.

Program cihaza ba�lanmak i�in uydu al�c�ya Telnet (TCP) ba�lant�s� yapar. Ayr�ca olas� ba�lant� kopmas� durumunda otomatik olarak tekrar ba�lanacak �ekilde programlanm��t�r.

Program simgesine sol t�klayarak program aray�z�ne, sa� t�klayarak ise ayar men�s�ne eri�ilmektedir. Program aray�z�n�n kapanmas� i�in aray�ze t�kland�ktan sonra ekranda herhangi ba�ka bir noktaya t�klamak yeterlidir. Program�n aray�z�nde uydu al�c�n�n temel kontrol tu�lar� vard�r, bunlar: A�a��, yukar�, sola, sa�a, kapat, sessiz, men� ve ��k�� tu�lar�d�r. Ayar men�s�nde ise IP adresi giri� kutusu, ba�lant� ve otomatik a��l�� se�enekleri vard�r. Ba�lant� ve otomatik a��l�� butonlar�n�n yan�nda durumlar�na g�re (ba�l� ise ya da otomatik a��l�� devrede ise) onay i�areti g�r�nmektedir. IP adresi ve di�er se�imler program kapan�rken kaydedilerek bir sonraki a��l��ta tekrar y�klenir.

Ayr�ca, kullan�m kolayl��� i�in program�n aray�z�ne ula�madan, herhangi bir anda klavye k�sayollar�n� kullanarak cihaza komutlar g�ndermek m�mk�nd�r. Klavyeden Alt + [Y�n tu�lar�] kullan�larak cihaza kumandadaki y�n tu�lar� komutlar� (sol-sa�: ses kontrol�, a�a��-yukar�: kanal de�i�tirme) oldu�u gibi h�zl�ca g�nderilebilir. Bu �zelli�i sa�lamak i�in Win32 API'sini kullanan harici [System Hotkey Component](http://www.codeproject.com/Articles/3055/System-Hotkey-Component) k�t�phanesi kullan�lm��t�r.

A�a��da program�n �rnek aray�z� mevcuttur.

* Program aray�z� ve hakk�nda ekran� birlikte g�r�nmekte.

![Program Aray�z� ve Yard�m Ekran�](ChipboxKumanda1.png)

* Simgeye sa� t�k yap�nca a��lan ayar ekran�:

![Program Ayar Men�s�](ChipboxKumanda2.png)

Program ile ilgili olarak, uydu al�c�lar� ve teknolojileri konsunda T�rkiye'deki en b�y�k forum olan TurkeyForum'daki ba�l��a [bu ba�lant�](http://www.turkeyforum.com/satforum/showthread.php?t=694928)dan ula��labilir.

