
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Equals(job2.Id));
            Assert.AreEqual(1, job2.Id - job1.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job3));
        }

        //ToString() Test Methods
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string nl = Environment.NewLine;
            string jobString = job1.ToString();
            Assert.IsTrue(jobString.StartsWith(nl));
            Assert.IsTrue(jobString.EndsWith(nl));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string jobString = job3.ToString();
            Assert.IsTrue(jobString.Contains("Name: Product tester"));
            Assert.IsTrue(jobString.Contains("Employer: ACME"));
            Assert.IsTrue(jobString.Contains("Location: Desert"));
            Assert.IsTrue(jobString.Contains("Position Type: Quality control"));
            Assert.IsTrue(jobString.Contains("Core Competency: Persistence"));
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string jobString = job1.ToString();
            Assert.IsTrue(jobString.Contains("Name: Data not available"));
            Assert.IsTrue(jobString.Contains("Employer: Data not available"));
            Assert.IsTrue(jobString.Contains("Location: Data not available"));
            Assert.IsTrue(jobString.Contains("Position Type: Data not available"));
            Assert.IsTrue(jobString.Contains("Core Competency: Data not available"));
        }
    }
}

