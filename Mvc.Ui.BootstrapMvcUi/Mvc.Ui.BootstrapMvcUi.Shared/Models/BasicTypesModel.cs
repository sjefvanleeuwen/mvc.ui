using System;

namespace Mvc.Ui.BootstrapMvcUi.Shared.Models
{
    public class BasicTypesModel
    {
        public DateTime? Date { get; set; }
        public DateTime? DateTime { get; set; }
        public TimeSpan? TimeSpan { get; set; }
        public decimal? Euro { get; set; }
        public uint? UInt { get; set; }
        public string Postcode { get; set; }

        public bool Boolean { get; set; }

        public QuestionAnswersWeighted QaWeighted { get; set; }

        public BasicTypesModel()
        {
        }
    }
}