using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoWL
{
    public class SensorerFac : AutoFac<Sensorer>
    {

        public void SetSensor(int sensorID, int value, int serial)
        {

            string field = "Lys";

            switch (sensorID)
            {
                case 0:
                    field = "Fugtighed";
                    break;
                case 1:
                    field = "Tryk";
                    break;
                case 2:
                    field = "Tempratur";
                    break;
                case 3:
                    field = "VindR";
                    break;
                case 4:
                    field = "Lys";
                    break;
                case 5:
                    field = "VindH";
                    break;
            }

            try
            {
                using (var cmd = new SqlCommand("Update Sensorer SET " + field + "=@Value WHERE KortSN=@Serial", Conn.CreateConnection()))
                {
                    cmd.Parameters.AddWithValue("@Value", value);
                    cmd.Parameters.AddWithValue("@Serial", serial);

                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }

            }
            catch (Exception)
            {

             
            }

        }
    }
}
