using System;
using System.Collections.Generic;
using System.Text;

namespace my_second_app
{
  public class DOB
    {
      public string name { get; set; }
      public string job { get; set; }
      public int day { get; set; }
      public int month { get; set; }
      public string img { get; set; }

      public DOB(string _name , string _job , int _day , int _month , string _img)
      {
          name = _name ; 
          job = _job ;
          day = _day ;
          month = _month ;
          img = _img;
      }
      
    }



  public class DOB_fill
  {
      public List<DOB> famous_list = new List<DOB>();

      public void famous()
      {
          famous_list.Add(new DOB("Justin Bieber", "(SINGER)", 1, 3, "/Assets/DOB/Justin.jpg"));
          famous_list.Add(new DOB("Daniel Craig", "(MOVIE ACTOR)", 2, 3, "/Assets/DOB/Daniel.jpg"));
          famous_list.Add(new DOB("Alexander Graham Bell", "(SCIENTIST)", 3, 3, "/Assets/DOB/Alexander.jpg"));
          famous_list.Add(new DOB("Brooklyn Beckham", "", 4, 3, "/Assets/DOB/Brooklyn.jpg"));
          famous_list.Add(new DOB("Eva Mendes", "(MOVIE ACTRESS)", 5, 3, "/Assets/DOB/Eva.jpg"));
          famous_list.Add(new DOB("Lou Costello", "(COMEDIAN)", 6, 3, "/Assets/DOB/Lou.jpg"));
          famous_list.Add(new DOB("Bryan Cranston", "", 7, 3, "/Assets/DOB/Bryan.jpg"));

          famous_list.Add(new DOB("Freddie Prinze", "Actor", 8, 3, "/Assets/DOB/Freddie.jpg"));
          famous_list.Add(new DOB("Bow Wow", "Rapper", 9, 3, "/Assets/DOB/Bow.jpg"));
          famous_list.Add(new DOB("Chuck Norris", "Actor", 10, 3, "/Assets/DOB/Chuck.jpg"));
          famous_list.Add(new DOB("Didier Drogba", "SOCCER PLAYER", 11, 3, "/Assets/DOB/Didier.jpg"));
          famous_list.Add(new DOB("Mitt Romney", "POLITICIAN", 12, 3, "/Assets/DOB/Mitt.jpg"));
          famous_list.Add(new DOB("Lucy Fry", "Actress", 13, 3, "/Assets/DOB/Lucy.jpg"));
          famous_list.Add(new DOB("Albert Einstein", "Scientist", 14, 3, "/Assets/DOB/Albert.jpg"));
          famous_list.Add(new DOB("Will I Am", "Singer", 15, 3, "/Assets/DOB/Will.jpg"));
          famous_list.Add(new DOB("Tyrel Jackson Williams", "Actor", 16, 3, "/Assets/DOB/Tyrel.jpg"));
          famous_list.Add(new DOB("Kurt Russell", "Actor", 17, 3, "/Assets/DOB/Kurt.jpg"));
          famous_list.Add(new DOB("Adam Levine", "Singer", 18, 3, "/Assets/DOB/Adam.jpg"));
          famous_list.Add(new DOB("Bruce Willis", "Actor", 19, 3, "/Assets/DOB/Bruce.jpg"));
          famous_list.Add(new DOB("Fernando Torres", "SOCCER PLAYER", 20, 3, "/Assets/DOB/Fernando.jpg"));
          famous_list.Add(new DOB("Ronaldinho", "SOCCER PLAYER", 21, 3, "/Assets/DOB/Ronaldinho.jpg"));
          famous_list.Add(new DOB("Bassem Youssef", "TV SHOW HOST", 22, 3, "/Assets/DOB/Bassem.jpg"));
          famous_list.Add(new DOB("Kyrie Irving", "BASKETBALL PLAYER", 23, 3, "/Assets/DOB/Kyrie.jpg"));
          famous_list.Add(new DOB("The Undertaker", "WRESTLER", 24, 3, "/Assets/DOB/.jpg"));
          famous_list.Add(new DOB("Big Sean", "Rapper", 125, 3, "/Assets/DOB/The.jpg"));
          famous_list.Add(new DOB("Eric Allan Kramer", "Actor", 26, 3, "/Assets/DOB/Eric.jpg"));
          famous_list.Add(new DOB("Manuel Neuer", "SOCCER PLAYER", 27, 3, "/Assets/DOB/Manuel.jpg"));
          famous_list.Add(new DOB("Lady Gaga", "Singer", 28, 3, "/Assets/DOB/Lady.jpg"));
          famous_list.Add(new DOB("Scott Wilson", "Actor", 29, 3, "/Assets/DOB/Scott.jpg"));
          famous_list.Add(new DOB("Sergio Ramos", "SOCCER PLAYER", 30, 3, "/Assets/DOB/Sergio.jpg"));
          famous_list.Add(new DOB("Ewan McGregor", "Actor", 31, 3, "/Assets/DOB/Ewan.jpg"));
      //    famous_list.Add(new DOB("", "", 1, 3, "/Assets/DOB/.jpg"));


        

          
      }
  }


}
