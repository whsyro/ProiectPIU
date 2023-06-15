using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Persoana
    {
        private const char SEPARATOR_FISIER = ',';
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int CNP = 3;
        private const int USERNAME = 4;
        private const int PASSWORD = 5;

        //proprietati
        private int idPersoana { set; get; }
        private string nume { set; get; }
        private string prenume { set; get; }
        private string cnp { set; get; }
        private string username { set; get; }
        private string password { set; get; }

        //constructori
        public Persoana()
        {
            nume = username = cnp= prenume = string.Empty;
            password = "0000";
        }

        public Persoana(int _idPersoana, string _nume,  string _prenume, string _cnp, string _username, string _password)
        {
            this.idPersoana = _idPersoana;
            this.nume = _nume;
            this.username = _username;
            this.cnp = _cnp;
            this.prenume = _prenume;
            this.password = _password;
        }

        
        public int GetIDPersoana()
        {
            return idPersoana;
        }

        public string GetNume()
        {
            return nume;
        }

        public string GetPrenume()
        {
            return prenume;
        }

        public string GetCNP()
        {
            return cnp;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public Persoana(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);

            idPersoana = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            cnp = dateFisier[CNP];
            prenume = dateFisier[PRENUME];
            username = dateFisier[USERNAME];
            password = dateFisier[PASSWORD];

        }
        public static bool verifyLogin(string numeFisier, string user, string pass)
        {
            int nrPersoane = 0;
            Admin verify=new Admin();
            Persoana[] datePersoane = verify.GetPersoana(out nrPersoane, numeFisier);
            for(int i=0;i<nrPersoane;i++)
            {
                if (datePersoane[i].username == user && datePersoane[i].password == pass)
                    return true;
            }
            return false;
        }

    }
}
