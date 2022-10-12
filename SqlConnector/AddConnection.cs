﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SqlConnector
{
    public partial class AddConnection : Form
    {


        public AddConnection()
        {
            InitializeComponent();
        }

        //path of data base
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db"; //database creat debug folder
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        private void data_show()
        {
            cbbDBtype.DisplayMember = "Text";
            cbbDBtype.ValueMember = "Value";

            cbbDBtype.Items.Add(new { Text = "Mssql", Value = "Mssql" });
            cbbDBtype.Items.Add(new { Text = "Oracle", Value = "Oracle" });


            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM DBconnection";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        //create database and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table DBconnection(DBname varchar(20),ConnStr varchar(100),DBtype varchar(12))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot create");
                return;
            }
        }

        private void AddConnection_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }



        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO DBconnection(DBname,ConnStr,DBtype) VALUES(@DBname,@ConnStr,@DBtype)";

                string DBname = txtDBname.Text;
                string ConnStr = txtConnStr.Text;
                string DBtype = cbbDBtype.Text;

                cmd.Parameters.AddWithValue("@DBname", DBname);
                cmd.Parameters.AddWithValue("@ConnStr", ConnStr);
                cmd.Parameters.AddWithValue("@DBtype", DBtype);

                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "DBname";
                dataGridView1.Columns[1].Name = "ConnStr";
                dataGridView1.Columns[2].Name = "DBtype";

                string[] row = new string[] { DBname, ConnStr, DBtype };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            string cellValue = Convert.ToString(dataGridView1.SelectedRows[0].Cells["DBname"].Value);
 
            try
            {
                cmd.CommandText = "DELETE FROM DBconnection where DBname =@DBname";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@DBname", cellValue);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delete data");
                return;
            }
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            //string ConnectionString = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ConnStr"].Value);
            string ConnectionString = "Server = MSI; Database = Northwind; User ID = 'Test123'; Password = 'Abc12345678'";
            try
            {

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var query = "select 1";
                    Console.WriteLine("Executing: {0}", query);

                    var command = new SqlCommand(query, connection);

                    connection.Open();
                    Console.WriteLine("SQL Connection successful.");

                    command.ExecuteScalar();
                    Console.WriteLine("SQL Query execution successful.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: {0}", ex.Message);
            }
        }
    }
}
