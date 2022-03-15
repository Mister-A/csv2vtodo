using CsvHelper.Configuration.Attributes;
using System;

namespace csv2vtodo
{
    public class WorkastCSVFile
    {
        [Name("Space")]
        public string Space { get; set; }

        [Name("List")]
        public string List { get; set; }

        [Name("Created on")]
        [Format("yyyy-MM-dd HH:mm:ss")]
        public DateTime? CreatedDate { get; set; }

        [Name("Created by")]
        public string CreatedBy { get; set; }

        [Name("Status")]
        public string Status { get; set; }

        [Name("ID")]
        public string ID { get; set; }

        [Name("Task")]
        public string Task { get; set; }

        [Name("Subtask")]
        public string Subtask { get; set; }

        [Name("Start Date")]
        [Format("yyyy-MM-dd HH:mm:ss")]
        public DateTime? StartDate { get; set; }

        [Name("Due Date")]
        [Format("yyyy-MM-dd HH:mm:ss")]
        public DateTime? DueDate { get; set; }

        [Name("Assigned To")]
        public string AssignedTo { get; set; }

        [Name("Tags")]
        public string Tags { get; set; }

        [Name("Completed On")]
        [Format("yyyy-MM-dd HH:mm:ss")]
        public DateTime? CompletedOn { get; set; }

        [Name("Completed By")]
        public string CompletedBy { get; set; }

        [Name("Link")]
        public string Link { get; set; }
    }
}