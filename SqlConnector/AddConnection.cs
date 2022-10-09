﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string DBtype = txtConnStr.Text;

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
    }
}
