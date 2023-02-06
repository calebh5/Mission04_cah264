using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//My program for validation and getting and setting the value from html to javascript
namespace Mission04_cah264.Models
{
    //here is my model to get the GradeCalculator to work
    public class GradeCalculatorModel
    {
        [Range(0,100,
            ErrorMessage = "The value needs to between 0 and 100")]
        public int Assignments { get; set; }

        [Range(0, 100,

    ErrorMessage = "The value needs to between 0 and 100")]
        public int GroupProjects { get; set; }

        [Range(0, 100,

    ErrorMessage = "The value needs to between 0 and 100")]
        public int Quizzes { get; set; }

        [Range(0, 100,

    ErrorMessage = "The value needs to between 0 and 100")]
        public int Midterm { get; set; }

        [Range(0, 100,
            
    ErrorMessage = "The value needs to between 0 and 100")]
        public int Final { get; set; }

        [Range(0, 100,

    ErrorMessage = "The value needs to between 0 and 100")]
        public int INTEXT { get; set; }

    }
}
