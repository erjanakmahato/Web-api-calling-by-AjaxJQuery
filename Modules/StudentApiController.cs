using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Modules
{
    [Route("api/student")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        //Get:api/GetAllStudents
        [HttpGet]
       
        public IEnumerable<PersonalDetails>GetAllStudents()
        {
            List<PersonalDetails> students = new List<PersonalDetails>
            {
                new PersonalDetails
                {
                    RegNo="2017-0001",
                    Name="Janak",
                    Address="Imadol",
                    PhoneNo="9813079818",
                    AdmissionDate=DateTime.Now
                },
                new PersonalDetails
                {
                    RegNo="2016-00002",
                    Name="Ashesh",
                    Address="Lokanthali",
                    PhoneNo="9813079818",
                    AdmissionDate=DateTime.Now
                },

            };
            return students;
        }
       
    }
   
}