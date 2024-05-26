using PRGProject.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Team Members
//Dylan , Mphela, Hatlane and Tumelo

/// With the con Variable change the server path to match with local computer
/// Store and unzip file in the desktop to accomodate the paths of all images and server
namespace PRGProject.DataLayer
{

    internal class DataHandler
    {
        string con = "Server = SINBAD\\SQLEXPRESS;Initial Catalog = BCStudentSystem; Integrated Security = SSPI"; //String variable conn will be used to connect to the dataabase
        DataTable table; // Initializing of a global datatable object
        SqlDataAdapter adapter;
        string query;


        
        //  Student Crud Operations Methods

        public DataTable ALLStudentData() // Retrieves all available Student Data 
        {
            query = @"SELECT * FROM BCStudents";


            adapter = new SqlDataAdapter(query, con);

            table = new DataTable();

            adapter.Fill(table);


            return table;
        }

         public void ADDStudent( Student student) //This method will allow user to add a new student to the database 
        {
               try
              {
                    query = $"INSERT INTO BCStudents VALUES ({student.StudentNumber},'{student.Name}', '{student.SurName}', '', '{student.DOB}','{student.PhoneNumber}', '{student.Address}', '{student.ModCode}','{student.gender}')";

                   using (SqlConnection connection = new SqlConnection(con))
                   {
                       using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();

                        }
                    }

                }
                catch (Exception e)
               {

                    Console.WriteLine(e.Message);
                }
         }


        public void UpdateStudent(Student student)//This method will be update student method
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studentNum", student.StudentNumber);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Surname", student.SurName);
                cmd.Parameters.AddWithValue("@DateOFBirth", student.DOB);
                cmd.Parameters.AddWithValue("@Phone", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@ModuleCode", student.ModCode);
                cmd.Parameters.AddWithValue("@Gender", student.gender);

                connection.Open();
                cmd.ExecuteNonQuery();

            }

        }

        public void DeleteStudent(int StudNum)
        {

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@studNum", StudNum);


                connection.Open();
                cmd.ExecuteNonQuery();


            }
        }//

        public DataTable SearchStudent(int StudNum)
        {

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spStudentSearch", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudNum", StudNum);

                connection.Open();
                table = new DataTable();
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);

                    return table;


                }



            }
        }

    // ============================================================================================================

    // ------------------------------------------ Module Crud Code ------------------------------------------------

    // ============================================================================================================
        public DataTable ALLModuleData() // Retrieves all available Module Data 
        {
            query = @"SELECT * FROM BCModules";

            adapter = new SqlDataAdapter(query, con);

            table = new DataTable();

            adapter.Fill(table);
            return table; ;

        }
        public void AddModule(Module module)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spModuleADD", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mcode", module.ModCode);
                cmd.Parameters.AddWithValue("@mName", module.ModName);
                cmd.Parameters.AddWithValue("@mDescription", module.ModDescription);
                cmd.Parameters.AddWithValue("@Links", module.ModLink);

                connection.Open();
                cmd.ExecuteNonQuery();

            }



        }

        public void UpdateModule(Module module)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spModuleUpdate", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mcode", module.ModCode);
                cmd.Parameters.AddWithValue("@mName", module.ModName);
                cmd.Parameters.AddWithValue("@mDescription", module.ModDescription);
                cmd.Parameters.AddWithValue("@Links", module.ModLink);

                connection.Open();
                cmd.ExecuteNonQuery();

            }

        }

        public void DeleteModule(int moduleCode)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spDeleteMod", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mcode", moduleCode);
                connection.Open();
                cmd.ExecuteNonQuery();

            }

        }

        public DataTable SearchModule(int moduleCode)
        {

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spModuleSearch", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mcode", moduleCode);

                connection.Open();
                table = new DataTable();
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);

                    return table;


                }



            }
        }


    }
    
}
