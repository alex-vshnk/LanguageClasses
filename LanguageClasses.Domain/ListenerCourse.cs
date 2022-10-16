using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageClasses.Domain
{
    public class ListenerCourse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ListenerId { get; set; }
    }
}
