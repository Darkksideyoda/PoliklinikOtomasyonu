using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliklinikOtomasyonu
{
    class HastaBilgileri
    {


        string _TC;
        public string hastaTC
        {
            get { return _TC; }
            set { _TC = value; }
        }
        /////////////////////////////////

        string _ad;
        public string hastaAdi
        {
            get { return _ad; }
            set { _ad = value; }
        }
        /////////////////////////////////

        string _soyad;
        public string hastaSoyadi
        {
            get { return _soyad; }
            set { _soyad = value; }    
        }

        /////////////////////////////////

        string _dogumyeri;

        public string hastaDogumyeri
        {
            get { return _dogumyeri; }
            set { _dogumyeri = value; }
        }
        /////////////////////////////////

        string _dogumtarihi;
        public string hastaDogumtarihi
        {
            get { return _dogumtarihi; }
            set { _dogumtarihi = value; }
        }
        /////////////////////////////////

        string _cinsiyet;
        public string hastaCinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }

        /////////////////////////////////

        string _sosyalGuvenceTuru;
        public string hastaSosyalGuvenceturu
        {
            get { return _sosyalGuvenceTuru; }
            set { _sosyalGuvenceTuru = value; }
        }

        /////////////////////////////////

        string _sosyalGuvenceNo;

        public string hastaSosyalguvenceNO
        {
            get { return _sosyalGuvenceNo; }
            set { _sosyalGuvenceNo = value; }
        }

        /////////////////////////////////

        string _kangrubu;
        public string hastaKangrubu
        {
            get { return _kangrubu; }
            set { _kangrubu = value; }
        }
        /////////////////////////////////

        string _telefon;
        public string hastaTelefon
        {
            get { return _telefon; }
            set { _telefon = value; }
            }
        /////////////////////////////////
        string _Eposta;

        public string hastaEposta
        {
            get { return _Eposta; }
            set { _Eposta = value; }
        }

        /////////////////////////////////

        string _hastaKayitNo;

        public string hastaKayitNO
        {
            get { return _hastaKayitNo; }
            set { _hastaKayitNo = value; }
        }

        /////////////////////////////////
        string _hastaNo;

        public string hastaNo
        {
            get { return _hastaNo; }
            set { _hastaNo = value; }
        }

        /////////////////////////////////


    }

    class muayneBilgileri : HastaBilgileri
    {


        int _ates;
        public int hastaAtesi
        {
            get { return _ates; }
            set { _ates = value; }
        }
        /////////////////////////////////
        int _kilo;
        public int hastaKilo
        {
            get { return _kilo; }
            set { _kilo = value; }
        }

        /////////////////////////////////

        int _boy;

        public int hastaBoy
        {
            get { return _boy; }
            set { _boy = value; }
        }
        /////////////////////////////////
        int _nabiz;

        public int hastaNabiz
        {
            get { return _nabiz; }
            set { _nabiz = value; }
        }
        /////////////////////////////////
        int _buyukTansiyon;
        public int tansiyonBuyuk
        {
            get { return _buyukTansiyon; }
            set { _buyukTansiyon = value; }
        }
        /////////////////////////////////
        int _kucukTansiyon;
        public int tansiyonKucuk
        {
            get { return _kucukTansiyon; }
            set { _kucukTansiyon = value; }
        }

        /////////////////////////////////
        string _hikaye;
        public string hastaHikayesi
        {
            get { return _hikaye; }
            set { _hikaye = value; }
        }
        /////////////////////////////////
        string _bulgu;
        public string hastaBulgulari
        {
            get { return _bulgu;}
            set { _bulgu = value; }
        }
        /////////////////////////////////
        string _karar;
        public string hastaKarar
        {
            get { return _karar; }
            set { _karar = value; }
        }
        
        /////////////////////////////////
        
        string _tani;

        public string hastaTanisi
        {
            get { return _tani; }
            set { _tani = value; }
        }

        /////////////////////////////////

        string _tetkik;

        public string hastaTetkik
        {
            get { return _tetkik; }
            set { _tetkik = value; }
        }

        /////////////////////////////////

        string _lab;

        public string hastaLab
        {
            get { return _lab; }
            set { _lab = value; }
        }

        /////////////////////////////////

        string _muayneTarih;

        public string hastaMuayneTarihi
        {
            get { return _muayneTarih; }
            set { _muayneTarih = value; }
        }
        /////////////////////////////////
        string _muaynePersonel;

        public string hastaMuaynePersonel
        {
            get { return _muaynePersonel; }
            set { _muaynePersonel = value; }
        }
        /////////////////////////////////

        string _saat;

        public string muayneSaat
        {
            get { return _saat; }
            set { _saat = value; }
        }



    }




}
