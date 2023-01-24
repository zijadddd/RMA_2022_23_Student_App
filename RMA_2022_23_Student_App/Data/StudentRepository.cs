using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App.Data
{
    public class StudentRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null) return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<Student>();
        }

        public void AddNewStudent(int studentId, string firstName, string lastName, string birthDate, string location, string phoneNumber, string email, string password,
                                  string index, string university, string faculty, string department, string description, string profilePhotoUrl) {
            int result = 0;
            try
            {
                Init();

                if (string.IsNullOrEmpty(firstName)) throw new Exception("First name field cannot be null or empty.");
                if (string.IsNullOrEmpty(lastName)) throw new Exception("Last name field cannot be null or empty.");
                if (string.IsNullOrEmpty(birthDate)) throw new Exception("Birth field date cannot be null or empty.");
                if (string.IsNullOrEmpty(location)) throw new Exception("Location field cannot be null or empty.");
                if (string.IsNullOrEmpty(phoneNumber)) throw new Exception("Phone field number cannot be null or empty.");
                if (string.IsNullOrEmpty(email)) throw new Exception("Email field cannot be null or empty.");
                if (string.IsNullOrEmpty(password)) throw new Exception("Password field cannot be null or empty.");
                if (string.IsNullOrEmpty(index)) throw new Exception("Index field cannot be null or empty.");
                if (string.IsNullOrEmpty(university)) throw new Exception("University field cannot be null or empty.");
                if (string.IsNullOrEmpty(faculty)) throw new Exception("Faculty field cannot be null or empty.");
                if (string.IsNullOrEmpty(department)) throw new Exception("Department field cannot be null or empty.");
                if (string.IsNullOrEmpty(description)) throw new Exception("Description field cannot be null or empty.");
                if (string.IsNullOrEmpty(profilePhotoUrl)) throw new Exception("Profile photo url field cannot be null or empty.");

                result = conn.Insert(new Student { 
                                                   studentId = studentId,
                                                   firstName = firstName, 
                                                   lastName = lastName,
                                                   birthDate = birthDate,
                                                   location = location,
                                                   phoneNumber = phoneNumber,
                                                   email = email,
                                                   password = password,
                                                   index = index,
                                                   university = university,
                                                   faculty = faculty,
                                                   department = department,
                                                   description = description,
                                                   profilePhotoUrl = profilePhotoUrl});

                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, firstName + " " + lastName);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", firstName + " " + lastName, ex.Message);
            }
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                Init();
                return conn.Table<Student>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("It's not possible to load data from database. {0}", ex.Message);
            }

            return new List<Student>();
        }
    }
}
