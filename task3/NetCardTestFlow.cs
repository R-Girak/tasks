using System;
using System.Collections.Generic;
using System.Text;

namespace task3  
{

    #region Usings
    using task3.DataStructures;

    #endregion

    class NetCardTestFlow
    {
    //Hint1 - 1 step read from FW register "PortCount" current quantity of ports

    //Hint2 - use the switch statement and enums from 1st class to set different flows for different quantities of ports.
    public void setFlow (NetCardDataStructurePorts.QuantityOfPorts p) {
            switch (p) {
                case NetCardDataStructurePorts.QuantityOfPorts.NetCard1Port:
                    break;
                case NetCardDataStructurePorts.QuantityOfPorts.NetCard2Ports:
                    break;
                case NetCardDataStructurePorts.QuantityOfPorts.NetCard4Ports:
                    break;
                case NetCardDataStructurePorts.QuantityOfPorts.NetCard8Ports:
                    break;
            }
        }

    /*Hint3 - to apply the changes made use the method "PerformReset"
      Hint4 - to check that speed or speeds applied read the FW register "Port##Speed" (## - means #of the port)
      Hint5 - if at least one portSpeed is not set (FW register "Port##Speed" returns NULL) the test should fail.*/
    //Hint3
    /*TestTemplate.PerformReset();*/

}
}
