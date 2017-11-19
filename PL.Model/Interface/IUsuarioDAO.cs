using PL.Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    interface IUsuarioDAO : IDisposable
    {
        IEnumerable<Usuario> getUsuarios();
        Usuario GetUsuarioById(int id);
        Boolean Add(Usuario u);
        void Delete(int id);
    }
}
