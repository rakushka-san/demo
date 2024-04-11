using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeasonCafe
{
    internal static class SeasonDB
    {
        public static Staff Auth(string userLogin, string userPassword)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"SELECT * FROM \"staff\" WHERE \"login\" = \"{userLogin}\" AND \"password\" = \"{userPassword}\" AND  \"status\" != \"Уволен\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string firstname = reader.GetString(1);
                            string surname = reader.GetString(2);
                            string role = reader.GetString(3);
                            string status = reader.GetString(4);
                            string login = reader.GetString(5);
                            string password = reader.GetString(6);
                            Staff staff = new Staff(id, firstname, surname, role, status, login, password);

                            return staff;
                        }

                        return null;
                    }
                }
            }
        }

        public static void createOrderTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"order\" (\r\n\t\"id\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"table\"\tTEXT NOT NULL,\r\n\t\"clients_amount\"\tINTEGER NOT NULL,\r\n\t\"order\"\tTEXT NOT NULL,\r\n\t\"status\"\tTEXT NOT NULL CHECK((\"status\" = \"Принят\") || (\"status\" = \"Готовится\") || (\"status\" = \"Готов\") || (\"status\" = \"Оплачен\")),\r\n\t\"date\"\tNUMERIC NOT NULL DEFAULT '(strftime(''%d.%m.%Y'', DATE(''now'')))',\r\n\t\"time\"\tNUMERIC NOT NULL DEFAULT '(strftime(''%H:%M'', TIME(''now'')))',\r\n\tPRIMARY KEY(\"id\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createStaffTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"staff\" (\r\n\t\"id\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"firstname\"\tTEXT NOT NULL,\r\n\t\"surname\"\tTEXT NOT NULL,\r\n\t\"role\"\tTEXT NOT NULL CHECK((\"role\" = \"Администратор\") || (\"role\" = \"Официант\") || (\"role\" = \"Повар\")),\r\n\t\"status\"\tTEXT NOT NULL CHECK((\"status\" = \"Работает\") || (\"status\" = \"Уволен\")),\r\n\t\"login\"\tTEXT NOT NULL UNIQUE,\r\n\t\"password\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"id\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createShiftTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"shift\" (\r\n\t\"id\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"date\"\tTEXT NOT NULL,\r\n\t\"start\"\tTEXT NOT NULL,\r\n\t\"end\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"id\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createStaffShiftTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"staff-shift\" (\r\n\t\"id\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"staff_id\"\tINTEGER NOT NULL,\r\n\t\"shift_id\"\tINTEGER NOT NULL,\r\n\tPRIMARY KEY(\"id\" AUTOINCREMENT),\r\n\tFOREIGN KEY(\"shift_id\") REFERENCES \"shift\"(\"id\"),\r\n\tFOREIGN KEY(\"staff_id\") REFERENCES \"staff\"(\"id\")\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createStaff(Staff staff)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"staff\"\r\n(\"firstname\", \"surname\", \"role\", \"status\", \"login\", \"password\")\r\nVALUES ('{staff.firstname}', '{staff.surname}', '{staff.role}', '{staff.status}', '{staff.login}', '{staff.password}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void updateStaff(Staff staff)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"UPDATE \"staff\"\r\nSET \"firstname\" = '{staff.firstname}', \"surname\" = '{staff.surname}', \"role\" = '{staff.role}', \"status\" = '{staff.status}', \"login\" = '{staff.login}', \"password\" = '{staff.password}'\r\nWHERE \"id\" = {staff.id};";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Staff> getStaff()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "SELECT * FROM \"staff\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Staff> staff = new List<Staff>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string firstname = reader.GetString(1);
                            string surname = reader.GetString(2);
                            string role = reader.GetString(3);
                            string status = reader.GetString(4);
                            string login = reader.GetString(5);
                            string password = reader.GetString(6);
                            staff.Add(new Staff(id, firstname, surname, role, status, login, password));
                        }

                        return staff;
                    }
                }
            }
        }

        public static List<Shift> getShifts()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "SELECT * FROM \"shift\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string date = reader.GetString(1);
                            string start = reader.GetString(2);
                            string end = reader.GetString(3);
                            List<Staff> staff = getShiftStaff(id);
                            shifts.Add(new Shift(id, date, start, end, staff));
                        }

                        return shifts;
                    }
                }
            }
        }

        public static void clearShiftStaff(int shiftId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"DELETE FROM \"staff-shift\" WHERE \"shift_id\"='{shiftId}'";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Staff> getShiftStaff(int shiftId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"SELECT \"staff\".\"id\", \"staff\".\"firstname\", \"staff\".\"surname\", \"staff\".\"role\", \"staff\".\"status\", \"staff\".\"login\", \"staff\".\"password\"\r\nFROM \"staff-shift\"\r\nLEFT JOIN \"staff\" ON \"staff-shift\".\"staff_id\"=\"staff\".\"id\"\r\nWHERE \"staff-shift\".\"shift_id\"={shiftId}";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Staff> staff = new List<Staff>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string firstname = reader.GetString(1);
                            string surname = reader.GetString(2);
                            string role = reader.GetString(3);
                            string status = reader.GetString(4);
                            string login = reader.GetString(5);
                            string password = reader.GetString(6);
                            staff.Add(new Staff(id, firstname, surname, role, status, login, password));
                        }

                        return staff;
                    }
                }
            }
        }

        public static void createShift(Shift shift)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"shift\"\r\n(\"date\", \"start\", \"end\")\r\nVALUES ('{shift.date}', '{shift.start}', '{shift.end}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createStaffShift(int staffId, int shiftId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"staff-shift\"\r\n(\"staff_id\", \"shift_id\")\r\nVALUES ('{staffId}', '{shiftId}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void createOrder(Order order)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"order\"\r\n(\"table\", \"clients_amount\", \"order\", \"status\", \"date\", \"time\")\r\nVALUES ('{order.table}', '{order.clientsAmount}', '{order.order}', '{order.status}', '{order.date}', '{order.time}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Order> getOrders()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = "SELECT * FROM \"order\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Order> orders = new List<Order>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string table = reader.GetString(1);
                            int clientsAmount = reader.GetInt32(2);
                            string order = reader.GetString(3);
                            string status = reader.GetString(4);
                            string date = reader.GetString(5);
                            string time = reader.GetString(6);
                            orders.Add(new Order(id, table, clientsAmount, order, status, date, time));
                        }

                        return orders;
                    }
                }
            }
        }

        public static List<Order> getCurrentOrders()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                DateTime currentDateTime = DateTime.Now;
                string currentDate = currentDateTime.Date.ToShortDateString();
                string currentTime = $"{currentDateTime.TimeOfDay.Hours}:{currentDateTime.TimeOfDay.Minutes}";

                string sql = $"SELECT \"order\".* \r\nFROM \"shift\"\r\nJOIN \"order\" ON \"order\".\"date\" = \"shift\".\"date\" AND \"order\".\"time\" >= \"shift\".\"start\" AND \"order\".\"time\" <= \"shift\".\"end\"\r\nWHERE \"shift\".\"date\" = '{currentDate}' AND \"shift\".\"start\" <= '{currentTime}' AND \"shift\".\"end\" >= '{currentTime}'";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Order> orders = new List<Order>();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string table = reader.GetString(1);
                            int clientsAmount = reader.GetInt32(2);
                            string order = reader.GetString(3);
                            string status = reader.GetString(4);
                            string date = reader.GetString(5);
                            string time = reader.GetString(6);
                            orders.Add(new Order(id, table, clientsAmount, order, status, date, time));
                        }

                        return orders;
                    }
                }
            }
        }

        public static void updateOrder(Order order)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=season.db"))
            {
                connection.Open();

                string sql = $"UPDATE \"order\"\r\nSET \"table\" = '{order.table}', \"clients_amount\" = '{order.clientsAmount}', \"order\" = '{order.order}', \"status\" = '{order.status}', \"date\" = '{order.date}', \"time\" = '{order.time}'\r\nWHERE \"id\" = {order.id};";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    
}
