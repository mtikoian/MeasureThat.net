using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeasureThat.Net.Models
{
    using System;

    public class NewBenchmarkModel
    {
        public NewBenchmarkModel()
        {
            this.TestCases = new List<TestCase>();
        }

        [Required]
        [Display(Name = "Benchmark Name")]
        [StringLength(60, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string BenchmarkName { get; set; }

        [StringLength(400, ErrorMessage = "The {0} must be at max {1} characters long.")]
        public string Description { get; set; }

        [Display(Name = "Html Preparation code")]
        public string HtmlPreparationCode { get; set; }

        //[Required]
        [Display(Name = "JavaScript preparation code")]
        public string ScriptPreparationCode { get; set; }

        [Required]
        [Display(Name = "Test Cases")]
        public List<TestCase> TestCases { get; set; }        

        public long Id { get; set; }

        public string OwnerId { get; set; }

        public DateTime WhenCreated { get; set; }

        public int Version { get; set; }
    }
}
