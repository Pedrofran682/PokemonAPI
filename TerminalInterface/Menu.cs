//using RestSharp;
//using System;
//using System.Text.Json;
//using VirtualPetPokemon.API;

//namespace VirtualPetPokemon.TerminalInterface
//{
//    public  class Menu
//    {
//        public  bool flag { get; private set; }
//        public bool gameRunnig { get; private set; } = true;
//        public List<MyPokemon> ListOfMyPokemons { get; set; }

//        public void StartMenu()
//        {
//            #region Print Menu
//            Console.WriteLine(@$"============================== Virtual Pokemon Pet ==============================");
//            Console.WriteLine($@"
//1 - Adoption of a Pokemon
//2 - My Pokemons
//3 - Quit");
//            #endregion

//            Console.Write("What will you do? ");
//            string option = Console.ReadLine();

//            switch (option)
//            {
//                case "1":
//                    MyPokemon newPokemon = await ChoosePokemonAsync();

//                    var pokemonInfos = new PokemonRequest();
//                    // To avoid multiples requests, lets define the parameters
//                    pokemonInfos.GetPokemonStatAsync(newPokemon);

//                    var do2Pokemon = "2";
//                    while (do2Pokemon == "1" || do2Pokemon == "2")
//                    {
//                        Console.Write(@"
//1 - See Pomekom info.
//2 - Adopt 
//3 - Leave");
//                        do2Pokemon = Console.ReadLine();

//                        if(do2Pokemon == "1") // Show Pokemon info
//                        {
//                            newPokemon.ShowPokemonStatus();
//                        }
//                        if(do2Pokemon == "2") // Adopt Pokemon
//                        {
//                            Console.WriteLine($"Congrats!!! You have adopted {newPokemon.Name}");
//                            ListOfMyPokemons.Add(newPokemon);
//                        }
//                    }
                    
//                    break;
//                case "2":
//                    MyPokemons();
//                    break;
//                case "3":
//                    Console.WriteLine("Closing...");
//                    Thread.Sleep(1000);
//                    break;

//            }



//            Console.ReadKey();
//        }

//        public void AdoptionOfPokemon(MyPokemon newPokemon)
//        {

//        }

//        public void CloseGame()
//        {
//            this.gameRunnig = false;
//        }

//        public  void MyPokemons()
//        {
//            throw new NotImplementedException();
//        }


//    }
//}
