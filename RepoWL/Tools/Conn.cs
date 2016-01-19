using System.Data.SqlClient;

namespace RepoWL
{
    //Host: 194.255.108.50
    //Database: dbWeatherLog
    //Username: WeatherLog
    //Password: eGZEFnL3

    public static class Conn
    {
        private static SqlConnection _Con = new SqlConnection("server=194.255.108.50;database=dbWeatherLog;uid=WeatherLog;pwd=eGZEFnL3;MultipleActiveResultSets=True");
    
        public static SqlConnection CreateConnection()
        {
            var cn = _Con;
            cn.Open();
            return cn;
        }

        public static SqlConnection GetCon()
        {
            var cn = _Con;
           
            return cn;
        }
    }
}


