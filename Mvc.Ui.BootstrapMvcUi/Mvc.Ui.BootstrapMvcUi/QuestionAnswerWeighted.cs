using System.Collections.Generic;

namespace Mvc.Ui.BootstrapMvcUi
{

    public class QuestionAnswersWeighted : List<QuestionAnswerWeighted>
    {
        public string Text { get; set; }
    }

    public class QuestionAnswerWeighted : QuestionAnswer
    {
        public uint Weight { get; set; }
    }

    public class QuestionAnswer
    {
        public string Text { get; set; }
    }
}
