using System;
using System.Collections.Generic;
using System.Text;

namespace my_second_app
{
   public class quotes
    {
       public int id { set; get; }
       public string quote { set; get; }
       public string name { set; get; }
       public string img { set; get; }


       public quotes(int _id , string _name ,string _quote , string _img)
       {
           id = _id;
           quote = _quote;
           img = _img;
           name = _name;
       }

    }


   public class quote_fill
   {

     public  List<quotes> q = new List<quotes>();

     public void fun1()
     {


         q.Add(new quotes(0, "–Thomas Edison", "Just because something doesn’t do what you planned it to do doesn’t mean it’s useless.", "/Assets/quotes/edison.jpg"));
         q.Add(new quotes(0, "–Albert Einstein", "It has become appallingly obvious that our technology has exceeded our humanity.", "/Assets/quotes/albert.jpg"));
         q.Add(new quotes(0, "–John Cleese", "If you want creative workers, give them enough time to play.", "/Assets/quotes/John.jpg"));
         q.Add(new quotes(0, "–Abraham Lincoln", "People are just about as happy as they make up their minds to be", "/Assets/quotes/Abraham.jpg"));
         q.Add(new quotes(0, "–William Jamesn", "The greatest discovery of my generation is that human beings can alter their lives by altering their attitudes of mind", "/Assets/quotes/William2.jpg"));
         q.Add(new quotes(0, "–Dennis P. Kimbro", "Life is 10% what happens to us and 90% how we react to it", "/Assets/quotes/Dennis.jpg"));
         q.Add(new quotes(0, "–Eleanor Roosevelt", "Learn from the mistakes of others. You can’t live long enough to make them all yourself", "/Assets/quotes/Eleanor.jpg"));
        // q.Add(new quotes(0, "–Eleanor Roosevelt", "If someone betrays you once, it’s his fault. If he betrays you twice, it’s your fault", "/Assets/quotes/Eleanor.jpg"));
         q.Add(new quotes(0, "–William Shakespeare", "Be not afraid of greatness: some are born great, some achieve greatness, and some have greatness thrust upon them", "/Assets/quotes/William.jpg"));
         q.Add(new quotes(0, "–Muhammad Ali", "A man with no imagination has no wings.", "/Assets/quotes/Muhammad.jpg"));
         q.Add(new quotes(0, "–Stephen Hawking", "However difficult life may seem, there is always something you can do and succeed at.", "/Assets/quotes/Stephen.jpg"));
      //   q.Add(new quotes(0, "–Eleanor Roosevelt", "Many people will walk in and out or your life, But only true friends will leave footprints in your heart", "/Assets/quotes/Eleanor.jpg"));
         
     }
       

   }




}
