using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Otopark_Otomasyonu
{
    class databaseConnection
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=otopark;Uid=yonetici;Pwd='123456Mm.';AllowUserVariables=True;UseCompression=True;charset=utf8");// charset ekleyerek Türkçe karakter sorununuda gidermiş olduk.

     
       
    }
}
