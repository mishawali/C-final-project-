using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedVehicleDealerShip
{
    public class DBMgr
    {
        //public static string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\UsedVehicles.mdf;Integrated Security=True;User Instance=True";
        public static string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\UsedVehicles.mdf;Integrated Security=True;User Instance=True";


        // insert make into data base
        public static int insertName(string name,string table, string id)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "insert into " + table + " ([Name]) values(@name);";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();

            int identity = 0;
            if( cmd.ExecuteNonQuery()>0)
            {
                identity = getNameId(name,table,id,null);
            }

            con.Close();

            return identity;

        }

        // insert model into data base
        public static int insertModel(VehicleModel vm)
        {

            SqlConnection con = new SqlConnection(connString);
            //string sql = "insert into Make ([Name]) values(@name); SELECT SCOPE_IDENTITY()";
            string sql = "insert into VehicleModel ([Name],[EngineSize],[NumberOfDoors],[Colour],[VehicleTypeId])";
            sql += " values(@name,@engineSize,@numberOfDoors,@colour,@vehicleTypeId);";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", vm.Name);
            cmd.Parameters.AddWithValue("@engineSize", vm.EngineSize);
            cmd.Parameters.AddWithValue("@numberOfDoors", vm.NumberOfDoors);
            cmd.Parameters.AddWithValue("@colour", vm.Colour);
            cmd.Parameters.AddWithValue("@vehicleTypeId", vm.VehicleTypeId);
            con.Open();

            int identity = 0;
            if (cmd.ExecuteNonQuery() > 0)
            {
                identity = getNameId(vm.Name, "VehicleModel","ModelId",null);
            }

            con.Close();

            return identity;

        }

        // insert vehicle into data base
        public static int insertVehicle(Vehicle v)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "insert into Vehicle ([MakeId],[ModelId],[Year],[Price],[Cost],[SoldDate],[Sold])";
            sql += " values(@makeid,@modelid,@year,@price,@cost,@soldDate,@sold);";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@makeid", v.MakeId);
            cmd.Parameters.AddWithValue("@modelid", v.ModelId);
            cmd.Parameters.AddWithValue("@year", v.Year);
            cmd.Parameters.AddWithValue("@price", v.Price);
            cmd.Parameters.AddWithValue("@cost", v.Cost);
            cmd.Parameters.AddWithValue("@soldDate", v.SoldDate.Date);
            cmd.Parameters.AddWithValue("@sold", v.Sold);
            con.Open();

            int result = cmd.ExecuteNonQuery();

            con.Close();

            int index = -1;
            if(result >0 )
            {
                index = getVehicleId(v.MakeId,v.ModelId);
                 
            }


            return index;
        }

        // get vehicle model
        public static VehicleModel getModelByName(string name)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "select * from VehicleModel where name = @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            VehicleModel vm = new VehicleModel();

            if(reader.Read())
            {
                vm.ModelId = (int)reader["ModelId"];
                vm.Name = (string)reader["Name"];
                vm.EngineSize = (int)reader["EngineSize"];
                vm.NumberOfDoors = (int)reader["NumberOfDoors"];
                vm.Colour = (string)reader["Colour"];
                vm.VehicleTypeId = (int)reader["VehicleTypeId"];
            }

            con.Close();
            return vm;
        }



        // get vehicle 
        public static Vehicle getVehicleById(int vehicleId)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "select * from Vehicle where vehicleId = @vehicleid";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@vehicleid", vehicleId);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Vehicle v = new Vehicle();

            if (reader.Read())
            {
                v.VehicleId = (int)reader["VehicleId"];
                v.MakeId = (int)reader["MakeId"];
                v.ModelId = (int)reader["ModelId"];
                v.Year = (int)reader["Year"];
                v.Price = double.Parse(reader["Price"].ToString());
                v.Cost = double.Parse(reader["Cost"].ToString());
                v.SoldDate = (DateTime)reader["SoldDate"];
                v.Sold = (bool)reader["Sold"];

            }

            con.Close();
            return v;
        }

        // get vehicle model by id
        public static VehicleModel getModelById(int modelId)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "select * from VehicleModel where ModelId = @modelId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@modelId", modelId);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            VehicleModel vm = new VehicleModel();

            if (reader.Read())
            {
                vm.ModelId = (int)reader["ModelId"];
                vm.Name = (string)reader["Name"];
                vm.EngineSize = (int)reader["EngineSize"];
                vm.NumberOfDoors = (int)reader["NumberOfDoors"];
                vm.Colour = (string)reader["Colour"];
                vm.VehicleTypeId = (int)reader["VehicleTypeId"];
            }

            con.Close();
            return vm;
        }


        // get vehicle make by id
        public static string getMakeById(int makeId)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "select * from Make where MakeId = @makeId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@makeId", makeId);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            string name = "";

            if (reader.Read())
            {
    
                name = (string)reader["Name"];
         
            }

            con.Close();
            return name;
        }


        // get name id from make table
        public static int getNameId(string name, string table, string id, VehicleModel model)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "select ["+id+"] from " + table + " where name = @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();

            Object result = cmd.ExecuteScalar();
            con.Close();

            int identity = 0;
            if (result == null)
            {
                if(model == null)
                    identity = DBMgr.insertName(name,table,id);
                else
                    identity = DBMgr.insertModel(model);
            }
            else
            {
                identity = (int)result;
            }

            return identity;
        }

        // get makes data table
        public static DataTable getTable(string table)
        {

            string sql = "select * from " + table;
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
            return dt;

        }


        // delete vehiclefrom vehicle table
        public static void deleteVehicle(int vehicleId)
        {
            string sql = "DELETE FROM Vehicle WHERE VehicleId = " + vehicleId;
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


        // update model
        public static void updateModel(VehicleModel vm)
        {
            SqlConnection con = new SqlConnection(connString);
            string sql = "update VehicleModel ";
            sql += " Set [EngineSize]=@engineSize,[NumberOfDoors]=@numberOfDoors,";
            sql += " [Colour]=@colour,[VehicleTypeId]=@vehicleTypeId ";
            sql += " where ModelId = @modelId"; 
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@modelId", vm.ModelId);
            cmd.Parameters.AddWithValue("@engineSize", vm.EngineSize);
            cmd.Parameters.AddWithValue("@numberOfDoors", vm.NumberOfDoors);
            cmd.Parameters.AddWithValue("@colour", vm.Colour);
            cmd.Parameters.AddWithValue("@vehicleTypeId", vm.VehicleTypeId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // update vehicle
        public static void updateVehicle(Vehicle v)
        {
            SqlConnection con = new SqlConnection(connString);
            string sql = "update Vehicle Set [MakeId]=@makeid,[ModelID]=@modelid,";
            sql += " [Year]=@year,[Price]=@price,[Cost]=@cost,[SoldDate]=@soldDate,[Sold]=@sold";
            sql += " where VehicleId = @vehicleId"; 
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@vehicleId", v.VehicleId);
            cmd.Parameters.AddWithValue("@makeid", v.MakeId);
            cmd.Parameters.AddWithValue("@modelid", v.ModelId);
            cmd.Parameters.AddWithValue("@year", v.Year);
            cmd.Parameters.AddWithValue("@price", v.Price);
            cmd.Parameters.AddWithValue("@cost", v.Cost);
            cmd.Parameters.AddWithValue("@soldDate", v.SoldDate);
            cmd.Parameters.AddWithValue("@sold", v.Sold);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        // get name id from make table
        public static int getVehicleId(int makeId, int modelId)
        {

            SqlConnection con = new SqlConnection(connString);
            string sql = "select vehicleId from Vehicle where MakeId = @makeId and ModelId = @modelId";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@MakeId", makeId);
            cmd.Parameters.AddWithValue("@ModelId", modelId);
            con.Open();

            int identity = (int)cmd.ExecuteScalar();
            con.Close();

          
            return identity;
        }

    }
}
