using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialWeb.Models

{
    public class EstampillaInputModel
    {
        public string NContrato { get; set; }
        public string ObjContrato { get; set; }
        public decimal VContrato { get; set; }
        public string ApoyaCovid19 { get; set; }
        
    }
    public class EstampillaViewModel : EstampillaInputModel
    {
        public EstampillaViewModel()
        {

        }
        public EstampillaViewModel(Estampilla estampilla)
        {
            NContrato = estampilla.NContrato;
            ObjContrato = estampilla.ObjContrato;
            VContrato = estampilla.VContrato;
            ApoyaCovid19 = estampilla.ApoyaCovid19;
            VEstampilla = estampilla.VEstampilla;  
        }
        public decimal VEstampilla { get; set; }
    }

}