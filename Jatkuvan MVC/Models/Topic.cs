using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jatkuvan_MVC.Models
{
    public partial class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? TimeToMaster { get; set; }
        public int? TimeSpent { get; set; }
        public string Source { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartLearningDate { get; set; }
        public bool? InProgress { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CompletionDate { get; set; }
    }
}
