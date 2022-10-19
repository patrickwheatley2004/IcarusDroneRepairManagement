using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcarusDroneRepairManagement
{
    // 6.1	Create a separate class file to hold the data items of the Drone. Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public. Add a display method that returns a string for Client Name and Service Cost. Add suitable code to the Client Name and Service Problem accessor methods so the data is formatted as Title case or Sentence case. Save the class as “Drone.cs”.
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
