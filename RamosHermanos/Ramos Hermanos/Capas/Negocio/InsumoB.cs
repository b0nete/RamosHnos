using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class InsumoB
    {
        //Metodos

        public static bool ExisteInsumo(InsumoEntity insumo)
        {

            MySQL.ConnectDB();

            string query = @"select count(*) from insumos
                             where idinsumo=@idinsumo";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@idinsumo", insumo.idInsumo);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        
        }

        public static InsumoEntity UpdateInsumo(InsumoEntity insumo)
        {
            MySQL.ConnectDB();

            string query = @"UPDATE from insumos
                           SET fecha=@fecha, proveedor=@proveedor, rubro=@rubro, marca=@marca, insumo=@insumo, descripcion=@descripcion
                           stockmin=@stockmin, estado=@estado
                           where idinsumo=@idinsumo";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@fecha", insumo.fecha);
            cmd.Parameters.AddWithValue("@proveedor", insumo.proveedor);
            cmd.Parameters.AddWithValue("@rubro", insumo.rubro);
            cmd.Parameters.AddWithValue("@marca";insumo.marca);
            cmd.Parameters.AddWithValue("@insumo";insumo.insumo);
            cmd.Parameters.AddWithValue("@descripcion";insumo.descripcion);

        
        }
        
        
    }
}
