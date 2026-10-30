using static Inheritance.Program.Employee;
using static Inheritance.Program.Employee.Manager;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee(
            //    "EMP001",
            //    "Mao Visal",
            //    "Male",
            //    "Phnom Penh",
            //    "012345678",
            //    "Sen Sok",
            //    "Phnom Penh"
            //);
            //emp.Info();
            string bar = new string('*', 50);

            Manager Test = new Manager(
             "EMP001",
             "Mao Visal",
             "Male",
             "Phnom Penh",
             "012345678",
             "Sen Sok",
            "Phnom Penh",
            "IT"
             );
            Console.WriteLine(bar);
            Test.Info();
            Console.WriteLine(bar);
            Developer devTest = new Developer(
             "EMP002",
             "Sok San",
             "Male",
             "Phnom Penh",
             "098765432",
             "Toul Kork",
             "Phnom Penh",
             "IT",
             "Level 3 Clearance"
             );
            Console.WriteLine(bar);
            devTest.Info();
            Console.WriteLine(bar);

        }

        public class Employee
        {
            //private string empcode;
            //private string name;
            //private string gender;
            //private string address;
            //private string phoneNumber;
            //private string currentAddress;
            //private string permanentAddress;
            public string empcode;
            public string name;
            public string gender;
            public string address;
            public string phoneNumber;
            public string currentAddress;
            public string permanentAddress;
            public virtual string Role => "Empolyee";

            public Employee(
                string empcode,
                string name,
                string gender,
                string address,
                string phoneNumber,
                string currentAddress,
                string permanentAddress)
            {
                this.empcode = empcode;
                this.name = name;
                this.gender = gender;   
                this.address = address;
                this.phoneNumber = phoneNumber;
                this.currentAddress = currentAddress;
                this.permanentAddress = permanentAddress;
            }


            public string GetEmpCode()
            {
                return empcode;
            }

            public string GetName()
            {
                return name;
            }

            public string GetGender()
            {
                return gender;
            }

            public string GetAddress()
            {
                return address;
            }

            public string GetPhoneNumber()
            {
                return phoneNumber;
            }

            public string GetCurrentAddress()
            {
                return currentAddress;
            }

            public string GetPermanentAddress()
            {
                return permanentAddress;
            }
            public void header()
            {
              
                Console.WriteLine($"Role: {Role}");

            }

            public virtual void Info()
            {
                
                string bar = new string('*', 50);
                
                Console.WriteLine("Employee Code: " + empcode);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gender: " + gender);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("Phone Number: " + phoneNumber);
                Console.WriteLine("Current Address: " + currentAddress);
                Console.WriteLine("Permanent Address: " + permanentAddress);
            }
            //class manager 
            public class Manager : Employee
            {
                // property
                // string department="";
                //fields
                private string department;
                public override string Role => "Manager";
                public Manager(string empcode, string name, string gender, string address, string phoneNumber, string currentAddress, string permanentAddress) : base(empcode, name, gender, address, phoneNumber, currentAddress, permanentAddress)
                {
                }

                //construvtor 
                public Manager(
                    string empcode,
                    string name,
                    string gender,
                    string address,
                    string phoneNumber,
                    string currentAddress,
                    string permanentAddress,
                    string department
                    )
                    : base(
                        empcode,
                        name,
                        gender,
                        address,
                        phoneNumber,
                        currentAddress,
                        permanentAddress
                          )
                {
                    this.department = department;
                }
                //public override void header()
                //{
                //    base.header();
                //}
                public override void Info()
                {

                    base.header();
                    base.Info();
                    Console.WriteLine("Department : " + department);
                }
                public class Developer : Manager
                {
                    private string cybersecurity;
                    public override string Role => "Developer";


                    //construvtor 
                    public Developer(
                        string empcode,
                        string name,
                        string gender,
                        string address,
                        string phoneNumber,
                        string currentAddress,
                        string permanentAddress,
                        string department,
                        string cybersecurity
                        )
                        : base(
                            empcode,
                            name,
                            gender,
                            address,
                            phoneNumber,
                            currentAddress,
                            permanentAddress,
                            department
                              )
                    {
                        this.cybersecurity = cybersecurity;
                    }
                    //public 
                    public override void Info()
                    {
                        base.Info();
                        Console.WriteLine("Cybersecurity: " + cybersecurity);
                    }

                }

            }
        }
    }
}