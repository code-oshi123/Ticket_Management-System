using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class AdminConClass 
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=ticketdb";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddLoc(string name,string address,string ownername)
        {
            LocationClass location = new LocationClass(name, address, ownername);

            if (name.Equals("") || address.Equals("") || ownername.Equals(""))
            {
                return "Please fill all fields";
            }

            if (!name.All(char.IsLetter) || !ownername.All(char.IsLetter))
            {
                return "Please enter letters only for description and location name";
            }

            conn.Open();
            string query5 = "INSERT INTO locationtable (locname, locaddress, locowner,morning,evening) VALUES (@location.Locname, @location.Locaddress, @location.Locowner,@available,@available)";
            MySqlCommand cmd4 = new MySqlCommand(query5, conn);
            cmd4.Parameters.AddWithValue("@location.Locname", location.Locname);
            cmd4.Parameters.AddWithValue("@location.Locaddress", location.Locaddress);
            cmd4.Parameters.AddWithValue("@location.Locowner", location.Locowner);
            cmd4.Parameters.AddWithValue("available", "available");
            cmd4.ExecuteNonQuery();
            conn.Close();
            return "Location Added";
        }

        public static void Setavailablity(string time, string id)
        {
            conn.Open();

            string checkQuery = "";
            if (time == "morning")
            {
                checkQuery = "SELECT morning FROM locationtable WHERE locid = @id";
            }
            else if (time == "evening")
            {
                checkQuery = "SELECT evening FROM locationtable WHERE locid = @id";
            }
            else
            {
                conn.Close();
                MessageBox.Show("Invalid time selection");
                return;
            }

            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@id", id);
            object result = checkCmd.ExecuteScalar();

            if (result != null && result.ToString() == "Booked")
            {
                conn.Close();
                MessageBox.Show($"{time} slot is already booked.");
                return;
            }

            // If not booked, mark as booked
            string updateQuery = $"UPDATE locationtable SET {time} = 'Booked' WHERE locid = @id";
            MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@id", id);
            updateCmd.ExecuteNonQuery();

            conn.Close();
        }

        public static bool IsTimeAvailable(string time, string id)
        {
            conn.Open();

            string query = $"SELECT {time} FROM locationtable WHERE locid = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            object result = cmd.ExecuteScalar();

            conn.Close();

            // If the value is "Booked", return false
            return result == null || result.ToString() != "Booked";
        }

        public static string DeleteLocation(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return "Please fill all fields";
            }

            try
            {
                Convert.ToInt32(id); // Optional: Validate as number if locid is numeric
            }
            catch
            {
                return "Id must be a number.";
            }

            try
            {
                string selectQuery = "SELECT locid FROM locationtable WHERE locid = @locid";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@locid", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            conn.Close();
                            return "Location not found";
                        }
                    }

                    conn.Close(); // Close before DELETE
                }

                // Now delete the location
                string deleteQuery = "DELETE FROM locationtable WHERE locid = @locid";
                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn))
                {
                    conn.Open();
                    cmdDelete.Parameters.AddWithValue("@locid", id);
                    cmdDelete.ExecuteNonQuery();
                    conn.Close();
                }

                return "Location deleted successfully";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static List<string> ViewAdminLocation()
        {
            List<string> events = new List<string>();
            string query = "SELECT * FROM locationtable";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int locid = reader.GetInt32("locid");
                            
                            string locname = reader.GetString("locname");
                            string locaddress = reader.GetString("locaddress");
                            string locowner = reader.GetString("locowner");
                            string mor_avalilability = reader.GetString("morning");
                            string eve_avalilability = reader.GetString("evening"); 

                            events.Add($"{locid} | {locname} | {locaddress} | {locowner} |{mor_avalilability} | {eve_avalilability}");
                            

                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log error or show message
                    Debug.WriteLine($"Database error: {ex.Message}");
                    return null;
                }
            }

            return events;
        }
    }
}
