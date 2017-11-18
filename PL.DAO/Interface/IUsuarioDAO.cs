using PL.Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.DAO
{
    interface IUsuarioDAO
    {
        IEnumerable<Usuario> getUsuarios();
        Usuario GetUsuarioById(int id);
        Boolean Add(Usuario u);
        void Delete(int id);
    }
}
