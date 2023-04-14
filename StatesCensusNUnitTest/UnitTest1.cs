using IndianStatesCensusAnalyserProblem;

namespace StatesCensusNUnitTest
{
    public class Tests
    {

        public string stateCensusFilePath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\NewFolder\StateCensusData.csv";
        public string stateIncorrectFilePath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\StateIncorrectPath.csv";
        public string stateFileTypePath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\NewFolder\StateFileType.txt";
        public string stateDelimeterPath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\NewFolder\StateDelimeter.csv";
        public string stateHeaderPath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\NewFolder\StateHeader.csv";
        //UC-1.1
        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StatesCensusAnalyser analyser= new StatesCensusAnalyser();
            CSVStateCensus stateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCensus.ReadStateCensusData(stateCensusFilePath), analyser.ReadStateCensusData(stateCensusFilePath));
        }
        //UC-1.2
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StatesCensusAnalyser analyser = new StatesCensusAnalyser();
            try
            {
                int records = analyser.ReadStateCensusData(stateIncorrectFilePath);
            }
            catch (StateCensusException e)
            {
                Assert.AreEqual(e.Message, "Incorrect File Path");
            }
        }
        //UC-1.3
        [Test]
        public void GivenStateCensusDataFileTypeIncorrect_WhenAlayzed_ShouldReturnException()
        {
            StatesCensusAnalyser analyzer = new StatesCensusAnalyser();
            try
            {
                int records = analyzer.ReadStateCensusData(stateFileTypePath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Type");
            }
        }
        //UC-1.4
        [Test]
        public void GivenStateCensusDataFileDelimeterIncorrect_WhenAlayzed_ShouldReturnException()
        {
            StatesCensusAnalyser analyzer = new StatesCensusAnalyser();
            try
            {
                int records = analyzer.ReadStateCensusData(stateDelimeterPath);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }
        //UC-1.5
        [Test]
        public void GivenStateCensusDataFileHeaderIncorrect_WhenAlayzed_ShouldReturnException()
        {
            StatesCensusAnalyser analyzer = new StatesCensusAnalyser();
            try
            {
                bool records = analyzer.ReadStateCensusData(stateHeaderPath, "State,Population,AreaInSqKm,DensityPerSqKm");
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
        //UC-2.1
        public string stateCodeFilePath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\StateCodes\StateCode.csv";
        public string stateCodeIncorrectFilePath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\StateCode.csv";
        public string stateCodeFileTypePath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\StateCodes\StateCodeFilType.txt";
        public string stateCodeDelimeterPath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\StateCodes\StateCodeDelimeter.csv";
        public string stateCodeHeaderPath = @"D:\BridgeLabs\IndianStatesCensusAnalyserProblem\StatesCensusNUnitTest\StateCodes\StateCodeHeader.csv";
        [Test]
        public void GivenStateCodeData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StatesCensusAnalyser analyser = new StatesCensusAnalyser();
            CSVStateCode stateCode = new CSVStateCode();
            Assert.AreEqual(stateCode.ReadStateCodeData(stateCodeFilePath), analyser.ReadStateCodeData(stateCodeFilePath));
        }
        //UC-2.2
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StatesCensusAnalyser analyser = new StatesCensusAnalyser();
            try
            {
                int records = analyser.ReadStateCodeData(stateCodeIncorrectFilePath);
            }
            catch (StateCodeException e)
            {
                Assert.AreEqual(e.Message, "Incorrect File Path");
            }
        }
        //UC-2.3
        [Test]
        public void GivenStateCodeDataFileTypeIncorrect_WhenAlayzed_ShouldReturnException()
        {
            StatesCensusAnalyser analyzer = new StatesCensusAnalyser();
            try
            {
                int records = analyzer.ReadStateCodeData(stateCodeFileTypePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Type");
            }
        }
        //UC-2.4
        [Test]
        public void GivenStateCodeDataFileDelimeterIncorrect_WhenAlayzed_ShouldReturnException()
        {
            StatesCensusAnalyser analyzer = new StatesCensusAnalyser();
            try
            {
                int records = analyzer.ReadStateCodeData(stateCodeDelimeterPath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }
        //UC-2.5
        [Test]
        public void GivenStateCodeDataFileHeaderIncorrect_WhenAlayzed_ShouldReturnException()
        {
            StatesCensusAnalyser analyzer = new StatesCensusAnalyser();
            try
            {
                bool records = analyzer.ReadStateCodeData(stateCodeHeaderPath, "SrNo,State,Name,TIN,StateCode");
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
    }
}