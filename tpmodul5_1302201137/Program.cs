﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics.Contracts;


namespace tpmodul5_1302201137
{
    internal class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo N = new SayaTubeVideo("Tutorial Design By Contract - Debi Ratnasari Novianti");

            N.PrintVideoDetails();
            Console.WriteLine("");
            Console.WriteLine("");


            N.IncreasePlayCount(5);
            N.PrintVideoDetails();

        }

    }
    public class SayaTubeVideo
    {

        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);

            this.title = title;
            Random random_id = new Random();
            id = random_id.Next(0, 100000);
            playCount = 0;
        }



        public void IncreasePlayCount(int count)
        {
            try
            {
                if (count >= 10000000) throw new Exception("Input Penambahan Playcount Maksimal 10.000.000!");
                playCount = playCount + count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        public void PrintVideoDetails()
        {

            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(playCount);

        }
    }
}