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
    public class NetCard1Port_10_Test : NetCardFlowBuilder
    {
        #region Fields and Constants

        /// <summary>
        /// Test case #2.
        /// </summary>
        public const string testName = "NetCard1Port_10_Test";

        /// <summary>
        /// The test case description.
        /// </summary>
        public const string testDescription = "Test flow:"
            + "\n 1) Set port configurations on Simics:"
            + "\n 1 port; Total speed: 10 Gb/sec"
            + "\n 2) Start FW boot."
            + "\n 3) Check the speed of the port, detected by FW.";

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetCard1Port_10_Test" /> class.
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="testDescription"></param>
        public NetCard1Port_10_Test(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers

        /// <summary>
        /// Dictionary "portsSpeed" containing name of the port and ports speed.
        /// </summary>
        protected override Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {
            {"PortSpeed1", 10}
        };

        #endregion
    }
}
