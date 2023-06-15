using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class ClassAuto
    {
        //constante
        private const char SEPARATOR_FISIER = ',';
        private const int ID = 0;
        private const int MARCA = 1;
        private const int CULOARE = 2;
        private const int AN = 3;
        private const int VIN = 4;
        private const int INCHIRIAT = 5;

        //proprietati
        private int IdAuto { set; get; }
        private string marca { set; get; }
        private string culoare { set; get; }
        private string an { set; get; }
        private string vin { set; get; }
        private string inchiriat { set; get; }

        //constructori
        public ClassAuto()
        {
            marca = culoare = an = vin = inchiriat = string.Empty;
        }

        public ClassAuto(int _idAuto, string _marca, string _culoare, string _an, string _vin, string _inchiriat)
        {
            this.IdAuto = _idAuto;
            this.marca = _marca;
            this.culoare = _culoare;
            this.an = _an;
            this.vin = _vin;
            this.inchiriat = _inchiriat;



        }

        public ClassAuto(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);

            //ORDINEA DE PRELUARE A CAMPURILOR
            IdAuto = Convert.ToInt32(dateFisier[ID]);
            marca = dateFisier[MARCA];
            culoare = dateFisier[CULOARE];
            an = dateFisier[AN];
            vin = dateFisier[VIN];
            inchiriat = dateFisier[INCHIRIAT];

        }


        public int GetIDAuto()
        {
            return IdAuto;
        }

        public string GetMarca()
        {
            return marca;
        }

        public string GetCuloare()
        {
            return culoare;
        }


        public string GetAN()
        {
            return an;
        }
        public string GetVin()
        {
            return vin;
        }
        public string GetInchiriat()
        {
            return inchiriat;
        }

    }
}
