using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evaluation_Manager.Models;
using DBLayer;

namespace Evaluation_Manager.Repositories {
	public class StudentRepository {
		public static List <Student> GetStudents () {
			List <Student> students = new List <Student> ();
			string selectQuery = "SELECT * FROM Students";
			DB.OpenConnection();
			var reader = DB.GetDataReader(selectQuery);
			while (reader.Read()) {
				Student student = CreateObject();
				students.Add(student);
			}
			reader.Close();
			DB.CloseConnection();
			return students;
		}
		private static Student CreateObject(System.Data.SqlClient.SqlDataReader reader) {
			int id = int.Parse(reader["Id"].ToString());
			string firstName = reader["FirstName"].ToString();
			string lastName = reader["LastName"].ToString();
			int grade = int.Parse(reader["Grade"].ToString());

			Student s = new Student();
			s.Id = id;
			s.FirstName = firstName;
			s.LastName = lastName;
			s.Grade = grade;

			return s;
		}
	}
}
