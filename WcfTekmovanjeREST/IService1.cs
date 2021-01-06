using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassTekmovanje;

namespace WcfTekmovanjeREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/tekmovalec/{name}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<TekmovanjeInfo> GetTekmovalec(string name);


        [OperationContract]
        [WebGet(UriTemplate = "/tekmovanje/{tekmovanje}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<TekmovanjeInfo> GetTekmovanje(string naslov);

        [OperationContract]
        [WebGet(UriTemplate = "/listnaslovov",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<string> ListTekmovanj();

        [OperationContract]
        [WebGet(UriTemplate = "/tekmovanje")]
        List<TekmovanjeInfo> GetTekmovanja();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ustvaritekmovanje", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void CreateTekmovanje(TekmovanjeInfo tekmovanje);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/posodobitekmovalca/{id}", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void UpdateTekmovalec(string id, TekmovanjeInfo tekmovanje);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/izbrisitekmovalca/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void DeleteTekmovalec(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/izdelki")]
        List<Izdelki> GetIzdelke();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ustvariizdelek", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void CreateIzdelek(Izdelki izdelek);


        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/posodbiizdelek/{id}", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void UpdateIzdelek(string id, Izdelki izdelek);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/izbrisiizdelek/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void DeleteIzdelek(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/obvestila")]
        List<Obvetilo> GetObvestila();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/ustvariobvestilo", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void CreateObvestilo(Obvetilo obvestilo);


        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/posodobiobvestilo/{id}", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void UpdateObvestilo(string id, Obvetilo obvestilo);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/izbrisiobvestilo/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void DeleteObvestilo(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/admin",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Admin> GetAdmin();

       
        [OperationContract]
        [WebGet(UriTemplate = "/uporabnik",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Uporabnik> GetUporabnik();
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
    }


