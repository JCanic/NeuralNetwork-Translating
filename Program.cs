using System;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.ML.Train;
using Encog.ML.Data.Basic;
using Encog;
using Encog.Neural.Networks.Training.Propagation.Back;
using Encog.Bot.Browse.Range;
using System.Linq;
using Encog.Neural.Networks.Training.Propagation.Manhattan;
using Encog.Neural.Networks.Training.Propagation.Quick;

namespace encog_sample_csharp
{
    internal class Program
    {
        /// <summary>
        /// Input for the XOR function.
        /// </summary>

        static void Main(string[] args)
        {

            //SET ZA TRENING

            double[] football = prevediRijecUParametre("football"); //+
            double[] fotboll = prevediRijecUParametre("fotboll");//+
            double[] fussball = prevediRijecUParametre("fussball");//+
            double[] fudbal = prevediRijecUParametre("fudbal");//+
            double[] futebol = prevediRijecUParametre("futebol");

            double[] handball = prevediRijecUParametre("handball");//+
            double[] handboll = prevediRijecUParametre("handboll");//+
            double[] handbold = prevediRijecUParametre("handbol");//+
            double[] hendboll = prevediRijecUParametre("hendboll");//+
            double[] handeboll = prevediRijecUParametre("handebol");

            double[] basketball = prevediRijecUParametre("basketball");//+
            double[] basketboll = prevediRijecUParametre("basketboll");//+
            double[] balocesto = prevediRijecUParametre("baloncesto");//+
            double[] basket = prevediRijecUParametre("basket");//+
            double[] basquetebol = prevediRijecUParametre("basquetebol");

            double[] schach = prevediRijecUParametre("schach");
            double[] shack = prevediRijecUParametre("schack");
            double[] scacchi = prevediRijecUParametre("scacchi");
            double[] skak = prevediRijecUParametre("skak");
            double[] schack = prevediRijecUParametre("schack");

            double[] waterpolo = prevediRijecUParametre("waterpolo");//+
            double[] wasserpolo = prevediRijecUParametre("wasserpolo");//+
            double[] vattenpolo = prevediRijecUParametre("vattenpolo");//+
            double[] vandpolo = prevediRijecUParametre("vandpolo");//+
            double[] vannpolo = prevediRijecUParametre("vannpolo");

            double[] competition = prevediRijecUParametre("competition");
            double[] competizione = prevediRijecUParametre("competizione");
            double[] competicion = prevediRijecUParametre("competicion");
            double[] competence = prevediRijecUParametre("competence");
            double[] competicao = prevediRijecUParametre("competicao");

            double[] medal = prevediRijecUParametre("medal");//+
            double[] medalla = prevediRijecUParametre("medalla");//+
            double[] medaglia = prevediRijecUParametre("medaglia");//+
            double[] medaille = prevediRijecUParametre("medaille");//+
            double[] medalj = prevediRijecUParametre("medalj");

            double[] trophy = prevediRijecUParametre("trophy");//+
            double[] trofeo = prevediRijecUParametre("trofeo");//+
            double[] trophae = prevediRijecUParametre("trophae");//+
            double[] trofe = prevediRijecUParametre("trofe");//+
            double[] trofee = prevediRijecUParametre("trofee");

            double[] helmet = prevediRijecUParametre("helmet");
            double[] hjelm = prevediRijecUParametre("hjelm");
            double[] hjalm = prevediRijecUParametre("hjalm");
            double[] helm = prevediRijecUParametre("helm");
            double[] helmo = prevediRijecUParametre("helmo");

            double[] victory = prevediRijecUParametre("victory");//+
            double[] vinna = prevediRijecUParametre("vinna");//+
            double[] victoria = prevediRijecUParametre("victoria");//+
            double[] vincita = prevediRijecUParametre("vincita");//+
            double[] vitoria = prevediRijecUParametre("vitoria");

            double[] stadium = prevediRijecUParametre("stadium");
            double[] stade = prevediRijecUParametre("stade");
            double[] stadyum = prevediRijecUParametre("stadyum");
            double[] stadio = prevediRijecUParametre("stadio");
            double[] stadion = prevediRijecUParametre("stadion");

            double[] defense = prevediRijecUParametre("defense");
            double[] defensa = prevediRijecUParametre("defensa");
            double[] defesa = prevediRijecUParametre("defesa");
            double[] difesa = prevediRijecUParametre("difesa");
            double[] defensie = prevediRijecUParametre("defensie");

            double[] point = prevediRijecUParametre("point");//+
            double[] ponto = prevediRijecUParametre("ponto");//+
            double[] punkt = prevediRijecUParametre("punkt");//+
            double[] punto = prevediRijecUParametre("punto");//+
            double[] punt = prevediRijecUParametre("punt");//+

            double[][] rjecnik = {football,fotboll,fussball,fudbal,futebol,handball,handboll,handbold,hendboll,handeboll,basketball,basketboll,balocesto,basket,basquetebol,
                schach,shack,scacchi,skak,schack,waterpolo,wasserpolo,vattenpolo,vandpolo,vannpolo,
                /*rugby,ragbi,regbi,rogbi,rugbai,*/competition,competizione,competicion,competence,competicao, medal,medalla,medaglia, medaille,medalj,trofe,trophae,trophy,trofeo,trofee,
                helmet,hjelm,hjalm,helm,helmo,victoria, vinna, vincita, victory,vitoria, stadium, stadyum, stade, stadio,stadion, defense, defensa, defesa, difesa,defensie, point,
            ponto,punkt,punto,punt};


            double[] nogomet = new double[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] rukomet = new double[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] kosarka = new double[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] sah = new double[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] vaterpolo = new double[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] bod = new double[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 };
            double[] natjecanje = new double[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 };
            double[] pobjeda = new double[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
            double[] medalja = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 };
            double[] pehar = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 };
            double[] stadionh = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            double[] obrana = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            double[] kaciga = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };

          

