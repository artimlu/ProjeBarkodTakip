-- phpMyAdmin SQL Dump
-- version 4.9.10
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost:3306
-- Üretim Zamanı: 21 May 2022, 12:46:21
-- Sunucu sürümü: 5.7.37
-- PHP Sürümü: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `wwwajan_barkod`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `Admin`
--

CREATE TABLE `Admin` (
  `id` int(11) NOT NULL,
  `isim` varchar(50) NOT NULL,
  `sifre` varchar(50) NOT NULL,
  `tc_no` varchar(12) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `Admin`
--

INSERT INTO `Admin` (`id`, `isim`, `sifre`, `tc_no`) VALUES
(1, 'Admin', '1234', '11111111111');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `calisan`
--

CREATE TABLE `calisan` (
  `c_id` int(11) NOT NULL,
  `c_isim` varchar(50) NOT NULL,
  `c_ist_id` int(11) NOT NULL,
  `c_bilgi` text NOT NULL,
  `c_yil` varchar(12) NOT NULL,
  `c_sifre` varchar(24) NOT NULL,
  `c_tc` varchar(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `calisan`
--

INSERT INTO `calisan` (`c_id`, `c_isim`, `c_ist_id`, `c_bilgi`, `c_yil`, `c_sifre`, `c_tc`) VALUES
(2, 'Ahmet Vardar', 5, 'adres: yunus emre mah. onbasi sok. 28/31 Sincan/Ankara', '1960', '1234', '23232323232'),
(3, 'mehmet çuhadar', 10, 'Tel: 0312 233 32 32 Mail: mehmet@aliserver.com', '1957', '1234', '77777777777'),
(4, 'Baris Akarsu', 7, 'Mail: a@a.com Tel: 0554 444 44 44', '1980', '1234', '15151515151'),
(5, 'Kadir Can', 4, 'Tel: 0532 555 55 55 Mail: bbb@bbb.com', '1990', '1234', '14141414141'),
(6, 'Fatih Bulus', 9, 'Tel: 0542 542 42 42 Mail: fff@gmail.com', '1999', '1234', '66666666666'),
(7, 'Hüseyin Taş', 2, 'Tel: 0555 555 55 55 Mail:ali@ali.com', '1.04.2022', '1234', '55555555555'),
(8, 'ahmet arif', 6, 'Tel: 0554 764 05 00\r\nMail: ahmeta@hotmail.com.tr', '1.04.2022', '1234', '22222222222'),
(9, 'Metin Çagri', 8, 'Tel: 0505 789 55 55 Mail:ali@ali.com', '2.04.2022', '1234', '33333333333'),
(10, 'Ahmet Mehmet', 7, 'Tel: 0555 765 55 55\r\nMail: ahmemehmet@gmail.com', '2.04.2022', '1234', '13131313131'),
(11, 'İlhan Şahin', 11, 'Ankara- 0555 555 4565', '15.05.2022', '1234', '88888888888'),
(17, 'Ahmet Albayrak', 13, 'Sincan-Ankara', '15.05.2022', '1234', '12121212121'),
(13, 'Fatih Rüştü', 13, '12', '15.05.2022', '1234', '98989898989'),
(18, 'çağrı can', 1, 'ankara', '17.05.2022', '1234', '44444444444'),
(19, 'metin yeşilbağ', 12, '3', '17.05.2022', '1234', '99999999999'),
(20, 'Emre Çiftçi', 3, 'Ankara-Etimesgut', '21.05.2022', '1234', '56565656565');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `depo`
--

CREATE TABLE `depo` (
  `d_id` int(11) NOT NULL,
  `d_urun` varchar(150) NOT NULL,
  `d_adet` int(11) NOT NULL,
  `d_tarih` varchar(10) NOT NULL,
  `d_aciklama` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `depo`
--

INSERT INTO `depo` (`d_id`, `d_urun`, `d_adet`, `d_tarih`, `d_aciklama`) VALUES
(2, 'Tornavida', 33, '4.04.2022', 'hernes marka'),
(3, 'Pense', 52, '5.04.2022', 'abc marka'),
(9, 'civata', 55, '17.05.2022', ''),
(6, 'Somun - 36\'lik', 500, '4.04.2022', '.'),
(5, 'ElektrikliTestere Ucu', 4, '4.04.2022', '.'),
(7, 'Matkap', 2, '4.04.2022', 'Dwans Marka. '),
(8, 'Spiral Tas', 3, '17.05.2022', '...'),
(11, 'aa', 111, '17.05.2022', 'aaa'),
(12, 'bbb', 6, '17.05.2022', 'afdasdsa'),
(13, 'asa', 5, '17.05.2022', '5');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giderler`
--

CREATE TABLE `giderler` (
  `gid_id` int(11) NOT NULL,
  `gid_isim` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `giderler`
--

INSERT INTO `giderler` (`gid_id`, `gid_isim`) VALUES
(5, 'Maas'),
(2, 'Elektrik'),
(3, 'Su'),
(4, 'Dogalgaz'),
(6, 'Akaryakıt');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `isler`
--

CREATE TABLE `isler` (
  `is_id` int(11) NOT NULL,
  `is_adi` varchar(255) NOT NULL,
  `is_barkod` varchar(60) NOT NULL,
  `is_durum` varchar(5) NOT NULL,
  `is_giris` varchar(30) NOT NULL,
  `is_tutar` int(11) NOT NULL,
  `is_mus` int(11) NOT NULL,
  `is_not` text NOT NULL,
  `is_urun` varchar(255) NOT NULL,
  `is_adet` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `isler`
--

INSERT INTO `isler` (`is_id`, `is_adi`, `is_barkod`, `is_durum`, `is_giris`, `is_tutar`, `is_mus`, `is_not`, `is_urun`, `is_adet`) VALUES
(5, 'ttt2', '3.3.04.2022105117', 'a', '4 Nisan 2022 Pazartesi', 1112, 5, '1112', '', 0),
(3, 'yeni is', '3.2.04.2022221512', 'a', '2 Nisan 2022 Cumartesi', 350000, 3, 'yen is not', '', 0),
(6, 'yeni is geldi', '4.4.04.2022180400', 'a', '4 Nisan 2022 Pazartesi', 5000, 4, 'is kayit', '', 0),
(7, '3000 adet L5 ürünü', '6.5.04.2022001017', 'a', '5 Nisan 2022 Sali', 50000, 6, '.', '', 0),
(8, '5000 adet c5 ', '4.17.04.2022001243', 'a', '17 Nisan 2022 Pazar', 40000, 4, '5000 adet c5 ', '', 0),
(9, 'AAA', '313.05.2022175710', 'a', '13 Mayis 2022 Cuma', 1111, 3, '1111\n\nHüseyin Tas:  sadsadsads ( 15.05.2022 16:04:27 ) ', '', 0),
(10, 'BBB', '413.05.2022180337', 'a', '13 Mayis 2022 Cuma', 222, 4, '222', '', 0),
(11, 'CCC', '113.05.2022181658', 'a', '13 Mayis 2022 Cuma', 1111, 1, 'CCC', '', 0),
(12, 'ddd', '113052022183514', 'a', '13 Mayis 2022 Cuma', 1111, 6, 'dddd\r\n\r\nAhmet Albayrak: YENİ İŞŞŞŞŞŞ ( 15.05.2022 22:04:16 ) \r\n\r\nAhmet Albayrak:  ER EWR WEREW REW R EWRWE  ER İŞİVLPVBFL PĞ  FG  S DF DSF DSF DS FDS F DSF SD FDS F SDFDS, DBÖNMSD SDSDFSD; . ( 15.05.2022 22:04:43 ) ', '', 0),
(13, 'eee', '1130522192509', 'b', '13 Mayis 2022 Cuma', 333, 6, '\r\n\r\nHüseyin Tas:ssss ( Hüseyin Tas - 15.05.2022 15:34:23 ) \r\n\r\nHüseyin Tas: yeni not ( Hüseyin Tas - 15.05.2022 15:51:08 ) \r\n\r\n ( mehmet çuhadar - 15.05.2022 15:54:02 ) \r\n\r\nHüseyin Tas: bbbb ( 15.05.2022 16:03:49 ) \r\nHüseyin Tas: aaaa ( 15.05.2022 16:11:20 ) \r\n\r\nmehmet çuhadar: yeni not girisis a ssa d sds d sdsa d s sdsadis g çsç isü dqa ( 15.05.2022 16:13:04 ) \r\n\r\nFatih Bulus: Kesme islemi yarin baslayacak... ( 15.05.2022 20:10:12 ) \r\n\r\nAhmet Albayrak: eeee ( 15.05.2022 21:31:15 ) \r\n\r\nAhmet Albayrak: e,e ( 15.05.2022 21:31:30 ) \r\n\r\nAhmet Albayrak: emere e rer ere r e r   şişpüğüğüğüğğ şlşilişklpop ıeorwer ıweır ewır weıorwepı r,ewjkjfklisdjfpısdujfpodufp uwır 08r9r7weuwepıjfipı jfpısdjf opıds ( 15.05.2022 21:31:37 ) ', '', 0),
(20, 'yeni sipariss', '3.15.05.2022225915', 'a', '15 Mayıs 2022 Pazar', 500000, 3, 'ürün falan filan 2  adet toplam 500.000 TL.Teslim tarihi: 03temmuz 2022 Güncelleme Sebebi: Teslim Tarihi degisti. adet:500 Güncelleme Sebebi: adet degisti', '', 0),
(21, 'L12 ürünü - Aselsan- 7 Ağustos ', '4.15.05.2022231208', 'a', '15 Mayıs 2022 Pazar', 700000, 4, 'ürün: L12 ürünü\r\nadet: 400\r\nFiyat: 700.000TL ', '', 0),
(22, 'cemre fiması ', '1170522114903', 'a', '17 Mayıs 2022 Salı', 5000, 8, 'emre cmre firmasına ait p15 kodlu üründen 200 adet', '', 0),
(23, 'Aselsan L5 ürünü 1000 adet', '4.17.05.2022122219', 'b', '17 Mayıs 2022 Salı', 30000, 4, 'L5 ÜRÜNÜ, 1000 ADET, teslim tarihi: 17 temmuz 2022 \r\n\r\nçağrı can: teknik resiim çizilip hammadde böşlümüne sevk gerçekleşti ( 17.05.2022 12:31:52 ) \r\n\r\nFatih Bulus: Kalıp hammade bekleniyor. (1 günlük gecikme) ( 17.05.2022 12:37:51 ) \r\n\r\nİlhan Şahin: aaaa ( 17.05.2022 12:40:02 ) \r\n\r\nAhmet Albayrak: Bekleme bölümü C Blok ( 17.05.2022 12:44:06 ) ', '', 0),
(24, 'Aselsan - L5 - 2000', '9180522003300', 'a', '18.05.2022', 30000, 4, 'iş teslimi: 31 Ağustos 2022', 'L5', 333),
(25, '111s', '9180522003915', 'a', '18.05.2022', 66662, 8, '...2', 'bbbs', 3332),
(26, 'emre çiftçi - emre555 - 50005', '9180522011655', 'a', '18.05.2022', 500005, 3, 'İş teslimi : 6 Ağustos 2022 Cumartesi - Bilgiler :5000 adet acil...5 --- Güncelleme Sebebi: 5Güncelleme Tarihi: 18.05.2022 00:00:54 --- --- Güncelleme Sebebi: adet arttı - Güncelleme Tarihi: 18.05.2022 00:06:29 ---', 'emre555', 50005),
(27, 'Havelsan - ek5 - 2000', '9180522012516', 'a', '18.05.2022', 20, 6, 'İş teslimi : 10 Temmuz 2022 Pazar - Bilgiler :iş acil...', 'ek5', 2000),
(28, 'id2', '1180522013542', 'a', '18.05.2022', 44002, 7, 'dd..2', 'üd2', 442);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `istasyon`
--

CREATE TABLE `istasyon` (
  `ist_id` int(11) NOT NULL,
  `ist_isim` varchar(120) NOT NULL,
  `ist_ac` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `istasyon`
--

INSERT INTO `istasyon` (`ist_id`, `ist_isim`, `ist_ac`) VALUES
(1, 'Teknik Resim', 'Ürünlerin 2 ve 3 Boyutlu çizimleri yapilarak, üretim alanina veren birimdir.'),
(2, 'Hammadde', 'Ürünün yapilacagi dogru malzemeyi temin eden birimdir.'),
(3, 'Muhasebe', 'Muhasebe isleri'),
(4, 'Satın Alma', 'Satin Alma'),
(5, 'Depo', 'Depo'),
(6, 'Satış ve Pazarlama', 'Satis ve Pazarlama'),
(7, 'İnsan Kaynakları', 'Insan Kaynaklari'),
(8, 'Kayıt', 'Kayit'),
(9, 'Kesme', 'Hammadde birminin getirdigi malzemeleri, teknik resime göre dogru boyutlarda keser.'),
(10, 'Kalıp İmalatı', 'Kesilen ürünlerin, hangi kalipta basılacagina karar veren birimdir. Eğer kalip yoksa, ürünün kalibi yapilir.'),
(11, 'Dövme', 'kesilmis malzemeler, siparis ürününe ait olan kaliplarda, uygun sicaklikta dövülür.'),
(12, 'İşleme', 'Dövülen Malzemeler için gerekli olan islemler CNC makineleri araciligiyla yapilir.'),
(13, 'Paket & Sevk', 'Islenen malzemeler, Kalite kontrolden geçtikten sonra paket islmei yapilir. Lojistik firmasinin gelmesiyle, sevk islemine geçilir.');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `muhasebe`
--

CREATE TABLE `muhasebe` (
  `muh_id` int(11) NOT NULL,
  `tarih` varchar(12) NOT NULL,
  `gelen` int(11) NOT NULL,
  `giden` int(11) NOT NULL,
  `gelen_kim` int(11) NOT NULL,
  `giden_kim` int(11) NOT NULL,
  `muh_not` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `muhasebe`
--

INSERT INTO `muhasebe` (`muh_id`, `tarih`, `gelen`, `giden`, `gelen_kim`, `giden_kim`, `muh_not`) VALUES
(9, '2022-05-17', 5000, 0, 9, 0, 'roketsan ödeme'),
(2, '2022-04-01', 1500, 0, 1, 0, 'ilk giris'),
(3, '2022-04-01', 2000, 0, 1, 0, '....'),
(4, '2022-04-01', 454545, 0, 1, 0, '12121212121'),
(6, '2022-04-01', 0, 5000, 0, 2, 'Elektrik Faturasi'),
(7, '2022-04-04', 50000, 0, 4, 0, 'aselsan ödeme'),
(8, '2022-04-04', 0, 60000, 0, 5, 'maas ödemeleri'),
(10, '2022-05-17', 0, 60000, 0, 5, 'maaş ödemeleri mayıs ayı'),
(11, '2022-05-17', 0, 2000, 0, 2, 'elektrik öedemi'),
(12, '2022-05-17', 90000, 0, 1, 0, 'megan satıldı'),
(13, '2022-05-17', 0, 50000, 0, 4, 'Doğalgaz Mayıs Ayı'),
(14, '2022-05-16', 0, 2000, 0, 3, 'su');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

CREATE TABLE `musteri` (
  `m_id` int(11) NOT NULL,
  `m_isim` varchar(100) NOT NULL,
  `m_mail` varchar(50) NOT NULL,
  `m_tel` varchar(20) NOT NULL,
  `m_adres` varchar(255) NOT NULL,
  `m_tarih` varchar(12) NOT NULL,
  `m_sifre` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`m_id`, `m_isim`, `m_mail`, `m_tel`, `m_adres`, `m_tarih`, `m_sifre`) VALUES
(1, 'Diğer', '0', '0', '0', '0', '0'),
(3, 'emre çiftçi', 'emre@emre.com', '05547640500', 'Sincan Ankara', '1.04.2022', '1234'),
(4, 'Aselsan', 'info@aselsan.com.tr', '0312 592 60 00', 'Mehmet Akif Ersoy Mahallesi Istiklal Marsi  Caddesi No: 16, 06200 Yenimahalle-Ankara, Türkiye', '1.04.2022', '1234'),
(6, 'Havelsan', 'info@havelsan.com.tr', '0312 312 22 22', 'Mustafa Kemal Mahallesi Sht. Ögrt. Senay Aybüke Yalçin Cad.', '4.04.2022', '1234'),
(7, 'İlhan Fatih', 'ilhan@metal.com.tr', '0312 312 31 32', 'Ankara', '15.05.2022', '1234'),
(8, 'emre cemre', 'cemreemre@emre.hotmail.com.tr', '03125567585', 'Ankara', '15.05.2022', '1234'),
(9, 'Roketsan', 'info@roketsan.com.tr', '0312 555 55 55', 'Ankara', '17.05.2022', '1234');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `satinalma`
--

CREATE TABLE `satinalma` (
  `s_id` int(11) NOT NULL,
  `s_urun` varchar(100) NOT NULL,
  `s_firma` varchar(120) NOT NULL,
  `s_ac` text NOT NULL,
  `s_fiyat` float NOT NULL,
  `s_tarih` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `satinalma`
--

INSERT INTO `satinalma` (`s_id`, `s_urun`, `s_firma`, `s_ac`, `s_fiyat`, `s_tarih`) VALUES
(1, 'çikolata2', 'ülker2', 'ülker\'den 113 adet metro, 115 adet albeni alinmistir...2', 300, '2022-04-01'),
(4, 'Matkap', 'Bosch', '1 adet Bosch marka ', 5000, '17.05.2022'),
(3, 'aaaa', 'bbbb', 'dadsadasdsa', 1111, '1.04.2022');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparis`
--

CREATE TABLE `siparis` (
  `si_id` int(11) NOT NULL,
  `si_ekleyen` int(11) NOT NULL,
  `si_baslangic` varchar(30) NOT NULL,
  `si_bitis` varchar(30) NOT NULL,
  `si_firma` int(11) NOT NULL,
  `si_bilgi` text NOT NULL,
  `si_okundu` int(11) NOT NULL,
  `si_adet` int(11) NOT NULL,
  `si_urun` varchar(255) NOT NULL,
  `si_fiyat` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `siparis`
--

INSERT INTO `siparis` (`si_id`, `si_ekleyen`, `si_baslangic`, `si_bitis`, `si_firma`, `si_bilgi`, `si_okundu`, `si_adet`, `si_urun`, `si_fiyat`) VALUES
(2, 8, '3 Nisan 20', '3 Haziran ', 3, 'ürün falan filan 2  adet toplam 500.000 TL.Teslim tarihi: 03temmuz 2022 Güncelleme Sebebi: Teslim Tarihi degisti. adet:500 Güncelleme Sebebi: adet degisti', 1, 0, '', 0),
(4, 8, '3 Nisan 2022 Pazar', '19 Agustos 2023 Cumartesi', 4, 'yeni siparisssssssssssss', 1, 0, '', 0),
(5, 8, '3 Nisan 2022 Pazar', '12 Haziran 2022 Pazar', 4, 'aaaa', 1, 0, '', 0),
(6, 8, '3 Nisan 2022 Pazar', '18 Haziran 2022 Cumartesi', 1, 'fiyat: 3000 , adet: 5000, ', 1, 0, '', 0),
(7, 8, '15 Mayıs 2022 Pazar', '7 Ağustos 2022 Pazar', 4, 'ürün: L12 ürünü\r\nadet: 400\r\nFiyat: 700.000TL --- Güncelleme Tarihi: 15.05.2022 23:04:21... Güncelleme Sebebi: adet ve fiyat değişti---', 1, 0, '', 0),
(8, 8, '17 Mayıs 2022 Salı', '17 Temmuz 2022 Pazar', 4, 'L5 ÜRÜNÜ, 1000 ADET, 30000 TL --- Güncelleme Tarihi: 17.05.2022 12:15:14... Güncelleme Sebebi: ADET YANLIŞ YAZILMIŞTI.---', 1, 0, '', 0),
(9, 8, '17 Mayıs 2022 Salı', '3 Temmuz 2022 Pazar', 3, 'L5,300 adet, 5000, FİRMA: EMRE ÇİFTÇİ', 1, 0, '', 0),
(10, 8, '17 Mayıs 2022 Salı', '30 Temmuz 2022 Cumartesi', 9, 'Firma: Roketsan\r\nÜrün: L5 ürünü\r\nAdet: 300\r\nFiyat: 50.000TL', 1, 0, '', 0),
(11, 8, '17 Mayıs 2022 Salı', '17 Ağustos 2022 Çarşamba', 7, 'Firma: İlhan Fatih\r\nÜrün: r5 \r\nAdet: 300\r\nFiyat: 50.000TL\r\nNot: iş 3 ay içinde teslim edilmeli', 1, 0, '', 0),
(12, 8, '17 Mayıs 2022 Salı', '10 Temmuz 2022 Pazar', 6, 'iş acil...', 1, 2000, 'ek5', 20),
(13, 8, '17 Mayıs 2022 Salı', '6 Ağustos 2022 Cumartesi', 3, '5000 adet acil...5 --- Güncelleme Sebebi: 5Güncelleme Tarihi: 18.05.2022 00:00:54 --- --- Güncelleme Sebebi: adet arttı - Güncelleme Tarihi: 18.05.2022 00:06:29 ---', 1, 50005, 'emre555', 500005);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `takip`
--

CREATE TABLE `takip` (
  `t_id` int(11) NOT NULL,
  `t_barkod` varchar(50) NOT NULL,
  `t_tarih` varchar(50) NOT NULL,
  `t_ist` varchar(50) NOT NULL,
  `t_calisan` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

--
-- Tablo döküm verisi `takip`
--

INSERT INTO `takip` (`t_id`, `t_barkod`, `t_tarih`, `t_ist`, `t_calisan`) VALUES
(1, '1', '1', '1', '1'),
(2, '32', '204', '0', '0'),
(3, '43', '304', '0', '0'),
(4, '3.3.04.2022105117', '3.04.2022 10:51:17', 'Kayit', 'Metin Çagri'),
(5, '4.4.04.2022180400', '4.04.2022 18:04:00', 'Kayit', 'Yönetici'),
(6, '6.5.04.2022001017', '5.04.2022 00:10:17', 'Kayit', 'Yönetici'),
(7, '4.17.04.2022001243', '17.04.2022 00:12:43', 'Kayit', 'Yönetici'),
(8, '313.05.2022175710', '13.05.2022 17:57:10', 'Kayit', 'Yönetici'),
(9, '413.05.2022180337', '13.05.2022 18:03:37', 'Kayit', 'Yönetici'),
(10, '113.05.2022181658', '13.05.2022 18:16:59', 'Kayit', 'Yönetici'),
(11, '113052022183514', '13.05.2022 18:35:14', 'Kayit', 'Yönetici'),
(12, '1130522192509', '13.05.2022 19:25:09', 'Kayit', 'Yönetici'),
(13, '1130522192509', '15.05.2022 14:09:46', 'Hammadde', 'Hüseyin Tas'),
(14, '3.2.04.2022221512', '15.05.2022 15:03:11', 'Hammadde', 'Hüseyin Tas'),
(15, '3.3.04.2022105117', '15.05.2022 15:11:30', 'Hammadde', 'Hüseyin Tas'),
(16, '1130522192509', '15.05.2022 15:53:54', 'Kalip', 'mehmet çuhadar'),
(17, '313.05.2022175710', '15.05.2022 16:04:23', 'Hammadde', 'Hüseyin Tas'),
(18, '1130522192509', '15.05.2022 20:09:56', 'Kesme', 'Fatih Bulus'),
(19, '1150522203934', '15.05.2022 20:39:34', 'Kayıt', 'Yönetici'),
(20, '1150522205852', '15.05.2022 20:58:53', 'Kayıt', 'Yönetici'),
(21, '1150522205911', '15.05.2022 20:59:11', 'Kayıt', 'Yönetici'),
(22, '1150522205949', '15.05.2022 20:59:49', 'Kayıt', 'Yönetici'),
(23, '1150522210000', '15.05.2022 21:00:00', 'Kayıt', 'Yönetici'),
(24, '1150522210010', '15.05.2022 21:00:10', 'Kayıt', 'Yönetici'),
(25, '1130522192509', '15.05.2022 21:21:00', 'Paket & Sevk', 'Ahmet Albayrak'),
(26, '113052022183514', '15.05.2022 22:04:13', 'Paket & Sevk', 'Ahmet Albayrak'),
(27, '3.15.05.2022225915', '15.05.2022 22:59:15', 'Kayıt', 'Metin Çagri'),
(28, '4.15.05.2022231208', '15.05.2022 23:12:08', 'Kayıt', 'Metin Çagri'),
(29, '1170522114903', '17.05.2022 11:49:03', 'Kayıt', 'Yönetici'),
(30, '4.17.05.2022122219', '17.05.2022 12:22:20', 'Kayıt', 'Metin Çagri'),
(31, '4.17.05.2022122219', '17.05.2022 12:29:49', 'Teknik Resim', 'çağrı can'),
(32, '4.17.05.2022122219', '17.05.2022 12:34:20', 'Hammadde', 'Hüseyin Taş'),
(33, '4.17.05.2022122219', '17.05.2022 12:37:47', 'Kesme', 'Fatih Bulus'),
(34, '4.17.05.2022122219', '17.05.2022 12:39:17', 'Kalıp İmalatı', 'mehmet çuhadar'),
(35, '4.17.05.2022122219', '17.05.2022 12:39:56', 'Dövme', 'İlhan Şahin'),
(36, '4.17.05.2022122219', '17.05.2022 12:40:46', 'İşleme', 'metin yeşilbağ'),
(37, '4.17.05.2022122219', '17.05.2022 12:41:35', 'Paket & Sevk', 'Ahmet Albayrak'),
(38, '9180522003300', '18.05.2022 00:33:00', 'Kayıt', 'Metin Çagri'),
(39, '9180522003915', '18.05.2022 00:39:15', 'Kayıt', 'Metin Çagri'),
(40, '9180522011655', '18.05.2022 01:16:55', 'Kayıt', 'Metin Çagri'),
(41, '9180522012516', '18.05.2022 01:25:17', 'Kayıt', 'Metin Çagri'),
(42, '1180522013542', '18.05.2022 01:35:42', 'Kayıt', 'Yönetici');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `Admin`
--
ALTER TABLE `Admin`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `calisan`
--
ALTER TABLE `calisan`
  ADD PRIMARY KEY (`c_id`);

--
-- Tablo için indeksler `depo`
--
ALTER TABLE `depo`
  ADD PRIMARY KEY (`d_id`);

--
-- Tablo için indeksler `giderler`
--
ALTER TABLE `giderler`
  ADD PRIMARY KEY (`gid_id`);

--
-- Tablo için indeksler `isler`
--
ALTER TABLE `isler`
  ADD PRIMARY KEY (`is_id`);

--
-- Tablo için indeksler `istasyon`
--
ALTER TABLE `istasyon`
  ADD PRIMARY KEY (`ist_id`);

--
-- Tablo için indeksler `muhasebe`
--
ALTER TABLE `muhasebe`
  ADD PRIMARY KEY (`muh_id`);

--
-- Tablo için indeksler `musteri`
--
ALTER TABLE `musteri`
  ADD PRIMARY KEY (`m_id`);

--
-- Tablo için indeksler `satinalma`
--
ALTER TABLE `satinalma`
  ADD PRIMARY KEY (`s_id`);

--
-- Tablo için indeksler `siparis`
--
ALTER TABLE `siparis`
  ADD PRIMARY KEY (`si_id`);

--
-- Tablo için indeksler `takip`
--
ALTER TABLE `takip`
  ADD PRIMARY KEY (`t_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `Admin`
--
ALTER TABLE `Admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `calisan`
--
ALTER TABLE `calisan`
  MODIFY `c_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Tablo için AUTO_INCREMENT değeri `depo`
--
ALTER TABLE `depo`
  MODIFY `d_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Tablo için AUTO_INCREMENT değeri `giderler`
--
ALTER TABLE `giderler`
  MODIFY `gid_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `isler`
--
ALTER TABLE `isler`
  MODIFY `is_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- Tablo için AUTO_INCREMENT değeri `istasyon`
--
ALTER TABLE `istasyon`
  MODIFY `ist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Tablo için AUTO_INCREMENT değeri `muhasebe`
--
ALTER TABLE `muhasebe`
  MODIFY `muh_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Tablo için AUTO_INCREMENT değeri `musteri`
--
ALTER TABLE `musteri`
  MODIFY `m_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Tablo için AUTO_INCREMENT değeri `satinalma`
--
ALTER TABLE `satinalma`
  MODIFY `s_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `siparis`
--
ALTER TABLE `siparis`
  MODIFY `si_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Tablo için AUTO_INCREMENT değeri `takip`
--
ALTER TABLE `takip`
  MODIFY `t_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
