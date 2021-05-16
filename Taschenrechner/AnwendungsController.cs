using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private RechnerModel model;

        public AnwendungsController(RechnerModel model)
        {
            this.model = model;
        }

        public void Ausfuehren()
        {
            model.Berechne();
        }
    }
}
