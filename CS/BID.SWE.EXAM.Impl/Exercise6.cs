using System;
using BID.SWE1.Exam.Interfaces;
using System.Data.SqlClient;
namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            string queryString = $"INSERT INTO TestAbgaben (Id,Tag,Monat,Jahr,Stunde,Minute,Name) VALUES(@Id,@Tag,@Monat,@Jahr,@Stunde,@Minute,@Name) ";
            DateTime dt = new DateTime();
            try
            {
                    SqlCommand command = new SqlCommand(queryString);
                    command.Parameters.AddWithValue("@Id", 1);
                    command.Parameters.AddWithValue("@Tag", dt.Day);
                    command.Parameters.AddWithValue("@Monat", dt.Month);
                    command.Parameters.AddWithValue("@Jahr", dt.Year);
                    command.Parameters.AddWithValue("@Stunde", dt.Hour);
                    command.Parameters.AddWithValue("@Minute", dt.Minute);
                    command.Parameters.AddWithValue("@Name", "Yavor Ivanov");
                    return command;
                }
            catch (Exception e)
            {
                throw e;

            }
            
        }
    }
}