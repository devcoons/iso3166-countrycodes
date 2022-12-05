using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ISO3166
{
    public class ISO3166 : INotifyPropertyChanged
    {
        private string continent = "--";
        private string country = "---";
        private string subdivision = "---";

        public string Continent
        {
            get { return continent; }
            set
            {
                if (value == continent)
                    return;
                continent = value;
                Country = "---";
                OnPropertyChanged("Continent");
                OnPropertyChanged("Countries");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (value == country)
                    return;
                country = value;
                Subdivision = "---";
                OnPropertyChanged("Country");
                OnPropertyChanged("Subdivisions");
            }
        }
        public string Subdivision
        {
            get { return subdivision; }
            set
            {
                if (value == subdivision)
                    return;
                subdivision = value;
                OnPropertyChanged("Subdivision");
            }
        }

        public List<KeyValuePair<string, string>> Continents => ISO3166Base.Continents;
        public List<KeyValuePair<string, string>> Countries
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(Continent))
                        return new List<KeyValuePair<string, string>>();

                    var x = ISO3166Base.continentsCountries.FindAll(o => o.Key == Continent).ToDictionary(t => t.Value, t => t.Key).Keys;
                    var k = ISO3166Base.Countries.FindAll(t => x.Contains(t.Key));
                    return k;
                }
                catch (Exception)
                {
                    return new List<KeyValuePair<string, string>>();
                }
            }
        }
        public List<KeyValuePair<string, string>> Subdivisions
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(Country))
                        return new List<KeyValuePair<string, string>>();

                    switch (Country)
                    {
                        case "ZWE":
                            return ISO3166Base.provincesZWE;
                        case "ZMB":
                            return ISO3166Base.provincesZMB;
                        case "YEM":
                            return ISO3166Base.provincesYEM;
                        case "VNM":
                            return ISO3166Base.provincesVNM;
                        case "VEN":
                            return ISO3166Base.provincesVEN;
                        case "VUT":
                            return ISO3166Base.provincesVUT;
                        case "UZB":
                            return ISO3166Base.provincesUZB;
                        case "URY":
                            return ISO3166Base.provincesURY;
                        case "UMI":
                            return ISO3166Base.provincesUMI;
                        case "USA":
                            return ISO3166Base.provincesUSA;
                        case "GBR":
                            return ISO3166Base.provincesGBR;
                        case "ARE":
                            return ISO3166Base.provincesARE;
                        case "UKR":
                            return ISO3166Base.provincesUKR;
                        case "UGA":
                            return ISO3166Base.provincesUGA;
                        case "TUV":
                            return ISO3166Base.provincesTUV;
                        case "TKM":
                            return ISO3166Base.provincesTKM;
                        case "TUR":
                            return ISO3166Base.provincesTUR;
                        case "TUN":
                            return ISO3166Base.provincesTUN;
                        case "TTO":
                            return ISO3166Base.provincesTTO;
                        case "THA":
                            return ISO3166Base.provincesTHA;
                        case "TZA":
                            return ISO3166Base.provincesTZA;
                        case "TJK":
                            return ISO3166Base.provincesTJK;
                        case "TWN":
                            return ISO3166Base.provincesTWN;
                        case "SYR":
                            return ISO3166Base.provincesSYR;
                        case "CHE":
                            return ISO3166Base.provincesCHE;
                        case "SWE":
                            return ISO3166Base.provincesSWE;
                        case "SUR":
                            return ISO3166Base.provincesSUR;
                        case "SDN":
                            return ISO3166Base.provincesSDN;
                        case "LKA":
                            return ISO3166Base.provincesLKA;
                        case "ESP":
                            return ISO3166Base.provincesESP;
                        case "SSD":
                            return ISO3166Base.provincesSSD;
                        case "ZAF":
                            return ISO3166Base.provincesZAF;
                        case "SOM":
                            return ISO3166Base.provincesSOM;
                        case "SLE":
                            return ISO3166Base.provincesSLE;
                        case "SYC":
                            return ISO3166Base.provincesSYC;
                        case "SLB":
                            return ISO3166Base.provincesSLB;
                        case "SVN":
                            return ISO3166Base.provincesSVN;
                        case "SVK":
                            return ISO3166Base.provincesSVK;
                        case "SGP":
                            return ISO3166Base.provincesSGP;
                        case "SRB":
                            return ISO3166Base.provincesSRB;
                        case "SEN":
                            return ISO3166Base.provincesSEN;
                        case "SAU":
                            return ISO3166Base.provincesSAU;
                        case "STP":
                            return ISO3166Base.provincesSTP;
                        case "SMR":
                            return ISO3166Base.provincesSMR;
                        case "WSM":
                            return ISO3166Base.provincesWSM;
                        case "VCT":
                            return ISO3166Base.provincesVCT;
                        case "LCA":
                            return ISO3166Base.provincesLCA;
                        case "KNA":
                            return ISO3166Base.provincesKNA;
                        case "SHN":
                            return ISO3166Base.provincesSHN;
                        case "RWA":
                            return ISO3166Base.provincesRWA;
                        case "RUS":
                            return ISO3166Base.provincesRUS;
                        case "ROU":
                            return ISO3166Base.provincesROU;
                        case "QAT":
                            return ISO3166Base.provincesQAT;
                        case "PRT":
                            return ISO3166Base.provincesPRT;
                        case "POL":
                            return ISO3166Base.provincesPOL;
                        case "PHL":
                            return ISO3166Base.provincesPHL;
                        case "PER":
                            return ISO3166Base.provincesPER;
                        case "PRY":
                            return ISO3166Base.provincesPRY;
                        case "PNG":
                            return ISO3166Base.provincesPNG;
                        case "PAN":
                            return ISO3166Base.provincesPAN;
                        case "PSE":
                            return ISO3166Base.provincesPSE;
                        case "PLW":
                            return ISO3166Base.provincesPLW;
                        case "PAK":
                            return ISO3166Base.provincesPAK;
                        case "OMN":
                            return ISO3166Base.provincesOMN;
                        case "NOR":
                            return ISO3166Base.provincesNOR;
                        case "NGA":
                            return ISO3166Base.provincesNGA;
                        case "NER":
                            return ISO3166Base.provincesNER;
                        case "NIC":
                            return ISO3166Base.provincesNIC;
                        case "NZL":
                            return ISO3166Base.provincesNZL;
                        case "NLD":
                            return ISO3166Base.provincesNLD;
                        case "NPL":
                            return ISO3166Base.provincesNPL;
                        case "NRU":
                            return ISO3166Base.provincesNRU;
                        case "NAM":
                            return ISO3166Base.provincesNAM;
                        case "MMR":
                            return ISO3166Base.provincesMMR;
                        case "MOZ":
                            return ISO3166Base.provincesMOZ;
                        case "MAR":
                            return ISO3166Base.provincesMAR;
                        case "NME":
                            return ISO3166Base.provincesNME;
                        case "MNG":
                            return ISO3166Base.provincesMNG;
                        case "MCO":
                            return ISO3166Base.provincesMCO;
                        case "MDA":
                            return ISO3166Base.provincesMDA;
                        case "FSM":
                            return ISO3166Base.provincesFSM;
                        case "MEX":
                            return ISO3166Base.provincesMEX;
                        case "MUS":
                            return ISO3166Base.provincesMUS;
                        case "MRT":
                            return ISO3166Base.provincesMRT;
                        case "MHL":
                            return ISO3166Base.provincesMHL;
                        case "MLT":
                            return ISO3166Base.provincesMLT;
                        case "MLI":
                            return ISO3166Base.provincesMLI;
                        case "MDV":
                            return ISO3166Base.provincesMDV;
                        case "MYS":
                            return ISO3166Base.provincesMYS;
                        case "MWI":
                            return ISO3166Base.provincesMWI;
                        case "MDG":
                            return ISO3166Base.provincesMDG;
                        case "LUX":
                            return ISO3166Base.provincesLUX;
                        case "LIE":
                            return ISO3166Base.provincesLIE;
                        case "LBY":
                            return ISO3166Base.provincesLBY;
                        case "LBR":
                            return ISO3166Base.provincesLBR;
                        case "LSO":
                            return ISO3166Base.provincesLSO;
                        case "LBN":
                            return ISO3166Base.provincesLBN;
                        case "LVA":
                            return ISO3166Base.provincesLVA;
                        case "LAO":
                            return ISO3166Base.provincesLAO;
                        case "KGZ":
                            return ISO3166Base.provincesKGZ;
                        case "KWT":
                            return ISO3166Base.provincesKWT;
                        case "KOR":
                            return ISO3166Base.provincesKOR;
                        case "PRK":
                            return ISO3166Base.provincesPRK;
                        case "KIR":
                            return ISO3166Base.provincesKIR;
                        case "KEN":
                            return ISO3166Base.provincesKEN;
                        case "KAZ":
                            return ISO3166Base.provincesKAZ;
                        case "JOR":
                            return ISO3166Base.provincesJOR;
                        case "JPN":
                            return ISO3166Base.provincesJPN;
                        case "JAM":
                            return ISO3166Base.provincesJAM;
                        case "ISR":
                            return ISO3166Base.provincesISR;
                        case "IRL":
                            return ISO3166Base.provincesIRL;
                        case "IRQ":
                            return ISO3166Base.provincesIRQ;
                        case "IRN":
                            return ISO3166Base.provincesIRN;
                        case "IDN":
                            return ISO3166Base.provincesIDN;
                        case "IND":
                            return ISO3166Base.provincesIND;
                        case "ISL":
                            return ISO3166Base.provincesISL;
                        case "HUN":
                            return ISO3166Base.provincesHUN;
                        case "HND":
                            return ISO3166Base.provincesHND;
                        case "HTI":
                            return ISO3166Base.provincesHTI;
                        case "GUY":
                            return ISO3166Base.provincesGUY;
                        case "GNB":
                            return ISO3166Base.provincesGNB;
                        case "GIN":
                            return ISO3166Base.provincesGIN;
                        case "GTM":
                            return ISO3166Base.provincesGTM;
                        case "GRD":
                            return ISO3166Base.provincesGRD;
                        case "GRL":
                            return ISO3166Base.provincesGRL;
                        case "GRC":
                            return ISO3166Base.provincesGRC;
                        case "GHA":
                            return ISO3166Base.provincesGHA;
                        case "DEU":
                            return ISO3166Base.provincesDEU;
                        case "GEO":
                            return ISO3166Base.provincesGEO;
                        case "GMB":
                            return ISO3166Base.provincesGMB;
                        case "GAB":
                            return ISO3166Base.provincesGAB;
                        case "FRA":
                            return ISO3166Base.provincesFRA;
                        case "FIN":
                            return ISO3166Base.provincesFIN;
                        case "FJI":
                            return ISO3166Base.provincesFJI;
                        case "ETH":
                            return ISO3166Base.provincesETH;
                        case "EST":
                            return ISO3166Base.provincesEST;
                        case "ERI":
                            return ISO3166Base.provincesERI;
                        case "GNQ":
                            return ISO3166Base.provincesGNQ;
                        case "SLV":
                            return ISO3166Base.provincesSLV;
                        case "EGY":
                            return ISO3166Base.provincesEGY;
                        case "ECU":
                            return ISO3166Base.provincesECU;
                        case "DOM":
                            return ISO3166Base.provincesDOM;
                        case "DMA":
                            return ISO3166Base.provincesDMA;
                        case "DJI":
                            return ISO3166Base.provincesDJI;
                        case "DNK":
                            return ISO3166Base.provincesDNK;
                        case "CZE":
                            return ISO3166Base.provincesCZE;
                        case "CYP":
                            return ISO3166Base.provincesCYP;
                        case "CUB":
                            return ISO3166Base.provincesCUB;
                        case "HRV":
                            return ISO3166Base.provincesHRV;
                        case "CIV":
                            return ISO3166Base.provincesCIV;
                        case "CRI":
                            return ISO3166Base.provincesCRI;
                        case "COG":
                            return ISO3166Base.provincesCOG;
                        case "COD":
                            return ISO3166Base.provincesCOD;
                        case "COM":
                            return ISO3166Base.provincesCOM;
                        case "COL":
                            return ISO3166Base.provincesCOL;
                        case "CHN":
                            return ISO3166Base.provincesCHN;
                        case "CHL":
                            return ISO3166Base.provincesCHL;
                        case "TCD":
                            return ISO3166Base.provincesTCD;
                        case "CAF":
                            return ISO3166Base.provincesCAF;
                        case "CPV":
                            return ISO3166Base.provincesCPV;
                        case "CAN":
                            return ISO3166Base.provincesCAN;
                        case "CMR":
                            return ISO3166Base.provincesCMR;
                        case "KHM":
                            return ISO3166Base.provincesKHM;
                        case "BDI":
                            return ISO3166Base.provincesBDI;
                        case "BFA":
                            return ISO3166Base.provincesBFA;
                        case "BGR":
                            return ISO3166Base.provincesBGR;
                        case "BRN":
                            return ISO3166Base.provincesBRN;
                        case "BRA":
                            return ISO3166Base.provincesBRA;
                        case "BWA":
                            return ISO3166Base.provincesBWA;
                        case "BIH":
                            return ISO3166Base.provincesBIH;
                        case "BES":
                            return ISO3166Base.provincesBES;
                        case "BTN":
                            return ISO3166Base.provincesBTN;
                        case "BOL":
                            return ISO3166Base.provincesBOL;
                        case "BEN":
                            return ISO3166Base.provincesBEN;
                        case "BLZ":
                            return ISO3166Base.provincesBLZ;
                        case "BEL":
                            return ISO3166Base.provincesBEL;
                        case "BLR":
                            return ISO3166Base.provincesBLR;
                        case "BRB":
                            return ISO3166Base.provincesBRB;
                        case "BGD":
                            return ISO3166Base.provincesBGD;
                        case "BHR":
                            return ISO3166Base.provincesBHR;
                        case "BHS":
                            return ISO3166Base.provincesBHS;
                        case "AZE":
                            return ISO3166Base.provincesAZE;
                        case "AUT":
                            return ISO3166Base.provincesAUT;
                        case "AUS":
                            return ISO3166Base.provincesAUS;
                        case "ARM":
                            return ISO3166Base.provincesARM;
                        case "ARG":
                            return ISO3166Base.provincesARG;
                        case "ATG":
                            return ISO3166Base.provincesATG;
                        case "AGO":
                            return ISO3166Base.provincesAGO;
                        case "AND":
                            return ISO3166Base.provincesAND;
                        case "DZA":
                            return ISO3166Base.provincesDZA;
                        case "ALB":
                            return ISO3166Base.provincesALB;
                        case "AFG":
                            return ISO3166Base.provincesAFG;
                        case "ITA":
                            return ISO3166Base.provincesITA;
                        default:
                            return ISO3166Base.provincesNONE;
                    }
                }
                catch (Exception)
                {
                    return new List<KeyValuePair<string, string>>();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }

}
