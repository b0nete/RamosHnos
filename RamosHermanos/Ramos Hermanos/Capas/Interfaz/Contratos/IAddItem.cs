using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Interfaz.Contratos
{
    interface IAddItem
    {
        void AddNewItem(DataGridViewRow row);
    }

    interface IAddItemDGV
    {
        void AddNewItem(DataGridViewRow row, int VAR);
    }

    interface GetParametro
    {
        void AddParametro(TextBox text);
    }    
}
