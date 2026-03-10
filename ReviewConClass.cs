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

    internal class ReviewConClass
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=ticketdb";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddReview(string eventreviewid, string eventreviewname, string eventreview)
        {

            FeedbackClass feedback = new FeedbackClass(Convert.ToInt32(eventreviewid), eventreviewname,eventreview);
            

            if (eventreviewid.Equals("") || eventreviewname.Equals("") || eventreview.Equals(""))
            {
                return "Please fill all fields";
            }
            try
            {
                Convert.ToInt32(feedback.Eventid);
            }
            catch (Exception ex)
            {
                return "Id must be a number.";
            }

            //check name is matched and add to feedback
            string query1 = "SELECT eventname FROM feedbacktable WHERE id = @eventreviewid";
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@eventreviewid", eventreviewid);

            using (MySqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.Read())
                {
                    string dbName = reader.GetString("eventname");

                    if (!dbName.Equals(eventreviewname, StringComparison.OrdinalIgnoreCase))
                    {
                        conn.Close();
                        return "Event id and name don't match";
                    }
                    // If names match, close reader and connection so we can insert feedback next
                    conn.Close();

                    // Insert feedback now
                    string query4 = "INSERT INTO feedbacktable (eventid, eventname, feedback) VALUES (@Eventid, @Eventname, @Feedback)";
                    conn.Open();
                    MySqlCommand cmd4 = new MySqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@Eventid", feedback.Eventid);
                    cmd4.Parameters.AddWithValue("@Eventname", feedback.Eventname);
                    cmd4.Parameters.AddWithValue("@Feedback", feedback.Feedback);
                    cmd4.ExecuteNonQuery();
                    conn.Close();

                    return "Feedback added successfully";
                }
                else
                {
                    // No event found with that ID
                    conn.Close();
                    return "Event ID not found";
                }
            }
        }

        public static List<string> Viewfeedback()
        {
            List<string> feedbacks = new List<string>();

            string query = "SELECT * FROM feedbacktable";

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
                            int index = reader.GetInt32("id");
                            string eventid= reader.GetString("eventid");
                            string eventname = reader.GetString("Eventname");
                            string feedback = reader.GetString("feedback");
                            feedbacks.Add($"{index} | {eventid} | {eventname} | {feedback}");

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

            return feedbacks;
        }
    }
}
