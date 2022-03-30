public class Alien{
  // Construtor:
  public Alien(string visitorName, string visitorRace, int visitorAge, float visitorHeight){
    this.name = visitorName;
    this.race = visitorRace;
    this.age = visitorAge;
    this.height = visitorHeight;
  }
  // Attribs:
  private string name;
  private string race;
  private int age;
  private float height;

  // getters and setters:
  public string getName(){return this.name;}
  public void setName(string n){this.name = n;}

  public string getRace() {return this.race;}
  public void setRace(string r) {this.race = r;}
  
  public int getAge() {return this.age;}
  public void setAge(int a) {this.age = a;}

  public float getHeight() {return this.height;}
  public void setHeight(float h) {this.height = h;}
}


/*
string name;
int age;
float height;
string race;
string permission = "está";

Console.WriteLine("Cadastrando novo viajante");
Console.WriteLine("Insira o nome do viajante: ");
name = Console.ReadLine();
Console.WriteLine("Insira a idade do viajante: ");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a altura do viajante: ");
height = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a raça do viajante: ");
race = Console.ReadLine();
*/