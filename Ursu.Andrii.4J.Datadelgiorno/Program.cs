using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ursu.Andrii._4J.Datadelgiorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(21, 11, 2020);
            Data data_default = new Data();

            Stampa(data, data_default);

            
        }
        static void Stampa(Data data, Data data_default)
        {
            //scegli che su quale data si vuole togliere aggiungere i giorni

            Console.WriteLine(data.trasforma());
            Console.WriteLine(data.aggiungi_togli_Giorni());
            Console.WriteLine(data_default.trasforma());
            Console.WriteLine(data_default.aggiungi_togli_Giorni());
            Console.WriteLine("confronto: {0}", data == data_default);
            Console.WriteLine("confronto: {0}", data > data_default);


            Console.ReadLine();
        }
    }
    class Data
    {
        public int _giorno { get; set; }
        public int _mese { get; set; }
        public int _anno { get; set; }

        public string datas;

        public Data(int a, int b , int c)
        {
            _giorno = a;
            _mese = b;
            _anno = c;

        }

        public Data()
        {
            _giorno = 1;
            _mese = 1;
            _anno = 1900;
        }
        public string trasforma()
        {
            
            return datas=Convert.ToString(Convert.ToString(_giorno)+ "-" + Convert.ToString(_mese) + "-" + Convert.ToString(_anno)); 
        }
        public string aggiungi_togli_Giorni()
        {

            DateTime data1 = Convert.ToDateTime(datas);


            Console.WriteLine("Inserisci i numeri di giorni che vuoi aggiungere oppure quelli che vuoi togliere utilizzando (+/- numero dei giorni)");
  
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime newDate = data1.AddDays(days);
            Console.WriteLine(newDate.ToShortDateString());

            return null;
 
        }


        public static string operator ==(Data data, Data data_default)
        {
            if (data._giorno == data_default._giorno && data._mese == data_default._mese && data._anno == data_default._anno)
            {
                return "Le due date sono uguali";
            }
            else
                return "Le due date non sono uguali";
            
            
        }
        public static string operator !=(Data data, Data data_default)
        {

            return null;

        }
        public static string operator >(Data data, Data data_default)
        {
            if(data._anno>data_default._anno)
            {
                return "La prima data è più recente rispetto all'altra data";
            }else
                return "La seconda data è posteriore rispetto all'altra data";


        }
        public static string operator <(Data data, Data data_default)
        {
            return null;

        }



    }
}
