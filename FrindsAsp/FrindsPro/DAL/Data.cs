using FrindsPro.Models;

namespace FrindsPro.DAL
{
    public class Data
    {
        string connectionString = "server = DESKTOP-184MO21\\SQLSERVER;initial catalog=Frinds_List; user id=sa; password=1234;TrustServerCertificate=Yes";
        private static Data _data;
        private DBcontext _layer;
            
        private Data() 
        {
            _layer = new DBcontext(connectionString);
        }
        public static DBcontext Get
        {
            get
            {
                if (_data == null)
                {
                    _data = new Data();
                }
                return _data._layer;
            }
        }        
    }
}
