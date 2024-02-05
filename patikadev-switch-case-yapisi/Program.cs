namespace patikadev_switch_case_yapisi
{
    internal class Program
    {
        static string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ibanınızı tam bir şekilde giriniz.");
            string iban = Console.ReadLine(); // IBAN'ı değiştirin
            string trimmedIban = RemoveSpaces(iban);

            string bank_code_local = trimmedIban.Substring(4, 5);



            string bank_name;
            /*
                switch (bank_code_local)
                {
                    case "00001":
                        bank_name = "TC Merkez Bankası";
                        break;
                    case "00004":
                        bank_name = "İller Bankası";
                        break;
                    case "00010":
                        bank_name = "Ziraat Bankası";
                    break;
                    case "00012":
                        bank_name = "Halkbank";
                        break;
                    case "00015":
                        bank_name = "Vakıflar Bankası";
                        break;
                    case "00017":
                        bank_name = "Kalkınma Bankası";
                        break;
                    case "00029":
                        bank_name = "Birleşik Fon Bankası";
                        break;
                    case "00032":
                        bank_name = "Türk Ekonomi Bankası";
                        break;
                    case "00046":
                        bank_name = "Akbank";
                        break;
                    case "00059":
                        bank_name = "Şekerbank";
                        break;
                    case "00062":
                        bank_name = "Garanti Bankası";
                        break;
                    case "00064":
                        bank_name = "İş Bankası";
                        break;
                    case "00067":
                        bank_name = "Yapı ve Kredi Bankası";
                        break;
                    case "00099":
                        bank_name = "ING Bank";
                        break;
                    case "00100":
                        bank_name = "Adabank";
                        break;
                    case "00111":
                        bank_name = "Finansbank";
                        break;
                    case "00123":
                        bank_name = "HSBC";
                        break;
                    case "00132":
                        bank_name = "Takasbank";
                        break;
                    case "00134":
                        bank_name = "Denizbank";
                        break;
                    case "00135":
                        bank_name = "Anadolu Bank";
                        break;
                    case "00137":
                        bank_name = "Rabobank";
                        break;
                    case "00138":
                        bank_name = "Dilerbank";
                        break;
                    case "00139":
                        bank_name = "GSD Bank";
                        break;
                    case "00141":
                        bank_name = "Nurol Yatırım Bankası";
                        break;
                    case "00142":
                        bank_name = "Bankpozitif Kredi ve Kalkınma Bankası";
                        break;
                    case "00143":
                        bank_name = "Aktif Yatırım Bankası";
                        break;
                    case "00146":
                        bank_name = "Odea Bank";
                        break;
                    case "00147":
                        bank_name = "Bank of Tokyo-Mitsubishi UFJ Turkey";
                        break;
                    case "00203":
                        bank_name = "Albaraka Türk Katılım Bankası";
                        break;
                    case "00205":
                        bank_name = "Kuveyt Türk Katılım Bankası";
                        break;
                    case "00206":
                        bank_name = "Türkiye Finans Katılım Bankası";
                        break;
                    case "00209":
                        bank_name = "Ziraat Katılım Bankası";
                        break;
                    case "00210":
                        bank_name = "Vakıf Katılım Bankası";
                        break;
                    case "00806":
                        bank_name = "Merkezi Kayıt Kuruluşu";
                        break;
                    case "00109":
                        bank_name = "ICBC Turkey Bank";
                        break;
                    default:
                        bank_name = "Tespit edilemedi";
                        break;
                }*/

            switch (bank_code_local)
            {
                case "00001":
                    bank_name = "Türkiye Cumhuriyet Merkez Bankası A.Ş.";
                    break;
                case "00004":
                    bank_name = "İller Bankası";
                    break;
                case "00010":
                    bank_name = "Türkiye Cumhuriyeti Ziraat Bankası A.Ş.";
                    break;
                case "00012":
                    bank_name = "Türkiye Halk Bankası A.Ş.";
                    break;
                case "00013":
                    bank_name = "Denizbank";
                    break;
                case "00014":
                    bank_name = "Türkiye Sınai Kalkınma Bankası A.Ş.";
                    break;
                case "00015":
                    bank_name = "Türkiye Vakıflar Bankası T.A.O.";
                    break;
                case "00016":
                    bank_name = "Türkiye İhracat Kredi Bankası A.Ş. (Eximbank)";
                    break;
                case "00017":
                    bank_name = "Türkiye Kalkınma Bankası A.Ş.";
                    break;
                case "00029":
                    bank_name = "Birleşik Fon Bankası A.Ş. (Bayındırbank A.Ş.)";
                    break;
                case "00032":
                    bank_name = "Türk Ekonomi Bankası A.Ş.";
                    break;
                case "00034":
                    bank_name = "Aktif Yatırım Bankası A.Ş.";
                    break;
                case "00046":
                    bank_name = "Akbank T.A.Ş.";
                    break;
                case "00048":
                    bank_name = "HSBC Bank A.Ş.";
                    break;
                case "00058":
                    bank_name = "Sınai Yatırım Bankası A.Ş.";
                    break;
                case "00059":
                    bank_name = "Şekerbank T.A.Ş.";
                    break;
                case "00062":
                    bank_name = "Türkiye Garanti Bankası A.Ş.";
                    break;
                case "00064":
                    bank_name = "Türkiye İş Bankası A.Ş.";
                    break;
                case "00067":
                    bank_name = "Yapı ve Kredi Bankası A.Ş.";
                    break;
                case "00071":
                    bank_name = "Fortis Bank (TEB)";
                    break;
                case "00087":
                    bank_name = "Banca di Roma";
                    break;
                case "00088":
                    bank_name = "The Royal Bank of Scotland PLC Merkezi Amsterdam İstanbul Merkez Şubesi";
                    break;
                case "00091":
                    bank_name = "Arap Türk Bankası A.Ş.";
                    break;
                case "00092":
                    bank_name = "Citibank N.A.";
                    break;
                case "00094":
                    bank_name = "Bank Mellat";
                    break;
                case "00095":
                    bank_name = "BCCI";
                    break;
                case "00096":
                    bank_name = "Turkish Bank A.Ş.";
                    break;
                case "00097":
                    bank_name = "Habib Bank Limited";
                    break;
                case "00098":
                    bank_name = "JP Morgan Chase Bank İstanbul Türkiye Şubesi";
                    break;
                case "00099":
                    bank_name = "Oyak Bank A.Ş. - ING BANK";
                    break;
                case "00100":
                    bank_name = "Adabank A.Ş.";
                    break;
                case "00101":
                    bank_name = "Türk Sakura Bank A.Ş.";
                    break;
                case "00103":
                    bank_name = "Fiba Bank A.Ş.";
                    break;
                case "00104":
                    bank_name = "IMPEXBANK";
                    break;
                case "00106":
                    bank_name = "PORTIGON A.G.";
                    break;
                case "00107":
                    bank_name = "BNP-Ak-Dresdner Bank A.Ş.";
                    break;
                case "00108":
                    bank_name = "Turkland Bank A.Ş.";
                    break;
                case "00109":
                    bank_name = "Tekstil Bankası A.Ş.";
                    break;
                case "00110":
                    bank_name = "Credit Lyonnais";
                    break;
                case "00111":
                    bank_name = "Finansbank A.Ş.";
                    break;
                case "00113":
                    bank_name = "Marbank";
                    break;
                case "00115":
                    bank_name = "Deutsche Bank A.Ş.";
                    break;
                case "00116":
                    bank_name = "TAİB Yatırım Bank A.Ş.";
                    break;
                case "00117":
                    bank_name = "Turizm Yatırım ve Ticaret Bank A.Ş.";
                    break;
                case "00118":
                    bank_name = "Kıbrıs Kredi Bankası";
                    break;
                case "00119":
                    bank_name = "Birleşik Yatırım";
                    break;
                case "00121":
                    bank_name = "Standard Chartered Yatırım Bankası Türk A.Ş.";
                    break;
                case "00122":
                    bank_name = "Societe Generale";
                    break;
                case "00123":
                    bank_name = "HSBC Bank A.Ş.";
                    break;
                case "00124":
                    bank_name = "Alternatifbank A.Ş.";
                    break;
                case "00125":
                    bank_name = "Burganbank A.Ş.";
                    break;
                case "00127":
                    bank_name = "KentBank";
                    break;
                case "00128":
                    bank_name = "Park Yatırım Bankası";
                    break;
                case "00129":
                    bank_name = "Tat Yatırım Bankası A.Ş.";
                    break;
                case "00132":
                    bank_name = "IMKB Takas ve Saklama Bankası A.Ş.";
                    break;
                case "00133":
                    bank_name = "ING BANK";
                    break;
                case "00134":
                    bank_name = "Denizbank A.Ş.";
                    break;
                case "00135":
                    bank_name = "Anadolubank A.Ş.";
                    break;
                case "00136":
                    bank_name = "Okan Yatırım Bankası A Ş";
                    break;
                case "00137":
                    bank_name = "Rabobank Nederland İstanbul Merkez Şubesi";
                    break;
                case "00138":
                    bank_name = "Diler Yatırım Bankası A.Ş.";
                    break;
                case "00139":
                    bank_name = "GSD Yatırım Bankası A.Ş.";
                    break;
                case "00140":
                    bank_name = "Credit Suisse First Boston İstanbul Şubesi";
                    break;
                case "00141":
                    bank_name = "Nurol Yatırım Bankası A.Ş.";
                    break;
                case "00142":
                    bank_name = "Bank Pozitif Kredi ve Kalkınma Bankası A.Ş.";
                    break;
                case "00144":
                    bank_name = "Atlas Yatırım Bankası A.Ş.";
                    break;
                case "00145":
                    bank_name = "Morgan Guarenty Trusy Company";
                    break;
                case "00146":
                    bank_name = "OdeaBank A.Ş.";
                    break;
                case "00147":
                    bank_name = "Bank of Tokyo -Mitsubishi UFJ Turkey A.Ş.";
                    break;
                case "00148":
                    bank_name = "Intesa SanPaolo SPA İtalya-İstanbul Merkez Şubesi";
                    break;
                case "00203":
                    bank_name = "Al Baraka Türk Katılım Bankası A.Ş.";
                    break;
                case "00204":
                    bank_name = "Family Finans Kurumu";
                    break;
                case "00205":
                    bank_name = "Kuveyt Türk Katılım Bankası A.Ş.";
                    break;
                case "00206":
                    bank_name = "Türkiye Finans Katılım Bankası A.Ş.";
                    break;
                case "00208":
                    bank_name = "Asya Katılım Bankası A.Ş.";
                    break;
                case "00210":
                    bank_name = "Vakıf Katılım Bankası A.Ş.";
                    break;
                case "00223":
                    bank_name = "Al Baraka Türk Katılım Bankası A.Ş.";
                    break;
                default:
                    bank_name = "Tespit edilemedi";
                    break;
            }
            Console.WriteLine("Girdiğiniz ibanın bankası: "+bank_name);
        }
    }
}
