using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace criptoCurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*          double total = 0;
                        double XRP=27.06453;
                        double BTC=0.00652669;
                        double SXP;
                        double ETH;
                        double BNB=0.4850768;
                        double CAKE = 1.517;
            */

            //OnlyForBTC

            {
                for (int i = 0; ; i++)
                {


                    WebRequest BTC_USDT_request = HttpWebRequest.Create("https://www.trbinance.com/trade/BTC_USDT");
                    WebResponse BTC_USDT_response = BTC_USDT_request.GetResponse();

                    StreamReader ReadResponse_BTC = new StreamReader(BTC_USDT_response.GetResponseStream());



                    string sourceCodes_BTC = ReadResponse_BTC.ReadToEnd();

                    int ContentStartIndex_BTC = sourceCodes_BTC.IndexOf("<span data-v-e1725664>") + 22;
                    int ContentEndIndex_BTC = sourceCodes_BTC.Substring(ContentStartIndex_BTC).IndexOf("</span>") + 1;

                    DateTime bugun1 = DateTime.Now;
                    Console.WriteLine(bugun1 + " *BTC now: " + sourceCodes_BTC.Substring(ContentStartIndex_BTC, ContentEndIndex_BTC));

                    //new
                    // BTC = BTC * sourceCodes_BTC.Substring(ContentStartIndex_BTC, ContentEndIndex_BTC);

                    string[] BTC_DB = sourceCodes_BTC.Substring(ContentStartIndex_BTC, ContentEndIndex_BTC).Split(new char[' ']);
                    for (int p = 0; p < BTC_DB.Length; p++)
                    {
                        Console.WriteLine(BTC_DB[p]); // correct value
                    }

                }
            }

            /*
                        for (int i = 0; ; i++)
                        {


                            WebRequest ETH_USDT_request = HttpWebRequest.Create("https://www.trbinance.com/trade/ETH_USDT");
                            WebResponse ETH_USDT_response = ETH_USDT_request.GetResponse();

                            StreamReader ReadResponse_ETH = new StreamReader(ETH_USDT_response.GetResponseStream());



                            string sourceCodes_ETH = ReadResponse_ETH.ReadToEnd();

                            int ContentStartIndex_ETH = sourceCodes_ETH.IndexOf("<span data-v-e1725664>") + 22;
                            int ContentEndIndex_ETH = sourceCodes_ETH.Substring(ContentStartIndex_ETH).IndexOf("</span>");

                            DateTime bugun = DateTime.Now;
                            Console.WriteLine(bugun + " *SXP now: " + sourceCodes_ETH.Substring(ContentStartIndex_ETH, ContentEndIndex_ETH));

                            //
                            WebRequest BTC_USDT_request = HttpWebRequest.Create("https://www.trbinance.com/trade/BTC_USDT");
                            WebResponse BTC_USDT_response = BTC_USDT_request.GetResponse();

                            StreamReader ReadResponse_BTC = new StreamReader(BTC_USDT_response.GetResponseStream());



                            string sourceCodes_BTC = ReadResponse_BTC.ReadToEnd();

                            int ContentStartIndex_BTC = sourceCodes_BTC.IndexOf("<span data-v-e1725664>") + 22;
                            int ContentEndIndex_BTC = sourceCodes_BTC.Substring(ContentStartIndex_BTC).IndexOf("</span>");

                            DateTime bugun1 = DateTime.Now;
                            Console.WriteLine(bugun1 + " *BTC now: " + sourceCodes_BTC.Substring(ContentStartIndex_BTC, ContentEndIndex_BTC));

                            //new
                            // BTC = BTC * sourceCodes_BTC.Substring(ContentStartIndex_BTC, ContentEndIndex_BTC);

                            //
                            WebRequest SXP_USDT_request = HttpWebRequest.Create("https://www.trbinance.com/trade/SXP_USDT");
                            WebResponse SXP_USDT_response = SXP_USDT_request.GetResponse();

                            StreamReader ReadResponse_SXP = new StreamReader(SXP_USDT_response.GetResponseStream());


                            string sourceCodes_SXP = ReadResponse_SXP.ReadToEnd();

                            int ContentStartIndex_SXP = sourceCodes_SXP.IndexOf("<span data-v-e1725664>") + 22;
                            int ContentEndIndex_SXP = sourceCodes_SXP.Substring(ContentStartIndex_SXP).IndexOf("</span>");

                            DateTime bugun2 = DateTime.Now;
                            Console.WriteLine(bugun2 + " *SXP now: " + sourceCodes_SXP.Substring(ContentStartIndex_SXP, ContentEndIndex_SXP));

                            //
                            WebRequest BNB_USDT_request = HttpWebRequest.Create("https://www.trbinance.com/trade/BNB_USDT");
                            WebResponse BNB_USDT_response = BNB_USDT_request.GetResponse();

                            StreamReader ReadResponse_BNB = new StreamReader(BNB_USDT_response.GetResponseStream());



                            string sourceCodes_BNB = ReadResponse_BNB.ReadToEnd();

                            int ContentStartIndex_BNB = sourceCodes_BNB.IndexOf("<span data-v-e1725664>") + 22;
                            int ContentEndIndex_BNB = sourceCodes_BNB.Substring(ContentStartIndex_BNB).IndexOf("</span>");

                            DateTime bugun3 = DateTime.Now;
                            Console.WriteLine(bugun3 + " *BNB now: " + sourceCodes_BNB.Substring(ContentStartIndex_BNB, ContentEndIndex_BNB));

                            //
                            WebRequest XRP_USDT_request = HttpWebRequest.Create("https://www.trbinance.com/trade/XRP_USDT");
                            WebResponse XRP_USDT_response = XRP_USDT_request.GetResponse();

                            StreamReader ReadResponse_XRP = new StreamReader(XRP_USDT_response.GetResponseStream());



                            string sourceCodes_XRP = ReadResponse_XRP.ReadToEnd();

                            int ContentStartIndex_XRP = sourceCodes_XRP.IndexOf("<span data-v-e1725664>") + 22;
                            int ContentEndIndex_XRP = sourceCodes_XRP.Substring(ContentStartIndex_XRP).IndexOf("</span>");

                            DateTime bugun4 = DateTime.Now;
                            Console.WriteLine(bugun4 + " *XRP now: " + sourceCodes_XRP.Substring(ContentStartIndex_XRP, ContentEndIndex_XRP));

                            //
                            WebRequest CAKE_BUSD_request = HttpWebRequest.Create("https://www.trbinance.com/trade/CAKE_BUSD");
                            WebResponse CAKE_BUSD_response = CAKE_BUSD_request.GetResponse();

                            StreamReader ReadResponse_CAKE = new StreamReader(CAKE_BUSD_response.GetResponseStream());



                            string sourceCodes_CAKE = ReadResponse_CAKE.ReadToEnd();

                            int ContentStartIndex_CAKE = sourceCodes_CAKE.IndexOf("<span data-v-e1725664>") + 22;
                            int ContentEndIndex_CAKE = sourceCodes_CAKE.Substring(ContentStartIndex_CAKE).IndexOf("</span>");

                            DateTime bugun5 = DateTime.Now;
                            Console.WriteLine(bugun4 + " *CAKE now: " + sourceCodes_CAKE.Substring(ContentStartIndex_CAKE, ContentEndIndex_CAKE));


                            string[] BTC_DB = sourceCodes_BTC.Substring(ContentStartIndex_BTC, ContentEndIndex_BTC).Split(new char[' ']);
                            for (int p = 0; p < BTC_DB.Length; p++)
                            {
                                Console.WriteLine(BTC_DB[p]); // correct value

                            }

                            string[] XRP_DB = sourceCodes_XRP.Substring(ContentStartIndex_XRP, ContentEndIndex_XRP).Split(new char[' ']);
                            for (int o = 0; o < XRP_DB.Length; o++)
                            {
                                Console.WriteLine(XRP_DB[o]); // correct value

                            }

                            string[] BNB_DB = sourceCodes_BNB.Substring(ContentStartIndex_BNB, ContentEndIndex_BNB).Split(new char[' ']);
                            for (int u = 0; u < BNB_DB.Length; u++)
                            {
                                Console.WriteLine(BNB_DB[u]); // correct value

                            }

                            string[] CAKE_DB = sourceCodes_CAKE.Substring(ContentStartIndex_CAKE, ContentEndIndex_CAKE).Split(new char[' ']);
                            for (int y = 0; y < CAKE_DB.Length; y++)
                            {
                                Console.WriteLine(CAKE_DB[y]); // correct value

                            }


                            Console.WriteLine();
                            Console.WriteLine("TOTAL:");

                            Console.WriteLine();
                        }
            */

        }
    }
}
