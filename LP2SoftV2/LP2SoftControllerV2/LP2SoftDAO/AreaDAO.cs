using LP2SoftModelV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftControllerV2.LP2SoftDAO
{
    public interface AreaDAO
    {
        int insertar(Area area);
        int actualizar(Area area);
        int eliminar(int idArea);
        BindingList<Area> listar();

    }
}
