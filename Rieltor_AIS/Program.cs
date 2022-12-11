using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
            conn.Open();
            // create table users if not exists id name surname phone position
            NpgsqlCommand command = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS users (id serial PRIMARY KEY, name varchar(50), surname varchar(50), phone varchar(50), position varchar(50))", conn);
            
            // create table realty if not exists id location type owner_count status
            NpgsqlCommand command2 = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS realty (id serial PRIMARY KEY, location varchar(50), r_type varchar(50), owner_count int, status varchar(50))", conn);
            
            // create table deals if not exists id date price
            NpgsqlCommand command3 = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS deals (id serial PRIMARY KEY, date varchar(50), price int)", conn);
            
            // create table personnel if not exists id login password account_type
            NpgsqlCommand command4 = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS personnel (id serial PRIMARY KEY, login varchar(50), password varchar(50), account_type varchar(50))", conn);
            
            // create table accounts if not exists id login password account_type personnel_id
            NpgsqlCommand command5 = new NpgsqlCommand("CREATE TABLE IF NOT EXISTS accounts (id serial PRIMARY KEY, login varchar(50), password varchar(50), account_type varchar(50), personnel_id int)", conn);
            
            // insert one row into each table
            // NpgsqlCommand command6 = new NpgsqlCommand("INSERT INTO users (name, surname, phone, position) VALUES ('Иван', 'Иванов', '8-800-555-35-35', 'Риелтор')", conn);
            // NpgsqlCommand command7 = new NpgsqlCommand("INSERT INTO realty (location, r_type, owner_count, status) VALUES ('Москва', 'Квартира', 1, 'Продается')", conn);
            // NpgsqlCommand command8 = new NpgsqlCommand("INSERT INTO deals (date, price) VALUES ('01.01.2019', 1000000)", conn);
            // NpgsqlCommand command9 = new NpgsqlCommand("INSERT INTO personnel (login, password, account_type) VALUES ('admin', 'admin', 'Администратор')", conn);
            // NpgsqlCommand command10 = new NpgsqlCommand("INSERT INTO accounts (login, password, account_type, personnel_id) VALUES ('a', 'a', 'Администратор', 1)", conn);
            // command6.ExecuteNonQuery();
            // command7.ExecuteNonQuery();
            // command8.ExecuteNonQuery();
            // command9.ExecuteNonQuery();
            // command10.ExecuteNonQuery();
            
            
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            
            conn.Close();
            
            
        }
    }
}