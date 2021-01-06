using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassTekmovanje;
using System.Configuration;

namespace WcfTekmovanjeREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private TekmovanjeDAO tekmovanjeDAO;

        public Service1()
        {
            tekmovanjeDAO = new TekmovanjeDAO();
            tekmovanjeDAO.ConnString=ConfigurationManager.ConnectionStrings["tekmovanjeConnString"].ConnectionString;
        }

        public List<TekmovanjeInfo>GetTekmovalec(string ime)
        {
            return tekmovanjeDAO.GetTekmovalec(ime);
        }
        public List<TekmovanjeInfo> GetTekmovanje(string naziv)
        {
            return tekmovanjeDAO.GetTekmovanje(naziv);
        }

        public List<string> ListTekmovanj()
        {
            return tekmovanjeDAO.SeznamTekmovanj();
        }

        public List<TekmovanjeInfo>GetTekmovanja()
        {
            return tekmovanjeDAO.GetTekmovanja();
        }

        public void CreateTekmovanje(TekmovanjeInfo tekmovanje)
        {
            tekmovanjeDAO.CreateTekmovanje(tekmovanje);
        }

        public void UpdateTekmovalec(string id, TekmovanjeInfo tekmovanje)
        {
            tekmovanjeDAO.UpdateTekmovalec(id, tekmovanje);
        }

        public void DeleteTekmovalec(string id)
        {
            tekmovanjeDAO.DeleteTekmovalec(id);
        }

        public List<Izdelki> GetIzdelke()
        {
            return tekmovanjeDAO.GetIzdelke();
        }

        public void CreateIzdelek(Izdelki izdelek)
        {
            tekmovanjeDAO.CreateIzdelek(izdelek);
        }

        public void UpdateIzdelek(string id, Izdelki izdelek)
        {
            tekmovanjeDAO.UpdateIzdelek(id, izdelek);
        }

        public void DeleteIzdelek(string id)
        {
            tekmovanjeDAO.DeleteIzdelek(id);
        }

        public List<Obvetilo> GetObvestila()
        {
            return tekmovanjeDAO.GetObvestila();
        }

        public void CreateObvestilo(Obvetilo obvestilo)
        {
            tekmovanjeDAO.CreateObvestilo(obvestilo);
        }

        public void UpdateObvestilo(string id, Obvetilo obvestilo)
        {
            tekmovanjeDAO.UpdateObvestilo(id, obvestilo);
        }

        public void DeleteObvestilo(string id)
        {
            tekmovanjeDAO.DeleteObvestilo(id);
        }


        public List<Admin> GetAdmin()
        {
            return tekmovanjeDAO.GetAdmin();
        }

        public List<Uporabnik> GetUporabnik()
        {
            return tekmovanjeDAO.GetUporabnik();
        }
    }
}
