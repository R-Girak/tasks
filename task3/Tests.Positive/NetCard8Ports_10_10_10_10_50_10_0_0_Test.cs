// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace task3.Tests.Positive
{
    #region Usings

    using System.Collections.Generic;
    using task3.FlowBuilders;

    #endregion

    /// <summary>
    /// Test case.
    /// </summary>
    public class NetCard8Ports_10_10_10_10_50_10_0_0_Test : NetCardFlowBuilder
    {
        #region Fields and Constants

        /// <summary>
        /// Test case #24.
        /// </summary>
        public const string testName = "NetCard8Ports_10_10_10_10_50_10_0_0_Test";

        /// <summary>
        /// The test case description.
        /// </summary>
        public const string testDescription = "Test flow:"
            + "\n 1) Set port configurations on Simics:"
            + "\n 2 ports; Total speed: 100 Gb/sec"
            + "\n 2) Start FW boot."
            + "\n 3) Check the number of ports, detected by FW."
            + "\n 4) Check the speed of each port, detected by FW.";

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetCard8Ports_10_10_10_10_50_10_0_0_Test" /> class.
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="testDescription"></param>
        public NetCard8Ports_10_10_10_10_50_10_0_0_Test(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers

        /// <summary>
        /// Dictionary "portsSpeed" containing name of the port and ports speed.
        /// </summary>
        protected override Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {
            {"PortSpeed1", 10},
            {"PortSpeed2", 10},
            {"PortSpeed3", 10},
            {"PortSpeed4", 10},
            {"PortSpeed5", 50},
            {"PortSpeed6", 10},
            {"PortSpeed7", 0},
            {"PortSpeed8", 0}
        };

        #endregion
    }
}
