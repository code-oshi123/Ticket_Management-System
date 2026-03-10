using Dbex.Models;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Dbex.Controller
{
    public class TicketController
    {
        private readonly string connectionString = "server=localhost;user=root;password=;database=ticketdb;";

        public void AddTicket(int eventID, string type, decimal price, int availability)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Check if the EventID exists in the events table
                    string checkQuery = "SELECT COUNT(*) FROM eventtable WHERE id = @id";
                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", eventID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show($"Event ID {eventID} does not exist in the events database.");
                            return;
                        }
                    }

                    // Step 2: Check for duplicate ticket type for this event
                    if (TicketExists(eventID, type))
                    {
                        MessageBox.Show("A ticket of this type already exists for the selected event.");
                        return;
                    }

                    // Step 3: Insert the ticket
                    string insertQuery = "INSERT INTO tickets (EventID, Type, Price, Availability) VALUES (@eventID, @type, @price, @availability)";
                    using (var insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@eventID", eventID);
                        insertCmd.Parameters.AddWithValue("@type", type);
                        insertCmd.Parameters.AddWithValue("@price", price);
                        insertCmd.Parameters.AddWithValue("@availability", availability);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ticket inserted into the database successfully!");
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error code
                {
                    MessageBox.Show("Duplicate ticket detected. This ticket type already exists for the event.");
                }
                else
                {
                    MessageBox.Show("MySQL error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message);
            }
        }


       

        public string UpdateTicketPrice(int ticketID, decimal newPrice)
        {
            try
            {

                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE tickets SET Price = @price WHERE TicketID = @ticketID";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@price", newPrice);
                        cmd.Parameters.AddWithValue("@ticketID", ticketID);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            Debug.WriteLine($"Ticket ID {ticketID} price updated to {newPrice}");
                            return "Ticket price updated successfully.";
                        }
                        else
                        {
                            Debug.WriteLine($"Ticket with ID {ticketID} not found.");
                            return "Ticket not found.";
                        }
                    }
                }

                }
            catch (Exception ex)
            {
                return "Error updating ticket price: " + ex.Message;
            }
        }


        public bool DeleteTicket(int ticketID)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tickets WHERE TicketID = @ticketID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketID", ticketID);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
        private List<Tickets> tickets = new List<Tickets>();

        public List<Tickets> GetAllTickets()
        {
            var ticketList = new List<Tickets>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM tickets";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ticketList.Add(new Tickets
                {
                    TicketID = reader.GetInt32("TicketID"),
                    EventID = reader.GetInt32("EventID"),
                    Type = reader.GetString("Type"),
                    Price = reader.GetDecimal("Price"),
                    Availability = reader.GetInt32("Availability")
                });
            }
            return ticketList;
        }
        public List<Tickets> GetTicketsByEventID(int eventID)
        {
            var ticketList = new List<Tickets>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM tickets WHERE EventID = @eventID";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@eventID", eventID);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ticketList.Add(new Tickets
                {
                    TicketID = reader.GetInt32("TicketID"),
                    EventID = reader.GetInt32("EventID"),
                    Type = reader.GetString("Type"),
                    Price = reader.GetDecimal("Price"),
                    Availability = reader.GetInt32("Availability")
                });
            }
            return ticketList;
        }
        public bool EventIDExists(int eventID)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tickets WHERE EventID = @eventID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public string UpdateTicketAvailability(int ticketID, int newAvailability)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE tickets SET Availability = @availability WHERE TicketID = @ticketID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@availability", newAvailability);
                        cmd.Parameters.AddWithValue("@ticketID", ticketID);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return "Ticket availability updated successfully.";
                        }
                        else
                        {
                            return "Ticket not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error updating availability: " + ex.Message;
            }
        }
        public List<(string Type, decimal Price)> GetTicketTypesAndPricesByEventID(int eventID)
        {
            var result = new List<(string Type, decimal Price)>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Type, Price FROM tickets WHERE EventID = @eventID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader.GetString("Type");
                            decimal price = reader.GetDecimal("Price");
                            result.Add((type, price));
                        }
                    }
                }
            }

            return result;
        }
        public bool IsValidTicketType(int eventID, string ticketType)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tickets WHERE EventID = @eventID AND Type = @type";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    cmd.Parameters.AddWithValue("@type", ticketType);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public string BookTicket(int ticketID, int quantity)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Check availability
                        string selectQuery = "SELECT Availability FROM tickets WHERE TicketID = @ticketID";
                        using (var selectCmd = new MySqlCommand(selectQuery, conn, transaction))
                        {
                            selectCmd.Parameters.AddWithValue("@ticketID", ticketID);
                            object result = selectCmd.ExecuteScalar();

                            if (result == null)
                                return "Ticket not found.";

                            int currentAvailability = Convert.ToInt32(result);
                            if (currentAvailability < quantity)
                                return "Not enough tickets available.";

                            // Update availability
                            string updateQuery = "UPDATE tickets SET Availability = Availability - @quantity WHERE TicketID = @ticketID";
                            using (var updateCmd = new MySqlCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@ticketID", ticketID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        // Get price and insert sale
                        string priceQuery = "SELECT Price FROM tickets WHERE TicketID = @ticketID";
                        using (var priceCmd = new MySqlCommand(priceQuery, conn, transaction))
                        {
                            priceCmd.Parameters.AddWithValue("@ticketID", ticketID);
                            object priceResult = priceCmd.ExecuteScalar();
                            if (priceResult == null)
                                throw new Exception("Ticket not found.");

                            decimal price = Convert.ToDecimal(priceResult);
                            decimal totalPrice = price * quantity;

                            string insertQuery = "INSERT INTO sales (TicketID, Quantity, TotalPrice) VALUES (@ticketID, @quantity, @totalPrice)";
                            using (var insertCmd = new MySqlCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@ticketID", ticketID);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return "Ticket(s) booked successfully.";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "Booking failed: " + ex.Message;
                    }
                }
            }
        }
        public decimal GetTotalRevenue()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(TotalPrice) FROM sales";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
        }
        public decimal? GetTicketPriceByEventAndType(int eventID, string ticketType)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Price FROM tickets WHERE EventID = @eventID AND Type = @type";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    cmd.Parameters.AddWithValue("@type", ticketType);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : (decimal?)null;
                }
            }
        }
        public bool TicketExists(int eventID, string type)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tickets WHERE EventID = @eventID AND Type = @type";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    cmd.Parameters.AddWithValue("@type", type);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public string Gettotalprice(decimal total)
        {
            return $"Total Price: Rs.{total}";
        }

        public string SaveSale(int eventID, string ticketType, int quantity)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        //  Get Ticket Price
                        string priceQuery = "SELECT Price FROM tickets WHERE EventID = @eventID AND Type = @type";
                        using (var priceCmd = new MySqlCommand(priceQuery, conn, transaction))
                        {
                            priceCmd.Parameters.AddWithValue("@eventID", eventID);
                            priceCmd.Parameters.AddWithValue("@type", ticketType);

                            object priceResult = priceCmd.ExecuteScalar();
                            if (priceResult == null)
                                return "Ticket type not found for the selected event.";

                            decimal price = Convert.ToDecimal(priceResult);
                            decimal totalPrice = price * quantity;

                            Gettotalprice(totalPrice);

                            // Step 2: Insert into sales table
                            string insertQuery = @"
                INSERT INTO sales (EventID, TicketType, Quantity, TotalPrice)
                VALUES (@eventID, @ticketType, @quantity, @totalPrice)";

                            using (var insertCmd = new MySqlCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@eventID", eventID);
                                insertCmd.Parameters.AddWithValue("@ticketType", ticketType);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                                insertCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return "Sale saved successfully.";
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "Error saving sale: " + ex.Message;
                    }
                }
            }
        }
        public bool IsTicketAvailable(int eventID, string ticketType, int requestedQuantity, out string message)
        {
            message = "";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Check if ticket type exists for this event
                string typeCheckQuery = "SELECT Availability FROM tickets WHERE EventId = @eventID AND Type = @ticketType";
                MySqlCommand typeCmd = new MySqlCommand(typeCheckQuery, conn);
                typeCmd.Parameters.AddWithValue("@eventID", eventID);
                typeCmd.Parameters.AddWithValue("@ticketType", ticketType);

                object availResult = typeCmd.ExecuteScalar();

                if (availResult == null)
                {
                    message = $"Ticket type '{ticketType}' does not exist for Event ID {eventID}.";
                    return false;
                }

                int totalAvailable = Convert.ToInt32(availResult);

                // Step 2: Get total sold quantity for this type
                string soldQuery = "SELECT COALESCE(SUM(Quantity), 0) FROM sales WHERE EventId = @eventID AND TicketType = @ticketType";
                MySqlCommand soldCmd = new MySqlCommand(soldQuery, conn);
                soldCmd.Parameters.AddWithValue("@eventID", eventID);
                soldCmd.Parameters.AddWithValue("@ticketType", ticketType);

                int totalSold = Convert.ToInt32(soldCmd.ExecuteScalar());

                int remaining = totalAvailable - totalSold;

                if (requestedQuantity > remaining)
                {
                    message = $"Only {remaining} tickets available for '{ticketType}' type.";
                    return false;
                }

                return true;
            }
        }


    }
}
