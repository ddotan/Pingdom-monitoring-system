using ConfigStorage;
using Pingdom.ObjectModel;
using Pingdom.TechinalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.BussinessLogic
{
    public class PingdomManager
    {
        private Checker<HTTPCheck> HttpChecker { get; set; }
        private Checker<PingCheck> PingChecker { get; set; }
        private Checker<PortCheck> PortChecker { get; set; }

        private readonly WebServices m_WebServices;
        private Credentials m_Credentials;
        public PingdomManager()
        {
            m_Credentials = AppConfigParser.Create<Credentials>();
            m_WebServices = WebServices.Connect( m_Credentials.AuthToken,m_Credentials.URL);
            HttpChecker = new Checker<HTTPCheck>(m_WebServices);

            PingChecker = new Checker<PingCheck>(m_WebServices);
            PortChecker = new Checker<PortCheck>(m_WebServices);



        }
        public void Upload(string i_CheckType)
        {

            if (i_CheckType == "WEB")
            {
                HttpChecker.Upload();

            }
            else if (i_CheckType == "PING")
            {
                PingChecker.Upload();
            }
            else
            {
                PortChecker.Upload();
            }
        }
    }
}
