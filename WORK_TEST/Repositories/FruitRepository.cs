using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WORK_TEST.Repositories
{
    public class FruitRepository
    {
        public DataSet getFruits()
        {   //บอกว่า เชือมกับ Database ตัวไหน โดยดูจาก ไฟล์ Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            //สร้าง Object สำหรับการติดต่อ Data base 
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //สร้าง Object Data set ที่เป็นกลุ่มข้อมูล โดยการดึงค่าต่างๆ ผลลัพธ์ จะอยู่ใน Data set ตัวนี้ 
            DataSet dataSet = new DataSet();

            //สร้างตัวแปล String เพื่อเก็บคำสั่ง SQL ก่อนนำไปสร้าง object
            string command = "SELECT * FROM [fruits]";

            //สร้างคำสั่ง SQL cmd โดนทำให้ string ธรรมดาเป็นตัวแปล Object เตรียมใช้งาน
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            //สร้าง Adapter สำหรับการแปลง ข้อมูลให้เข้ากัน  (ถึงตอนนี้ ข้อมูลดึงเส็จรแล้ว แต่สร้าง Adapter ขึ้นมาเพื่อแปลงข้อมูลลง Datasetได้)
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }

        public void addFruits(string Input_1,string Input_2)
        {   //บอกว่า เชือมกับ Database ตัวไหน โดยดูจาก ไฟล์ Web.config
            string connectionString = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            //สร้าง Object สำหรับการติดต่อ Data base 
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            //สร้าง Object Data set ที่เป็นกลุ่มข้อมูล โดยการดึงค่าต่างๆ ผลลัพธ์ จะอยู่ใน Data set ตัวนี้ 
            //   DataSet dataSet = new DataSet();

            //สร้างตัวแปล String เพื่อเก็บคำสั่ง SQL ก่อนนำไปสร้าง object
              string command = "INSERT INTO fruits VALUES('"+Input_1+"','"+ Input_2+"');";

            //string command = "INSERT INTO fruits VALUES('TestName','TestPoto');";
            //INSERT INTO [dbo].[fruits]([name],[photo])VALUES('NULL,@Entry1','NULL,@Entry2')

            //สร้างคำสั่ง SQL cmd โดนทำให้ string ธรรมดาเป็นตัวแปล Object เตรียมใช้งาน
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);


            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            //สร้าง Adapter สำหรับการแปลง ข้อมูลให้เข้ากัน  (ถึงตอนนี้ ข้อมูลดึงเส็จรแล้ว แต่สร้าง Adapter ขึ้นมาเพื่อแปลงข้อมูลลง Datasetได้)
            // SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //sqlDataAdapter.Fill(dataSet);
            //return dataSet;
        }

    }
}