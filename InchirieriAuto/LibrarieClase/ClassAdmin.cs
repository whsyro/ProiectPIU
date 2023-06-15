using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;

namespace LibrarieClase
{
    public class Admin : Persoana
    {
        private const int NR_MAX_PERSOANE = 100;
        private const int NR_MAX_AUTO = 100;
        private const char SEPARATOR_FISIER = ',';
        public static void ScriereCsvPersoana(string numeFisier, int _idPersoana, string _nume, string _cnp, string _adresa, string _username, string _password)
        {

            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier = locatiefisier + "\\" + numeFisier;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(cale_completa_fisier, true))
            {
                file.WriteLine(Convert.ToString(_idPersoana) + SEPARATOR_FISIER + _nume + SEPARATOR_FISIER + _cnp + SEPARATOR_FISIER + _adresa + SEPARATOR_FISIER + _username + SEPARATOR_FISIER + _password);
            }

        }

        public Persoana[] GetPersoana(out int nrPersoane, string numeFisier)
        {
            Persoana[] persoana = new Persoana[NR_MAX_PERSOANE];
            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier = locatiefisier + "\\" + numeFisier;
            using (System.IO.StreamReader file = new System.IO.StreamReader(cale_completa_fisier, true))
            {
                string linieFisier;
                nrPersoane = 0;
                while ((linieFisier = file.ReadLine()) != null)
                {
                    persoana[nrPersoane++] = new Persoana(linieFisier);
                }
            }

            return persoana;
        }

        public static bool VerifExistFile(string numeFisier)
        {
            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier = locatiefisier + "\\" + numeFisier;
            if (File.Exists(cale_completa_fisier))
                return true;
            else
                return false;


        }
        public static void StergeDatePersoanaFisierAdmin(string data, string numeFisier)
        {
            int nrPersoane = 0;
            int data_delete = 0;

            string tempFile = "tempfile.csv";
            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier = locatiefisier + "\\" + numeFisier;

            Admin admin = new Admin();
            Persoana[] datePersoana = admin.GetPersoana(out nrPersoane, numeFisier);

            for (int i = 0; i < nrPersoane; i++)
                if (datePersoana[i].GetCNP() != data)
                {
                    ScriereCsvPersoana(tempFile, datePersoana[i].GetIDPersoana(), datePersoana[i].GetNume(), datePersoana[i].GetPrenume(), datePersoana[i].GetCNP(),  datePersoana[i].GetUsername(), datePersoana[i].GetPassword());
                }
                else
                {
                    data_delete++;
                }
            if (data_delete != 0)
            {
                File.Delete(cale_completa_fisier);
                nrPersoane = 0;
                Persoana[] datePersoanaCopy = admin.GetPersoana(out nrPersoane, tempFile);
                for (int i = 0; i < nrPersoane; i++)
                {
                    ScriereCsvPersoana(numeFisier, datePersoanaCopy[i].GetIDPersoana(), datePersoanaCopy[i].GetNume(), datePersoanaCopy[i].GetPrenume() ,datePersoanaCopy[i].GetCNP(),  datePersoanaCopy[i].GetUsername(), datePersoanaCopy[i].GetPassword());
                }
                
            }
            string cale_completa_fisier_temp = locatiefisier + "\\" + tempFile;

            File.Delete(cale_completa_fisier_temp);
        }

        public static void ScriereCsvAuto(string numeFisier, int _idAuto, string _marca, string _culoare, string _an, string _vin, string _inchiriat)
        {

            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier = locatiefisier + "\\" + numeFisier;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(cale_completa_fisier, true))
            {
                file.WriteLine(Convert.ToString(_idAuto) + SEPARATOR_FISIER + _marca + SEPARATOR_FISIER + _culoare + SEPARATOR_FISIER + _an + SEPARATOR_FISIER + _vin + SEPARATOR_FISIER + _inchiriat);
            }

        }

        public  ClassAuto[] GetAuto(out int nrAuto, string numeFisier)
        {
            ClassAuto[] auto = new ClassAuto[NR_MAX_AUTO];
            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier = locatiefisier + "\\" + numeFisier;
            using (System.IO.StreamReader file = new System.IO.StreamReader(cale_completa_fisier, true))
            {
                string linieFisier;
                nrAuto = 0;
                while ((linieFisier = file.ReadLine()) != null)
                {
                    auto[nrAuto++] = new ClassAuto(linieFisier);
                }
            }

            return auto;
        }
        public static void StergeDatePersoanaFisierClient(string data, string numeFisierPersoane,string numeFisierAuto)
        {
            int nrPersoane = 0;
            int nrAuto = 0;
            int data_delete = 0;

            string tempFile1 = "tempfile1.csv";
            string tempFile2 = "tempfile2.csv";
            string locatiefisier = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cale_completa_fisier_Persoane = locatiefisier + "\\" + numeFisierPersoane;
            string cale_completa_fisier_Auto = locatiefisier + "\\" + numeFisierAuto;

            Admin admin = new Admin();
            Persoana[] datePersoana = admin.GetPersoana(out nrPersoane, numeFisierPersoane);
            ClassAuto[] dateAuto = admin.GetAuto(out nrAuto, numeFisierAuto);

            for (int i = 0; i < nrPersoane; i++)
                if (datePersoana[i].GetCNP() != data)
                {
                    ScriereCsvPersoana(tempFile1, datePersoana[i].GetIDPersoana(), datePersoana[i].GetNume(), datePersoana[i].GetPrenume(), datePersoana[i].GetCNP(), datePersoana[i].GetUsername(), datePersoana[i].GetPassword());
                    ScriereCsvAuto(tempFile2, dateAuto[i].GetIDAuto(), dateAuto[i].GetMarca(), dateAuto[i].GetCuloare(), dateAuto[i].GetAN(), dateAuto[i].GetVin(), dateAuto[i].GetInchiriat());
                }
                else
                {
                    data_delete++;
                }
            if (data_delete != 0)
            {
                File.Delete(cale_completa_fisier_Persoane);
                File.Delete(cale_completa_fisier_Auto);
                nrPersoane = 0;
                Persoana[] datePersoanaCopy = admin.GetPersoana(out nrPersoane, tempFile1);
                ClassAuto[] dateAutoCopy = admin.GetAuto(out nrAuto, tempFile2);
                for (int i = 0; i < nrPersoane; i++)
                {
                    ScriereCsvPersoana(numeFisierPersoane, datePersoanaCopy[i].GetIDPersoana(), datePersoanaCopy[i].GetNume(), datePersoanaCopy[i].GetPrenume(), datePersoanaCopy[i].GetCNP(), datePersoanaCopy[i].GetUsername(), datePersoanaCopy[i].GetPassword());
                    ScriereCsvAuto(numeFisierAuto, dateAutoCopy[i].GetIDAuto(), dateAutoCopy[i].GetMarca(), dateAutoCopy[i].GetCuloare(), dateAutoCopy[i].GetAN(), dateAutoCopy[i].GetVin(), dateAutoCopy[i].GetInchiriat());
                }

            }
            string cale_completa_fisier_temp1 = locatiefisier + "\\" + tempFile1;

            File.Delete(cale_completa_fisier_temp1);
            string cale_completa_fisier_temp2 = locatiefisier + "\\" + tempFile2;

            File.Delete(cale_completa_fisier_temp2);
        }

    }
}
