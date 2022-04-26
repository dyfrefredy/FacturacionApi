using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Model.Base
{
    public abstract class EntityBase<U>
    {
        public U Id { get; set; }
    }
}
