using System;
using System.Collections.Generic;

class Program {
    
  public static void Main (string[] args) {
  string name;
  int age;
  float height;
  string race;
  string permission;
  int state = 0;
  string screen = "MenuInicial";
  bool isRunning = true;
  string continueRegistering;
  var aliens = new List<Alien>();
  
  while(isRunning){
    switch (screen) {
      case "MenuInicial":
        MenuInicial();
        break;
      case "Cadastro":
        CadastrarViajante();
        break;
      case "Consulta":
        Console.WriteLine("Lista de viajantes atendidos nesta sessão:");
        ConsultaViajantes();
        state = 0;
        screen = "MenuInicial";
        break;
      case "Emergencia":
        Console.WriteLine("Acionou a Emergência");
        
        break;
    }
  }

  void MenuInicial(){
    Console.WriteLine("Escolha sua opção:");
    Console.WriteLine("1 - Cadastro");
    Console.WriteLine("2 - Consulta");
    Console.WriteLine("3 - Emergência!!!");
    Console.WriteLine("0 - Sair");
    state = int.Parse(Console.ReadLine());
        
    if (state == 1) screen = "Cadastro";
    else if (state == 2) screen = "Consulta";
    else if (state == 3) screen = "Emergencia";
    else if (state == 0) isRunning = false;
    else Console.WriteLine("Opção Inválida");
  }
    
  void CadastrarViajante(){
    Console.WriteLine("Cadastrando novo viajante");
    Console.WriteLine("Insira o nome do viajante: ");
    name = Console.ReadLine();
    Console.WriteLine("Insira a idade do viajante: ");
    age = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira a altura do viajante: ");
    height = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira a raça do viajante: ");
    race = Console.ReadLine();
  
    if (race == "Klingon" || 
        race == "Vuvrian" || 
        name == "Jabba" || 
        name == "Revan" || 
        name == "Borg" || 
        height > 2.8f) {
      permission = "não está";
    } else {
      permission = "está";
    }
    Console.WriteLine("O viajante {0}, da raça {1}, tem {2} anos e {3}m de altura e {4} autorizado a entrar no planeta Terra", name, race, age, height, permission);
    if (permission == "está") Console.WriteLine("O Imposto para a entrada de {0} é de {1}.", name, CalculaImposto(height));
    Alien traveler = new Alien(name, race, age, height);
    aliens.Add(traveler); // adiciona o viajante à lista
    Console.WriteLine("Deseja cadastrar outro viajante? s/n");
                 
    do {  
      continueRegistering = Console.ReadLine();
      if (continueRegistering == "n" || continueRegistering == "N"){
        screen = "MenuInicial";
        state = 1;
      } else Console.WriteLine("Opção inválida.");
    } while(continueRegistering != "n" && 
             continueRegistering != "N" && 
             continueRegistering != "s" && 
             continueRegistering != "S");
  } // Fecha a função CadastrarViajante()

  float CalculaImposto(float h){
    return h * 100;
  }

  void ConsultaViajantes(){
    foreach(Alien a in aliens){
      Console.WriteLine("Nome: {0} Raça: {1} Idade: {2} Altura: {3}", a.getName(), a.getRace(), a.getAge(), a.getHeight());
    }
  }
    
  } // Fecha a funçao Main()
} // Fecha a classe Program()