using System;
namespace Domain.Entities
{
	public class Car
	{
        public string name { get; set; }
        public int year { get; set; }
        public string model { get; set; }
        public float price { get; set; }
        public string brand { get; set; }

        public void StarEngine()
        {

            Console.WriteLine("starting car engine ...");
        }

        public void StopEngine()
        {
            Console.WriteLine("stopiong car engine ...");
        }

        public void Break()
        {
            Console.WriteLine("breaking car...");
        }
    }
}