            double[] testRijec = prevediRijecUParametre("vatnapolo");


            double[][] testX = { testRijec };

            double[] ocekivaniPrijevod = vaterpolo;            

            double[][] testY = { ocekivaniPrijevod };


            
            //sum data
            double[][] x = rjecnik;

            double[][] y =
            {
                nogomet,nogomet,nogomet,nogomet,nogomet, rukomet,rukomet,rukomet,rukomet,rukomet, kosarka,kosarka,kosarka,kosarka,kosarka,
                sah,sah,sah,sah,sah, vaterpolo, vaterpolo, vaterpolo, vaterpolo,vaterpolo, natjecanje,natjecanje,natjecanje,natjecanje,natjecanje, medalja,medalja, medalja, medalja,medalja, pehar,pehar,pehar,pehar,pehar,
                kaciga,kaciga,kaciga,kaciga,kaciga,pobjeda, pobjeda, pobjeda, pobjeda,pobjeda,stadionh,stadionh,stadionh,stadionh,stadionh, obrana,obrana,obrana,obrana,obrana,
                bod,bod,bod,bod,bod
        };

            BasicNetwork network = new BasicNetwork();

            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 5));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 8));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 13));

            network.Structure.FinalizeStructure();
            network.Reset();


            IMLDataSet dataset = new BasicMLDataSet(x, y);

            IMLDataSet testset = new BasicMLDataSet(testX, testY);

            IMLTrain learner = new Backpropagation(network, dataset);

            int epoch = 1;


            do
            {
                learner.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error:" + learner.Error);
                epoch++;
            } while (learner.Error > 0.025);

            int brojac = 0;
            foreach (IMLDataPair pair in dataset)
            {

                IMLData result = network.Compute(pair.Input);

                /*
                Console.WriteLine("{0},{1},{2},{3}={4}   -> {5}", pair.Input[0],
                    pair.Input[1], pair.Input[2], pair.Input[3], pair.Ideal, result);
                */

                double maxValue = 0;
                int i_maxValue = 0;

                for (int i = 0; i < 13; i++)
                {
                    if (result[i] > maxValue)
                    {
                        maxValue = result[i];
                        i_maxValue = i;
                    }
                }

                ispisiInpute(brojac);

                brojac++;

                switch (i_maxValue)
                {
                    case 0:
                        Console.WriteLine("nogomet");
                        break;
                    case 1:
                        Console.WriteLine("rukomet");
                        break;
                    case 2:
                        Console.WriteLine("kosarka");
                        break;
                    case 3:
                        Console.WriteLine("sah");
                        break;
                    case 4:
                        Console.WriteLine("vaterpolo");
                        break;
                    case 5:
                        Console.WriteLine("bod");
                        break;
                    case 6:
                        Console.WriteLine("natjecanje");
                        break;
                    case 7:
                        Console.WriteLine("pobjeda");
                        break;
                    case 8:
                        Console.WriteLine("medalja");
                        break;
                    case 9:
                        Console.WriteLine("pehar");
                        break;
                    case 10:
                        Console.WriteLine("stadion");
                        break;
                    case 11:
                        Console.WriteLine("obrana");
                        break;
                    case 12:
                        Console.WriteLine("kaciga");
                        break;
                    default:
                        Console.WriteLine("Nijedan prijevod ne odgovara navedenoj riječi.");
                        break;
                }

            }

        }


        //PARAMETRI
        //početno slovo = f -> 26 slova; 6. slovo po redu -> 6/26 = 0,23
        //broj samoglasnika s obzirom na duljinu riječi = football(8), 3 samoglasnika 3/8 = 0,38
        //duljina rijeci = sport s najduljim imenom -> 20 slova = football = 8/20 = 0.4
        //posljedenje slovo = l -> 26 slova; 9. slovo po redu -> 9/26 = 0,35
        public static double[] prevediRijecUParametre(string rijec)
        {
            double x, y, f, z, v;
            int brojac = 0;

            switch (Char.ToLower(rijec[0]))
            {
                case 'a':
                    x = Math.Round((float)1 / 26, 2); ;
                    break;
                case 'b':
                    x = Math.Round((float)2 / 26, 2);
                    break;
                case 'c':
                    x = Math.Round((float)3 / 26, 2);
                    break;
                case 'd':
                    x = Math.Round((float)4 / 26, 2);
                    break;
                case 'e':
                    x = Math.Round((float)5 / 26, 2);
                    break;
                case 'f':
                    x = Math.Round((float)6 / 26, 2);
                    break;
                case 'g':
                    x = Math.Round((float)7 / 26, 2);
                    break;
                case 'h':
                    x = Math.Round((float)8 / 26, 2);
                    break;
                case 'i':
                    x = Math.Round((float)9 / 26, 2);
                    break;
                case 'j':
                    x = Math.Round((float)10 / 26, 2);
                    break;
                case 'k':
                    x = Math.Round((float)11 / 26, 2);
                    break;
                case 'l':
                    x = Math.Round((float)12 / 26, 2);
                    break;
                case 'm':
                    x = Math.Round((float)13 / 26, 2);
                    break;
                case 'n':
                    x = Math.Round((float)14 / 26, 2);
                    break;
                case 'o':
                    x = Math.Round((float)15 / 26, 2);
                    break;
                case 'p':
                    x = Math.Round((float)16 / 26, 2);
                    break;
                case 'q':
                    x = Math.Round((float)17 / 26, 2);
                    break;
                case 'r':
                    x = Math.Round((float)18 / 26, 2);
                    break;
                case 's':
                    x = Math.Round((float)19 / 26, 2);
                    break;
                case 't':
                    x = Math.Round((float)20 / 26, 2);
                    break;
                case 'u':
                    x = Math.Round((float)21 / 26, 2);
                    break;
                case 'v':
                    x = Math.Round((float)22 / 26, 2);
                    break;
                case 'w':
                    x = Math.Round((float)23 / 26, 2);
                    break;
                case 'x':
                    x = Math.Round((float)24 / 26, 2);
                    break;
                case 'y':
                    x = Math.Round((float)25 / 26, 2);
                    break;
                case 'z':
                    x = Math.Round((float)26 / 26, 2);
                    break;
                default:
                    x = 0;
                    break;
            }

            switch (Char.ToLower(rijec[1]))
            {
                case 'a':
                    f = Math.Round((float)1 / 26, 2); ;
                    break;
                case 'b':
                    f = Math.Round((float)2 / 26, 2);
                    break;
                case 'c':
                    f = Math.Round((float)3 / 26, 2);
                    break;
                case 'd':
                    f = Math.Round((float)4 / 26, 2);
                    break;
                case 'e':
                    f = Math.Round((float)5 / 26, 2);
                    break;
                case 'f':
                    f = Math.Round((float)6 / 26, 2);
                    break;
                case 'g':
                    f = Math.Round((float)7 / 26, 2);
                    break;
                case 'h':
                    f = Math.Round((float)8 / 26, 2);
                    break;
                case 'i':
                    f = Math.Round((float)9 / 26, 2);
                    break;
                case 'j':
                    f = Math.Round((float)10 / 26, 2);
                    break;
                case 'k':
                    f = Math.Round((float)11 / 26, 2);
                    break;
                case 'l':
                    f = Math.Round((float)12 / 26, 2);
                    break;
                case 'm':
                    f = Math.Round((float)13 / 26, 2);
                    break;
                case 'n':
                    f = Math.Round((float)14 / 26, 2);
                    break;
                case 'o':
                    f = Math.Round((float)15 / 26, 2);
                    break;
                case 'p':
                    f = Math.Round((float)16 / 26, 2);
                    break;
                case 'q':
                    f = Math.Round((float)17 / 26, 2);
                    break;
                case 'r':
                    f = Math.Round((float)18 / 26, 2);
                    break;
                case 's':
                    f = Math.Round((float)19 / 26, 2);
                    break;
                case 't':
                    f = Math.Round((float)20 / 26, 2);
                    break;
                case 'u':
                    f = Math.Round((float)21 / 26, 2);
                    break;
                case 'v':
                    f = Math.Round((float)22 / 26, 2);
                    break;
                case 'w':
                    f = Math.Round((float)23 / 26, 2);
                    break;
                case 'x':
                    f = Math.Round((float)24 / 26, 2);
                    break;
                case 'y':
                    f = Math.Round((float)25 / 26, 2);
                    break;
                case 'z':
                    f = Math.Round((float)26 / 26, 2);
                    break;
                default:
                    f = 0;
                    break;
            }


            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i] == 'a' || rijec[i] == 'e' || rijec[i] == 'i' || rijec[i] == 'o' || rijec[i] == 'u')
                {
                    brojac++;
                }
            }
            y = Math.Round((float)brojac / rijec.Length, 2);
            z = Math.Round((float)rijec.Length / 20, 2);

            switch (Char.ToLower(rijec[rijec.Length - 1]))
            {
                case 'a':
                    v = Math.Round((float)1 / 26, 2); ;
                    break;
                case 'b':
                    v = Math.Round((float)2 / 26, 2);
                    break;
                case 'c':
                    v = Math.Round((float)3 / 26, 2);
                    break;
                case 'd':
                    v = Math.Round((float)4 / 26, 2);
                    break;
                case 'e':
                    v = Math.Round((float)5 / 26, 2);
                    break;
                case 'f':
                    v = Math.Round((float)6 / 26, 2);
                    break;
                case 'g':
                    v = Math.Round((float)7 / 26, 2);
                    break;
                case 'h':
                    v = Math.Round((float)8 / 26, 2);
                    break;
                case 'i':
                    v = Math.Round((float)9 / 26, 2);
                    break;
                case 'j':
                    v = Math.Round((float)10 / 26, 2);
                    break;
                case 'k':
                    v = Math.Round((float)11 / 26, 2);
                    break;
                case 'l':
                    v = Math.Round((float)12 / 26, 2);
                    break;
                case 'm':
                    v = Math.Round((float)13 / 26, 2);
                    break;
                case 'n':
                    v = Math.Round((float)14 / 26, 2);
                    break;
                case 'o':
                    v = Math.Round((float)15 / 26, 2);
                    break;
                case 'p':
                    v = Math.Round((float)16 / 26, 2);
                    break;
                case 'q':
                    v = Math.Round((float)17 / 26, 2);
                    break;
                case 'r':
                    v = Math.Round((float)18 / 26, 2);
                    break;
                case 's':
                    v = Math.Round((float)19 / 26, 2);
                    break;
                case 't':
                    v = Math.Round((float)20 / 26, 2);
                    break;
                case 'u':
                    v = Math.Round((float)21 / 26, 2);
                    break;
                case 'v':
                    v = Math.Round((float)22 / 26, 2);
                    break;
                case 'w':
                    v = Math.Round((float)23 / 26, 2);
                    break;
                case 'x':
                    v = Math.Round((float)24 / 26, 2);
                    break;
                case 'y':
                    v = Math.Round((float)25 / 26, 2);
                    break;
                case 'z':
                    v = Math.Round((float)26 / 26, 2);
                    break;
                default:
                    v = 0;
                    break;
            }


            double[] parametri = new double[] { x, y, f, z, v };

            return parametri;

        }

        public static void ispisiInpute(int brojac)
        {
            switch (brojac)
            {


                case 0:
                    Console.Write("football -> ");
                    break;
                case 1:
                    Console.Write("fotboll -> ");
                    break;
                case 2:
                    Console.Write("fussball -> ");
                    break;
                case 3:
                    Console.Write("fudbal -> ");
                    break;
                case 4:
                    Console.Write("futebol -> ");
                    break;
                case 5:
                    Console.Write("handball -> ");
                    break;
                case 6:
                    Console.Write("handboll -> ");
                    break;
                case 7:
                    Console.Write("handbold -> ");
                    break;
                case 8:
                    Console.Write("hendboll -> ");
                    break;
                case 9:
                    Console.Write("handeboll -> ");
                    break;
                case 10:
                    Console.Write("basketball -> ");
                    break;
                case 11:
                    Console.Write("basketboll -> ");
                    break;
                case 12:
                    Console.Write("balocesto -> ");
                    break;
                case 13:
                    Console.Write("basket -> ");
                    break;
                case 14:
                    Console.Write("basquetebol -> ");
                    break;
                case 15:
                    Console.Write("shack -> ");
                    break;
                case 16:
                    Console.Write("scacchi -> ");
                    break;
                case 17:
                    Console.Write("skak -> ");
                    break;
                case 18:
                    Console.Write("shack -> ");
                    break;
                case 19:
                    Console.Write("schack -> ");
                    break;
                case 20:
                    Console.Write("waterpolo -> ");
                    break;
                case 21:
                    Console.Write("wasserpolo -> ");
                    break;
                case 22:
                    Console.Write("vattenpolo -> ");
                    break;
                case 23:
                    Console.Write("vandpolo -> ");
                    break;
                case 24:
                    Console.Write("vannpolo -> ");
                    break;
                case 25:
                    Console.Write("competition -> ");
                    break;
                case 26:
                    Console.Write("competizione -> ");
                    break;
                case 27:
                    Console.Write("competicion -> ");
                    break;
                case 28:
                    Console.Write("competence -> ");
                    break;
                case 29:
                    Console.Write("competicao -> ");
                    break;
                case 30:
                    Console.Write("medal -> ");
                    break;
                case 31:
                    Console.Write("medalla -> ");
                    break;
                case 32:
                    Console.Write("medaglia -> ");
                    break;
                case 33:
                    Console.Write("medaille -> ");
                    break;
                case 34:
                    Console.Write("medalj -> ");
                    break;
                case 35:
                    Console.Write("trofe -> ");
                    break;
                case 36:
                    Console.Write("trophae -> ");
                    break;
                case 37:
                    Console.Write("trophy -> ");
                    break;
                case 38:
                    Console.Write("trofeo -> ");
                    break;
                case 39:
                    Console.Write("trofee -> ");
                    break;
                case 40:
                    Console.Write("helmet -> ");
                    break;
                case 41:
                    Console.Write("hjelm -> ");
                    break;
                case 42:
                    Console.Write("hjalm -> ");
                    break;
                case 43:
                    Console.Write("helm -> ");
                    break;
                case 44:
                    Console.Write("helmo -> ");
                    break;
                case 45:
                    Console.Write("victoria -> ");
                    break;
                case 46:
                    Console.Write("vinna -> ");
                    break;
                case 47:
                    Console.Write("vincita -> ");
                    break;
                case 48:
                    Console.Write("victory -> ");
                    break;
                case 49:
                    Console.Write("vitoria -> ");
                    break;
                case 50:
                    Console.Write("stadium -> ");
                    break;
                case 51:
                    Console.Write("stadyum -> ");
                    break;
                case 52:
                    Console.Write("stade -> ");
                    break;
                case 53:
                    Console.Write("stadio -> ");
                    break;
                case 54:
                    Console.Write("stadion -> ");
                    break;
                case 55:
                    Console.Write("defense -> ");
                    break;
                case 56:
                    Console.Write("defensa -> ");
                    break;
                case 57:
                    Console.Write("defesa -> ");
                    break;
                case 58:
                    Console.Write("difesa -> ");
                    break;
                case 59:
                    Console.Write("defensie -> ");
                    break;
                case 60:
                    Console.Write("point -> ");
                    break;
                case 61:
                    Console.Write("ponto -> ");
                    break;
                case 62:
                    Console.Write("punkt -> ");
                    break;
                case 63:
                    Console.Write("punto -> ");
                    break;
                case 64:
                    Console.Write("punt -> ");
                    break;


            }
        }

    }
}
