namespace Entity
{
    public class Estampilla
    {
        public string NContrato { get; set; }
        public string ObjContrato { get; set; }
        public decimal VContrato { get; set; }
        public string ApoyaCovid19 { get; set; }
        public decimal VEstampilla { get; set; }

        public void CalcularEstampilla()
        {
            if (ApoyaCovid19.Equals("SI"))
            {
                VEstampilla=(VContrato*1)/100;
            }else{
                VEstampilla=(VContrato*2)/100;
            }
            }
        
    }
}