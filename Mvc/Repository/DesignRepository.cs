using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Mvc.Models;

namespace Mvc.Repository
{
    public class DesignRepository
    {
            public readonly string Connectionstring;

            public DesignRepository()
            {

            Connectionstring = @"Data source=DESKTOP-23V7KHU;Initial catalog=Painto;User Id=sa;Password=Anaiyaan@123";
        }

        public DesignveiwModel Model()
        {
            DesignveiwModel Pan = new DesignveiwModel();

            Console.WriteLine("Enter the Name");
            Pan.Name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            Pan.Email = Console.ReadLine();
            Console.WriteLine("Enter the Phonenumber");
            Pan.Phonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Massages");
            Pan.Message = Console.ReadLine();

            return Pan;
        }
        public void Insertinfo(DesignveiwModel a)
        {
            try
            {

                SqlConnection con = new SqlConnection(Connectionstring);

                con.Open();
                con.Execute($"exec insertinfo  '{a.Name}','{a.Email}',{a.Phonenumber},'{a.Message}'");
                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
