using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Tofa";
            Console.WriteLine(strStore.Data);

            DataStore<int> age= new DataStore<int>();
            age.Data = 99;
            Console.WriteLine(strStore.Data+" age of "+age.Data);

            keyValuePair<int, string> kvp = new keyValuePair<int, string>();
            kvp.Key = 123;
            kvp.Value = "Hundread";
            Console.WriteLine(kvp.Key+" "+kvp.Value);

            keyValuePair<int,string>kvp1= new keyValuePair<int,string>();
            kvp1.Key = 66;
            kvp1.Value = "Alu Khan";
            Console.WriteLine(kvp1.Value + " age of "+kvp1.Key);

            Icon<string> ic = new Icon<string>();
            ic.News = "Prothom Alo";
            Console.WriteLine(ic.News);
            UCC<int ,string>u= new UCC<int ,string>();
            u.Id = 01;
            u.Name = "Tofa";
            Console.WriteLine(u.Name+" is id no "+u.Id);

            Console.ReadKey();
        }
    }
    class DataStore<T>
    {
        public T Data { get; set; }
    }
    public class keyValuePair<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

    }
    public class Icon<T>
    {
        public T News { get; set; }
    }
    public class UCC<Tkey, Tvalue>
    {
        public Tkey Id { get; set; }
        public Tvalue Name { get; set; }
    }
}
