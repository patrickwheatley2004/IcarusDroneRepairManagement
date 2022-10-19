using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcarusDroneRepairManagement
{
    internal class Drone
    {
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private double serviceCost;
        private int serviceTag;

        public Drone(string clientName, string droneModel, string serviceProblem, double serviceCost, int serviceTag)
        {
            this.clientName = typeCaseString(clientName);
            this.droneModel = typeCaseString(droneModel);
            this.serviceProblem = serviceProblem;
            this.serviceCost = serviceCost;
            this.serviceTag = serviceTag;
        } 
        
        protected string typeCaseString(string input)
        {
            char c = char.ToUpper(input[0]);
            string n = c.ToString() + (input = input.TrimStart(input[0]));
            return n;
        }

        public string getClientName()
        {
            return clientName;
        }
        public string getDroneModel()
        {
            return droneModel;
        }
        public string getServiceProblem()
        {
            return serviceProblem;
        }
        public double getServiceCost()
        {
            return serviceCost;
        }
        public int getServiceTag()
        {
            return serviceTag;
        }

    }
}
