using System;
using System.Collections.Generic;
using System.Linq;

namespace laboratorna1OOP
{
    class Country
    {

        private string Name;
        private string formOfGoverment;
        private float area;
        private float population;
        private string language;
        public Country(string Name, string formOfGoverment, float area, float population, string language)
        {
            this.Name = Name;
            this.formOfGoverment = formOfGoverment;
            this.area = area;
            this.population = population;
            this.language = language;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetFormofGoverment()
        {
            return formOfGoverment;
        }
        public float GetArea()
        {
            return area;
        }
        public float GetPopulation()
        {
            return population;
        }
        public string GetLanguage()
        {
            return language;
        }
        public Country()
        { }
        public void Input()
        {
            Name = Console.ReadLine();
            formOfGoverment = Console.ReadLine();
            area = Convert.ToSingle(Console.ReadLine());
            population = Convert.ToSingle(Console.ReadLine());
            language = Console.ReadLine();
        }
        public string getInfo()
        {
            return "Назва країни: " + Name + " \nФорма правління: " + formOfGoverment + " \nПлоща: " + area + "\nПопуляція: " + population + "\nМова: " + language;
        }
        public double AreaPerPopulation()
        {
            return area / population;
        }
        public string CheckInfoForSearch(string EnteredName)
        {
            if (Name.ToLower().Equals(EnteredName.ToLower())
                || formOfGoverment.ToLower() == EnteredName.ToLower()
                || Convert.ToString(area) == EnteredName
                || Convert.ToString(population) == EnteredName
                || language.ToLower() == EnteredName.ToLower())
            {
                return getInfo();
            }
            return null;
        }

    }


    class Program
    {
        public static List<Country> countries = new List<Country>();
        public static List<Country> GetUserByName(string name)
        {
            List<Country> list = new List<Country>();
            foreach (Country i in countries)
            {
                if (i.GetName() == name)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        static void Menu()
        {
            Console.WriteLine("1.Додати країну");
            Console.WriteLine("2.Показати усі країни");
            Console.WriteLine("3.Пошук");
            Console.WriteLine("4.Видалення");
            Console.WriteLine("5.Сортування");
            Console.WriteLine("6.Individual");
            Console.WriteLine("7.Вихід");
        }
        static void Add()
        {
            Country country = new Country();
            Console.Clear();
            Console.WriteLine("Введiть назву країни, Форма правління, Площа, Популяція, Мову:");
            country.Input();
            countries.Add(country);
            Console.Clear();
        }
        static void Show()
        {
            Console.Clear();
            foreach (var item in countries)
            {
                Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.getInfo()}\n");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Введiть номер країни, що потрiбно видалити: ");
            countries.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();
        }
        static void Search()
        {
            Console.Clear();
            Console.WriteLine("Пошук: ");
            string EnteredValue = Console.ReadLine();
            Console.Clear();
            int q = 0;
            foreach (var item in countries)
            {
                if (item.CheckInfoForSearch(EnteredValue) != null)
                {
                    q++;
                    Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.CheckInfoForSearch(EnteredValue)}\n");
                }
            }
            if (q == 0)
            {
                Console.WriteLine("Нічого не знайдено");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Sort()
        {
            Console.Clear();
            Console.WriteLine("Оберiть ознаку сортування:\n1.Назва\n2.Форма правління\n3.Площа\n4.Популяція\n5.Мова");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Clear();
                        for (int i = 0; i < countries.Count(); i++)
                        {
                            for (int j = 0; j < countries.Count() - 1 - i; j++)
                            {
                                if (countries[j].GetName().ToLower().CompareTo(countries[j + 1].GetName().ToLower()) > 0)
                                {
                                    Country temp = countries[j];
                                    countries[j] = countries[j + 1];
                                    countries[j + 1] = temp;
                                }
                            }
                        }
                        foreach (Country item in countries)
                        {
                            Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.getInfo()}\n");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                case 2:
                    {
                        Console.Clear();
                        for (int i = 0; i < countries.Count(); i++)
                        {
                            for (int j = 0; j < countries.Count() - 1 - i; j++)
                            {
                                if (countries[j].GetFormofGoverment().ToLower().CompareTo(countries[j + 1].GetFormofGoverment().ToLower()) > 0)
                                {
                                    Country temp = countries[j];
                                    countries[j] = countries[j + 1];
                                    countries[j + 1] = temp;
                                }
                            }
                        }
                        foreach (Country item in countries)
                        {
                            Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.getInfo()}\n");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                case 3:
                    {
                        Console.Clear();
                        for (int i = 0; i < countries.Count(); i++)
                        {
                            for (int j = 0; j < countries.Count() - 1 - i; j++)
                            {
                                if (countries[j].GetArea().CompareTo(countries[j + 1].GetArea()) > 0)
                                {
                                    Country temp = countries[j];
                                    countries[j] = countries[j + 1];
                                    countries[j + 1] = temp;
                                }
                            }
                        }
                        foreach (Country item in countries)
                        {
                            Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.getInfo()}\n");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                case 4:
                    {
                        Console.Clear();
                        for (int i = 0; i < countries.Count(); i++)
                        {
                            for (int j = 0; j < countries.Count() - 1 - i; j++)
                            {
                                if (countries[j].GetPopulation().CompareTo(countries[j + 1].GetPopulation()) > 0)
                                {
                                    Country temp = countries[j];
                                    countries[j] = countries[j + 1];
                                    countries[j + 1] = temp;
                                }
                            }
                        }
                        foreach (Country item in countries)
                        {
                            Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.getInfo()}\n");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                case 5:
                    {
                        Console.Clear();
                        for (int i = 0; i < countries.Count(); i++)
                        {
                            for (int j = 0; j < countries.Count() - 1 - i; j++)
                            {
                                if (countries[j].GetLanguage().CompareTo(countries[j + 1].GetLanguage()) > 0)
                                {
                                    Country temp = countries[j];
                                    countries[j] = countries[j + 1];
                                    countries[j + 1] = temp;
                                }
                            }
                        }
                        foreach (Country item in countries)
                        {
                            Console.WriteLine($"Iндекс: {countries.IndexOf(item)}\n{item.getInfo()}\n");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }


        public static void Calculate()
        {
            Console.Clear();
            Console.WriteLine("Виберiть номер країни: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Популяції на одну людину: {countries[index].AreaPerPopulation()}");
            Console.ReadKey();
            Console.Clear();
        }

        static void Exit()
        {
            System.Environment.Exit(0);
        }
        static void notTrueChoose()
        {
            Console.WriteLine("Такого пункта меню не існує.");
        }

        static void Main(string[] args)
        {
            bool w = true;
            while (w)
            {
                Menu();
				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 1:
						{
                            Add();
                            break;
						}
					case 2:
						{
                            Show();
                            break;
						}
					case 3:
						{
                            Search();
                            break;
						}
					case 4:
						{
                            Delete();
                            break;
						}
                    case 5:
                        {
                            Sort();
                            break;
                        }
                    case 6:
                        {
                            Calculate();
                            break;
                        }
					case 7:
						{
                            Exit();
                            break;
						}
					default:
                        {
                            notTrueChoose();
                            break;
						}
				}
			}
		}
    }
}
