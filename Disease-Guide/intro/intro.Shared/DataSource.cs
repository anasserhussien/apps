using System;
using System.Collections.Generic;
using System.Text;

namespace intro
{
    public class DataSource
    {

        public int id { set; get; }
        public string name { set; get; }
        public string types { set; get; }
        public string img { set; get; }
        public string title { set; get; }
        public string desc { set; get; }

        public DataSource(int _id , string _name , string _types , string _img , string _title , string _desc)
        {
            id = _id;
            name = _name;
            types = _types;
            img = _img;
            title = _title;
            desc = _desc;
        }
        
    }



    public class Datafill
    {
      
     public List<DataSource> diseases = new List<DataSource>();
        

       public void fun1()
       { 
           ///Assets/0.jpg

           diseases.Add(new DataSource(0, "Liver", "\n\n Hepatitis A \n Hepatitis B \n Hepatitis C", "/Assets/doc.jpg", "Types of Viral Hepatitis ", "Hepatitis"));
           diseases.Add(new DataSource(1, "Heart", "\n\n Rheumatic heart disease\n Hypertensive heart disease\n Ischemic heart disease\n Cerebrovascular disease\n Inflammatory heart disease", "/Assets/doc.jpg", "222222222222", "blaaaaaaaa"));
           diseases.Add(new DataSource(2, "Diabetes", "\n\n Type 1 Diabetes\n Type 2 Diabetes \n Gestational Diabetes", "/Assets/doc.jpg", "3333333333333", "bla blaaaaaaaaaa"));
           diseases.Add(new DataSource(3, "Pressure", "\n\n Malignant Hypertension\n Secondary Hypertension\n Renal Hypertension ", "/Assets/doc.jpg", "4444444444", "44444 :'D "));

        }


    }


}