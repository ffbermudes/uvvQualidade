using System;

namespace AOP3UVV {
    public class StudentData {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Registration { get; set; }
        public string Date { get; set; }

        public StudentData(string nome, string senha, string email, int registration, string data) {

            Name = nome;
            Password = senha;
            Email = email;
            Registration = registration;
            Date = data;
        }

        public override string ToString() {
            return $"Name: {Name}, Password: {Password}, Email: {Email}, Registration: {Registration}, Date: {Date}";
        }

        public static void Main() {
            StudentData student = new StudentData("filipe", "123456", "email.com", 1, "10/04/1993");

        }
    }



}
