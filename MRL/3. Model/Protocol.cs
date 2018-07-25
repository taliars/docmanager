﻿using System;
using MRL.Common;


namespace MRL.Model
{
    public class Protocol
    {
        public string Species { get; set; }         //вид протокола
        public string Name { get; set; }            //нгаименование протокола
        public string Date { get; set; }            //дата протокола
        public string Dates { get; set; }           //даты измерений
        public string Perfomer { get; set; }        //исполнитель
    }

    public class Protocols: RangedObservableCollection<Protocol>
    {
        public void AddNew(string species)
        {
            string name = "";

            switch (species)
            {
                case "Шум":
                    name = "шм";
                    break;

                case "Инфрзвук":
                    name = "иф";
                    break;

                case "Вибрация":
                    name = "вб";
                    break;

                case "ЭМИ 50 Гц":
                    name = "эм";
                    break;

                case "Радиация":
                    name = "рн";
                    break;

                case "Радионуклиды":
                    name = "рн";
                    break;

                case "Почва":
                    name = "пч";
                    break;

                case "Вода":
                    name = "пв";
                    break;

                case "Воздух":
                    name = "ав";
                    break;

                default:
                    break;
            }

            Random random = new Random();

            this.Add(new Protocol
            {
                Species = species,
                Name = random.Next(1, 999) + name + "-234-18",
                Date = DateTime.Now.Date.ToString(), 
                Perfomer = "Z"               
            });
        }            
    }
}
