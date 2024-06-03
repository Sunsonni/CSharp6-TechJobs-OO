using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.
            public Job()
            {
                Id = nextId;
                nextId++;
            }

            public Job(string name, Employer employerName, Location employerLocation, 
                PositionType jobType, CoreCompetency jobCoreCompetency) : this ()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods. 
        public override bool Equals(object obj)
        {
            return obj is Job job && Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string nl = Environment.NewLine;
            string message = "Data not avaliable";
            StringBuilder output = new StringBuilder();
            string a = Name != null || Name == "" ? Name : message;
            string b = EmployerName == null|| EmployerName.ToString() == ""? message : EmployerName.ToString() ;
            string c = EmployerLocation == null || EmployerLocation.ToString() == ""? message : EmployerLocation.ToString();
            string d = JobType == null || JobType.ToString() == ""? message : JobType.ToString() ;
            string e = JobCoreCompetency == null || JobCoreCompetency.ToString() == ""?  message: JobCoreCompetency.ToString();

            output.Append(nl);
            output.AppendLine($"ID: {Id}");
            output.AppendLine($"Name: {a}");
            output.AppendLine($"Employer: {b}");
            output.AppendLine($"Location: {c}");
            output.AppendLine($"Position Type: {d}");
            output.Append($"Core Competency: {e}");

            return output + nl;

    }
}
}

