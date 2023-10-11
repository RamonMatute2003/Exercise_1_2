using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_2{
    public class Employee {
        private static string names, surnames, birth_date, email;

        public Employee(){
            
        }

        public static string get_name(){
            return names;
        }

        public static string get_surnames(){
            return surnames;
        }

        public static string get_birth_date(){
            return birth_date;
        }

        public static string get_email(){
            return email;
        }

        public void set_name(string name){
            names=name;
        }

        public void set_surnames(string surname){
            surnames=surname;
        }

        public void set_birth_date(string birth_date1){
            birth_date=birth_date1;
        }

        public void set_email(string email1){
            email=email1;
        }
    }
}
